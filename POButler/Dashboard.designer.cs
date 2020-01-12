using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace POButler
{
    [DesignerGenerated()]
    public partial class Dashboard : MetroFramework.Forms.MetroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this._DataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acctCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acctNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.importDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yesImportDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.delAdd1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delAdd2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delAdd3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delAdd4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docHeaderTempBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manifolddbDataSet = new POButler.ManifolddbDataSet();
            this._lblReccount = new System.Windows.Forms.Label();
            this._Label1 = new System.Windows.Forms.Label();
            this._lblPasteldb = new System.Windows.Forms.Label();
            this._BtnConString = new System.Windows.Forms.Button();
            this._Label9 = new System.Windows.Forms.Label();
            this.btnScanner = new System.Windows.Forms.Button();
            this.docHeaderTempTableAdapter = new POButler.ManifolddbDataSetTableAdapters.DocHeaderTempTableAdapter();
            this._Button3 = new System.Windows.Forms.Button();
            this._btnCheckCodes = new System.Windows.Forms.Button();
            this._BtnPostToPastel = new System.Windows.Forms.Button();
            this._btnDealPricing = new System.Windows.Forms.Button();
            this._BtnInventView = new System.Windows.Forms.Button();
            this._BtnCurrPOs = new System.Windows.Forms.Button();
            this._BtnDownloadPOs = new System.Windows.Forms.Button();
            this._PictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docHeaderTempBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manifolddbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // _DataGridView1
            // 
            this._DataGridView1.AllowUserToAddRows = false;
            this._DataGridView1.AllowUserToDeleteRows = false;
            this._DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._DataGridView1.AutoGenerateColumns = false;
            this._DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.docNumDataGridViewTextBoxColumn,
            this.acctCodeDataGridViewTextBoxColumn,
            this.acctNameDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn,
            this.importedDataGridViewCheckBoxColumn,
            this.importDateDataGridViewTextBoxColumn,
            this.yesImportDataGridViewCheckBoxColumn,
            this.delAdd1DataGridViewTextBoxColumn,
            this.delAdd2DataGridViewTextBoxColumn,
            this.delAdd3DataGridViewTextBoxColumn,
            this.delAdd4DataGridViewTextBoxColumn,
            this.repCodeDataGridViewTextBoxColumn,
            this.ordValueDataGridViewTextBoxColumn});
            this._DataGridView1.DataSource = this.docHeaderTempBindingSource;
            this._DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this._DataGridView1.Location = new System.Drawing.Point(163, 117);
            this._DataGridView1.MultiSelect = false;
            this._DataGridView1.Name = "_DataGridView1";
            this._DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this._DataGridView1.Size = new System.Drawing.Size(842, 355);
            this._DataGridView1.TabIndex = 4;
            this._DataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._DataGridView1_CellDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // docNumDataGridViewTextBoxColumn
            // 
            this.docNumDataGridViewTextBoxColumn.DataPropertyName = "DocNum";
            this.docNumDataGridViewTextBoxColumn.HeaderText = "DocNum";
            this.docNumDataGridViewTextBoxColumn.Name = "docNumDataGridViewTextBoxColumn";
            // 
            // acctCodeDataGridViewTextBoxColumn
            // 
            this.acctCodeDataGridViewTextBoxColumn.DataPropertyName = "AcctCode";
            this.acctCodeDataGridViewTextBoxColumn.HeaderText = "AcctCode";
            this.acctCodeDataGridViewTextBoxColumn.Name = "acctCodeDataGridViewTextBoxColumn";
            // 
            // acctNameDataGridViewTextBoxColumn
            // 
            this.acctNameDataGridViewTextBoxColumn.DataPropertyName = "AcctName";
            this.acctNameDataGridViewTextBoxColumn.HeaderText = "AcctName";
            this.acctNameDataGridViewTextBoxColumn.Name = "acctNameDataGridViewTextBoxColumn";
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            // 
            // importedDataGridViewCheckBoxColumn
            // 
            this.importedDataGridViewCheckBoxColumn.DataPropertyName = "Imported";
            this.importedDataGridViewCheckBoxColumn.HeaderText = "Imported";
            this.importedDataGridViewCheckBoxColumn.Name = "importedDataGridViewCheckBoxColumn";
            // 
            // importDateDataGridViewTextBoxColumn
            // 
            this.importDateDataGridViewTextBoxColumn.DataPropertyName = "ImportDate";
            this.importDateDataGridViewTextBoxColumn.HeaderText = "ImportDate";
            this.importDateDataGridViewTextBoxColumn.Name = "importDateDataGridViewTextBoxColumn";
            // 
            // yesImportDataGridViewCheckBoxColumn
            // 
            this.yesImportDataGridViewCheckBoxColumn.DataPropertyName = "YesImport";
            this.yesImportDataGridViewCheckBoxColumn.HeaderText = "YesImport";
            this.yesImportDataGridViewCheckBoxColumn.Name = "yesImportDataGridViewCheckBoxColumn";
            // 
            // delAdd1DataGridViewTextBoxColumn
            // 
            this.delAdd1DataGridViewTextBoxColumn.DataPropertyName = "DelAdd1";
            this.delAdd1DataGridViewTextBoxColumn.HeaderText = "DelAdd1";
            this.delAdd1DataGridViewTextBoxColumn.Name = "delAdd1DataGridViewTextBoxColumn";
            // 
            // delAdd2DataGridViewTextBoxColumn
            // 
            this.delAdd2DataGridViewTextBoxColumn.DataPropertyName = "DelAdd2";
            this.delAdd2DataGridViewTextBoxColumn.HeaderText = "DelAdd2";
            this.delAdd2DataGridViewTextBoxColumn.Name = "delAdd2DataGridViewTextBoxColumn";
            // 
            // delAdd3DataGridViewTextBoxColumn
            // 
            this.delAdd3DataGridViewTextBoxColumn.DataPropertyName = "DelAdd3";
            this.delAdd3DataGridViewTextBoxColumn.HeaderText = "DelAdd3";
            this.delAdd3DataGridViewTextBoxColumn.Name = "delAdd3DataGridViewTextBoxColumn";
            // 
            // delAdd4DataGridViewTextBoxColumn
            // 
            this.delAdd4DataGridViewTextBoxColumn.DataPropertyName = "DelAdd4";
            this.delAdd4DataGridViewTextBoxColumn.HeaderText = "DelAdd4";
            this.delAdd4DataGridViewTextBoxColumn.Name = "delAdd4DataGridViewTextBoxColumn";
            // 
            // repCodeDataGridViewTextBoxColumn
            // 
            this.repCodeDataGridViewTextBoxColumn.DataPropertyName = "RepCode";
            this.repCodeDataGridViewTextBoxColumn.HeaderText = "RepCode";
            this.repCodeDataGridViewTextBoxColumn.Name = "repCodeDataGridViewTextBoxColumn";
            // 
            // ordValueDataGridViewTextBoxColumn
            // 
            this.ordValueDataGridViewTextBoxColumn.DataPropertyName = "OrdValue";
            this.ordValueDataGridViewTextBoxColumn.HeaderText = "OrdValue";
            this.ordValueDataGridViewTextBoxColumn.Name = "ordValueDataGridViewTextBoxColumn";
            // 
            // docHeaderTempBindingSource
            // 
            this.docHeaderTempBindingSource.DataMember = "DocHeaderTemp";
            this.docHeaderTempBindingSource.DataSource = this.manifolddbDataSet;
            // 
            // manifolddbDataSet
            // 
            this.manifolddbDataSet.DataSetName = "ManifolddbDataSet";
            this.manifolddbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _lblReccount
            // 
            this._lblReccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._lblReccount.AutoSize = true;
            this._lblReccount.Location = new System.Drawing.Point(41, 524);
            this._lblReccount.Name = "_lblReccount";
            this._lblReccount.Size = new System.Drawing.Size(10, 13);
            this._lblReccount.TabIndex = 7;
            this._lblReccount.Text = "-";
            // 
            // _Label1
            // 
            this._Label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._Label1.AutoSize = true;
            this._Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label1.Location = new System.Drawing.Point(442, 78);
            this._Label1.Name = "_Label1";
            this._Label1.Size = new System.Drawing.Size(210, 24);
            this._Label1.TabIndex = 10;
            this._Label1.Text = "Import Purchase Orders";
            // 
            // _lblPasteldb
            // 
            this._lblPasteldb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._lblPasteldb.AutoSize = true;
            this._lblPasteldb.Location = new System.Drawing.Point(196, 480);
            this._lblPasteldb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._lblPasteldb.Name = "_lblPasteldb";
            this._lblPasteldb.Size = new System.Drawing.Size(58, 13);
            this._lblPasteldb.TabIndex = 23;
            this._lblPasteldb.Text = "lblPasteldb";
            // 
            // _BtnConString
            // 
            this._BtnConString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._BtnConString.Location = new System.Drawing.Point(163, 475);
            this._BtnConString.Margin = new System.Windows.Forms.Padding(2);
            this._BtnConString.Name = "_BtnConString";
            this._BtnConString.Size = new System.Drawing.Size(29, 24);
            this._BtnConString.TabIndex = 25;
            this._BtnConString.Text = "?";
            this._BtnConString.UseVisualStyleBackColor = true;
            this._BtnConString.Click += new System.EventHandler(this._Button1_Click_1);
            // 
            // _Label9
            // 
            this._Label9.AutoSize = true;
            this._Label9.Location = new System.Drawing.Point(163, 100);
            this._Label9.Name = "_Label9";
            this._Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._Label9.Size = new System.Drawing.Size(141, 13);
            this._Label9.TabIndex = 26;
            this._Label9.Text = "(right click to remove record)";
            // 
            // btnScanner
            // 
            this.btnScanner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScanner.Location = new System.Drawing.Point(919, 495);
            this.btnScanner.Name = "btnScanner";
            this.btnScanner.Size = new System.Drawing.Size(75, 23);
            this.btnScanner.TabIndex = 31;
            this.btnScanner.Text = "Scanner";
            this.btnScanner.UseVisualStyleBackColor = true;
            this.btnScanner.Click += new System.EventHandler(this.BtnScanner_Click);
            // 
            // docHeaderTempTableAdapter
            // 
            this.docHeaderTempTableAdapter.ClearBeforeFill = true;
            // 
            // _Button3
            // 
            this._Button3.FlatAppearance.BorderSize = 0;
            this._Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this._Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Button3.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this._Button3.Image = global::POButler.Properties.Resources._497px_Error_svg1;
            this._Button3.Location = new System.Drawing.Point(12, 326);
            this._Button3.Name = "_Button3";
            this._Button3.Size = new System.Drawing.Size(145, 47);
            this._Button3.TabIndex = 28;
            this._Button3.Text = "Error PO\'s";
            this._Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._Button3.UseVisualStyleBackColor = true;
            this._Button3.Click += new System.EventHandler(this._Button3_Click);
            // 
            // _btnCheckCodes
            // 
            this._btnCheckCodes.FlatAppearance.BorderSize = 0;
            this._btnCheckCodes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this._btnCheckCodes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnCheckCodes.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this._btnCheckCodes.Image = global::POButler.Properties.Resources.syncorders;
            this._btnCheckCodes.Location = new System.Drawing.Point(12, 223);
            this._btnCheckCodes.Name = "_btnCheckCodes";
            this._btnCheckCodes.Size = new System.Drawing.Size(145, 47);
            this._btnCheckCodes.TabIndex = 24;
            this._btnCheckCodes.Text = "Validate Codes";
            this._btnCheckCodes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._btnCheckCodes.UseVisualStyleBackColor = true;
            this._btnCheckCodes.Click += new System.EventHandler(this._btnCheckCodes_Click);
            // 
            // _BtnPostToPastel
            // 
            this._BtnPostToPastel.FlatAppearance.BorderSize = 0;
            this._BtnPostToPastel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this._BtnPostToPastel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._BtnPostToPastel.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this._BtnPostToPastel.Image = global::POButler.Properties.Resources.sageptnr1;
            this._BtnPostToPastel.Location = new System.Drawing.Point(12, 431);
            this._BtnPostToPastel.Name = "_BtnPostToPastel";
            this._BtnPostToPastel.Size = new System.Drawing.Size(145, 47);
            this._BtnPostToPastel.TabIndex = 22;
            this._BtnPostToPastel.Text = "Post selected";
            this._BtnPostToPastel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._BtnPostToPastel.UseVisualStyleBackColor = true;
            this._BtnPostToPastel.Click += new System.EventHandler(this._BtnPostToPastel_Click);
            // 
            // _btnDealPricing
            // 
            this._btnDealPricing.FlatAppearance.BorderSize = 0;
            this._btnDealPricing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this._btnDealPricing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnDealPricing.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this._btnDealPricing.Image = global::POButler.Properties.Resources.specialdeal;
            this._btnDealPricing.Location = new System.Drawing.Point(12, 378);
            this._btnDealPricing.Name = "_btnDealPricing";
            this._btnDealPricing.Size = new System.Drawing.Size(145, 47);
            this._btnDealPricing.TabIndex = 21;
            this._btnDealPricing.Text = "Deal Pricing";
            this._btnDealPricing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._btnDealPricing.UseVisualStyleBackColor = true;
            this._btnDealPricing.Click += new System.EventHandler(this._btnDealPricing_Click);
            // 
            // _BtnInventView
            // 
            this._BtnInventView.FlatAppearance.BorderSize = 0;
            this._BtnInventView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this._BtnInventView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._BtnInventView.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this._BtnInventView.Image = global::POButler.Properties.Resources.LinesSmall;
            this._BtnInventView.Location = new System.Drawing.Point(12, 275);
            this._BtnInventView.Name = "_BtnInventView";
            this._BtnInventView.Size = new System.Drawing.Size(145, 47);
            this._BtnInventView.TabIndex = 20;
            this._BtnInventView.Text = "Inventory View";
            this._BtnInventView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._BtnInventView.UseVisualStyleBackColor = true;
            this._BtnInventView.Click += new System.EventHandler(this._BtnInventView_Click);
            // 
            // _BtnCurrPOs
            // 
            this._BtnCurrPOs.FlatAppearance.BorderSize = 0;
            this._BtnCurrPOs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this._BtnCurrPOs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._BtnCurrPOs.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this._BtnCurrPOs.Image = global::POButler.Properties.Resources.boxesSmall;
            this._BtnCurrPOs.Location = new System.Drawing.Point(12, 170);
            this._BtnCurrPOs.Name = "_BtnCurrPOs";
            this._BtnCurrPOs.Size = new System.Drawing.Size(145, 47);
            this._BtnCurrPOs.TabIndex = 19;
            this._BtnCurrPOs.Text = "Current PO\'s";
            this._BtnCurrPOs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._BtnCurrPOs.UseVisualStyleBackColor = true;
            this._BtnCurrPOs.Click += new System.EventHandler(this._BtnCurrPOs_Click);
            // 
            // _BtnDownloadPOs
            // 
            this._BtnDownloadPOs.BackColor = System.Drawing.Color.Transparent;
            this._BtnDownloadPOs.FlatAppearance.BorderSize = 0;
            this._BtnDownloadPOs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this._BtnDownloadPOs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._BtnDownloadPOs.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._BtnDownloadPOs.Image = global::POButler.Properties.Resources.downloadarrow;
            this._BtnDownloadPOs.Location = new System.Drawing.Point(12, 117);
            this._BtnDownloadPOs.Name = "_BtnDownloadPOs";
            this._BtnDownloadPOs.Size = new System.Drawing.Size(145, 47);
            this._BtnDownloadPOs.TabIndex = 18;
            this._BtnDownloadPOs.Text = "Download PO\'s";
            this._BtnDownloadPOs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._BtnDownloadPOs.UseVisualStyleBackColor = false;
            this._BtnDownloadPOs.Click += new System.EventHandler(this.BtnDownloadPOs_Click);
            // 
            // _PictureBox2
            // 
            this._PictureBox2.BackgroundImage = global::POButler.Properties.Resources.FDBicon;
            this._PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._PictureBox2.Location = new System.Drawing.Point(12, 9);
            this._PictureBox2.Name = "_PictureBox2";
            this._PictureBox2.Size = new System.Drawing.Size(85, 93);
            this._PictureBox2.TabIndex = 12;
            this._PictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(789, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "FDB Orders";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 541);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnScanner);
            this.Controls.Add(this._Button3);
            this.Controls.Add(this._Label9);
            this.Controls.Add(this._BtnConString);
            this.Controls.Add(this._btnCheckCodes);
            this.Controls.Add(this._lblPasteldb);
            this.Controls.Add(this._BtnPostToPastel);
            this.Controls.Add(this._btnDealPricing);
            this.Controls.Add(this._BtnInventView);
            this.Controls.Add(this._BtnCurrPOs);
            this.Controls.Add(this._BtnDownloadPOs);
            this.Controls.Add(this._PictureBox2);
            this.Controls.Add(this._Label1);
            this.Controls.Add(this._lblReccount);
            this.Controls.Add(this._DataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this._DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docHeaderTempBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manifolddbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
                    _DataGridView1.CellEndEdit -= _DataGridView1_CurrentCellDirtyStateChanged;
                    _DataGridView1.CellMouseDown -= _DataGridView1_CellMouseDown;
                }

                _DataGridView1 = value;
                if (_DataGridView1 != null)
                {
                    _DataGridView1.CellDoubleClick += _DataGridView1_CellDoubleClick;
                    _DataGridView1.CellEndEdit += _DataGridView1_CurrentCellDirtyStateChanged;
                    _DataGridView1.CellMouseDown += _DataGridView1_CellMouseDown;
                }
            }
        }

        internal ManifolddbDataSet ManifolddbDataSet
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return ManifolddbDataSet;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (ManifolddbDataSet != null)
                {
                }

                ManifolddbDataSet = value;
                if (ManifolddbDataSet != null)
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

        private PictureBox _PictureBox2;

        internal PictureBox PictureBox2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return PictureBox2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (PictureBox2 != null)
                {
                }

                PictureBox2 = value;
                if (PictureBox2 != null)
                {
                }
            }
        }

        private Button _BtnDownloadPOs;

        internal Button BtnDownloadPOs
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BtnDownloadPOs;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BtnDownloadPOs != null)
                {
                    _BtnDownloadPOs.Click -= BtnDownloadPOs_Click;
                }

                _BtnDownloadPOs = value;
                if (_BtnDownloadPOs != null)
                {
                    _BtnDownloadPOs.Click += BtnDownloadPOs_Click;
                }
            }
        }

        private Button _BtnCurrPOs;

        internal Button BtnCurrPOs
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BtnCurrPOs;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BtnCurrPOs != null)
                {
                    _BtnCurrPOs.Click -= _BtnCurrPOs_Click;
                }

                _BtnCurrPOs = value;
                if (_BtnCurrPOs != null)
                {
                    _BtnCurrPOs.Click += _BtnCurrPOs_Click;
                }
            }
        }

        private Button _BtnInventView;

        internal Button BtnInventView
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BtnInventView;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BtnInventView != null)
                {
                    _BtnInventView.Click -= _BtnInventView_Click;
                }

                _BtnInventView = value;
                if (_BtnInventView != null)
                {
                    _BtnInventView.Click += _BtnInventView_Click;
                }
            }
        }

        private Button _btnDealPricing;

        internal Button btnDealPricing
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnDealPricing;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnDealPricing != null)
                {
                    _btnDealPricing.Click -= _btnDealPricing_Click;
                }

                _btnDealPricing = value;
                if (_btnDealPricing != null)
                {
                    _btnDealPricing.Click += _btnDealPricing_Click;
                }
            }
        }

        private Button _BtnPostToPastel;

        internal Button BtnPostToPastel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BtnPostToPastel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BtnPostToPastel != null)
                {
                    _BtnPostToPastel.Click -= _BtnPostToPastel_Click;
                }

                _BtnPostToPastel = value;
                if (_BtnPostToPastel != null)
                {
                    _BtnPostToPastel.Click += _BtnPostToPastel_Click;
                }
            }
        }

        internal BindingSource DocHeaderTempBindingSource
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return docHeaderTempBindingSource;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (docHeaderTempBindingSource != null)
                {
                }

                docHeaderTempBindingSource = value;
                if (docHeaderTempBindingSource != null)
                {
                }
            }
        }

        internal ManifolddbDataSetTableAdapters.DocHeaderTempTableAdapter DocHeaderTempTableAdapter
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return DocHeaderTempTableAdapter;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (DocHeaderTempTableAdapter != null)
                {
                }

                DocHeaderTempTableAdapter = value;
                if (DocHeaderTempTableAdapter != null)
                {
                }
            }
        }

        private Label _lblPasteldb;

        internal Label lblPasteldb
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblPasteldb;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblPasteldb != null)
                {
                }

                _lblPasteldb = value;
                if (_lblPasteldb != null)
                {
                }
            }
        }

        private Button _btnCheckCodes;

        internal Button btnCheckCodes
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCheckCodes;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCheckCodes != null)
                {
                    _btnCheckCodes.Click -= _btnCheckCodes_Click;
                }

                _btnCheckCodes = value;
                if (_btnCheckCodes != null)
                {
                    _btnCheckCodes.Click += _btnCheckCodes_Click;
                }
            }
        }

        private Button _BtnConString;

        internal Button Button1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BtnConString;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BtnConString != null)
                {
                    _BtnConString.Click -= _Button1_Click_1;
                }

                _BtnConString = value;
                if (_BtnConString != null)
                {
                    _BtnConString.Click += _Button1_Click_1;
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

        //private DataGridViewTextBoxColumn DocNumDataGridViewTextBoxColumn;
        //private DataGridViewTextBoxColumn AcctCodeDataGridViewTextBoxColumn;
        //private DataGridViewTextBoxColumn AcctNameDataGridViewTextBoxColumn;
        //private DataGridViewTextBoxColumn OrdValue;
        //private DataGridViewTextBoxColumn DueDateDataGridViewTextBoxColumn;
        //private DataGridViewTextBoxColumn DelAdd1DataGridViewTextBoxColumn;
        //private DataGridViewTextBoxColumn DelAdd2DataGridViewTextBoxColumn;
        //private DataGridViewTextBoxColumn DelAdd3DataGridViewTextBoxColumn;
        //private DataGridViewTextBoxColumn DelAdd4DataGridViewTextBoxColumn;
        //private DataGridViewCheckBoxColumn YesImportDataGridViewCheckBoxColumn;
        //private DataGridViewTextBoxColumn _DocNumDataGridViewTextBoxColumn;

        //internal DataGridViewTextBoxColumn DocNumDataGridViewTextBoxColumn
        //{
        //    [MethodImpl(MethodImplOptions.Synchronized)]
        //    get
        //    {
        //        return _DocNumDataGridViewTextBoxColumn;
        //    }

        //    [MethodImpl(MethodImplOptions.Synchronized)]
        //    set
        //    {
        //        if (_DocNumDataGridViewTextBoxColumn != null)
        //        {
        //        }

        //        _DocNumDataGridViewTextBoxColumn = value;
        //        if (_DocNumDataGridViewTextBoxColumn != null)
        //        {
        //        }
        //    }
        //}

        //private DataGridViewTextBoxColumn _AcctCodeDataGridViewTextBoxColumn;

        //internal DataGridViewTextBoxColumn AcctCodeDataGridViewTextBoxColumn
        //{
        //    [MethodImpl(MethodImplOptions.Synchronized)]
        //    get
        //    {
        //        return _AcctCodeDataGridViewTextBoxColumn;
        //    }

        //    [MethodImpl(MethodImplOptions.Synchronized)]
        //    set
        //    {
        //        if (_AcctCodeDataGridViewTextBoxColumn != null)
        //        {
        //        }

        //        _AcctCodeDataGridViewTextBoxColumn = value;
        //        if (_AcctCodeDataGridViewTextBoxColumn != null)
        //        {
        //        }
        //    }
        //}

        //private DataGridViewTextBoxColumn _AcctNameDataGridViewTextBoxColumn;

        //internal DataGridViewTextBoxColumn AcctNameDataGridViewTextBoxColumn
        //{
        //    [MethodImpl(MethodImplOptions.Synchronized)]
        //    get
        //    {
        //        return _AcctNameDataGridViewTextBoxColumn;
        //    }

        //    [MethodImpl(MethodImplOptions.Synchronized)]
        //    set
        //    {
        //        if (_AcctNameDataGridViewTextBoxColumn != null)
        //        {
        //        }

        //        _AcctNameDataGridViewTextBoxColumn = value;
        //        if (_AcctNameDataGridViewTextBoxColumn != null)
        //        {
        //        }
        //    }
        //}

        //private DataGridViewTextBoxColumn _OrdValue;

        //internal DataGridViewTextBoxColumn OrdValue
        //{
        //    [MethodImpl(MethodImplOptions.Synchronized)]
        //    get
        //    {
        //        return _OrdValue;
        //    }

        //    [MethodImpl(MethodImplOptions.Synchronized)]
        //    set
        //    {
        //        if (_OrdValue != null)
        //        {
        //        }

        //        _OrdValue = value;
        //        if (_OrdValue != null)
        //        {
        //        }
        //    }
        //}

        //private DataGridViewTextBoxColumn _DueDateDataGridViewTextBoxColumn;

        //internal DataGridViewTextBoxColumn DueDateDataGridViewTextBoxColumn
        //{
        //    [MethodImpl(MethodImplOptions.Synchronized)]
        //    get
        //    {
        //        return _DueDateDataGridViewTextBoxColumn;
        //    }

        //    [MethodImpl(MethodImplOptions.Synchronized)]
        //    set
        //    {
        //        if (_DueDateDataGridViewTextBoxColumn != null)
        //        {
        //        }

        //        _DueDateDataGridViewTextBoxColumn = value;
        //        if (_DueDateDataGridViewTextBoxColumn != null)
        //        {
        //        }
        //    }
        //}

        //private DataGridViewTextBoxColumn _DelAdd1DataGridViewTextBoxColumn;

        //internal DataGridViewTextBoxColumn DelAdd1DataGridViewTextBoxColumn
        //{
        //    [MethodImpl(MethodImplOptions.Synchronized)]
        //    get
        //    {
        //        return _DelAdd1DataGridViewTextBoxColumn;
        //    }

        //    [MethodImpl(MethodImplOptions.Synchronized)]
        //    set
        //    {
        //        if (_DelAdd1DataGridViewTextBoxColumn != null)
        //        {
        //        }

        //        _DelAdd1DataGridViewTextBoxColumn = value;
        //        if (_DelAdd1DataGridViewTextBoxColumn != null)
        //        {
        //        }
        //    }
        //}

        //private DataGridViewTextBoxColumn _DelAdd2DataGridViewTextBoxColumn;

        //internal DataGridViewTextBoxColumn DelAdd2DataGridViewTextBoxColumn
        //{
        //    [MethodImpl(MethodImplOptions.Synchronized)]
        //    get
        //    {
        //        return _DelAdd2DataGridViewTextBoxColumn;
        //    }

        //    [MethodImpl(MethodImplOptions.Synchronized)]
        //    set
        //    {
        //        if (_DelAdd2DataGridViewTextBoxColumn != null)
        //        {
        //        }

        //        _DelAdd2DataGridViewTextBoxColumn = value;
        //        if (_DelAdd2DataGridViewTextBoxColumn != null)
        //        {
        //        }
        //    }
        //}

        //private DataGridViewTextBoxColumn _DelAdd3DataGridViewTextBoxColumn;

        //internal DataGridViewTextBoxColumn DelAdd3DataGridViewTextBoxColumn
        //{
        //    [MethodImpl(MethodImplOptions.Synchronized)]
        //    get
        //    {
        //        return _DelAdd3DataGridViewTextBoxColumn;
        //    }

        //    [MethodImpl(MethodImplOptions.Synchronized)]
        //    set
        //    {
        //        if (_DelAdd3DataGridViewTextBoxColumn != null)
        //        {
        //        }

        //        _DelAdd3DataGridViewTextBoxColumn = value;
        //        if (_DelAdd3DataGridViewTextBoxColumn != null)
        //        {
        //        }
        //    }
        //}

        //private DataGridViewTextBoxColumn _DelAdd4DataGridViewTextBoxColumn;

        //internal DataGridViewTextBoxColumn DelAdd4DataGridViewTextBoxColumn
        //{
        //    [MethodImpl(MethodImplOptions.Synchronized)]
        //    get
        //    {
        //        return _DelAdd4DataGridViewTextBoxColumn;
        //    }

        //    [MethodImpl(MethodImplOptions.Synchronized)]
        //    set
        //    {
        //        if (_DelAdd4DataGridViewTextBoxColumn != null)
        //        {
        //        }

        //        _DelAdd4DataGridViewTextBoxColumn = value;
        //        if (_DelAdd4DataGridViewTextBoxColumn != null)
        //        {
        //        }
        //    }
        //}

        //private DataGridViewCheckBoxColumn _YesImportDataGridViewCheckBoxColumn;

        //internal DataGridViewCheckBoxColumn YesImportDataGridViewCheckBoxColumn
        //{
        //    [MethodImpl(MethodImplOptions.Synchronized)]
        //    get
        //    {
        //        return _YesImportDataGridViewCheckBoxColumn;
        //    }

        //    [MethodImpl(MethodImplOptions.Synchronized)]
        //    set
        //    {
        //        if (_YesImportDataGridViewCheckBoxColumn != null)
        //        {
        //        }

        //        _YesImportDataGridViewCheckBoxColumn = value;
        //        if (_YesImportDataGridViewCheckBoxColumn != null)
        //        {
        //        }
        //    }
        //}

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

        private Button _Button3;
        private Button btnScanner;
        private DataGridViewTextBoxColumn ordValue1DataGridViewTextBoxColumn;
        private ManifolddbDataSet manifolddbDataSet;
        private BindingSource docHeaderTempBindingSource;
        private ManifolddbDataSetTableAdapters.DocHeaderTempTableAdapter docHeaderTempTableAdapter;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn docNumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn acctCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn acctNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn importedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn importDateDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn yesImportDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn delAdd1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn delAdd2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn delAdd3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn delAdd4DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn repCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ordValueDataGridViewTextBoxColumn;
        private Button button1;

        //private DataGridViewTextBoxColumn IDDataGridViewTextBoxColumn;

        internal Button Button3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button3 != null)
                {
                }

                _Button3 = value;
                if (_Button3 != null)
                {
                }
            }
        }
    }
}
