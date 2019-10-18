using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace POButler
{
    public partial class ConnectionPath
    {

        public ConnectionPath()
        {
            InitializeComponent();
            ConnectionPath_Load();
        }

        private PasSDK.PastelPartnerSDK SDK = new PasSDK.PastelPartnerSDK();
        private string StrReturn;

        private object SetYourLicense(string Serno, string authcode)
        {
            SDK.SetLicense(Serno, authcode);
            return default(object);
        }

        private void ConnectionPath_Load()
        {
            string dpath = Properties.Settings.Default.PastelDataPath.ToString();
            _txtDatapath.Text = dpath;
        }

        private void _Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Pastelinfo SerNum = new Pastelinfo();
                SetYourLicense(SerNum.GetSerNum("A"), SerNum.GetAuthCode("A"));

                // Set Pastel Data Path
                StrReturn = SDK.SetDataPath(txtDatapath.Text);

                if (Conversions.ToDouble(StrReturn) == 0)
                {
                    //PastelDataPath = txtDatapath.Text;
                    Interaction.MsgBox("Successfully Saved", Constants.vbInformation, "Saved");
                    Close();
                }
                else
                    Interaction.MsgBox("Invalid data path - unable to update", Constants.vbCritical, "Path Error");
            }
            catch (Exception)
            {
                Interaction.MsgBox("Invalid data path - unable to update", Constants.vbCritical, "Path Error");
            }
        }
    }
}
