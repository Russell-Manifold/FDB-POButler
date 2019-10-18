using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace POButler
{
    public partial class InventoryAllocation
    {
        public InventoryAllocation()
        {
            InitializeComponent();
        }
        // Dim Serno As String = "DK18811036A", Authcde As String = "1632999"
        private string Serno = "DK198110007"; // Pastel SDK V19 Codes
        private string Authcde = "5635796";
        private PasSDK.PastelPartnerSDK SDK = new PasSDK.PastelPartnerSDK();
        private string StrReturn;

        private object SetYourLicense(string Serno, string authcode)
        {
            SDK.SetLicense(ref Serno, ref authcode);
            return default(object);
        }

        private string GetResultDesc(string strRCode)
        {
            string GetResultDescRet = default(string);
            switch (strRCode)
            {
                case var @case when @case == "0":
                    {
                        GetResultDescRet = "0 = Call successfully executed" + Conversions.ToString((char)13) + Conversions.ToString((char)10);
                        break;
                    }

                case var case1 when case1 == "1":
                    {
                        GetResultDescRet = "1 = File Not found" + Conversions.ToString((char)13) + Conversions.ToString((char)10);
                        break;
                    }

                case var case2 when case2 == "2":
                    {
                        GetResultDescRet = "2 = Invalid number of fields" + Conversions.ToString((char)13) + Conversions.ToString((char)10);
                        GetResultDescRet = GetResultDescRet + "Check your SetDataPath call and make sure" + Conversions.ToString((char)13) + Conversions.ToString((char)10);
                        GetResultDescRet = GetResultDescRet + "pastel files exist at that path" + Conversions.ToString((char)13) + Conversions.ToString((char)10);
                        GetResultDescRet = GetResultDescRet + "Try and use directories less than 8 characters long" + Conversions.ToString((char)13) + Conversions.ToString((char)10);
                        break;
                    }

                case var case3 when case3 == "3":
                    {
                        GetResultDescRet = "3 = Record update not successful" + Conversions.ToString((char)13) + Conversions.ToString((char)10);
                        break;
                    }

                case var case4 when case4 == "4":
                    {
                        GetResultDescRet = "4 = Record insert not successful" + Conversions.ToString((char)13) + Conversions.ToString((char)10);
                        break;
                    }

                case var case5 when case5 == "5":
                    {
                        GetResultDescRet = "5 = Record does not exist in file";
                        break;
                    }

                case var case6 when case6 == "6":
                    {
                        GetResultDescRet = "6 = Data path does not exist";
                        break;
                    }

                case var case7 when case7 == "7":
                    {
                        GetResultDescRet = "7 = Access denied";
                        break;
                    }

                case var case8 when case8 == "9":
                    {
                        GetResultDescRet = "9 = End of file";
                        break;
                    }

                case var case9 when case9 == "10":
                    {
                        GetResultDescRet = "10 = Field number specified not valid";
                        break;
                    }

                case var case10 when case10 == "11":
                    {
                        GetResultDescRet = "11 = Invalid period number (1 to 13)";
                        break;
                    }

                case var case11 when case11 == "12":
                    {
                        GetResultDescRet = "12 = Invalid Date";
                        break;
                    }

                case var case12 when case12 == "13":
                    {
                        GetResultDescRet = "13 = Invalid account type (GDC)";
                        break;
                    }

                case var case13 when case13 == "14":
                    {
                        GetResultDescRet = "14 = Invalid general ledger account number";
                        break;
                    }

                case var case14 when case14 == "15":
                    {
                        GetResultDescRet = "15 = General ledger account contains sub accounts";
                        break;
                    }

                case var case15 when case15 == "16":
                    {
                        GetResultDescRet = "16 = General ledger account number must be numeric";
                        break;
                    }

                case var case16 when case16 == "17":
                    {
                        GetResultDescRet = "17 = Invalid customer account code";
                        break;
                    }

                case var case17 when case17 == "18":
                    {
                        GetResultDescRet = "18 = Invalid supplier account code";
                        break;
                    }

                case var case18 when case18 == "19":
                    {
                        GetResultDescRet = "19 = Invalid inventory item code";
                        break;
                    }

                case var case19 when case19 == "20":
                    {
                        GetResultDescRet = "20 = Invalid salesman code";
                        break;
                    }

                case var case20 when case20 == "21":
                    {
                        GetResultDescRet = "21 = Invalid job code";
                        break;
                    }

                case var case21 when case21 == "22":
                    {
                        GetResultDescRet = "22 = Invalid Tax Type (0 to 30)";
                        break;
                    }

                case var case22 when case22 == "23":
                    {
                        GetResultDescRet = "23 = Transaction amount cannot be less that the tax amount";
                        break;
                    }

                case var case23 when case23 == "24":
                    {
                        GetResultDescRet = "24 = Invalid open item transaction type - must be O (Original) or A (Allocation)";
                        break;
                    }

                case var case24 when case24 == "25":
                    {
                        GetResultDescRet = "25 = There cannot be more than 500 lines in a batch";
                        break;
                    }

                case var case25 when case25 == "26":
                    {
                        GetResultDescRet = "26 = Invalid account description";
                        break;
                    }

                case var case26 when case26 == "27":
                    {
                        GetResultDescRet = "27 = Default group needs to set up in Pastel";
                        break;
                    }

                case var case27 when case27 == "28":
                    {
                        GetResultDescRet = "28 = Invalid document line type – must be 2, 5, or 7";
                        break;
                    }

                case var case28 when case28 == "29":
                    {
                        GetResultDescRet = "29 = Invalid exclusive / inclusive – must be 0 or 1";
                        break;
                    }

                case var case29 when case29 == "30":
                    {
                        GetResultDescRet = "30 = Invalid Entry Type (1 to 90)";
                        break;
                    }

                case var case30 when case30 == "31":
                    {
                        GetResultDescRet = "31 = Duplicate inventory item";
                        break;
                    }

                case var case31 when case31 == "32":
                    {
                        GetResultDescRet = "32 = Invalid multi-store code";
                        break;
                    }

                case var case32 when case32 == "33":
                    {
                        GetResultDescRet = "33 = Invalid Currency Code";
                        break;
                    }

                case var case33 when case33 == "99":
                    {
                        GetResultDescRet = "99 = General Error (the error message is the VB 5 error code and description)";
                        break;
                    }
            }

            return GetResultDescRet;
        }

        public InventoryAllocation(string itemcode, string barcode)
        {
            InitializeComponent();
            lblitemcode.Text = itemcode;
            lblBarcode.Text = barcode;
            SetYourLicense(Serno, Authcde);
            StrReturn = SDK.SetDataPath(Properties.Settings.Default.PastelDataPath);
            var argFileName = "ACCPRD";
            short argKeyNumber = Conversions.ToShort(0);
            short argFieldNumber = Conversions.ToShort(3);
            StrReturn = SDK.GetField(ref argFileName, ref argKeyNumber, ref itemcode, ref argFieldNumber);

            string itemname;
            if (Conversions.ToDouble(StrReturn.Split('|')[0].ToString()) != 0)
                itemname = string.Empty;
            else
                itemname = StrReturn.Split('|')[1].ToString();
            lblItemName.Text = itemname;
        }

        private void DataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            // If DataGridView1.IsCurrentCellDirty Then
            Validate();
            InventoryAllocBindingSource.EndEdit();
            InventoryAllocTableAdapter.Update(ManifolddbDataSet.InventoryAlloc);
            Calculatetotals();
        }

        private void InventoryAllocation_Load(object sender, EventArgs e)
        {
            var frm = new PseWait();
            frm.Show();
            frm.Refresh();
            UpdateAutoAllocateQuaitities();
            Loadgrid();
            // TODO: This line of code loads data into the 'ManifolddbDataSet.InventoryAlloc' table. You can move, or remove it, as needed.
            InventoryAllocTableAdapter.Fill(ManifolddbDataSet.InventoryAlloc);
            lblReccount.Text = Conversions.ToString(DataGridView1.RowCount) + " Records";
            // DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns[4].Visible = false;
            // DataGridView1.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            DataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Calculatetotals();

            frm.Hide();
        }

        private void Loadgrid()
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
                            cmd.CommandText = "DELETE * FROM InventoryAlloc";
                            cmd.ExecuteNonQuery();

                            cmd.CommandText = "INSERT INTO InventoryAlloc ( ID, AcctCode, AcctName, ItemCode, OrdQty, AvailQty, PostQty, PONumber )" + " SELECT DocLines.ID, DocHeader.AcctCode, DocHeader.AcctName, DocLines.Code, DocLines.OrdQty, DocLines.AvailQty, DocLines.PostQty, DocLines.iDocNum " + " FROM DocLines INNER JOIN DocHeader ON DocLines.iDocNum = DocHeader.DocNum WHERE (((DocLines.Code)= '" + lblitemcode.Text + "') AND ((DocHeader.Imported)=False))";
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

        private void ToolStripRemove_Click(object sender, EventArgs e)
        {
            switch (Interaction.MsgBox("Remove this item from all PO's. Are you sure?", Constants.vbYesNo, "Remove lines"))
            {
                case Constants.vbYes:
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
                                        foreach (DataGridViewRow rw in DataGridView1.Rows)
                                        {
                                            cmd.CommandText = "DELETE * FROM DocLinesTemp WHERE BarCode = '" + lblBarcode.Text + "' AND iDocNum = '" + rw.Cells[3].Value + "'";
                                            cmd.ExecuteNonQuery();

                                            cmd.CommandText = "DELETE * FROM DocLines WHERE BarCode = '" + lblBarcode.Text + "' AND iDocNum = '" + rw.Cells[3].Value + "'";
                                            cmd.ExecuteNonQuery();
                                        }
                                        con.Close();
                                        Interaction.MsgBox("Successfully removed", Constants.vbInformation, "Removed successfully");
                                        Close();
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

        private void Calculatetotals()
        {
            var ordqty = default(int);
            var availqty = default(int);
            var postqty = default(int);
            foreach (DataGridViewRow grv in DataGridView1.Rows)
            {
                ordqty = Conversions.ToInteger(ordqty + Convert.ToDouble(grv.Cells[5].Value));
                postqty = Conversions.ToInteger(postqty + Convert.ToDouble(grv.Cells[7].Value));
                availqty = Conversions.ToInteger(grv.Cells[6].Value);
                if (postqty > ordqty)
                    grv.DefaultCellStyle.ForeColor = Color.Red;
                else
                    grv.DefaultCellStyle.ForeColor = Color.Black;
            }
            lblOrderedQty.Text = Conversions.ToString(ordqty);
            lblPostQty.Text = Conversions.ToString(postqty);
            lblAvailQty.Text = Conversions.ToString(availqty);
            lblAvailQty2.Text = Conversions.ToString(availqty);
            lblBalance.Text = Conversions.ToString(availqty - postqty);
            if (availqty - postqty < 0)
            {
                lblBalance.ForeColor = Color.Red;
                Label10.ForeColor = Color.Red;
            }
        }

        private void ToolStripSave_Click(object sender, EventArgs e)
        {
            lblitemcode.Focus();
            try
            {
                if (Conversions.ToDouble(lblBalance.Text) < 0)
                {
                    switch (Interaction.MsgBox("Warning - Insufficient inventory for this item - are you sure you want to continue?", MsgBoxStyle.YesNoCancel, "Insufficient Stock"))
                    {
                        case Constants.vbYes:
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
                                                foreach (DataGridViewRow grw in DataGridView1.Rows)
                                                {
                                                    cmd.CommandText = Conversions.ToString("UPDATE DocLines SET PostQty = '" + grw.Cells[7].Value + "' WHERE ID = ") + grw.Cells[0].Value;
                                                    cmd.ExecuteNonQuery();

                                                    cmd.CommandText = Conversions.ToString("UPDATE DocLinesTemp SET PostQty = '" + grw.Cells[7].Value + "' WHERE ID = ") + grw.Cells[0].Value;
                                                    cmd.ExecuteNonQuery();
                                                }
                                                cmd.CommandText = "DELETE * FROM InventoryAlloc";
                                                cmd.ExecuteNonQuery();
                                                con.Close();
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
                                return;
                            }
                    }
                }
                else
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

                                    foreach (DataGridViewRow grw in DataGridView1.Rows)
                                    {
                                        cmd.CommandText = Conversions.ToString("UPDATE DocLines SET PostQty = '" + grw.Cells[7].Value + "' WHERE ID = ") + grw.Cells[0].Value;
                                        cmd.ExecuteNonQuery();

                                        cmd.CommandText = Conversions.ToString("UPDATE DocLinesTemp SET PostQty = '" + grw.Cells[7].Value + "' WHERE ID = ") + grw.Cells[0].Value;
                                        cmd.ExecuteNonQuery();
                                    }
                                    cmd.CommandText = "DELETE * FROM InventoryAlloc";
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                }
                                catch (Exception)
                                {
                                }
                            }
                        }
                    }
                Interaction.MsgBox("Successfully Saved", Constants.vbInformation, "Save Successful");
                Close();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, Constants.vbInformation, "Save error");
            }
        }

        private void UpdateAutoAllocateQuaitities()
        {
            using (var con = new OleDbConnection(Properties.Settings.Default.ManifolddbConnectionString))
            {
                using (var cmd = new OleDbCommand())
                {
                    using (var oda = new OleDbDataAdapter())
                    {
                        try
                        {
                            var dt = new DataTable();
                            cmd.CommandText = "SELECT DocLines.BarCode, DocLines.Code, DocLines.Descript AS Item_Description, Sum(DocLines.OrdQty) AS Reqd_Qty, Max(DocLines.AvailQty) AS Avail_Qty, '" + "" + "' AS Close_Bal, PostQty FROM DocLines INNER JOIN DocHeader ON DocLines.iDocNum = DocHeader.DocNum GROUP BY DocLines.BarCode, DocLines.Code, DocLines.Descript, DocLines.AvailQty, DocHeader.Imported, '" + "" + "', DocLines.PostQty HAVING (((DocHeader.Imported)=False));";
                            cmd.Connection = con;
                            con.Open();
                            oda.SelectCommand = cmd;
                            oda.Fill(dt);

                            foreach (DataRow rw in dt.Rows)
                            {
                                if ((int)rw[6] > 0)
                                {
                                }
                                else
                                {
                                    int Closebal = (int)rw[4] - (int)rw[3];
                                    if (Closebal < 0)
                                    {
                                    }
                                    else
                                    {
                                        // The is sufficient stock to supply all records - Therefor update all records to auto supply requested quantities
                                        cmd.Connection = con;
                                        cmd.CommandText = "UPDATE DocLines SET DocLines.PostQty = " + "OrdQty" + " WHERE (((DocLines.Code)= '" + rw[1] + "'))";
                                        cmd.ExecuteNonQuery();
                                    }
                                }
                            }
                            con.Close();
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
            }
        }
    }
}
