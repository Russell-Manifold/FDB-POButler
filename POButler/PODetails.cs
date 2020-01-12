using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PasSDK;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace POButler
{
    public partial class PODetails
    {
        public PODetails(string poid)
        {
            InitializeComponent();
            poidL = poid;
        }

        private string poidL;
        private PastelPartnerSDK SDK = new PastelPartnerSDK();
        private string StrReturn;

        private object SetYourLicense(string Serno, string authcode)
        {
            SDK.SetLicense(ref Serno, ref authcode);
            return default(object);
        }
        

        private void PODetails_Load(object sender, EventArgs e)
        {
            lblPONum.Text = poidL;
            LoadMainDetails();
            LoadLines();
            DocLinesTempTableAdapter.Fill(ManifolddbDataSet.DocLinesTemp);
            MaxQuantityFulFill();
            GetOrderValue();
            DocLinesTempTableAdapter.Fill(ManifolddbDataSet.DocLinesTemp);
            FormatGrid();
        }

        private void LoadLines()
        {
            string SOString;
            int QtyOnSO;
            string batchqty;
            int QtyBatch;
            int AvailQty = 0;
            int TotQtybuy = 0;
            int TotQtybuyA = 0;
            int TotQtyAdjust = 0;
            int TotQtyAdjustA = 0;
            int TotQtySell = 0;
            int TotQtySellA = 0;
            string itemcode;

            using (var con = new OleDbConnection(Properties.Settings.Default.ManifolddbConnectionString))
            {
                using (var cmd = new OleDbCommand())
                {
                    using (var oda = new OleDbDataAdapter())
                    {
                        try
                        {
                            con.Open();
                            // ''''''''''''''''''''

                            var dt = new DataTable();
                            cmd.CommandText = "SELECT DocLines.Code FROM DocLines INNER JOIN DocHeader ON DocLines.iDocNum = DocHeader.DocNum GROUP BY DocLines.Code, DocHeader.Imported HAVING (((DocHeader.Imported)=False))";
                            cmd.Connection = con;
                            oda.SelectCommand = cmd;
                            oda.Fill(dt);
                            DataGridView1.DataSource = dt;

                            foreach (DataRow rw1 in dt.Rows)
                            {
                                itemcode = rw1[0].ToString();
                                var argFileName = "ACCPRD";
                                short argKeyNumber = Conversions.ToShort(0);
                                short argFieldNumber = Conversions.ToShort(3);
                                StrReturn = SDK.GetField(ref argFileName, ref argKeyNumber, ref itemcode, ref argFieldNumber);
                                if (Conversions.ToDouble(StrReturn.Split('|')[0]) == 0)
                                {

                                    // to get current qty on hand for WH 001
                                    if (Conversions.ToDouble(StrReturn.Split('|')[0]) == 0)
                                    {
                                        var InvJSDK = new PastelInventoryJnl();
                                        var argStore = "001";
                                        var argThisYear = true;
                                        short argPeriod = Conversions.ToShort(13);
                                        StrReturn = Conversions.ToString(InvJSDK.OnHand(ref argStore, ref itemcode, ref argThisYear, ref argPeriod));
                                        AvailQty = Conversions.ToInteger(StrReturn);
                                    }
                                    else
                                        AvailQty = 0;

                                    if (Conversions.ToDouble(StrReturn.Split('|')[0]) == 0)
                                    {
                                        var InvJSDK = new PastelInventoryJnl();
                                        var argStore1 = "025";
                                        var argThisYear1 = true;
                                        short argPeriod1 = Conversions.ToShort(13);
                                        StrReturn = Conversions.ToString(InvJSDK.OnHand(ref argStore1, ref itemcode, ref argThisYear1, ref argPeriod1));
                                        AvailQty = Conversions.ToInteger(AvailQty + Conversions.ToDouble(StrReturn));
                                    }
                                    else
                                        AvailQty = AvailQty;
                                    var argFileName1 = "ACCPRDQ";
                                    short argKeyNumber1 = Conversions.ToShort(1);
                                    var argKeyValue = "001" + itemcode;
                                    short argFieldNumber1 = Conversions.ToShort(4);
                                    SOString = SDK.GetField(ref argFileName1, ref argKeyNumber1, ref argKeyValue, ref argFieldNumber1);
                                    if ((SOString.Split('|')[0] ?? "") == "0")
                                        QtyOnSO = Conversions.ToInteger(SOString.Split('|')[1]);
                                    else
                                        QtyOnSO = 0;
                                    var argFileName2 = "ACCPRDQ";
                                    short argKeyNumber2 = Conversions.ToShort(1);
                                    var argKeyValue1 = "001" + itemcode;
                                    short argFieldNumber2 = Conversions.ToShort(3);
                                    batchqty = SDK.GetField(ref argFileName2, ref argKeyNumber2, ref argKeyValue1, ref argFieldNumber2);
                                    if ((batchqty.Split('|')[0] ?? "") == "0")
                                        QtyBatch = Conversions.ToInteger(batchqty.Split('|')[1]);
                                    else
                                        QtyBatch = 0;
                                    AvailQty = AvailQty + QtyOnSO + QtyBatch;
                                }
                                else
                                    AvailQty = 0;

                                cmd.Connection = con;
                                cmd.CommandText = "UPDATE DocLines SET DocLines.AvailQty = " + Conversions.ToString(AvailQty) + " WHERE (((DocLines.Code)= '" + itemcode + "'))";
                                cmd.ExecuteNonQuery();

                                TotQtybuy = 0;
                                TotQtySell = 0;
                                TotQtyAdjust = 0;
                                TotQtybuyA = 0;
                                TotQtySellA = 0;
                                TotQtyAdjustA = 0;
                            }
                            con.Close();
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
            }
            // ''''''''''''''''''''''

            using (var con = new OleDbConnection(Properties.Settings.Default.ManifolddbConnectionString))
            {
                using (var cmd = new OleDbCommand())
                {
                    using (var oda = new OleDbDataAdapter())
                    {
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandText = "DELETE * FROM DocLinesTemp";
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "INSERT INTO DocLinesTemp (ID, iDocNum, Barcode, Code, Descript, OrdQty, AvailQty, PostQty, POrate, ListRate, DealRate, PostRate, LineVal)" + " SELECT ID, iDocNum, Barcode, Code, Descript, OrdQty, AvailQty, PostQty, POrate, ListRate, DealRate, PostRate, [PostRate]*[PostQty] AS LineVal" + " FROM DocLines WHERE (((iDocNum)='" + lblPONum.Text + "')) " + " GROUP BY ID, iDocNum, Barcode, Code, Descript, OrdQty, AvailQty, PostQty, POrate, ListRate, DealRate, PostRate, [PostRate]*[PostQty];";
                        try
                        {
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

        private void GetOrderValue()
        {
            double ordval = 0;
            foreach (DataGridViewRow grw in DataGridView1.Rows)
                ordval = Conversions.ToDouble(ordval + (double)grw.Cells[13].Value);
            lblOrdVal.Text = Strings.Format(ordval, "# ###.00");
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
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
                            cmd.Connection = con;
                            cmd.CommandText = "UPDATE DocHeader SET YesImport = -1 WHERE DocNum = '" + lblPONum.Text + "'";
                            cmd.ExecuteNonQuery();

                            cmd.Connection = con;
                            cmd.CommandText = "UPDATE DocHeaderTemp SET YesImport = -1 WHERE DocNum = '" + lblPONum.Text + "'";
                            cmd.ExecuteNonQuery();
                            con.Close();
                            Interaction.MsgBox("Successfully saved", Constants.vbInformation, "Save Successful");
                        }
                        catch (Exception ex)
                        {
                            Interaction.MsgBox(ex.Message, Constants.vbInformation, "Save Error");
                        }
                    }
                }
            }
        }

        private void FormatGrid()
        {
            foreach (DataGridViewRow rw in DataGridView1.Rows)
            {
                int postqty = Conversions.ToInteger(rw.Cells[7].Value);
                if (postqty == 0)
                {
                    // Insufficient stock - mark record as red
                    rw.Cells[2].Style.ForeColor = Color.Red;
                    rw.Cells[3].Style.ForeColor = Color.Red;
                    rw.Cells[4].Style.ForeColor = Color.Red;
                    rw.Cells[5].Style.ForeColor = Color.Red;
                }
                // col 9 must = col 10 OR col 11
                double porate = Conversions.ToDouble(rw.Cells[9].Value);
                double listRte = Conversions.ToDouble(rw.Cells[10].Value);
                double dealrate = Conversions.ToDouble(rw.Cells[11].Value);
                if (porate != dealrate)
                {
                    rw.Cells[9].Style.ForeColor = Color.Red;
                    rw.Cells[10].Style.ForeColor = Color.Red;
                    rw.Cells[11].Style.ForeColor = Color.Red;
                }
            }
            DataGridView1.Columns[0].Visible = false;
            DataGridView1.Columns[1].Visible = false;
            DataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void _DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string itemcode;
            string barcode;
            try
            {
                barcode = DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                itemcode = DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                var frm = new InventoryAllocation(itemcode, barcode);
                frm.ShowDialog();
                LoadLines();
                DocLinesTempTableAdapter.Fill(ManifolddbDataSet.DocLinesTemp);
                GetOrderValue();
                DocLinesTempTableAdapter.Fill(ManifolddbDataSet.DocLinesTemp);
                FormatGrid();
            }
            catch (Exception)
            {
            }
        }

        private void MaxQuantityFulFill()
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
                                var dt = new DataTable();
                                cmd.CommandText = "Select Sum(DocLines.OrdQty) As SumOfOrdQty FROM DocLines GROUP BY DocLines.Code HAVING (((DocLines.Code)= '" + grw.Cells[3].Value + "'))";
                                oda.SelectCommand = cmd;
                                oda.Fill(dt);

                                cmd.Connection = con;
                                cmd.CommandText = Conversions.ToString("UPDATE DocLinesTemp Set TotalOrd = " + dt.Rows[0][0] + " WHERE Code= '") + grw.Cells[3].Value + "'";
                                cmd.ExecuteNonQuery();
                                dt.Rows.Clear();
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

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            switch (Interaction.MsgBox("Remove and ignore this order. Are you sure?", Constants.vbYesNo, "Remove order"))
            {
                case Constants.vbYes:
                    {
                        var frm = new PseWait();
                        frm.Show();
                        frm.Refresh();

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
                                        cmd.CommandText = "DELETE * FROM DocHeaderTemp WHERE DocNum = '" + lblPONum.Text + "'";
                                        cmd.ExecuteNonQuery();

                                        cmd.CommandText = "UPDATE DocHeader Set Imported = 1 WHERE DocNum = '" + lblPONum.Text + "'";
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                    }
                                    catch (Exception)
                                    {
                                    }
                                }
                            }
                        }
                        Interaction.MsgBox("Update successful", Constants.vbInformation, "PO Set to Ignore");
                        frm.Hide();
                        Close();
                        break;
                    }

                case Constants.vbNo:
                    {
                        break;
                    }
            }
        }

        private void LoadMainDetails()
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
                            var dt = new DataTable();
                            cmd.CommandText = "Select TOP 1 DocNum, AcctCode, AcctName, DueDate, Imported, ImportDate, YesImport, DelAdd1, DelAdd2, DelAdd3, DelAdd4 FROM DocHeader WHERE DocNum = '" + lblPONum.Text + "'";
                            oda.SelectCommand = cmd;
                            oda.Fill(dt);
                            lblDueDate.Text = dt.Rows[0]["DueDate"].ToString();
                            lblCustCode.Text = dt.Rows[0]["AcctCode"].ToString();
                            lblCustName.Text = dt.Rows[0]["AcctName"].ToString();
                            lblAdd1.Text = dt.Rows[0]["DelAdd1"].ToString();
                            lblAdd2.Text = dt.Rows[0]["DelAdd2"].ToString();
                            lblAdd3.Text = dt.Rows[0]["DelAdd3"].ToString();
                            lblAdd4.Text = dt.Rows[0]["DelAdd4"].ToString();
                            con.Close();
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
            }
        }

        private void DataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowid;
            if ((int)e.Button == (int)MouseButtons.Right)
            {
                switch (Interaction.MsgBox("You are about to delete this line. Are you sure?", Constants.vbYesNo, "Delete line"))
                {
                    case Constants.vbYes:
                        {
                            var frm = new PseWait();
                            frm.Show();
                            frm.Refresh();
                            rowid = Conversions.ToInteger(DataGridView1.Rows[e.RowIndex].Cells[0].Value);
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
                                            cmd.CommandText = "DELETE * FROM DocLines WHERE ID= " + Conversions.ToString(rowid);
                                            cmd.ExecuteNonQuery();

                                            cmd.CommandText = "DELETE * FROM DocLinesTemp WHERE ID= " + Conversions.ToString(rowid);
                                            cmd.ExecuteNonQuery();

                                            con.Close();
                                            LoadLines();
                                            DocLinesTempTableAdapter.Fill(ManifolddbDataSet.DocLinesTemp);
                                            FormatGrid();
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

       private void _BtnReady_Click(object sender, EventArgs e)
        {
            {
                Validate();
                DocLinesTempBindingSource.EndEdit();
                using (var con = new OleDbConnection(Properties.Settings.Default.ManifolddbConnectionString))
                {
                    using (var cmd = new OleDbCommand())
                    {
                        using (var oda = new OleDbDataAdapter())
                        {
                            con.Open();
                            foreach (DataGridViewRow grw in DataGridView1.Rows)
                            {
                                try
                                {
                                    cmd.Connection = con;
                                    cmd.CommandText = "UPDATE DocLines SET Code ='" + grw.Cells[3].Value.ToString() + "' , Descript = '" + grw.Cells[4].Value.ToString() + "' WHERE ID = " + grw.Cells[0].Value.ToString() + "";
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception)
                                {
                                }
                            }
                            con.Close();
                        }
                    }
                }
                LoadLines();
            }
        }

    }
}
