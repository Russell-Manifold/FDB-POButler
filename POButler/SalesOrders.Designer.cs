namespace POButler
{
    partial class SalesOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesOrders));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this._PictureBox2 = new System.Windows.Forms.PictureBox();
            this._BtnCurrPOs = new System.Windows.Forms.Button();
            this._BtnPostToPastel = new System.Windows.Forms.Button();
            this._BtnDownloadPOs = new System.Windows.Forms.Button();
            this._BtnInventView = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnScanner = new System.Windows.Forms.Button();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this._PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(328, 45);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(215, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Import Purchase Orders";
            // 
            // _PictureBox2
            // 
            this._PictureBox2.BackgroundImage = global::POButler.Properties.Resources.FDBicon;
            this._PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._PictureBox2.Location = new System.Drawing.Point(7, 12);
            this._PictureBox2.Name = "_PictureBox2";
            this._PictureBox2.Size = new System.Drawing.Size(85, 93);
            this._PictureBox2.TabIndex = 13;
            this._PictureBox2.TabStop = false;
            // 
            // _BtnCurrPOs
            // 
            this._BtnCurrPOs.FlatAppearance.BorderSize = 0;
            this._BtnCurrPOs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this._BtnCurrPOs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._BtnCurrPOs.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this._BtnCurrPOs.Image = global::POButler.Properties.Resources.boxesSmall;
            this._BtnCurrPOs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._BtnCurrPOs.Location = new System.Drawing.Point(7, 134);
            this._BtnCurrPOs.Name = "_BtnCurrPOs";
            this._BtnCurrPOs.Size = new System.Drawing.Size(179, 47);
            this._BtnCurrPOs.TabIndex = 20;
            this._BtnCurrPOs.Text = "Current FDB PO\'s";
            this._BtnCurrPOs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._BtnCurrPOs.UseVisualStyleBackColor = true;
            // 
            // _BtnPostToPastel
            // 
            this._BtnPostToPastel.FlatAppearance.BorderSize = 0;
            this._BtnPostToPastel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this._BtnPostToPastel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._BtnPostToPastel.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this._BtnPostToPastel.Image = global::POButler.Properties.Resources.sageptnr1;
            this._BtnPostToPastel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._BtnPostToPastel.Location = new System.Drawing.Point(7, 293);
            this._BtnPostToPastel.Name = "_BtnPostToPastel";
            this._BtnPostToPastel.Size = new System.Drawing.Size(179, 47);
            this._BtnPostToPastel.TabIndex = 23;
            this._BtnPostToPastel.Text = "Post PO\'s To Pastel";
            this._BtnPostToPastel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._BtnPostToPastel.UseVisualStyleBackColor = true;
            // 
            // _BtnDownloadPOs
            // 
            this._BtnDownloadPOs.BackColor = System.Drawing.Color.Transparent;
            this._BtnDownloadPOs.FlatAppearance.BorderSize = 0;
            this._BtnDownloadPOs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this._BtnDownloadPOs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._BtnDownloadPOs.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._BtnDownloadPOs.Image = global::POButler.Properties.Resources.downloadarrow;
            this._BtnDownloadPOs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._BtnDownloadPOs.Location = new System.Drawing.Point(7, 187);
            this._BtnDownloadPOs.Name = "_BtnDownloadPOs";
            this._BtnDownloadPOs.Size = new System.Drawing.Size(179, 47);
            this._BtnDownloadPOs.TabIndex = 24;
            this._BtnDownloadPOs.Text = "Import FDB PO\'s";
            this._BtnDownloadPOs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._BtnDownloadPOs.UseVisualStyleBackColor = false;
            // 
            // _BtnInventView
            // 
            this._BtnInventView.FlatAppearance.BorderSize = 0;
            this._BtnInventView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this._BtnInventView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._BtnInventView.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this._BtnInventView.Image = global::POButler.Properties.Resources.LinesSmall;
            this._BtnInventView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._BtnInventView.Location = new System.Drawing.Point(7, 240);
            this._BtnInventView.Name = "_BtnInventView";
            this._BtnInventView.Size = new System.Drawing.Size(179, 47);
            this._BtnInventView.TabIndex = 25;
            this._BtnInventView.Text = "FDB Inventory";
            this._BtnInventView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._BtnInventView.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(739, 576);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Sales Orders";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnScanner
            // 
            this.btnScanner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScanner.Location = new System.Drawing.Point(820, 576);
            this.btnScanner.Name = "btnScanner";
            this.btnScanner.Size = new System.Drawing.Size(75, 23);
            this.btnScanner.TabIndex = 33;
            this.btnScanner.Text = "Scanner";
            this.btnScanner.UseVisualStyleBackColor = true;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(192, 137);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(714, 433);
            this.metroGrid1.TabIndex = 35;
            // 
            // SalesOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 622);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnScanner);
            this.Controls.Add(this._BtnInventView);
            this.Controls.Add(this._BtnDownloadPOs);
            this.Controls.Add(this._BtnPostToPastel);
            this.Controls.Add(this._BtnCurrPOs);
            this.Controls.Add(this._PictureBox2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesOrders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this._PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox _PictureBox2;
        private System.Windows.Forms.Button _BtnCurrPOs;
        private System.Windows.Forms.Button _BtnPostToPastel;
        private System.Windows.Forms.Button _BtnDownloadPOs;
        private System.Windows.Forms.Button _BtnInventView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnScanner;
        private MetroFramework.Controls.MetroGrid metroGrid1;
    }
}