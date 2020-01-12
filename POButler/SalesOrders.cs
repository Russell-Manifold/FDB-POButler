using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POButler
{
    public partial class SalesOrders : MetroFramework.Forms.MetroForm
    {
        public SalesOrders()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new Dashboard();
            frm.ShowDialog();
        }
    }
}
