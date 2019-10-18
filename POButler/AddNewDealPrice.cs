using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
namespace POButler
{
    public partial class AddNewDealPrice
    {
        public AddNewDealPrice()
        {
            InitializeComponent();
        }
        // Dim Serno As String = "DK18811036A", Authcde As String = "1632999"
        private string Serno = "DK198110007"; // Pastel SDK V19 Codes
        private string Authcde = "5635796";
        private PasSDK.PastelPartnerSDK SDK = new PasSDK.PastelPartnerSDK();
        private string StrReturn;
        private DataTable dtbl;
        private DataRow tblrow;

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

        private void GetInventoryList()
        {
            SetYourLicense(Serno, Authcde);
            StrReturn = SDK.SetDataPath(Properties.Settings.Default.PastelDataPath);

            dtbl = new DataTable();
            dtbl.Columns.Add(new DataColumn("ItemCode"));
            dtbl.Columns.Add(new DataColumn("ItemDescript"));
            var argFileName = "ACCPRD";
            int InventCount = SDK.NumberOfRecords(argFileName);
            int i = 0;
            var argFileName1 = "ACCPRD";
            short argKeyNumber = Conversions.ToShort("0");
            var argKeyValue = "AAA";
            StrReturn = SDK.GetNearest(argFileName1, argKeyNumber, argKeyValue);
            if ((StrReturn.Split('|')[0] ?? "") == "0")
            {
                tblrow = dtbl.NewRow();
                tblrow["ItemCode"] = StrReturn.Split('|')[2];
                tblrow["ItemDescript"] = StrReturn.Split('|')[3];
                dtbl.Rows.Add(tblrow);

                while (i != InventCount)
                {
                    try
                    {
                        var argFileName2 = "ACCPRD";
                        short argKeyNumber1 = Conversions.ToShort("1");
                        StrReturn = SDK.GetNext(argFileName2, argKeyNumber1);
                        if (StrReturn.ToString().Split('|')[0] != "9") {
                            tblrow = dtbl.NewRow();
                            tblrow["ItemCode"] = StrReturn.Split('|')[2].ToString();
                            tblrow["ItemDescript"] = StrReturn.Split('|')[3].ToString();
                            dtbl.Rows.Add(tblrow);
                        }
                    }
                    catch (Exception ex)
                    {
                        Interaction.MsgBox(ex.Message, Constants.vbCritical, "Pricing error");
                        return;
                    }
                    i = i + 1;
                }
            }
            else
                Interaction.MsgBox(GetResultDesc(StrReturn.Split('|')[0]));

            ComboItemCodes.DataSource = dtbl;
            ComboItemCodes.DisplayMember = "ItemCode";
            ComboItemCodes.ValueMember = "ItemCode";
        }

        private void AddNewDealPrice_Load(object sender, EventArgs e)
        {
            var frm = new PseWait();
            frm.Show();
            frm.Refresh();

            // GetClients()
            GetInventoryList();

            frm.Hide();
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtUnitPrice.Text.Length > 1)
            {
                try
                {
                    double unitpr = Conversions.ToDouble(txtUnitPrice.Text);
                }
                catch (Exception)
                {
                    txtUnitPrice.Text = txtUnitPrice.Text.Substring(0, txtUnitPrice.Text.Length - 1);
                }
            }
        }

        private void ToolStripSave_Click(object sender, EventArgs e)
        {
            double unitpr;
            try
            {
                unitpr = Conversions.ToDouble(txtUnitPrice.Text);
            }
            catch (Exception)
            {
                Interaction.MsgBox("Invalid Price, unable to save", Constants.vbCritical, "Pricing error");
                return;
            }

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
                            cmd.CommandText = "INSERT INTO CustDealPriceMatrix (itemCode, itemDescription, FrmDate, ToDate, Price)" + " VALUES ('" + ComboItemCodes.SelectedValue + "', '" + txtItemName.Text.ToString() + "', '" + Strings.Format(txtDatePicker1.Value, "dd MMM yyyy") + "', '" + Strings.Format(txtDatepicker2.Value, "dd MMM yyyy") + "', " + Strings.Format(unitpr, "#.00") + ")";
                            cmd.ExecuteNonQuery();
                            con.Close();
                            Interaction.MsgBox("Successfully Saved", Constants.vbInformation, "Deal Price Saved");
                            txtUnitPrice.Text = "0.00";
                        }
                        catch (Exception ex)
                        {
                            Interaction.MsgBox("Err43D-" + ex.Message, Constants.vbCritical, "Save Error");
                        }
                    }
                }
            }
        }

        private void ComboItemCodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cb = (ComboBox)sender;
            if (!cb.Focused)
                return;
            if (ComboItemCodes.SelectedIndex > 0)
            {
                var argFileName = "ACCPRD";
                short argKeyNumber = Conversions.ToShort("0");
                string argKeyValue = (string)ComboItemCodes.SelectedValue;
                short argFieldNumber = Conversions.ToShort("3");
                txtItemName.Text = SDK.GetField(ref argFileName, ref argKeyNumber, ref argKeyValue, ref argFieldNumber).Split('|')[1];
            }
        }

        // Private Sub GetClients()

        // dtbl = New DataTable
        // dtbl.Columns.Add(New DataColumn("ClientCode"))
        // dtbl.Columns.Add(New DataColumn("ClientDescript"))

        // tblrow = dtbl.NewRow
        // tblrow("ClientCode") = "-"
        // tblrow("ClientDescript") = "- Select -"
        // dtbl.Rows.Add(tblrow)

        // SetYourLicense(Serno, Authcde)
        // StrReturn = SDK.SetDataPath(My.Settings.PastelDataPath)
        // Dim clreccount As Integer = SDK.NumberOfRecords("ACCMASD")

        // Dim clstr = SDK.GetNearest("ACCMASD", 0, 0)
        // tblrow = dtbl.NewRow
        // tblrow("ClientCode") = clstr.Split("|")(2)
        // tblrow("ClientDescript") = clstr.Split("|")(3)
        // dtbl.Rows.Add(tblrow)

        // Dim i As Integer = 0
        // Do Until i = clreccount - 1
        // clstr = SDK.GetNext("ACCMASD", 0)
        // tblrow = dtbl.NewRow
        // tblrow("ClientCode") = clstr.Split("|")(2)
        // tblrow("ClientDescript") = clstr.Split("|")(3)
        // dtbl.Rows.Add(tblrow)
        // i = i + 1
        // Loop

        // ComboCustCode.DataSource = dtbl
        // ComboCustCode.DisplayMember = "ClientCode"
        // ComboCustCode.ValueMember = "ClientDescript"

        // End Sub

        // Private Sub ComboCustCode_SelectedIndexChanged(sender As Object, e As EventArgs)
        // Dim cb As ComboBox = CType(sender, ComboBox)
        // If Not cb.Focused Then
        // Return
        // End If
        // If ComboCustCode.SelectedIndex > 0 Then
        // txtCustName.Text = ComboCustCode.SelectedValue
        // End If
        // ComboItemCodes.Focus()
        // End Sub

        private void AddNewDealPrice_Closed(object sender, EventArgs e)
        {

            //POButler.DealPricing.CustDealPriceMatrixTableAdapter.Fill(POButler.DealPricing.ManifolddbDataSet.CustDealPriceMatrix);
            //POButler.DealPricing.DataGridView1.Columns[0].Visible = false;
            //POButler.DealPricing.DataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
