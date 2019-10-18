using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Spire.Pdf;
using Spire.Pdf.Exporting.Text;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;

namespace POButler
{
    public partial class DownloadDateSelector
    {
        public DownloadDateSelector()
        {
            InitializeComponent();
        }

        private DataTable dtbl;
        private DataRow dtblrow;
        private bool iserr = false;

        // Dim Serno As String = "DK18811036A", Authcde As String = "1632999" ' Pastel SDK V18 Codes
        private string Serno = "DK198110007"; // Pastel SDK V19 Codes
        private string Authcde = "5635796";
        private PasSDK.PastelPartnerSDK SDK = new PasSDK.PastelPartnerSDK();
        private string StrReturn;

        private object SetYourLicense(string Serno, string authcode)
        {
            SDK.SetLicense(ref Serno, ref authcode);
            return default(object);
        }

        private string GetResultDesc(object strRCode)
        {
            string GetResultDescRet = default(string);
            switch (strRCode)
            {
                case var @case when @case.ToString() == "0":
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

        private void Read_Emails()
        {
            var frm = new PseWait();
            frm.Show();
            frm.Refresh();
            int pgi;
            int pgCount;
            int mailcnt = 0;
            double totalpoval = 0;
            string accname;
            dtbl = new DataTable();
            dtbl.Columns.Add(new DataColumn("AcctCode"));
            dtbl.Columns.Add(new DataColumn("PONum"));

            string folderpath = @"H:\Batchemails\";

            SetYourLicense(Serno, Authcde);
            StrReturn = SDK.SetDataPath(Properties.Settings.Default.PastelDataPath);

            if (!Information.IsNothing(StrReturn))
            {
                if (Conversions.ToDouble(StrReturn.Split('|')[0]) == 0)
                {
                    foreach (object item in System.IO.Directory.GetFiles(folderpath))
                    {
                        var doc = new PdfDocument();
                        try
                        {
                            doc.LoadFromFile(item.ToString());
                            // get all pages in doc
                            pgCount = doc.Pages.Count;
                            pgi = 0;
                            var page = doc.Pages[pgi];

                            int SelectAreaEndY = 700;
                            int SelectAreaStartY = 82;

                            string LineValFinal = string.Empty;
                            float LineHeight = 6;
                            float CodeDimx;
                            float CodeDimY;
                            float CodeDimWidth;
                            float CodeDimHeight;
                            RectangleF CodevalArea;
                            string CodeToStr;
                            string CodeValValue = string.Empty;

                            // these apply to all fields
                            // ''''''''''''''''''''''''''''''''''''''
                            // dimensions and details to get account code from document

                            // From Top
                            CodeDimY = Conversions.ToSingle(47 / 0.35277);

                            // height of field
                            CodeDimHeight = Conversions.ToSingle(20 / 0.35572);

                            // From Left of page
                            CodeDimx = Conversions.ToSingle(170 / 0.35227);
                            // Width of field
                            CodeDimWidth = Conversions.ToSingle(65 / 0.35572);

                            while (CodeValValue.ToString().Length <= 0)
                            {
                                CodevalArea = new RectangleF(CodeDimx, CodeDimY, CodeDimWidth, CodeDimHeight);
                                CodeToStr = page.ExtractText(CodevalArea);
                                CodeValValue = Strings.Replace(CodeToStr.ToString(), "Evaluation Warning : The document was created with Spire.PDF for .NET.", "");
                                CodeValValue = CodeValValue.Replace(Environment.NewLine, "|");
                                CodeDimY = CodeDimY + 1;
                            }
                            while (CodeValValue.ToString().Contains("||"))
                                CodeValValue = Strings.Replace(CodeValValue, "||", "|");
                            string AccCode = CodeValValue.Split('(')[1];
                            AccCode = AccCode.Split(')')[0];

                            string add1;
                            try
                            {
                                add1 = Strings.Replace(Strings.Trim(CodeValValue.Split('|')[1]), "'", "");
                                add1 = Strings.Replace(add1, "&", "and");
                                add1 = add1.Split(')')[1];
                            }
                            catch (Exception)
                            {
                                add1 = "-";
                            }

                            string add2;
                            try
                            {
                                add2 = Strings.Replace(Strings.Trim(CodeValValue.Split('|')[2]), "'", "");
                                add2 = Strings.Replace(add2, "&", "and");
                                if (Information.IsNothing(add2))
                                    add2 = "-";
                            }
                            catch (Exception)
                            {
                                add2 = "-";
                            }

                            string add3;
                            try
                            {
                                add3 = Strings.Replace(Strings.Trim(CodeValValue.Split('|')[3]), "'", "");
                                add3 = Strings.Replace(add3, "&", "and");
                                if (Information.IsNothing(add3))
                                    add3 = "-";
                            }
                            catch (Exception)
                            {
                                add3 = "-";
                            }

                            string add4;
                            try
                            {
                                add4 = Strings.Replace(Strings.Trim(CodeValValue.Split('|')[4]), "'", "");
                                add4 = Strings.Replace(add4, "&", "and");
                                if (Information.IsNothing(add4))
                                    add4 = "-";
                            }
                            catch (Exception)
                            {
                                add4 = "-";
                            }

                            float PONumDimx;
                            float PONumDimY;
                            float PONumDimWidth;

                            // '''''''''''''''''''''''''''''''''''''''''''''''''''''

                            float PONumDimHeight;
                            RectangleF PONumArea;
                            string POToStr;
                            string PONumValue = string.Empty;

                            // dimensions and details to get PO Number from document

                            // From Top
                            PONumDimY = Conversions.ToSingle(20 / 0.35277);

                            // height of field
                            PONumDimHeight = Conversions.ToSingle(7 / 0.35572);

                            // From Left of page
                            PONumDimx = Conversions.ToSingle(225 / 0.35227);
                            // Width of field
                            PONumDimWidth = Conversions.ToSingle(35 / 0.35572);

                            while (PONumValue.ToString().Length <= 0)
                            {
                                PONumArea = new RectangleF(PONumDimx, PONumDimY, PONumDimWidth, PONumDimHeight);
                                POToStr = page.ExtractText(PONumArea);
                                PONumValue = Strings.Replace(POToStr.ToString(), "Evaluation Warning : The document was created with Spire.PDF for .NET.", "");
                                PONumValue = PONumValue.Replace(Environment.NewLine, "");
                                PONumDimY = PONumDimY + 1;
                            }
                            PONumValue = PONumValue.Split(':')[1];
                            PONumValue = Strings.Replace(PONumValue, " ", "");

                            // '''''''''''''''''''''''''''''''''''''''''''''''''''''
                            frm.Refresh();
                            float PODateDimx;
                            float PODateDimY;
                            float PODateDimWidth;
                            float PODateDimHeight;
                            RectangleF PODateArea;
                            string PODateValue = string.Empty;

                            // dimensions and details to get PO Due Date rom document

                            // From Top
                            PODateDimY = Conversions.ToSingle(SelectAreaStartY / 0.35277);

                            // height of field
                            PODateDimHeight = Conversions.ToSingle(4 / 0.35572);

                            // From Left of page
                            PODateDimx = Conversions.ToSingle(268 / 0.35227);
                            // Width of field
                            PODateDimWidth = Conversions.ToSingle(18 / 0.35572);

                            while (PODateValue.ToString().Length <= 0)
                            {
                                PODateArea = new RectangleF(PODateDimx, PODateDimY, PODateDimWidth, PODateDimHeight);
                                POToStr = page.ExtractText(PODateArea);
                                PODateValue = Strings.Replace(POToStr.ToString(), "Evaluation Warning : The document was created with Spire.PDF for .NET.", "");
                                PODateValue = PODateValue.Replace(Environment.NewLine, "");
                                PODateDimY = PODateDimY + 1;
                            }
                            PODateValue = Strings.Replace(PODateValue, ".", "|");
                            PODateValue = PODateValue.Split('|')[0] + " " + DateAndTime.MonthName(Conversions.ToInteger(PODateValue.Split('|')[1]), true) + " " + PODateValue.Split('|')[2];
                            var argFileName = "ACCMASD";
                            short argKeyNumber = Conversions.ToShort(0);
                            short argFieldNumber = Conversions.ToShort(3);
                            // '''''''''''''''''''''''''''''''''''''''''''''''''''''
                            string acctname = SDK.GetField(ref argFileName, ref argKeyNumber, ref AccCode, ref argFieldNumber);
                            if ((acctname.Split('|')[0] ?? "") != "0")
                                acctname = GetResultDesc(acctname.Split('|')[0]);
                            else
                            {
                                acctname = Strings.Replace(acctname.Split('|')[1], "'", "");
                                acctname = Strings.Replace(acctname, "&", "and");
                            }

                            using (var con = new OleDbConnection(Properties.Settings.Default.ManifolddbConnectionString))
                            {
                                using (var cmd = new OleDbCommand())
                                {
                                    using (var oda = new OleDbDataAdapter())
                                    {
                                        try
                                        {
                                            cmd.CommandText = "INSERT INTO  DocHeader (DocNum, AcctCode, AcctName, DueDate, DelAdd1, DelAdd2, DelAdd3, DelAdd4) VALUES ('" + PONumValue + "', '" + AccCode + "', '" + acctname + "', '" + PODateValue + "', '" + add1.ToString() + "' , '" + add2.ToString() + "', '" + add3.ToString() + "', '" + add4.ToString() + "')";
                                            cmd.Connection = con;
                                            con.Open();
                                            cmd.ExecuteNonQuery();
                                            con.Close();
                                        }
                                        catch (Exception)
                                        {
                                            iserr = true;
                                        }
                                    }
                                }
                            }

                            if (iserr == false)
                            {
                                int loopcnt = 0;
                                // get all lines from all pages of PO
                                while (pgi != pgCount)
                                {
                                    page = doc.Pages[pgi];

                                    // LOOP THROUGH ALL LINES ON PO

                                    // create lines string then insert string into doclines table
                                    string artline = string.Empty;
                                    string PArtLine = string.Empty;
                                    float POBarDimx;
                                    float POBarDimY;
                                    float POBarDimWidth;
                                    // GET ARTICLE NUMBER
                                    // '''''''''''''''''''''''''''''''''''''''''''''''''''''

                                    float POBarDimHeight;
                                    RectangleF POBarArea;
                                    string POBarValue = string.Empty;

                                    // From Top
                                    POBarDimY = Conversions.ToSingle(SelectAreaStartY / 0.35277);

                                    // height of field
                                    // POBarDimHeight = 2.55 / 0.35572
                                    POBarDimHeight = Conversions.ToSingle(35 / 0.35572);

                                    // From Left of page
                                    POBarDimx = Conversions.ToSingle(95 / 0.35227);

                                    // Width of field
                                    // POBarDimWidth = 25 / 0.35572
                                    POBarDimWidth = Conversions.ToSingle(125 / 0.35572);

                                    POBarArea = new RectangleF(POBarDimx, POBarDimY, POBarDimWidth, POBarDimHeight);
                                    var strategy = new SimpleTextExtractionStrategy();
                                    POToStr = page.ExtractText(POBarArea, strategy);
                                    POBarValue = Strings.Replace(POToStr.ToString(), "Evaluation Warning : The document was created with Spire.PDF for .NET.", "");
                                    POBarValue = POBarValue.Replace(Environment.NewLine, "|");

                                    while (POBarValue.ToString().Contains("||"))
                                        POBarValue = Strings.Replace(POBarValue, "||", "|");
                                    int Lcount;
                                    double OrdQty;
                                    double OrdRate;
                                    string Barcode;
                                    string itemcode;
                                    string itemdescript;

                                    using (var con = new OleDbConnection(Properties.Settings.Default.ManifolddbConnectionString))
                                    {
                                        using (var cmd = new OleDbCommand())
                                        {
                                            using (var oda = new OleDbDataAdapter())
                                            {
                                                con.Open();
                                                int j = 0;
                                                // document contains a max of 10 lines in the rectangle
                                                Lcount = 9;
                                                while (j <= Lcount)
                                                {
                                                    int AvailQty = 0;
                                                    int TotQtybuy = 0;
                                                    int TotQtybuyA = 0;
                                                    int TotQtyAdjust = 0;
                                                    int TotQtyAdjustA = 0;
                                                    int TotQtySell = 0;
                                                    int TotQtySellA = 0;
                                                    try
                                                    {
                                                        Barcode = Strings.Replace(POBarValue.Split('|')[1 + j * 7], " ", "");
                                                        if (Barcode.ToString().Length == 13)
                                                        {
                                                            try
                                                            {
                                                                itemcode = Strings.Replace(POBarValue.Split('|')[2 + j * 7], " ", "");
                                                                OrdQty = Conversions.ToDouble(Strings.Replace(POBarValue.Split('|')[3 + j * 7], ",", ""));
                                                                OrdRate = Conversions.ToDouble(Strings.Replace(POBarValue.Split('|')[7 + j * 7], ",", ""));
                                                            }
                                                            catch (Exception)
                                                            {
                                                                Barcode = Strings.Replace(POBarValue.Split('|')[1 + j * 8], " ", "");
                                                                itemcode = Strings.Replace(POBarValue.Split('|')[2 + j * 8], " ", "");
                                                                OrdQty = Conversions.ToDouble(Strings.Replace(POBarValue.Split('|')[3 + j * 8], ",", ""));
                                                                OrdRate = Conversions.ToDouble(Strings.Replace(POBarValue.Split('|')[8 + j * 8], ",", ""));
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Barcode = Strings.Replace(POBarValue.Split('|')[1 + j * 8], " ", "");
                                                            itemcode = Strings.Replace(POBarValue.Split('|')[2 + j * 8], " ", "");
                                                            OrdQty = Conversions.ToDouble(Strings.Replace(POBarValue.Split('|')[3 + j * 8], ",", ""));
                                                            OrdRate = Conversions.ToDouble(Strings.Replace(POBarValue.Split('|')[8 + j * 8], ",", ""));
                                                        }
                                                        var argFileName1 = "ACCPRD";
                                                        short argKeyNumber1 = Conversions.ToShort(0);
                                                        short argFieldNumber1 = Conversions.ToShort(3);
                                                        StrReturn = SDK.GetField(ref argFileName1, ref argKeyNumber1, ref itemcode, ref argFieldNumber1);
                                                        if (Conversions.ToDouble(StrReturn.Split('|')[0].ToString()) != 0)
                                                            // itemdescript = GetResultDesc(StrReturn.Split("|")(0))
                                                            itemdescript = string.Empty;
                                                        else
                                                            itemdescript = StrReturn.Split('|')[1].ToString();

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
                                                        string SOString;

                                                        // total avilable qty is AvailQty - Qty on Sales Order 
                                                        int QtyOnSO;
                                                        var argFileName2 = "ACCPRDQ";
                                                        short argKeyNumber2 = Conversions.ToShort(1);
                                                        var argKeyValue = "001" + itemcode;
                                                        short argFieldNumber2 = Conversions.ToShort(4);
                                                        SOString = SDK.GetField(ref argFileName2, ref argKeyNumber2, ref argKeyValue, ref argFieldNumber2);
                                                        if ((SOString.Split('|')[0] ?? "") == "0")
                                                            QtyOnSO = Conversions.ToInteger(SOString.Split('|')[1]);
                                                        else
                                                            QtyOnSO = 0;

                                                        AvailQty = AvailQty + QtyOnSO;
                                                        string PriceList;
                                                        int PriceListReturnvaluefield;
                                                        var listrate = default(double);
                                                        double sellrate;
                                                        try
                                                        {
                                                            var argFileName3 = "ACCMASD";
                                                            short argKeyNumber3 = Conversions.ToShort(0);
                                                            short argFieldNumber3 = Conversions.ToShort(77);
                                                            // get system price based on customer price regeme
                                                            PriceList = SDK.GetField(ref argFileName3, ref argKeyNumber3, ref AccCode, ref argFieldNumber3);
                                                            PriceListReturnvaluefield = Conversions.ToInteger(Conversions.ToDouble(PriceList.Split('|')[1]) + 12);
                                                            var argFileName4 = "ACCSTKST";
                                                            short argKeyNumber4 = Conversions.ToShort(0);
                                                            var argKeyValue1 = "001" + itemcode.ToString();
                                                            short argFieldNumber4 = Conversions.ToShort(PriceListReturnvaluefield);

                                                            // get price for this price list for this client
                                                            listrate = Conversions.ToDouble(SDK.GetField(ref argFileName4, ref argKeyNumber4, ref argKeyValue1, ref argFieldNumber4).Split('|')[1]);
                                                        }
                                                        catch (Exception)
                                                        {
                                                        }

                                                        sellrate = OrdRate;
                                                        var dt1 = new DataTable();

                                                        // check for pricing in CustDealPriceMatrix table
                                                        double Dealrate;
                                                        cmd.CommandText = "SELECT Price FROM CustDealPriceMatrix WHERE (itemCode= '" + itemcode + "') And (FrmDate<= " + "#" + Strings.Format(DateAndTime.Today, "dd MMM yyyy") + "#" + ") And (ToDate>= " + "#" + Strings.Format(DateAndTime.Today, "dd MMM yyyy") + "#" + ")";
                                                        cmd.Connection = con;
                                                        oda.SelectCommand = cmd;
                                                        oda.Fill(dt1);
                                                        if (dt1.Rows.Count == 0)
                                                            Dealrate = listrate;
                                                        else
                                                            Dealrate = Conversions.ToDouble(dt1.Rows[0][0].ToString());

                                                        cmd.Connection = con;
                                                        cmd.CommandText = "INSERT INTO  DocLines (Barcode, iDocNum, Code, OrdQty, PORate, Descript, AvailQty, DealRate, ListRate, PostRate) VALUES ('" + Barcode + "', '" + PONumValue + "', '" + itemcode + "', " + Conversions.ToString(OrdQty) + ", " + Conversions.ToString(OrdRate) + ", '" + itemdescript + "', " + Conversions.ToString(AvailQty) + ", " + Conversions.ToString(Dealrate) + ", " + Conversions.ToString(listrate) + ", " + Conversions.ToString(sellrate) + ")";
                                                        cmd.ExecuteNonQuery();
                                                        totalpoval = totalpoval + OrdQty * OrdRate;
                                                    }
                                                    catch (Exception)
                                                    {
                                                    }
                                                    j = j + 1;
                                                }
                                                con.Close();
                                            }
                                        }
                                    }

                                    // move to next page and continue
                                    pgi = pgi + 1;
                                }
                                // Update PO value in DocNum table
                                using (var con = new OleDbConnection(Properties.Settings.Default.ManifolddbConnectionString))
                                {
                                    using (var cmd = new OleDbCommand())
                                    {
                                        using (var oda = new OleDbDataAdapter())
                                        {
                                            con.Open();
                                            cmd.Connection = con;
                                            cmd.CommandText = "UPDATE DocHeader SET  OrdValue = " + Conversions.ToString(totalpoval) + " WHERE DocNum = '" + PONumValue + "'";
                                            cmd.ExecuteNonQuery();
                                            totalpoval = 0;
                                        }
                                    }
                                }
                            }
                            else
                                iserr = false;
                            CodeValValue = string.Empty;
                            PONumValue = string.Empty;
                        }
                        catch (Exception)
                        {
                        }
                        frm.lblordercount.Text = Conversions.ToString(mailcnt) + " email attachments scanned";
                        mailcnt = mailcnt + 1;
                        frm.Refresh();
                    }
                    frm.Hide();
                    Interaction.MsgBox(Conversions.ToString(mailcnt) + " email attachments retrieved", Constants.vbInformation, "Records Retrieved");
                    this.Close();
                }
                else
                {
                    frm.Hide();
                    Interaction.MsgBox("Pastel SDK connection error - Unable to continue", Constants.vbCritical, "Connection error");
                }
            }
            else
            {
                frm.Hide();
                Interaction.MsgBox("Pastel SDK connection error - Unable to continue", Constants.vbCritical, "Connection error 2");
            }
        }

        private void _Button1_Click(object sender, EventArgs e)
        {
            Read_Emails();
        }
    }
}
