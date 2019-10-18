using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace POButler
{
    [DesignerGenerated()]
    public partial class InventoryAllocation : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryAllocation));
            _DataGridView1 = new DataGridView();
            _DataGridView1.CellEndEdit += DataGridView1_CurrentCellDirtyStateChanged;
            _InventoryAllocBindingSource = new BindingSource(components);
            _ManifolddbDataSet = new POButler.ManifolddbDataSet();
            _InventoryAllocTableAdapter = new POButler.ManifolddbDataSetTableAdapters.InventoryAllocTableAdapter();
            _Label1 = new Label();
            _StatusStrip1 = new StatusStrip();
            _lblReccount = new Label();
            _lblitemcode = new Label();
            _Label3 = new Label();
            _lblItemName = new Label();
            _Label4 = new Label();
            _lblOrderedQty = new Label();
            _Label5 = new Label();
            _lblAvailQty = new Label();
            _Label6 = new Label();
            _lblPostQty = new Label();
            _Label8 = new Label();
            _lblBalance = new Label();
            _Label10 = new Label();
            _ToolStrip1 = new ToolStrip();
            _ToolStripSave = new ToolStripButton();
            _ToolStripSave.Click += ToolStripSave_Click;
            _ToolStripRemove = new ToolStripButton();
            _ToolStripRemove.Click += ToolStripRemove_Click;
            _lblAvailQty2 = new Label();
            _Label7 = new Label();
            _lblBarcode = new Label();
            _Label9 = new Label();
            _PictureBox2 = new PictureBox();
            _IDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            _AcctCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            _AcctNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            _PONumber = new DataGridViewTextBoxColumn();
            _ItemCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            _OrdQtyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            _AvailQtyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            _PostQtyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)_DataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_InventoryAllocBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_ManifolddbDataSet).BeginInit();
            _ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_PictureBox2).BeginInit();
            SuspendLayout();
            // 
            // DataGridView1
            // 
            _DataGridView1.AllowUserToAddRows = false;
            _DataGridView1.AllowUserToDeleteRows = false;
            _DataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom
                | AnchorStyles.Left
                | AnchorStyles.Right;
            _DataGridView1.AutoGenerateColumns = false;
            _DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle1.BackColor = SystemColors.Control;
            DataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            _DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
            _DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _DataGridView1.Columns.AddRange(new DataGridViewColumn[] { _IDDataGridViewTextBoxColumn, _AcctCodeDataGridViewTextBoxColumn, _AcctNameDataGridViewTextBoxColumn, _PONumber, _ItemCodeDataGridViewTextBoxColumn, _OrdQtyDataGridViewTextBoxColumn, _AvailQtyDataGridViewTextBoxColumn, _PostQtyDataGridViewTextBoxColumn });
            _DataGridView1.DataSource = _InventoryAllocBindingSource;
            _DataGridView1.Location = new Point(23, 167);
            _DataGridView1.Name = "DataGridView1";
            _DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle2.BackColor = SystemColors.Control;
            DataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _DataGridView1.Size = new Size(1081, 300);
            _DataGridView1.TabIndex = 0;
            // 
            // InventoryAllocBindingSource
            // 
            _InventoryAllocBindingSource.DataMember = "InventoryAlloc";
            _InventoryAllocBindingSource.DataSource = _ManifolddbDataSet;
            // 
            // ManifolddbDataSet
            // 
            _ManifolddbDataSet.DataSetName = "ManifolddbDataSet";
            _ManifolddbDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            // 
            // InventoryAllocTableAdapter
            // 
            _InventoryAllocTableAdapter.ClearBeforeFill = true;
            // 
            // Label1
            // 
            _Label1.Anchor = AnchorStyles.Top;
            _Label1.AutoSize = true;
            _Label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Underline, GraphicsUnit.Point, Conversions.ToByte(0));
            _Label1.Location = new Point(481, 25);
            _Label1.Name = "Label1";
            _Label1.Size = new Size(173, 24);
            _Label1.TabIndex = 10;
            _Label1.Text = "Inventory Allocation";
            // 
            // StatusStrip1
            // 
            _StatusStrip1.ImageScalingSize = new Size(20, 20);
            _StatusStrip1.Location = new Point(0, 565);
            _StatusStrip1.Name = "StatusStrip1";
            _StatusStrip1.Size = new Size(1116, 22);
            _StatusStrip1.TabIndex = 11;
            _StatusStrip1.Text = "StatusStrip1";
            // 
            // lblReccount
            // 
            _lblReccount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _lblReccount.AutoSize = true;
            _lblReccount.Location = new Point(48, 570);
            _lblReccount.Name = "lblReccount";
            _lblReccount.Size = new Size(10, 13);
            _lblReccount.TabIndex = 12;
            _lblReccount.Text = "-";
            // 
            // lblitemcode
            // 
            _lblitemcode.AutoSize = true;
            _lblitemcode.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _lblitemcode.Location = new Point(275, 56);
            _lblitemcode.Name = "lblitemcode";
            _lblitemcode.Size = new Size(60, 13);
            _lblitemcode.TabIndex = 14;
            _lblitemcode.Text = "lblitemcode";
            // 
            // Label3
            // 
            _Label3.AutoSize = true;
            _Label3.Location = new Point(179, 56);
            _Label3.Name = "Label3";
            _Label3.Size = new Size(55, 13);
            _Label3.TabIndex = 13;
            _Label3.Text = "Item Code";
            // 
            // lblItemName
            // 
            _lblItemName.AutoSize = true;
            _lblItemName.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _lblItemName.Location = new Point(275, 95);
            _lblItemName.Name = "lblItemName";
            _lblItemName.Size = new Size(65, 13);
            _lblItemName.TabIndex = 16;
            _lblItemName.Text = "lblItemName";
            // 
            // Label4
            // 
            _Label4.AutoSize = true;
            _Label4.Location = new Point(179, 95);
            _Label4.Name = "Label4";
            _Label4.Size = new Size(27, 13);
            _Label4.TabIndex = 15;
            _Label4.Text = "Item";
            // 
            // lblOrderedQty
            // 
            _lblOrderedQty.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _lblOrderedQty.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _lblOrderedQty.Location = new Point(1022, 469);
            _lblOrderedQty.Name = "lblOrderedQty";
            _lblOrderedQty.Size = new Size(80, 16);
            _lblOrderedQty.TabIndex = 18;
            _lblOrderedQty.Text = "lblOrderedQty";
            _lblOrderedQty.TextAlign = ContentAlignment.TopRight;
            // 
            // Label5
            // 
            _Label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _Label5.AutoSize = true;
            _Label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _Label5.Location = new Point(927, 469);
            _Label5.Name = "Label5";
            _Label5.Size = new Size(81, 16);
            _Label5.TabIndex = 17;
            _Label5.Text = "Ordered Qty";
            // 
            // lblAvailQty
            // 
            _lblAvailQty.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _lblAvailQty.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _lblAvailQty.Location = new Point(1022, 490);
            _lblAvailQty.Name = "lblAvailQty";
            _lblAvailQty.Size = new Size(80, 16);
            _lblAvailQty.TabIndex = 20;
            _lblAvailQty.Text = "lblAvailQty";
            _lblAvailQty.TextAlign = ContentAlignment.TopRight;
            // 
            // Label6
            // 
            _Label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _Label6.AutoSize = true;
            _Label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _Label6.Location = new Point(927, 490);
            _Label6.Name = "Label6";
            _Label6.Size = new Size(88, 16);
            _Label6.TabIndex = 19;
            _Label6.Text = "Available Qty";
            // 
            // lblPostQty
            // 
            _lblPostQty.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _lblPostQty.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _lblPostQty.Location = new Point(1022, 510);
            _lblPostQty.Name = "lblPostQty";
            _lblPostQty.Size = new Size(80, 16);
            _lblPostQty.TabIndex = 22;
            _lblPostQty.Text = "lblPostQty";
            _lblPostQty.TextAlign = ContentAlignment.TopRight;
            // 
            // Label8
            // 
            _Label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _Label8.AutoSize = true;
            _Label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _Label8.Location = new Point(927, 510);
            _Label8.Name = "Label8";
            _Label8.Size = new Size(58, 16);
            _Label8.TabIndex = 21;
            _Label8.Text = "Post Qty";
            // 
            // lblBalance
            // 
            _lblBalance.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _lblBalance.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _lblBalance.Location = new Point(1022, 530);
            _lblBalance.Name = "lblBalance";
            _lblBalance.Size = new Size(80, 16);
            _lblBalance.TabIndex = 24;
            _lblBalance.Text = "lblBalance";
            _lblBalance.TextAlign = ContentAlignment.TopRight;
            // 
            // Label10
            // 
            _Label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _Label10.AutoSize = true;
            _Label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _Label10.Location = new Point(927, 530);
            _Label10.Name = "Label10";
            _Label10.Size = new Size(58, 16);
            _Label10.TabIndex = 23;
            _Label10.Text = "Balance";
            // 
            // ToolStrip1
            // 
            _ToolStrip1.ImageScalingSize = new Size(20, 20);
            _ToolStrip1.Items.AddRange(new ToolStripItem[] { _ToolStripSave, _ToolStripRemove });
            _ToolStrip1.Location = new Point(0, 0);
            _ToolStrip1.Name = "ToolStrip1";
            _ToolStrip1.Size = new Size(1116, 27);
            _ToolStrip1.TabIndex = 25;
            _ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripSave
            // 
            _ToolStripSave.Alignment = ToolStripItemAlignment.Right;
            //_ToolStripSave.Image = POButler.My.Resources.Resources.Save2;
            _ToolStripSave.ImageTransparentColor = Color.Magenta;
            _ToolStripSave.Name = "ToolStripSave";
            _ToolStripSave.Padding = new Padding(0, 0, 50, 0);
            _ToolStripSave.Size = new Size(188, 24);
            _ToolStripSave.Text = "Save Post Quantities";
            // 
            // ToolStripRemove
            // 
            //_ToolStripRemove.Image = POButler.My.Resources.Resources.ban2;
            _ToolStripRemove.ImageTransparentColor = Color.Magenta;
            _ToolStripRemove.Name = "ToolStripRemove";
            _ToolStripRemove.Padding = new Padding(0, 0, 50, 0);
            _ToolStripRemove.Size = new Size(214, 24);
            _ToolStripRemove.Text = "Remove from ALL Orders";
            // 
            // lblAvailQty2
            // 
            _lblAvailQty2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _lblAvailQty2.Location = new Point(275, 114);
            _lblAvailQty2.Name = "lblAvailQty2";
            _lblAvailQty2.Size = new Size(80, 13);
            _lblAvailQty2.TabIndex = 27;
            _lblAvailQty2.Text = "lblAvailQty2";
            _lblAvailQty2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label7
            // 
            _Label7.AutoSize = true;
            _Label7.Location = new Point(177, 114);
            _Label7.Name = "Label7";
            _Label7.Size = new Size(77, 13);
            _Label7.TabIndex = 26;
            _Label7.Text = "Total Available";
            // 
            // lblBarcode
            // 
            _lblBarcode.AutoSize = true;
            _lblBarcode.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _lblBarcode.Location = new Point(275, 76);
            _lblBarcode.Name = "lblBarcode";
            _lblBarcode.Size = new Size(57, 13);
            _lblBarcode.TabIndex = 30;
            _lblBarcode.Text = "lblBarcode";
            // 
            // Label9
            // 
            _Label9.AutoSize = true;
            _Label9.Location = new Point(179, 76);
            _Label9.Name = "Label9";
            _Label9.Size = new Size(47, 13);
            _Label9.TabIndex = 29;
            _Label9.Text = "Barcode";
            // 
            // PictureBox2
            // 
            //_PictureBox2.BackgroundImage = POButler.My.Resources.Resources.FDBicon;
            _PictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            _PictureBox2.Location = new Point(23, 34);
            _PictureBox2.Name = "PictureBox2";
            _PictureBox2.Size = new Size(92, 93);
            _PictureBox2.TabIndex = 28;
            _PictureBox2.TabStop = false;
            // 
            // IDDataGridViewTextBoxColumn
            // 
            _IDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            _IDDataGridViewTextBoxColumn.Frozen = true;
            _IDDataGridViewTextBoxColumn.HeaderText = "ID";
            _IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn";
            _IDDataGridViewTextBoxColumn.Width = 43;
            // 
            // AcctCodeDataGridViewTextBoxColumn
            // 
            _AcctCodeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            _AcctCodeDataGridViewTextBoxColumn.DataPropertyName = "AcctCode";
            _AcctCodeDataGridViewTextBoxColumn.Frozen = true;
            _AcctCodeDataGridViewTextBoxColumn.HeaderText = "Acct";
            _AcctCodeDataGridViewTextBoxColumn.Name = "AcctCodeDataGridViewTextBoxColumn";
            _AcctCodeDataGridViewTextBoxColumn.ReadOnly = true;
            _AcctCodeDataGridViewTextBoxColumn.Width = 54;
            // 
            // AcctNameDataGridViewTextBoxColumn
            // 
            _AcctNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            _AcctNameDataGridViewTextBoxColumn.DataPropertyName = "AcctName";
            _AcctNameDataGridViewTextBoxColumn.Frozen = true;
            _AcctNameDataGridViewTextBoxColumn.HeaderText = "Name";
            _AcctNameDataGridViewTextBoxColumn.Name = "AcctNameDataGridViewTextBoxColumn";
            _AcctNameDataGridViewTextBoxColumn.ReadOnly = true;
            _AcctNameDataGridViewTextBoxColumn.Width = 60;
            // 
            // PONumber
            // 
            _PONumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            _PONumber.DataPropertyName = "PONumber";
            _PONumber.Frozen = true;
            _PONumber.HeaderText = "PONumber";
            _PONumber.Name = "PONumber";
            _PONumber.Width = 84;
            // 
            // ItemCodeDataGridViewTextBoxColumn
            // 
            _ItemCodeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            _ItemCodeDataGridViewTextBoxColumn.DataPropertyName = "ItemCode";
            _ItemCodeDataGridViewTextBoxColumn.Frozen = true;
            _ItemCodeDataGridViewTextBoxColumn.HeaderText = "ItemCode";
            _ItemCodeDataGridViewTextBoxColumn.Name = "ItemCodeDataGridViewTextBoxColumn";
            _ItemCodeDataGridViewTextBoxColumn.ReadOnly = true;
            _ItemCodeDataGridViewTextBoxColumn.Width = 5;
            // 
            // OrdQtyDataGridViewTextBoxColumn
            // 
            _OrdQtyDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            _OrdQtyDataGridViewTextBoxColumn.DataPropertyName = "OrdQty";
            _OrdQtyDataGridViewTextBoxColumn.Frozen = true;
            _OrdQtyDataGridViewTextBoxColumn.HeaderText = "Order Qty";
            _OrdQtyDataGridViewTextBoxColumn.Name = "OrdQtyDataGridViewTextBoxColumn";
            _OrdQtyDataGridViewTextBoxColumn.ReadOnly = true;
            _OrdQtyDataGridViewTextBoxColumn.Width = 77;
            // 
            // AvailQtyDataGridViewTextBoxColumn
            // 
            _AvailQtyDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            _AvailQtyDataGridViewTextBoxColumn.DataPropertyName = "AvailQty";
            _AvailQtyDataGridViewTextBoxColumn.Frozen = true;
            _AvailQtyDataGridViewTextBoxColumn.HeaderText = "Avail Qty";
            _AvailQtyDataGridViewTextBoxColumn.Name = "AvailQtyDataGridViewTextBoxColumn";
            _AvailQtyDataGridViewTextBoxColumn.ReadOnly = true;
            _AvailQtyDataGridViewTextBoxColumn.Width = 74;
            // 
            // PostQtyDataGridViewTextBoxColumn
            // 
            _PostQtyDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            _PostQtyDataGridViewTextBoxColumn.DataPropertyName = "PostQty";
            _PostQtyDataGridViewTextBoxColumn.HeaderText = "Post Qty";
            _PostQtyDataGridViewTextBoxColumn.Name = "PostQtyDataGridViewTextBoxColumn";
            _PostQtyDataGridViewTextBoxColumn.Width = 72;
            // 
            // InventoryAllocation
            // 
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 587);
            Controls.Add(_lblBarcode);
            Controls.Add(_Label9);
            Controls.Add(_PictureBox2);
            Controls.Add(_lblAvailQty2);
            Controls.Add(_Label7);
            Controls.Add(_ToolStrip1);
            Controls.Add(_lblBalance);
            Controls.Add(_Label10);
            Controls.Add(_lblPostQty);
            Controls.Add(_Label8);
            Controls.Add(_lblAvailQty);
            Controls.Add(_Label6);
            Controls.Add(_lblOrderedQty);
            Controls.Add(_Label5);
            Controls.Add(_lblItemName);
            Controls.Add(_Label4);
            Controls.Add(_lblitemcode);
            Controls.Add(_Label3);
            Controls.Add(_lblReccount);
            Controls.Add(_StatusStrip1);
            Controls.Add(_Label1);
            Controls.Add(_DataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InventoryAllocation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Allocation";
            ((System.ComponentModel.ISupportInitialize)_DataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)_InventoryAllocBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)_ManifolddbDataSet).EndInit();
            base.Load += InventoryAllocation_Load;
            _ToolStrip1.ResumeLayout(false);
            _ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_PictureBox2).EndInit();
            base.Load += InventoryAllocation_Load;
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
                    _DataGridView1.CellEndEdit -= DataGridView1_CurrentCellDirtyStateChanged;
                }

                _DataGridView1 = value;
                if (_DataGridView1 != null)
                {
                    _DataGridView1.CellEndEdit += DataGridView1_CurrentCellDirtyStateChanged;
                }
            }
        }

        private POButler.ManifolddbDataSet _ManifolddbDataSet;

        internal POButler.ManifolddbDataSet ManifolddbDataSet
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

        private BindingSource _InventoryAllocBindingSource;

        internal BindingSource InventoryAllocBindingSource
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _InventoryAllocBindingSource;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_InventoryAllocBindingSource != null)
                {
                }

                _InventoryAllocBindingSource = value;
                if (_InventoryAllocBindingSource != null)
                {
                }
            }
        }

        private POButler.ManifolddbDataSetTableAdapters.InventoryAllocTableAdapter _InventoryAllocTableAdapter;

        internal POButler.ManifolddbDataSetTableAdapters.InventoryAllocTableAdapter InventoryAllocTableAdapter
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _InventoryAllocTableAdapter;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_InventoryAllocTableAdapter != null)
                {
                }

                _InventoryAllocTableAdapter = value;
                if (_InventoryAllocTableAdapter != null)
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

        private StatusStrip _StatusStrip1;

        internal StatusStrip StatusStrip1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _StatusStrip1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_StatusStrip1 != null)
                {
                }

                _StatusStrip1 = value;
                if (_StatusStrip1 != null)
                {
                }
            }
        }

        private Label _lblReccount;

        internal Label lblReccount
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblReccount;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblReccount != null)
                {
                }

                _lblReccount = value;
                if (_lblReccount != null)
                {
                }
            }
        }

        private Label _lblitemcode;

        internal Label lblitemcode
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblitemcode;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblitemcode != null)
                {
                }

                _lblitemcode = value;
                if (_lblitemcode != null)
                {
                }
            }
        }

        private Label _Label3;

        internal Label Label3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label3 != null)
                {
                }

                _Label3 = value;
                if (_Label3 != null)
                {
                }
            }
        }

        private Label _lblItemName;

        internal Label lblItemName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblItemName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblItemName != null)
                {
                }

                _lblItemName = value;
                if (_lblItemName != null)
                {
                }
            }
        }

        private Label _Label4;

        internal Label Label4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label4 != null)
                {
                }

                _Label4 = value;
                if (_Label4 != null)
                {
                }
            }
        }

        private Label _lblOrderedQty;

        internal Label lblOrderedQty
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblOrderedQty;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblOrderedQty != null)
                {
                }

                _lblOrderedQty = value;
                if (_lblOrderedQty != null)
                {
                }
            }
        }

        private Label _Label5;

        internal Label Label5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label5 != null)
                {
                }

                _Label5 = value;
                if (_Label5 != null)
                {
                }
            }
        }

        private Label _lblAvailQty;

        internal Label lblAvailQty
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblAvailQty;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblAvailQty != null)
                {
                }

                _lblAvailQty = value;
                if (_lblAvailQty != null)
                {
                }
            }
        }

        private Label _Label6;

        internal Label Label6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label6 != null)
                {
                }

                _Label6 = value;
                if (_Label6 != null)
                {
                }
            }
        }

        private Label _lblPostQty;

        internal Label lblPostQty
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblPostQty;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblPostQty != null)
                {
                }

                _lblPostQty = value;
                if (_lblPostQty != null)
                {
                }
            }
        }

        private Label _Label8;

        internal Label Label8
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label8;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label8 != null)
                {
                }

                _Label8 = value;
                if (_Label8 != null)
                {
                }
            }
        }

        private Label _lblBalance;

        internal Label lblBalance
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblBalance;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblBalance != null)
                {
                }

                _lblBalance = value;
                if (_lblBalance != null)
                {
                }
            }
        }

        private Label _Label10;

        internal Label Label10
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label10;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label10 != null)
                {
                }

                _Label10 = value;
                if (_Label10 != null)
                {
                }
            }
        }

        private ToolStrip _ToolStrip1;

        internal ToolStrip ToolStrip1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ToolStrip1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ToolStrip1 != null)
                {
                }

                _ToolStrip1 = value;
                if (_ToolStrip1 != null)
                {
                }
            }
        }

        private ToolStripButton _ToolStripRemove;

        internal ToolStripButton ToolStripRemove
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ToolStripRemove;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ToolStripRemove != null)
                {
                    _ToolStripRemove.Click -= ToolStripRemove_Click;
                }

                _ToolStripRemove = value;
                if (_ToolStripRemove != null)
                {
                    _ToolStripRemove.Click += ToolStripRemove_Click;
                }
            }
        }

        private Label _lblAvailQty2;

        internal Label lblAvailQty2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblAvailQty2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblAvailQty2 != null)
                {
                }

                _lblAvailQty2 = value;
                if (_lblAvailQty2 != null)
                {
                }
            }
        }

        private Label _Label7;

        internal Label Label7
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label7;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label7 != null)
                {
                }

                _Label7 = value;
                if (_Label7 != null)
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

        private ToolStripButton _ToolStripSave;

        internal ToolStripButton ToolStripSave
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ToolStripSave;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ToolStripSave != null)
                {
                    _ToolStripSave.Click -= ToolStripSave_Click;
                }

                _ToolStripSave = value;
                if (_ToolStripSave != null)
                {
                    _ToolStripSave.Click += ToolStripSave_Click;
                }
            }
        }

        private Label _lblBarcode;

        internal Label lblBarcode
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblBarcode;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblBarcode != null)
                {
                }

                _lblBarcode = value;
                if (_lblBarcode != null)
                {
                }
            }
        }

        private Label _Label9;

        internal Label Label9
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label9;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label9 != null)
                {
                }

                _Label9 = value;
                if (_Label9 != null)
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

        private DataGridViewTextBoxColumn _AcctCodeDataGridViewTextBoxColumn;

        internal DataGridViewTextBoxColumn AcctCodeDataGridViewTextBoxColumn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AcctCodeDataGridViewTextBoxColumn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AcctCodeDataGridViewTextBoxColumn != null)
                {
                }

                _AcctCodeDataGridViewTextBoxColumn = value;
                if (_AcctCodeDataGridViewTextBoxColumn != null)
                {
                }
            }
        }

        private DataGridViewTextBoxColumn _AcctNameDataGridViewTextBoxColumn;

        internal DataGridViewTextBoxColumn AcctNameDataGridViewTextBoxColumn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AcctNameDataGridViewTextBoxColumn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AcctNameDataGridViewTextBoxColumn != null)
                {
                }

                _AcctNameDataGridViewTextBoxColumn = value;
                if (_AcctNameDataGridViewTextBoxColumn != null)
                {
                }
            }
        }

        private DataGridViewTextBoxColumn _PONumber;

        internal DataGridViewTextBoxColumn PONumber
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PONumber;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PONumber != null)
                {
                }

                _PONumber = value;
                if (_PONumber != null)
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

        private DataGridViewTextBoxColumn _OrdQtyDataGridViewTextBoxColumn;

        internal DataGridViewTextBoxColumn OrdQtyDataGridViewTextBoxColumn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _OrdQtyDataGridViewTextBoxColumn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_OrdQtyDataGridViewTextBoxColumn != null)
                {
                }

                _OrdQtyDataGridViewTextBoxColumn = value;
                if (_OrdQtyDataGridViewTextBoxColumn != null)
                {
                }
            }
        }

        private DataGridViewTextBoxColumn _AvailQtyDataGridViewTextBoxColumn;

        internal DataGridViewTextBoxColumn AvailQtyDataGridViewTextBoxColumn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AvailQtyDataGridViewTextBoxColumn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AvailQtyDataGridViewTextBoxColumn != null)
                {
                }

                _AvailQtyDataGridViewTextBoxColumn = value;
                if (_AvailQtyDataGridViewTextBoxColumn != null)
                {
                }
            }
        }

        private DataGridViewTextBoxColumn _PostQtyDataGridViewTextBoxColumn;

        internal DataGridViewTextBoxColumn PostQtyDataGridViewTextBoxColumn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PostQtyDataGridViewTextBoxColumn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PostQtyDataGridViewTextBoxColumn != null)
                {
                }

                _PostQtyDataGridViewTextBoxColumn = value;
                if (_PostQtyDataGridViewTextBoxColumn != null)
                {
                }
            }
        }
    }
}
