using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace POButler
{
    [DesignerGenerated()]
    public partial class InventoryView : MetroFramework.Forms.MetroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryView));
            this._DataGridView1 = new System.Windows.Forms.DataGridView();
            this._StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this._lblReccount = new System.Windows.Forms.Label();
            this._DataGridView2 = new System.Windows.Forms.DataGridView();
            this._Label1 = new System.Windows.Forms.Label();
            this._PictureBox2 = new System.Windows.Forms.PictureBox();
            this._BtnDownloadPOs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DataGridView2)).BeginInit();
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
            this._DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._DataGridView1.Location = new System.Drawing.Point(157, 116);
            this._DataGridView1.Name = "_DataGridView1";
            this._DataGridView1.ReadOnly = true;
            this._DataGridView1.Size = new System.Drawing.Size(854, 166);
            this._DataGridView1.TabIndex = 0;
            // 
            // _StatusStrip1
            // 
            this._StatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._StatusStrip1.Location = new System.Drawing.Point(20, 315);
            this._StatusStrip1.Name = "_StatusStrip1";
            this._StatusStrip1.Size = new System.Drawing.Size(983, 22);
            this._StatusStrip1.TabIndex = 1;
            this._StatusStrip1.Text = "StatusStrip1";
            // 
            // _lblReccount
            // 
            this._lblReccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._lblReccount.AutoSize = true;
            this._lblReccount.Location = new System.Drawing.Point(58, 341);
            this._lblReccount.Name = "_lblReccount";
            this._lblReccount.Size = new System.Drawing.Size(10, 13);
            this._lblReccount.TabIndex = 8;
            this._lblReccount.Text = "-";
            // 
            // _DataGridView2
            // 
            this._DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._DataGridView2.Location = new System.Drawing.Point(415, 38);
            this._DataGridView2.Name = "_DataGridView2";
            this._DataGridView2.Size = new System.Drawing.Size(240, 15);
            this._DataGridView2.TabIndex = 11;
            this._DataGridView2.Visible = false;
            // 
            // _Label1
            // 
            this._Label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._Label1.AutoSize = true;
            this._Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label1.Location = new System.Drawing.Point(448, 75);
            this._Label1.Name = "_Label1";
            this._Label1.Size = new System.Drawing.Size(172, 24);
            this._Label1.TabIndex = 20;
            this._Label1.Text = "Inventory Demands";
            // 
            // _PictureBox2
            // 
            this._PictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_PictureBox2.BackgroundImage")));
            this._PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._PictureBox2.Location = new System.Drawing.Point(6, 20);
            this._PictureBox2.Name = "_PictureBox2";
            this._PictureBox2.Size = new System.Drawing.Size(75, 79);
            this._PictureBox2.TabIndex = 22;
            this._PictureBox2.TabStop = false;
            // 
            // _BtnDownloadPOs
            // 
            this._BtnDownloadPOs.FlatAppearance.BorderSize = 0;
            this._BtnDownloadPOs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this._BtnDownloadPOs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._BtnDownloadPOs.Image = global::POButler.Properties.Resources.downloadarrow;
            this._BtnDownloadPOs.Location = new System.Drawing.Point(6, 116);
            this._BtnDownloadPOs.Name = "_BtnDownloadPOs";
            this._BtnDownloadPOs.Size = new System.Drawing.Size(145, 47);
            this._BtnDownloadPOs.TabIndex = 19;
            this._BtnDownloadPOs.Text = "Download as .xls";
            this._BtnDownloadPOs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._BtnDownloadPOs.UseVisualStyleBackColor = true;
            this._BtnDownloadPOs.Click += new System.EventHandler(this._BtnDownloadPOs_Click);
            // 
            // InventoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 357);
            this.Controls.Add(this._PictureBox2);
            this.Controls.Add(this._Label1);
            this.Controls.Add(this._BtnDownloadPOs);
            this.Controls.Add(this._DataGridView2);
            this.Controls.Add(this._lblReccount);
            this.Controls.Add(this._StatusStrip1);
            this.Controls.Add(this._DataGridView1);
            this.Name = "InventoryView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this._DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DataGridView2)).EndInit();
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
                    _DataGridView1.ColumnHeaderMouseClick -= DataGridView1_ColumnHeaderMouseClick;
                    _DataGridView1.CellDoubleClick -= DataGridView1_CellDoubleClick;
                }

                _DataGridView1 = value;
                if (_DataGridView1 != null)
                {
                    _DataGridView1.ColumnHeaderMouseClick += DataGridView1_ColumnHeaderMouseClick;
                    _DataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;
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

        private DataGridView _DataGridView2;

        internal DataGridView DataGridView2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DataGridView2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DataGridView2 != null)
                {
                }

                _DataGridView2 = value;
                if (_DataGridView2 != null)
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
                return BtnDownloadPOs;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BtnDownloadPOs != null)
                {
                    _BtnDownloadPOs.Click -= _BtnDownloadPOs_Click;
                }

                _BtnDownloadPOs = value;
                if (_BtnDownloadPOs != null)
                {
                    _BtnDownloadPOs.Click += _BtnDownloadPOs_Click;
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
    }
}
