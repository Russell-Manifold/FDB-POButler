using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace POButler
{
    [DesignerGenerated()]
    public partial class DealPricing : Form
    {      
        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                    components.Dispose();
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(DealPricing));
            _DataGridView1 = new DataGridView();
            _DataGridView1.CellEndEdit += DataGridView1_CellEndEdit;
            _DataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;
            _DataGridView1.RowsRemoved += DataGridView1_RowsRemoved;
            _CustDealPriceMatrixBindingSource = new BindingSource(components);
            _ManifolddbDataSet = new ManifolddbDataSet();
            _CustDealPriceMatrixTableAdapter = new ManifolddbDataSetTableAdapters.CustDealPriceMatrixTableAdapter();
            _Label1 = new Label();
            _BtnAddNew = new Button();
            _BtnAddNew.Click += BtnAddNew_Click;
            _PictureBox2 = new PictureBox();
            _PictureBox1 = new PictureBox();
            _Label2 = new Label();
            _IDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            _ItemCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            _itemDescription = new DataGridViewTextBoxColumn();
            _FrmDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            _ToDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            _PriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)_DataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_CustDealPriceMatrixBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_ManifolddbDataSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_PictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DataGridView1
            // 
            _DataGridView1.AllowUserToAddRows = false;
            _DataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom
                | AnchorStyles.Left
                | AnchorStyles.Right;
            _DataGridView1.AutoGenerateColumns = false;
            _DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _DataGridView1.Columns.AddRange(new DataGridViewColumn[] { _IDDataGridViewTextBoxColumn, _ItemCodeDataGridViewTextBoxColumn, _itemDescription, _FrmDateDataGridViewTextBoxColumn, _ToDateDataGridViewTextBoxColumn, _PriceDataGridViewTextBoxColumn });
            _DataGridView1.DataSource = _CustDealPriceMatrixBindingSource;
            _DataGridView1.Location = new Point(184, 142);
            _DataGridView1.Margin = new Padding(4, 4, 4, 4);
            _DataGridView1.Name = "DataGridView1";
            _DataGridView1.Size = new Size(1181, 144);
            _DataGridView1.TabIndex = 0;
            // 
            // CustDealPriceMatrixBindingSource
            // 
            _CustDealPriceMatrixBindingSource.DataMember = "CustDealPriceMatrix";
            _CustDealPriceMatrixBindingSource.DataSource = _ManifolddbDataSet;
            // 
            // ManifolddbDataSet
            // 
            _ManifolddbDataSet.DataSetName = "ManifolddbDataSet";
            _ManifolddbDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            // 
            // CustDealPriceMatrixTableAdapter
            // 
            _CustDealPriceMatrixTableAdapter.ClearBeforeFill = true;
            // 
            // Label1
            // 
            _Label1.Anchor = AnchorStyles.Top;
            _Label1.AutoSize = true;
            _Label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Underline, GraphicsUnit.Point, Conversions.ToByte(0));
            _Label1.Location = new Point(593, 89);
            _Label1.Margin = new Padding(4, 0, 4, 0);
            _Label1.Name = "Label1";
            _Label1.Size = new Size(144, 29);
            _Label1.TabIndex = 13;
            _Label1.Text = "Deal Pricing";
            // 
            // BtnAddNew
            // 
            _BtnAddNew.FlatStyle = FlatStyle.Flat;
            //_BtnAddNew.Image = My.Resources.Resources.plus;
            _BtnAddNew.Location = new Point(16, 142);
            _BtnAddNew.Margin = new Padding(4, 4, 4, 4);
            _BtnAddNew.Name = "BtnAddNew";
            _BtnAddNew.Size = new Size(160, 58);
            _BtnAddNew.TabIndex = 17;
            _BtnAddNew.Text = "Add New";
            _BtnAddNew.TextImageRelation = TextImageRelation.ImageBeforeText;
            _BtnAddNew.UseVisualStyleBackColor = true;
            // 
            // PictureBox2
            // 
            //_PictureBox2.BackgroundImage = My.Resources.Resources.FDBicon;
            _PictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            _PictureBox2.Location = new Point(16, 16);
            _PictureBox2.Margin = new Padding(4, 4, 4, 4);
            _PictureBox2.Name = "PictureBox2";
            _PictureBox2.Size = new Size(123, 114);
            _PictureBox2.TabIndex = 15;
            _PictureBox2.TabStop = false;
            // 
            // PictureBox1
            // 
            _PictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            //_PictureBox1.BackgroundImage = My.Resources.Resources.FDBicon;
            _PictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            _PictureBox1.Location = new Point(1243, 16);
            _PictureBox1.Margin = new Padding(4, 4, 4, 4);
            _PictureBox1.Name = "PictureBox1";
            _PictureBox1.Size = new Size(123, 114);
            _PictureBox1.TabIndex = 14;
            _PictureBox1.TabStop = false;
            // 
            // Label2
            // 
            _Label2.Location = new Point(36, 203);
            _Label2.Margin = new Padding(4, 0, 4, 0);
            _Label2.Name = "Label2";
            _Label2.Size = new Size(123, 39);
            _Label2.TabIndex = 18;
            _Label2.Text = "(Double click row         to delete)";
            // 
            // IDDataGridViewTextBoxColumn
            // 
            _IDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            _IDDataGridViewTextBoxColumn.HeaderText = "ID";
            _IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn";
            // 
            // ItemCodeDataGridViewTextBoxColumn
            // 
            _ItemCodeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            _ItemCodeDataGridViewTextBoxColumn.DataPropertyName = "itemCode";
            _ItemCodeDataGridViewTextBoxColumn.HeaderText = "Item Code";
            _ItemCodeDataGridViewTextBoxColumn.Name = "ItemCodeDataGridViewTextBoxColumn";
            // 
            // itemDescription
            // 
            _itemDescription.DataPropertyName = "itemDescription";
            _itemDescription.HeaderText = "Description";
            _itemDescription.Name = "itemDescription";
            // 
            // FrmDateDataGridViewTextBoxColumn
            // 
            _FrmDateDataGridViewTextBoxColumn.DataPropertyName = "FrmDate";
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle1.Format = "dd MMM yyyy";
            DataGridViewCellStyle1.NullValue = null;
            _FrmDateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1;
            _FrmDateDataGridViewTextBoxColumn.HeaderText = "From Date";
            _FrmDateDataGridViewTextBoxColumn.Name = "FrmDateDataGridViewTextBoxColumn";
            // 
            // ToDateDataGridViewTextBoxColumn
            // 
            _ToDateDataGridViewTextBoxColumn.DataPropertyName = "ToDate";
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle2.Format = "dd MMM yyyy";
            DataGridViewCellStyle2.NullValue = null;
            _ToDateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2;
            _ToDateDataGridViewTextBoxColumn.HeaderText = "To Date";
            _ToDateDataGridViewTextBoxColumn.Name = "ToDateDataGridViewTextBoxColumn";
            // 
            // PriceDataGridViewTextBoxColumn
            // 
            _PriceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            _PriceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3;
            _PriceDataGridViewTextBoxColumn.HeaderText = "Price";
            _PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn";
            // 
            // DealPricing
            // 
            AutoScaleDimensions = new SizeF(8.0F, 16.0F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1373, 386);
            Controls.Add(_Label2);
            Controls.Add(_BtnAddNew);
            Controls.Add(_PictureBox2);
            Controls.Add(_PictureBox1);
            Controls.Add(_Label1);
            Controls.Add(_DataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "DealPricing";
            Text = "Deal Pricing";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)_DataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)_CustDealPriceMatrixBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)_ManifolddbDataSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)_PictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)_PictureBox1).EndInit();
            base.Load += DealPricing_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView _DataGridView1;

        internal DataGridView DataGridView1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DataGridView1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DataGridView1 != null)
                {
                    _DataGridView1.CellEndEdit -= DataGridView1_CellEndEdit;
                    _DataGridView1.CellDoubleClick -= DataGridView1_CellDoubleClick;
                    _DataGridView1.RowsRemoved -= DataGridView1_RowsRemoved;
                }

                _DataGridView1 = value;
                if (_DataGridView1 != null)
                {
                    _DataGridView1.CellEndEdit += DataGridView1_CellEndEdit;
                    _DataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;
                    _DataGridView1.RowsRemoved += DataGridView1_RowsRemoved;
                }
            }
        }

        private ManifolddbDataSet _ManifolddbDataSet;

        internal ManifolddbDataSet ManifolddbDataSet
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ManifolddbDataSet;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ManifolddbDataSet != null)
                {
                }

                _ManifolddbDataSet = value;
                if (_ManifolddbDataSet != null)
                {
                }
            }
        }

        private BindingSource _CustDealPriceMatrixBindingSource;

        internal BindingSource CustDealPriceMatrixBindingSource
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CustDealPriceMatrixBindingSource;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CustDealPriceMatrixBindingSource != null)
                {
                }

                _CustDealPriceMatrixBindingSource = value;
                if (_CustDealPriceMatrixBindingSource != null)
                {
                }
            }
        }

        private ManifolddbDataSetTableAdapters.CustDealPriceMatrixTableAdapter _CustDealPriceMatrixTableAdapter;

        internal ManifolddbDataSetTableAdapters.CustDealPriceMatrixTableAdapter CustDealPriceMatrixTableAdapter
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CustDealPriceMatrixTableAdapter;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CustDealPriceMatrixTableAdapter != null)
                {
                }

                _CustDealPriceMatrixTableAdapter = value;
                if (_CustDealPriceMatrixTableAdapter != null)
                {
                }
            }
        }

        private PictureBox _PictureBox2;

        internal PictureBox PictureBox2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PictureBox2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PictureBox2 != null)
                {
                }

                _PictureBox2 = value;
                if (_PictureBox2 != null)
                {
                }
            }
        }

        private PictureBox _PictureBox1;

        internal PictureBox PictureBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PictureBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PictureBox1 != null)
                {
                }

                _PictureBox1 = value;
                if (_PictureBox1 != null)
                {
                }
            }
        }

        private Label _Label1;

        internal Label Label1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label1 != null)
                {
                }

                _Label1 = value;
                if (_Label1 != null)
                {
                }
            }
        }

        private Button _BtnAddNew;

        internal Button BtnAddNew
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BtnAddNew;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BtnAddNew != null)
                {
                    _BtnAddNew.Click -= BtnAddNew_Click;
                }

                _BtnAddNew = value;
                if (_BtnAddNew != null)
                {
                    _BtnAddNew.Click += BtnAddNew_Click;
                }
            }
        }

        private Label _Label2;

        internal Label Label2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label2 != null)
                {
                }

                _Label2 = value;
                if (_Label2 != null)
                {
                }
            }
        }

        private DataGridViewTextBoxColumn _IDDataGridViewTextBoxColumn;

        internal DataGridViewTextBoxColumn IDDataGridViewTextBoxColumn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _IDDataGridViewTextBoxColumn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_IDDataGridViewTextBoxColumn != null)
                {
                }

                _IDDataGridViewTextBoxColumn = value;
                if (_IDDataGridViewTextBoxColumn != null)
                {
                }
            }
        }

        private DataGridViewTextBoxColumn _ItemCodeDataGridViewTextBoxColumn;

        internal DataGridViewTextBoxColumn ItemCodeDataGridViewTextBoxColumn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ItemCodeDataGridViewTextBoxColumn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ItemCodeDataGridViewTextBoxColumn != null)
                {
                }

                _ItemCodeDataGridViewTextBoxColumn = value;
                if (_ItemCodeDataGridViewTextBoxColumn != null)
                {
                }
            }
        }

        private DataGridViewTextBoxColumn _itemDescription;

        internal DataGridViewTextBoxColumn itemDescription
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _itemDescription;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_itemDescription != null)
                {
                }

                _itemDescription = value;
                if (_itemDescription != null)
                {
                }
            }
        }

        private DataGridViewTextBoxColumn _FrmDateDataGridViewTextBoxColumn;

        internal DataGridViewTextBoxColumn FrmDateDataGridViewTextBoxColumn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _FrmDateDataGridViewTextBoxColumn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_FrmDateDataGridViewTextBoxColumn != null)
                {
                }

                _FrmDateDataGridViewTextBoxColumn = value;
                if (_FrmDateDataGridViewTextBoxColumn != null)
                {
                }
            }
        }

        private DataGridViewTextBoxColumn _ToDateDataGridViewTextBoxColumn;

        internal DataGridViewTextBoxColumn ToDateDataGridViewTextBoxColumn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ToDateDataGridViewTextBoxColumn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ToDateDataGridViewTextBoxColumn != null)
                {
                }

                _ToDateDataGridViewTextBoxColumn = value;
                if (_ToDateDataGridViewTextBoxColumn != null)
                {
                }
            }
        }

        private DataGridViewTextBoxColumn _PriceDataGridViewTextBoxColumn;

        internal DataGridViewTextBoxColumn PriceDataGridViewTextBoxColumn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PriceDataGridViewTextBoxColumn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PriceDataGridViewTextBoxColumn != null)
                {
                }

                _PriceDataGridViewTextBoxColumn = value;
                if (_PriceDataGridViewTextBoxColumn != null)
                {
                }
            }
        }
    }
}
