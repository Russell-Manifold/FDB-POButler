using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace POButler
{
    [DesignerGenerated()]
    public partial class PODetails : MetroFramework.Forms.MetroForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this._Label1 = new System.Windows.Forms.Label();
            this._Label2 = new System.Windows.Forms.Label();
            this._Label3 = new System.Windows.Forms.Label();
            this._Label4 = new System.Windows.Forms.Label();
            this._Label6 = new System.Windows.Forms.Label();
            this._lblPONum = new System.Windows.Forms.Label();
            this._lblDueDate = new System.Windows.Forms.Label();
            this._lblCustName = new System.Windows.Forms.Label();
            this._lblCustCode = new System.Windows.Forms.Label();
            this._lblAdd3 = new System.Windows.Forms.Label();
            this._lblAdd2 = new System.Windows.Forms.Label();
            this._lblAdd1 = new System.Windows.Forms.Label();
            this._Label5 = new System.Windows.Forms.Label();
            this._Label7 = new System.Windows.Forms.Label();
            this._DataGridView1 = new System.Windows.Forms.DataGridView();
            this._DocLinesTempBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._ManifolddbDataSet = new POButler.ManifolddbDataSet();
            this._DocLinesTempTableAdapter = new POButler.ManifolddbDataSetTableAdapters.DocLinesTempTableAdapter();
            this._lblOrdVal = new System.Windows.Forms.Label();
            this._Label8 = new System.Windows.Forms.Label();
            this._lblAdd4 = new System.Windows.Forms.Label();
            this._ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this._BtnReady = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDocNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineValDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalOrdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DocLinesTempBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ManifolddbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // _Label1
            // 
            this._Label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._Label1.AutoSize = true;
            this._Label1.Location = new System.Drawing.Point(417, 65);
            this._Label1.Name = "_Label1";
            this._Label1.Size = new System.Drawing.Size(79, 13);
            this._Label1.TabIndex = 0;
            this._Label1.Text = "Customer Code";
            // 
            // _Label2
            // 
            this._Label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._Label2.AutoSize = true;
            this._Label2.Location = new System.Drawing.Point(417, 90);
            this._Label2.Name = "_Label2";
            this._Label2.Size = new System.Drawing.Size(51, 13);
            this._Label2.TabIndex = 1;
            this._Label2.Text = "Customer";
            // 
            // _Label3
            // 
            this._Label3.AutoSize = true;
            this._Label3.Location = new System.Drawing.Point(46, 65);
            this._Label3.Name = "_Label3";
            this._Label3.Size = new System.Drawing.Size(94, 13);
            this._Label3.TabIndex = 2;
            this._Label3.Text = "Customer PO Num";
            // 
            // _Label4
            // 
            this._Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._Label4.AutoSize = true;
            this._Label4.Location = new System.Drawing.Point(795, 65);
            this._Label4.Name = "_Label4";
            this._Label4.Size = new System.Drawing.Size(89, 13);
            this._Label4.TabIndex = 5;
            this._Label4.Text = "Delivery Address ";
            // 
            // _Label6
            // 
            this._Label6.AutoSize = true;
            this._Label6.Location = new System.Drawing.Point(46, 90);
            this._Label6.Name = "_Label6";
            this._Label6.Size = new System.Drawing.Size(53, 13);
            this._Label6.TabIndex = 3;
            this._Label6.Text = "Due Date";
            // 
            // _lblPONum
            // 
            this._lblPONum.AutoSize = true;
            this._lblPONum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblPONum.Location = new System.Drawing.Point(146, 65);
            this._lblPONum.Name = "_lblPONum";
            this._lblPONum.Size = new System.Drawing.Size(54, 13);
            this._lblPONum.TabIndex = 6;
            this._lblPONum.Text = "lblPONum";
            // 
            // _lblDueDate
            // 
            this._lblDueDate.AutoSize = true;
            this._lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblDueDate.Location = new System.Drawing.Point(146, 90);
            this._lblDueDate.Name = "_lblDueDate";
            this._lblDueDate.Size = new System.Drawing.Size(60, 13);
            this._lblDueDate.TabIndex = 7;
            this._lblDueDate.Text = "lblDueDate";
            // 
            // _lblCustName
            // 
            this._lblCustName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._lblCustName.AutoSize = true;
            this._lblCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCustName.Location = new System.Drawing.Point(502, 90);
            this._lblCustName.Name = "_lblCustName";
            this._lblCustName.Size = new System.Drawing.Size(66, 13);
            this._lblCustName.TabIndex = 8;
            this._lblCustName.Text = "lblCustName";
            // 
            // _lblCustCode
            // 
            this._lblCustCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._lblCustCode.AutoSize = true;
            this._lblCustCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCustCode.Location = new System.Drawing.Point(502, 65);
            this._lblCustCode.Name = "_lblCustCode";
            this._lblCustCode.Size = new System.Drawing.Size(63, 13);
            this._lblCustCode.TabIndex = 9;
            this._lblCustCode.Text = "lblCustCode";
            // 
            // _lblAdd3
            // 
            this._lblAdd3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lblAdd3.AutoSize = true;
            this._lblAdd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblAdd3.Location = new System.Drawing.Point(890, 91);
            this._lblAdd3.Name = "_lblAdd3";
            this._lblAdd3.Size = new System.Drawing.Size(42, 13);
            this._lblAdd3.TabIndex = 10;
            this._lblAdd3.Text = "lblAdd3";
            // 
            // _lblAdd2
            // 
            this._lblAdd2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lblAdd2.AutoSize = true;
            this._lblAdd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblAdd2.Location = new System.Drawing.Point(890, 78);
            this._lblAdd2.Name = "_lblAdd2";
            this._lblAdd2.Size = new System.Drawing.Size(42, 13);
            this._lblAdd2.TabIndex = 11;
            this._lblAdd2.Text = "lblAdd2";
            // 
            // _lblAdd1
            // 
            this._lblAdd1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lblAdd1.AutoSize = true;
            this._lblAdd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblAdd1.Location = new System.Drawing.Point(890, 65);
            this._lblAdd1.Name = "_lblAdd1";
            this._lblAdd1.Size = new System.Drawing.Size(42, 13);
            this._lblAdd1.TabIndex = 12;
            this._lblAdd1.Text = "lblAdd1";
            // 
            // _Label5
            // 
            this._Label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label5.Location = new System.Drawing.Point(49, 123);
            this._Label5.Name = "_Label5";
            this._Label5.Size = new System.Drawing.Size(1020, 2);
            this._Label5.TabIndex = 13;
            // 
            // _Label7
            // 
            this._Label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._Label7.AutoSize = true;
            this._Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label7.Location = new System.Drawing.Point(392, 25);
            this._Label7.Name = "_Label7";
            this._Label7.Size = new System.Drawing.Size(204, 24);
            this._Label7.TabIndex = 14;
            this._Label7.Text = "Purchase Order Details";
            // 
            // _DataGridView1
            // 
            this._DataGridView1.AllowUserToAddRows = false;
            this._DataGridView1.AllowUserToDeleteRows = false;
            this._DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._DataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iDocNumDataGridViewTextBoxColumn,
            this.barcodeDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.descriptDataGridViewTextBoxColumn,
            this.ordQtyDataGridViewTextBoxColumn,
            this.availQtyDataGridViewTextBoxColumn,
            this.postQtyDataGridViewTextBoxColumn,
            this.pOrateDataGridViewTextBoxColumn,
            this.listRateDataGridViewTextBoxColumn,
            this.dealRateDataGridViewTextBoxColumn,
            this.postRateDataGridViewTextBoxColumn,
            this.lineValDataGridViewTextBoxColumn,
            this.totalOrdDataGridViewTextBoxColumn});
            this._DataGridView1.DataSource = this._DocLinesTempBindingSource;
            this._DataGridView1.Location = new System.Drawing.Point(12, 149);
            this._DataGridView1.Name = "_DataGridView1";
            this._DataGridView1.Size = new System.Drawing.Size(1081, 111);
            this._DataGridView1.TabIndex = 15;
            this._DataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._DataGridView1_CellDoubleClick);
            // 
            // _DocLinesTempBindingSource
            // 
            this._DocLinesTempBindingSource.DataMember = "DocLinesTemp";
            this._DocLinesTempBindingSource.DataSource = this._ManifolddbDataSet;
            // 
            // _ManifolddbDataSet
            // 
            this._ManifolddbDataSet.DataSetName = "ManifolddbDataSet";
            this._ManifolddbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _DocLinesTempTableAdapter
            // 
            this._DocLinesTempTableAdapter.ClearBeforeFill = true;
            // 
            // _lblOrdVal
            // 
            this._lblOrdVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._lblOrdVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblOrdVal.Location = new System.Drawing.Point(993, 278);
            this._lblOrdVal.Name = "_lblOrdVal";
            this._lblOrdVal.Size = new System.Drawing.Size(100, 16);
            this._lblOrdVal.TabIndex = 22;
            this._lblOrdVal.Text = "lblOrdVal";
            this._lblOrdVal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _Label8
            // 
            this._Label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._Label8.AutoSize = true;
            this._Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label8.Location = new System.Drawing.Point(860, 278);
            this._Label8.Name = "_Label8";
            this._Label8.Size = new System.Drawing.Size(129, 16);
            this._Label8.TabIndex = 21;
            this._Label8.Text = "Order Value (Ex Vat)";
            // 
            // _lblAdd4
            // 
            this._lblAdd4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lblAdd4.AutoSize = true;
            this._lblAdd4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblAdd4.Location = new System.Drawing.Point(890, 104);
            this._lblAdd4.Name = "_lblAdd4";
            this._lblAdd4.Size = new System.Drawing.Size(42, 13);
            this._lblAdd4.TabIndex = 24;
            this._lblAdd4.Text = "lblAdd4";
            // 
            // _ToolStripButton1
            // 
            this._ToolStripButton1.Name = "_ToolStripButton1";
            this._ToolStripButton1.Size = new System.Drawing.Size(23, 23);
            // 
            // _BtnReady
            // 
            this._BtnReady.BackColor = System.Drawing.Color.Transparent;
            this._BtnReady.FlatAppearance.BorderSize = 0;
            this._BtnReady.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this._BtnReady.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._BtnReady.Location = new System.Drawing.Point(208, 7);
            this._BtnReady.Name = "_BtnReady";
            this._BtnReady.Size = new System.Drawing.Size(163, 23);
            this._BtnReady.TabIndex = 26;
            this._BtnReady.Text = "Mark as ready to Post";
            this._BtnReady.UseVisualStyleBackColor = false;
            this._BtnReady.Click += new System.EventHandler(this._BtnReady_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // iDocNumDataGridViewTextBoxColumn
            // 
            this.iDocNumDataGridViewTextBoxColumn.DataPropertyName = "iDocNum";
            this.iDocNumDataGridViewTextBoxColumn.HeaderText = "iDocNum";
            this.iDocNumDataGridViewTextBoxColumn.Name = "iDocNumDataGridViewTextBoxColumn";
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // descriptDataGridViewTextBoxColumn
            // 
            this.descriptDataGridViewTextBoxColumn.DataPropertyName = "Descript";
            this.descriptDataGridViewTextBoxColumn.HeaderText = "Descript";
            this.descriptDataGridViewTextBoxColumn.Name = "descriptDataGridViewTextBoxColumn";
            // 
            // ordQtyDataGridViewTextBoxColumn
            // 
            this.ordQtyDataGridViewTextBoxColumn.DataPropertyName = "OrdQty";
            this.ordQtyDataGridViewTextBoxColumn.HeaderText = "OrdQty";
            this.ordQtyDataGridViewTextBoxColumn.Name = "ordQtyDataGridViewTextBoxColumn";
            // 
            // availQtyDataGridViewTextBoxColumn
            // 
            this.availQtyDataGridViewTextBoxColumn.DataPropertyName = "AvailQty";
            this.availQtyDataGridViewTextBoxColumn.HeaderText = "AvailQty";
            this.availQtyDataGridViewTextBoxColumn.Name = "availQtyDataGridViewTextBoxColumn";
            // 
            // postQtyDataGridViewTextBoxColumn
            // 
            this.postQtyDataGridViewTextBoxColumn.DataPropertyName = "PostQty";
            this.postQtyDataGridViewTextBoxColumn.HeaderText = "PostQty";
            this.postQtyDataGridViewTextBoxColumn.Name = "postQtyDataGridViewTextBoxColumn";
            // 
            // pOrateDataGridViewTextBoxColumn
            // 
            this.pOrateDataGridViewTextBoxColumn.DataPropertyName = "POrate";
            this.pOrateDataGridViewTextBoxColumn.HeaderText = "POrate";
            this.pOrateDataGridViewTextBoxColumn.Name = "pOrateDataGridViewTextBoxColumn";
            // 
            // listRateDataGridViewTextBoxColumn
            // 
            this.listRateDataGridViewTextBoxColumn.DataPropertyName = "ListRate";
            this.listRateDataGridViewTextBoxColumn.HeaderText = "ListRate";
            this.listRateDataGridViewTextBoxColumn.Name = "listRateDataGridViewTextBoxColumn";
            // 
            // dealRateDataGridViewTextBoxColumn
            // 
            this.dealRateDataGridViewTextBoxColumn.DataPropertyName = "DealRate";
            this.dealRateDataGridViewTextBoxColumn.HeaderText = "DealRate";
            this.dealRateDataGridViewTextBoxColumn.Name = "dealRateDataGridViewTextBoxColumn";
            // 
            // postRateDataGridViewTextBoxColumn
            // 
            this.postRateDataGridViewTextBoxColumn.DataPropertyName = "PostRate";
            this.postRateDataGridViewTextBoxColumn.HeaderText = "PostRate";
            this.postRateDataGridViewTextBoxColumn.Name = "postRateDataGridViewTextBoxColumn";
            // 
            // lineValDataGridViewTextBoxColumn
            // 
            this.lineValDataGridViewTextBoxColumn.DataPropertyName = "LineVal";
            this.lineValDataGridViewTextBoxColumn.HeaderText = "LineVal";
            this.lineValDataGridViewTextBoxColumn.Name = "lineValDataGridViewTextBoxColumn";
            // 
            // totalOrdDataGridViewTextBoxColumn
            // 
            this.totalOrdDataGridViewTextBoxColumn.DataPropertyName = "TotalOrd";
            this.totalOrdDataGridViewTextBoxColumn.HeaderText = "TotalOrd";
            this.totalOrdDataGridViewTextBoxColumn.Name = "totalOrdDataGridViewTextBoxColumn";
            // 
            // PODetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 405);
            this.Controls.Add(this._BtnReady);
            this.Controls.Add(this._lblAdd4);
            this.Controls.Add(this._lblOrdVal);
            this.Controls.Add(this._Label8);
            this.Controls.Add(this._DataGridView1);
            this.Controls.Add(this._Label7);
            this.Controls.Add(this._Label5);
            this.Controls.Add(this._lblAdd1);
            this.Controls.Add(this._lblAdd2);
            this.Controls.Add(this._lblAdd3);
            this.Controls.Add(this._lblCustCode);
            this.Controls.Add(this._lblCustName);
            this.Controls.Add(this._lblDueDate);
            this.Controls.Add(this._lblPONum);
            this.Controls.Add(this._Label4);
            this.Controls.Add(this._Label6);
            this.Controls.Add(this._Label3);
            this.Controls.Add(this._Label2);
            this.Controls.Add(this._Label1);
            this.Name = "PODetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this._DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DocLinesTempBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ManifolddbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

        private Label _lblPONum;

        internal Label lblPONum
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblPONum;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblPONum != null)
                {
                }

                _lblPONum = value;
                if (_lblPONum != null)
                {
                }
            }
        }

        private Label _lblDueDate;

        internal Label lblDueDate
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblDueDate;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblDueDate != null)
                {
                }

                _lblDueDate = value;
                if (_lblDueDate != null)
                {
                }
            }
        }

        private Label _lblCustName;

        internal Label lblCustName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblCustName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblCustName != null)
                {
                }

                _lblCustName = value;
                if (_lblCustName != null)
                {
                }
            }
        }

        private Label _lblCustCode;

        internal Label lblCustCode
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblCustCode;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblCustCode != null)
                {
                }

                _lblCustCode = value;
                if (_lblCustCode != null)
                {
                }
            }
        }

        private Label _lblAdd3;

        internal Label lblAdd3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblAdd3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblAdd3 != null)
                {
                }

                _lblAdd3 = value;
                if (_lblAdd3 != null)
                {
                }
            }
        }

        private Label _lblAdd2;

        internal Label lblAdd2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblAdd2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblAdd2 != null)
                {
                }

                _lblAdd2 = value;
                if (_lblAdd2 != null)
                {
                }
            }
        }

        private Label _lblAdd1;

        internal Label lblAdd1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblAdd1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblAdd1 != null)
                {
                }

                _lblAdd1 = value;
                if (_lblAdd1 != null)
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
                    _DataGridView1.CellDoubleClick -= _DataGridView1_CellDoubleClick;
                    _DataGridView1.CellMouseDown -= DataGridView1_CellMouseDown;
                }

                _DataGridView1 = value;
                if (_DataGridView1 != null)
                {
                    _DataGridView1.CellDoubleClick += _DataGridView1_CellDoubleClick;
                    _DataGridView1.CellMouseDown += DataGridView1_CellMouseDown;
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

        private BindingSource _DocLinesTempBindingSource;

        internal BindingSource DocLinesTempBindingSource
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DocLinesTempBindingSource;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DocLinesTempBindingSource != null)
                {
                }

                _DocLinesTempBindingSource = value;
                if (_DocLinesTempBindingSource != null)
                {
                }
            }
        }

        private POButler.ManifolddbDataSetTableAdapters.DocLinesTempTableAdapter _DocLinesTempTableAdapter;

        internal POButler.ManifolddbDataSetTableAdapters.DocLinesTempTableAdapter DocLinesTempTableAdapter
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DocLinesTempTableAdapter;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DocLinesTempTableAdapter != null)
                {
                }

                _DocLinesTempTableAdapter = value;
                if (_DocLinesTempTableAdapter != null)
                {
                }
            }
        }

        private Label _lblOrdVal;

        internal Label lblOrdVal
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblOrdVal;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblOrdVal != null)
                {
                }

                _lblOrdVal = value;
                if (_lblOrdVal != null)
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

        internal ToolStripButton ToolStripButton1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ToolStripButton1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ToolStripButton1 != null)
                {
                    _ToolStripButton1.Click -= ToolStripButton1_Click;
                }

                _ToolStripButton1 = value;
                if (_ToolStripButton1 != null)
                {
                    _ToolStripButton1.Click += ToolStripButton1_Click;
                }
            }
        }

        private Label _lblAdd4;

        internal Label lblAdd4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblAdd4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblAdd4 != null)
                {
                }

                _lblAdd4 = value;
                if (_lblAdd4 != null)
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

        private DataGridViewTextBoxColumn IDocNumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn BarcodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn DescriptDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn OrdQtyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn AvailQtyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn PostQtyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn TotalOrd;
        private DataGridViewTextBoxColumn POrateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ListRateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn DealRateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn PostRateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn LineVal;
        private ToolStripButton _ToolStripButton1;
        private Button _BtnReady;
        private DataGridViewTextBoxColumn _IDocNumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDocNumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ordQtyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn availQtyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn postQtyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pOrateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn listRateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dealRateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn postRateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lineValDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalOrdDataGridViewTextBoxColumn;
    }
}
