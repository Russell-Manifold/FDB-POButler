using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System;
using System.Data.OleDb;
using Microsoft.VisualBasic.CompilerServices;
using BarcodeEncoder;
namespace POButler
{
    public partial class Dashboard
    {
        public Dashboard()
        {
            InitializeComponent();
            Dashboard_Load();
        }
        
        private PasSDK.PastelPartnerSDK SDK = new PasSDK.PastelPartnerSDK();
        private string StrReturn;
        private string StrReturn1;
        private string StrReturn2;
        private string StrReturn3;

        private object SetYourLicense(string Serno, string authcode)
        {     
             SDK.SetLicense(ref Serno, ref authcode);
             return default(object);
        }

        private void BtnDownloadPOs_Click(object sender, EventArgs e)
        {
            var frm = new DownloadDateSelector();
            frm.ShowDialog();
            Loadtemptable();
        }

        private void _BtnCurrPOs_Click(object sender, EventArgs e)
        {
            Refresh();
            DocHeaderTempTableAdapter.Fill(ManifolddbDataSet.DocHeaderTemp);
            lblReccount.Text = Conversions.ToString(DataGridView1.RowCount) + " records";
            try
            {
                DataGridView1.Columns[0].Visible = false;
                DataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception)
            {
            }
            Refresh();
        }

        private void _BtnInventView_Click(object sender, EventArgs e)
        {
            var frm = new InventoryView();
            frm.ShowDialog();
        }

        private void _btnDealPricing_Click(object sender, EventArgs e)
        {
            var frm = new DealPricing();
            frm.ShowDialog();
        }

        private void _BtnPostToPastel_Click(object sender, EventArgs e)
        {
            double exvat;
            double inclvat;
            PictureBox2.Focus();
            bool b = false;
            foreach (DataGridViewRow grw in DataGridView1.Rows)
            {
                if (Operators.ConditionalCompareObjectEqual(grw.Cells[10].Value, true, false))
                {
                    b = true;
                    break;
                }
            }

            if (b == true)
            {
                switch (Interaction.MsgBox("Send all selected PO's to Pastel. Continue?", Constants.vbYesNoCancel, "Send Confirmation"))
                {
                    case Constants.vbYes:
                        {
                            var frm = new PseWait();
                            frm.Show();
                            frm.Refresh();
                            string PObarcode;

                            // check all codes before sending
                            string PasBarcode;
                            Pastelinfo SerNum = new Pastelinfo();
                            SetYourLicense(SerNum.GetSerNum("A"), SerNum.GetAuthCode("A"));
                            // Set Pastel Data Path
                            StrReturn = SDK.SetDataPath(Properties.Settings.Default.PastelDataPath);

                            SDK.OpenDocumentFiles();

                            if ((StrReturn ?? "") == "0")
                            {
                                foreach (DataGridViewRow grw in DataGridView1.Rows)
                                {
                                    if (Operators.ConditionalCompareObjectEqual(grw.Cells[10].Value, true, false))
                                    {
                                        var argFileName = "ACCDELIV";
                                        short argKeyNumber = Conversions.ToShort(2);
                                        short argFieldNumber = Conversions.ToShort(3);
                                        string rep = SDK.GetField(argFileName, argKeyNumber, grw.Cells[2].Value.ToString(), argFieldNumber).Split('|')[1];
                                        var isValidDate = default(bool);
                                        string DeldtS;
                                        if (isValidDate == Information.IsDate(grw.Cells[5].Value) == true)
                                            DeldtS = Strings.Format(grw.Cells[5].Value, "dd/MM/yyyy");
                                        else
                                        {
                                            DeldtS = Conversions.ToString(Conversions.ToString(grw.Cells[5].Value.ToString().Split('/')[0]) + grw.Cells[5].Value.ToString().Split('/')[1]) + grw.Cells[5].Value.ToString().Split('/')[2];
                                            if (isValidDate == Information.IsDate(DeldtS) == true)
                                            {
                                            }
                                            else
                                            {
                                                Interaction.MsgBox("Error with Date - " + grw.Cells[5].Value + " Unable to continue", Constants.vbCritical, "Critical Date Error");
                                                return;
                                            }
                                        }

                                        // ''''''''''''''''''
                                        if (DeldtS.ToString().Length != 10)
                                        {
                                            Interaction.MsgBox("Error with Date - " + grw.Cells[5].Value + " Unable to continue", Constants.vbCritical, "Critical Date Error");
                                            return;
                                        }
                                        var argAdditionalCostInvoice = false;
                                        // ''''''''''''''''''''''''''''''''''

                                        // StrReturn = SDK.DefineDocumentHeader("||Y|AGC001                            |05/03/1999                         |                                   |N|0|Message no.1 |Message no.2|Message no.3|Delivery no.1                      |Delivery no.2                      |Delivery no.3                      |Delivery no.4                      |Delivery no.5|                    |00||05/03/1999    |011-7402156   |Johnny     |011-7402157|1", False)
                                        // StrReturn = SDK.DefineDocumentHeader("||Y|" & grw.Cells(2).Value.ToString & "|" & Format(Now(), "dd/MM/yyyy") & "|" & grw.Cells(1).Value.ToString & "|N|0|             |            |            |" & grw.Cells(6).Value.ToString & "|" & grw.Cells(7).Value.ToString & "|" & grw.Cells(8).Value.ToString & "|" & grw.Cells(9).Value.ToString & "|             |" & rep.ToString & "|00||" & DeldtS & "|" & "  - " & "|" & "-" & "|" & "-" & "|1", False)
                                        StrReturn = SDK.DefineDocumentHeader("||Y|" + grw.Cells[2].Value.ToString() + "|" + Strings.Format(DateAndTime.Now, "dd/MM/yyyy") + "|" + grw.Cells[1].Value.ToString() + "|N|0|             |            |            |" + grw.Cells[6].Value.ToString() + "|" + grw.Cells[7].Value.ToString() + "|" + grw.Cells[8].Value.ToString() + "|" + grw.Cells[9].Value.ToString() + "|             |" + rep.ToString() + "|00||" + DeldtS + "|" + "  - " + "|" + "-" + "|" + "-" + "|1|ExampDescript|Ref|Add1|Add2|Add3|Add4|Add5|" + DeldtS + "|  |N", ref argAdditionalCostInvoice);
                                        // get all doc lines and add them to sdk.document

                                        using (var con = new OleDbConnection(Properties.Settings.Default.ManifolddbConnectionString))
                                        {
                                            using (var cmd = new OleDbCommand())
                                            {
                                                using (var oda = new OleDbDataAdapter())
                                                {
                                                    try
                                                    {
                                                        var dt = new DataTable();
                                                        cmd.Connection = con;
                                                        con.Open();
                                                        cmd.CommandText = "SELECT Code, Descript, PostQty, PostRate, BarCode  FROM DocLines WHERE iDocNum = '" + grw.Cells[1].Value.ToString() + "'";
                                                        oda.SelectCommand = cmd;
                                                        oda.Fill(dt);

                                                        foreach (DataRow rw in dt.Rows)
                                                        {
                                                            // verify codes before sending line
                                                            PObarcode = rw[4].ToString();
                                                            SDK.CloseDocumentFiles();
                                                            var argFileName1 = "ACCPRD";
                                                            short argKeyNumber1 = Conversions.ToShort(0);
                                                            string argKeyValue = (string)rw[0];
                                                            short argFieldNumber1 = Conversions.ToShort(4);
                                                            PasBarcode = SDK.GetField(ref argFileName1, ref argKeyNumber1, ref argKeyValue, ref argFieldNumber1).Split('|')[1];
                                                            if ((PObarcode ?? "") != (PasBarcode ?? ""))
                                                            {
                                                                frm.Hide();
                                                                Interaction.MsgBox("CRITICAL ERROR - Item code error for item -" + rw[0].ToString() + Constants.vbCrLf + Constants.vbCrLf + " Unable to continue!", Constants.vbCritical, "CRITICAL ERROR");
                                                                return;
                                                            }
                                                            SDK.OpenDocumentFiles();

                                                            try
                                                            {
                                                                exvat = Conversions.ToDouble(Strings.Replace(rw[3].ToString(), ",", "."));
                                                            }
                                                            catch (Exception)
                                                            {
                                                                exvat = Conversions.ToDouble(Strings.Replace(rw[3].ToString(), ".", ","));
                                                            }
                                                            inclvat = exvat * 1.15;
                                                            // StrReturn = SDK.DefineDocumentLine("0|1                         |87.72                           |100.00                          |EACH|01|||1000000                    |Description                 |6|JHB")
                                                            StrReturn = SDK.DefineDocumentLine("0|" + rw[2].ToString() + "|" + Strings.Replace(Conversions.ToString(exvat), ",", ".") + "|" + Strings.Replace(Conversions.ToString(inclvat), ",", ".") + "|EACH|15|||" + rw[0].ToString() + "|" + rw[1].ToString() + " |4|001");
                                                        }

                                                        short argDocumentType = Conversions.ToShort(102);
                                                        short argUserID = Conversions.ToShort(0);
                                                        StrReturn = SDK.ImportDocument(ref argDocumentType, ref argUserID);
                                                        frm.Hide();
                                                        if (Conversions.ToDouble(Strings.Split(StrReturn, "|")[0]) == 0)
                                                        {
                                                            // delete rows from local Docheader and doc lines tables
                                                            cmd.Connection = con;
                                                            cmd.CommandText = "UPDATE DocHeader SET Imported = 1, ImportDate = '" + Conversions.ToString(DateAndTime.Now) + "', PastelNum = '" + Strings.Split(StrReturn, "|")[1] + "'  WHERE DocNum = '" + grw.Cells[1].Value.ToString() + "'";
                                                            cmd.ExecuteNonQuery();

                                                            cmd.Connection = con;
                                                            cmd.CommandText = "DELETE FROM DocHeaderTemp WHERE DocNum = '" + grw.Cells[1].Value.ToString() + "'";
                                                            cmd.ExecuteNonQuery();

                                                            cmd.Connection = con;
                                                            cmd.CommandText = "DELETE FROM DocLinesTemp WHERE iDocNum = '" + grw.Cells[1].Value.ToString() + "'";
                                                            cmd.ExecuteNonQuery();
                                                            con.Close();
                                                        }
                                                        else
                                                        {
                                                            con.Close();
                                                            SDK.CloseDocumentFiles();
                                                            Pastelinfo Err = new Pastelinfo();
                                                            Interaction.MsgBox("Err - PO Num-" + grw.Cells[1].Value.ToString() + " - " + Err.GetResultDesc(Strings.Split(StrReturn, "|")[0]), Constants.vbCritical, "Import Error");
                                                            return;
                                                        }
                                                    }
                                                    catch (Exception)
                                                    {
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                SDK.CloseDocumentFiles();
                                Interaction.MsgBox("Pastel successfully updated", Constants.vbInformation, "Update Status");
                                frm.Hide();
                            }
                            else
                                return;
                            break;
                        }

                    case Constants.vbNo:
                        {
                            return;
                        }

                    case Constants.vbCancel:
                        {
                            return;
                        }
                }
            }
            else
                Interaction.MsgBox("No records selected", Constants.vbInformation, "Selection error");
        }

        private void Dashboard_Load()
        {
           
            
            AddFields();
            lblPasteldb.Text = Properties.Settings.Default.PastelDataPath;

            
            
            lblReccount.Text = Conversions.ToString(DataGridView1.Rows.Count) + " records";
            try
            {
                DataGridView1.Columns[0].Visible = false;
                DataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception)
            {
            }

            Pastelinfo SerNum = new Pastelinfo();
            SetYourLicense(SerNum.GetSerNum("A"), SerNum.GetAuthCode("A"));
            // Set Pastel Data Path
            StrReturn = SDK.SetDataPath(Properties.Settings.Default.PastelDataPath);

            if (!Information.IsNothing(StrReturn))
            {
                if (Conversions.ToDouble(StrReturn.Split('|')[0]) == 0)
                {
                }
                else
                    Interaction.MsgBox("Pastel SDK connection error - Unable to continue", Constants.vbCritical, "Connection error");
            }
            else
                Interaction.MsgBox("Pastel SDK connection error - Unable to continue", Constants.vbCritical, "Connection error 2");
        }

        public void _DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string poid;
            try
            {
                poid = DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                var frm = new PODetails(poid);
                frm.ShowDialog();
                DocHeaderTempTableAdapter.Fill(ManifolddbDataSet.DocHeaderTemp);
                lblReccount.Text = Conversions.ToString(DataGridView1.Rows.Count) + " records";
                try
                {
                    DataGridView1.Columns[0].Visible = false;
                    DataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                catch (Exception)
                {
                }
            }
            catch (Exception)
            {
            }
        }

        private void AddFields()
        {
            using (var con = new OleDbConnection(Properties.Settings.Default.ManifolddbConnectionString))
            {
                using (var cmd = new OleDbCommand())
                {
                    using (var oda = new OleDbDataAdapter())
                    {
                        try
                        {
                            cmd.Connection = con;
                            con.Open();
                            cmd.CommandText = "ALTER TABLE DocHeaderTemp ADD COLUMN OrdValue Double";
                            cmd.ExecuteNonQuery();

                            cmd.CommandText = "ALTER TABLE DocHeader ADD COLUMN OrdValue Double";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
            }
        }

        private void Loadtemptable()
        {
            using (var con = new OleDbConnection(Properties.Settings.Default.ManifolddbConnectionString))
            {
                using (var cmd = new OleDbCommand())
                {
                    using (var oda = new OleDbDataAdapter())
                    {
                        try
                        {
                            cmd.Connection = con;
                            con.Open();
                            cmd.CommandText = "DELETE * FROM DocHeaderTemp";
                            cmd.ExecuteNonQuery();

                            cmd.CommandText = "INSERT INTO DocHeaderTemp ( DocNum, AcctCode, AcctName, DueDate, Imported, ImportDate, YesImport, DelAdd1, DelAdd2, DelAdd3, DelAdd4, OrdValue )" + " SELECT DocNum, AcctCode, AcctName, DueDate, Imported, ImportDate, YesImport, DelAdd1, DelAdd2, DelAdd3, DelAdd4, OrdValue FROM DocHeader" + " WHERE (((Imported)=False))";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
            }
            DocHeaderTempTableAdapter.Fill(ManifolddbDataSet.DocHeaderTemp);
            lblReccount.Text = Conversions.ToString(DataGridView1.Rows.Count) + " records";
            try
            {
                DataGridView1.Columns[0].Visible = false;
                DataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception)
            {
            }
        }

        private void _DataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            // If DataGridView1.IsCurrentCellDirty Then
            Validate();
            DocHeaderTempBindingSource.EndEdit();
            DocHeaderTempTableAdapter.Update(ManifolddbDataSet.DocHeaderTemp);
            lblReccount.Text = Conversions.ToString(DataGridView1.Rows.Count) + " records";
        }
 
        private void _DataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            string poid;
            if ((int)e.Button == (int)MouseButtons.Right)
            {
                switch (Interaction.MsgBox("WARNING - You are about to remove this document. Are you sure?", Constants.vbYesNo, "Ignore document"))
                {
                    case Constants.vbYes:
                        {
                            var frm = new PseWait();
                            frm.Show();
                            frm.Refresh();
                            poid = DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                            using (var con = new OleDbConnection(Properties.Settings.Default.ManifolddbConnectionString))
                            {
                                using (var cmd = new OleDbCommand())
                                {
                                    using (var oda = new OleDbDataAdapter())
                                    {
                                        try
                                        {
                                            cmd.Connection = con;
                                            con.Open();
                                            cmd.Connection = con;
                                            cmd.CommandText = "UPDATE DocHeader SET Imported = 1 WHERE DocNum = '" + poid + "'";
                                            cmd.ExecuteNonQuery();

                                            cmd.CommandText = "DELETE FROM DocHeaderTemp WHERE DocNum = '" + poid + "'";
                                            cmd.ExecuteNonQuery();

                                            con.Close();
                                            DocHeaderTempTableAdapter.Fill(ManifolddbDataSet.DocHeaderTemp);
                                            lblReccount.Text = Conversions.ToString(DataGridView1.Rows.Count) + " records";
                                            frm.Hide();
                                        }
                                        catch (Exception)
                                        {
                                        }
                                    }
                                }
                            }

                            break;
                        }

                    case Constants.vbNo:
                        {
                            break;
                        }
                }
            }
        }

        private void _Button1_Click_1(object sender, EventArgs e)
        {
            var frm = new ConnectionPath();
            frm.ShowDialog();
            lblPasteldb.Text = Properties.Settings.Default.PastelDataPath;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Pastelinfo SerNum = new Pastelinfo();
            SetYourLicense(SerNum.GetSerNum("A"), SerNum.GetAuthCode("A"));
            // Set Pastel Data Path
            string conpath = lblPasteldb.Text.Replace('\\', '/');
            StrReturn = SDK.SetDataPath(Properties.Settings.Default.PastelDataPath);
            if (StrReturn == "0")
            {
                StrReturn = SDK.DefineBOMHead("7290103668077|BOM HEADER|12.1|12.2|12.3|12.4|12.5|12.6|12.7|12.8|12.9|12|10|20|30|100|200|300|10106-30L-REDIB|Y|Y|N||N|N|002");
            }
            if (StrReturn == "0")
            {
                StrReturn = SDK.DefineBOMLine("7290103668077|1213-HANDLES|10|002");
            }
            //if (StrReturn == "0")
            //{
            //    StrReturn = SDK.DefineBOMLine("7290103668077|1213-LID|5|002");
            //}
            if (StrReturn == "0")
            {
                StrReturn = SDK.ImportBOM();
            }

            if (StrReturn == "0")
            {
                Interaction.MsgBox("YAY");
            }
            else {
                Interaction.MsgBox("BOO");
            }
            }

            private void _btnCheckCodes_Click(object sender, EventArgs e)
        {
            var frm = new PseWait();
            frm.Show();
            frm.Refresh();
            string POitemcode;
            string PObarcode;
            string PasBarcode;
            Pastelinfo SerNum = new Pastelinfo();
            SetYourLicense(SerNum.GetSerNum("A"), SerNum.GetAuthCode("A"));
            // Set Pastel Data Path
            StrReturn = SDK.SetDataPath(Properties.Settings.Default.PastelDataPath);

            using (var con = new OleDbConnection(Properties.Settings.Default.ManifolddbConnectionString))
            {
                using (var cmd = new OleDbCommand())
                {
                    using (var oda = new OleDbDataAdapter())
                    {
                        try
                        {
                            var dt = new DataTable();
                            cmd.CommandText = "SELECT DocLines.Code, DocLines.Barcode, Sum(DocLines.OrdQty) AS Reqd_Qty FROM DocLines INNER JOIN DocHeader ON DocLines.iDocNum = DocHeader.DocNum GROUP BY DocLines.Code, DocLines.Barcode, DocHeader.Imported HAVING (((DocHeader.Imported)=False))";
                            con.Open();
                            cmd.Connection = con;
                            oda.SelectCommand = cmd;
                            oda.Fill(dt);
                            foreach (DataRow rw1 in dt.Rows)
                            {
                                POitemcode = rw1[0].ToString();
                                PObarcode = rw1[1].ToString();
                                var argFileName = "ACCPRD";
                                short argKeyNumber = Conversions.ToShort(0);
                                short argFieldNumber = Conversions.ToShort(4);
                                // verify that barcode and item code match in both systems
                                PasBarcode = SDK.GetField(ref argFileName, ref argKeyNumber, ref POitemcode, ref argFieldNumber).Split('|')[1];
                                if ((PObarcode ?? "") != (PasBarcode ?? ""))
                                {
                                    frm.Hide();
                                    Interaction.MsgBox("CRITICAL ERROR - Item code error for item -" + POitemcode, Constants.vbCritical, "CRITICAL ERROR");
                                    return;
                                }
                            }
                            frm.Hide();
                            Interaction.MsgBox("No error found", Constants.vbInformation, "Validation passed");
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
            }
        }

       private void Button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;
            string itmcode;
            Pastelinfo SerNum = new Pastelinfo();
            SetYourLicense(SerNum.GetSerNum("A"), SerNum.GetAuthCode("A"));
            // Set Pastel Data Path
            StrReturn = SDK.SetDataPath(Properties.Settings.Default.PastelDataPath);
            var argFileName1 = "ACCPRD";
            short argKeyNumber = Conversions.ToShort("4");
            var argKeyValue = "*******63625*";
            StrReturn = SDK.GetNearest(argFileName1, argKeyNumber, argKeyValue);
            if ((StrReturn.Split('|')[0] ?? "") == "0")
            {
                do
                {
                    if ((StrReturn.Split('|')[4] ?? "").Contains("63625"))
                    {
                        itmcode = StrReturn.Split('|')[2];
                        //Interaction.MsgBox("Barcode = " + StrReturn.Split('|')[4] + "(" + j + " Records searched)", Constants.vbInformation, "Validation passed");
                        i += 1;
                    }
                    else
                    {
                        StrReturn = SDK.GetNext(argFileName1, argKeyNumber);
                        j = j += 1;
                    }
                } while (i == 0);
            }
        }

        private void BtnScanner_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (Screen.PrimaryScreen.Bounds.Width < 400 && Screen.PrimaryScreen.Bounds.Height < 600)
            {
                this.Hide();
                Main m = new Main();
                m.ShowDialog();
                this.Close();
            }
        }
    }
}
