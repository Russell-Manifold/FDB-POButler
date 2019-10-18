using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

    namespace POButler
{
    public partial class InventoryView
    {
        public InventoryView()
        {
            InitializeComponent();
        }
        private PasSDK.PastelPartnerSDK SDK = new PasSDK.PastelPartnerSDK();
        private string StrReturn;

        // Dim Serno As String = "DK18811036A", Authcde As String = "1632999"
        private string Serno = "DK198110007"; // Pastel SDK V19 Codes
        private string Authcde = "5635796";

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

        private void InventoryView_Load(object sender, EventArgs e)
        {
            Loadgrid();
        }

        private void Loadgrid()
        {
            string SOString;
            int QtyOnSO;
            string batchqty;
            // must recalculate values from pastel
            int QtyBatch;
            SetYourLicense(Serno, Authcde);
            StrReturn = SDK.SetDataPath(Properties.Settings.Default.PastelDataPath);
            int AvailQty = 0;
            string itemcode;

            using (var con = new OleDbConnection(Properties.Settings.Default.ManifolddbConnectionString))
            {
                using (var cmd = new OleDbCommand())
                {
                    using (var oda = new OleDbDataAdapter())
                    {
                        try
                        {
                            var dt = new DataTable();
                            cmd.CommandText = "SELECT DocLines.Code, Sum(DocLines.OrdQty) AS Reqd_Qty FROM DocLines INNER JOIN DocHeader ON DocLines.iDocNum = DocHeader.DocNum GROUP BY DocLines.Code, DocHeader.Imported HAVING (((DocHeader.Imported)=False))";
                            con.Open();
                            cmd.Connection = con;
                            oda.SelectCommand = cmd;
                            oda.Fill(dt);
                            // DataGridView1.DataSource = dt

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
                                        var InvJSDK = new PasSDK.PastelInventoryJnl();
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
                                        var InvJSDK = new PasSDK.PastelInventoryJnl();
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
                                 }
                            con.Close();
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
            }

            using (var con = new OleDbConnection(Properties.Settings.Default.ManifolddbConnectionString))
            {
                using (var cmd = new OleDbCommand())
                {
                    using (var oda = new OleDbDataAdapter())
                    {
                        try
                        {
                            var dt = new DataTable();
                            cmd.CommandText = "SELECT DocLines.BarCode, DocLines.Code, DocLines.Descript AS Item_Description, Sum(DocLines.OrdQty) AS Reqd_Qty, Max(DocLines.AvailQty) AS Avail_Qty, '" + "" + "' AS Close_Bal FROM DocLines INNER JOIN DocHeader ON DocLines.iDocNum = DocHeader.DocNum GROUP BY DocLines.BarCode, DocLines.Code, DocLines.Descript, DocLines.AvailQty, DocHeader.Imported, '" + "" + "' HAVING (((DocHeader.Imported)=False));";
                            cmd.Connection = con;
                            con.Open();
                            oda.SelectCommand = cmd;
                            oda.Fill(dt);
                            DataGridView1.DataSource = dt;

                            foreach (DataGridViewRow rw in DataGridView1.Rows)
                            {
                                int Closebal = Conversions.ToInteger(Conversions.ToDouble(rw.Cells[4].Value.ToString()) - Conversions.ToDouble(rw.Cells[3].Value.ToString()));
                                rw.Cells[5].Value = Closebal;

                                if (Closebal < 0)
                                {
                                    // Insufficient stock - mark record as red
                                    rw.Cells[1].Style.ForeColor = Color.Red;
                                    rw.Cells[2].Style.ForeColor = Color.Red;
                                    rw.Cells[4].Style.ForeColor = Color.Red;
                                    rw.Cells[5].Style.ForeColor = Color.Red;
                                    cmd.Connection = con;
                                    cmd.CommandText = "UPDATE DocLines SET DocLines.PostQty = 0 WHERE (((DocLines.Code)= '" + rw.Cells[1].Value + "'))";
                                    cmd.ExecuteNonQuery();
                                }
                                else
                                {
                                    rw.Cells[1].Style.ForeColor = Color.Black;
                                    rw.Cells[2].Style.ForeColor = Color.Black;
                                    rw.Cells[4].Style.ForeColor = Color.Black;
                                    rw.Cells[5].Style.ForeColor = Color.Black;
                                    // The is sufficient stock to supply all records - Therefor update all records to auto supply requested quantities
                                    cmd.Connection = con;
                                    cmd.CommandText = "UPDATE DocLines SET DocLines.PostQty = " + "OrdQty" + " WHERE (((DocLines.Code)= '" + rw.Cells[1].Value + "'))";
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            con.Close();
                            lblReccount.Text = Conversions.ToString(DataGridView1.RowCount) + " records";
                            DataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            DataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            DataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            DataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
            }
        }

        private void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow rw in DataGridView1.Rows)
            {
                rw.Cells[5].Value = Conversions.ToDouble(rw.Cells[4].Value.ToString()) - Conversions.ToDouble(rw.Cells[3].Value.ToString());
                if (Convert.ToInt32(rw.Cells[5].Value.ToString()) < 0)
                {
                    rw.Cells[1].Style.ForeColor = Color.Red;
                    rw.Cells[2].Style.ForeColor = Color.Red;
                    rw.Cells[4].Style.ForeColor = Color.Red;
                    rw.Cells[5].Style.ForeColor = Color.Red;
                }
            }
            lblReccount.Text = Conversions.ToString(DataGridView1.RowCount) + " records";
            DataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string itemcode;
            string barcode;
            try
            {
                barcode = DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                itemcode = DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                var frm = new InventoryAllocation(itemcode, barcode);
                frm.ShowDialog();
                Loadgrid();
            }
            catch (Exception)
            {
            }
        }

        private void _BtnDownloadPOs_Click(object sender, EventArgs e)
        {
            var dtbl = new DataTable();
            //object Excel  = CreateObject(“Excel.Application”);
            switch (Interaction.MsgBox("Include items where there is sufficient stock?", Constants.vbYesNoCancel, "Select download type"))
            {
                case Constants.vbYes:
                    {
                        //// if (Excel == null)
                        // {
                        //    // MsgBox(“It appears that Excel Is Not installed On this machine.This operation requires MS Excel To be installed On this machine.”, MsgBoxStyle.Critical);


                        //     return;
                        // }
                        // Excel.Visible = true;
                        using (var con = new OleDbConnection(Properties.Settings.Default.ManifolddbConnectionString))
                        {
                            using (var cmd = new OleDbCommand())
                            {
                                using (var oda = new OleDbDataAdapter())
                                {
                                    try
                                    {
                                        cmd.CommandText = "SELECT DocHeader.AcctCode, DocHeader.AcctName, DocLines.Code, DocLines.Descript, DocLines.OrdQty as [Order_Qty], DocLines.AvailQty as [Avail_Qty], DocLines.PostQty as [Post_Qty], DocLines.iDocNum as [PO_Num]" + " FROM DocLines INNER JOIN DocHeader ON DocLines.iDocNum = DocHeader.DocNum ORDER BY DocLines.Code;";
                                        cmd.Connection = con;
                                        con.Open();
                                        oda.SelectCommand = cmd;
                                        oda.Fill(dtbl);
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
                        //if (Excel == null)
                        //{
                        //    MsgBox(“It appears that Excel Is Not installed On this machine.This operation requires MS Excel To be installed On this machine.”, MsgBoxStyle.Critical);    
                        //    return;
                        //}
                        //Excel.Visible = true;
                        using (var con = new OleDbConnection(Properties.Settings.Default.ManifolddbConnectionString))
                        {
                            using (var cmd = new OleDbCommand())
                            {
                                using (var oda = new OleDbDataAdapter())
                                {
                                    try
                                    {
                                        cmd.CommandText = "SELECT DocHeader.AcctCode, DocHeader.AcctName, DocLines.Code, DocLines.Descript, DocLines.OrdQty as [Order_Qty], DocLines.AvailQty as [Avail_Qty], DocLines.PostQty as [Post_Qty], DocLines.iDocNum as [PO_Num]" + " FROM DocLines INNER JOIN DocHeader ON DocLines.iDocNum = DocHeader.DocNum WHERE (((DocLines.PostQty)<>[DocLines].[OrdQty])) ORDER BY DocLines.Code;";
                                        cmd.Connection = con;
                                        con.Open();
                                        oda.SelectCommand = cmd;
                                        oda.Fill(dtbl);
                                    }
                                    catch (Exception)
                                    {
                                    }
                                }
                            }
                        }

                        break;
                    }

                case Constants.vbCancel:
                    {
                        return;
                    }
            }

            DataGridView2.Rows.Clear();
            DataGridView2.DataSource = dtbl;

            // Initialize Excel Sheet
            //{
            //    var withBlock = Excel;
            //    withBlock.SheetsInNewWorkbook = 1;
            //    withBlock.Workbooks.Add();
            //    withBlock.Worksheets(1).Select();

            //    // Add header row to Excel Sheet by copying column headers from the Datagrid
            //    // Dim Col As DataGridViewColumn
            //    int i = 1;
            //    foreach (var Col in DataGridView2.Columns)
            //    {
            //        withBlock.Cells(1, i).Value = Col.HeaderText;
            //        i += 1;
            //    }

            //    // Add data to excel sheet by looping through the rows
            //    // in the datagrid
            //    i = 2;
            //    DataGridViewRow RowItem;
            //    DataGridViewCell Cell;
            //    try
            //    {
            //        foreach (var RowItem in DataGridView2.Rows)
            //        {
            //            int j = 1;
            //            foreach (var Cell in RowItem.Cells)
            //            {
            //                withBlock.Cells(i, j).Value = Cell.Value.ToString();
            //                j += 1;
            //            }
            //            i += 1;
            //        }
            //    }
            //    catch (Exception)
            //    {
            //    }
            //}

            //// Excel.Quit()
            //System.Runtime.InteropServices.Marshal.ReleaseComObject(Excel);
            //Excel = null;
            //MsgBox(“Export to Excel Complete”, MsgBoxStyle.Information);           
        }

    }
}
