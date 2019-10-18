using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace POButler
{
    public partial class DealPricing
    {
        public DealPricing()
        {
            InitializeComponent();
        }
        private void DealPricing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ManifolddbDataSet.CustDealPriceMatrix' table. You can move, or remove it, as needed.
            this.CustDealPriceMatrixTableAdapter.Fill(this.ManifolddbDataSet.CustDealPriceMatrix);
            DataGridView1.Columns[0].Visible = false;
            DataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            var frm = new AddNewDealPrice();
            frm.ShowDialog();
            this.CustDealPriceMatrixTableAdapter.Fill(this.ManifolddbDataSet.CustDealPriceMatrix);
            DataGridView1.Columns[0].Visible = false;
            DataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.Validate();
            this.CustDealPriceMatrixBindingSource.EndEdit();
            this.CustDealPriceMatrixTableAdapter.Update(this.ManifolddbDataSet.CustDealPriceMatrix);
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int linid;
            switch (Interaction.MsgBox("Delete this row! Are you sure?", Constants.vbYesNo, "Confirm delete row"))
            {
                case Constants.vbYes:
                    {
                        linid = Conversions.ToInteger(DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
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
                                        cmd.CommandText = "DELETE * FROM CustDealPriceMatrix WHERE ID = " + Conversions.ToString(linid);
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                        this.CustDealPriceMatrixTableAdapter.Fill(this.ManifolddbDataSet.CustDealPriceMatrix);
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

        private void DataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            switch (Interaction.MsgBox("Delete this record, are you sure?", Constants.vbYesNo, "Delete warning"))
            {
                case Constants.vbYes:
                    {
                        this.Validate();
                        this.CustDealPriceMatrixBindingSource.EndEdit();
                        this.CustDealPriceMatrixTableAdapter.Update(this.ManifolddbDataSet.CustDealPriceMatrix);
                        break;
                    }

                case Constants.vbNo:
                    {
                        this.Refresh();
                        this.Validate();
                        this.CustDealPriceMatrixBindingSource.EndEdit();
                        this.CustDealPriceMatrixTableAdapter.Fill(this.ManifolddbDataSet.CustDealPriceMatrix);
                        DataGridView1.Columns[0].Visible = false;
                        DataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        break;
                    }
            }
        }
    }
}
