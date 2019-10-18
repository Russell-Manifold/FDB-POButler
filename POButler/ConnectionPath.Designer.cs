using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace POButler
{
    [DesignerGenerated()]
    public partial class ConnectionPath : Form
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
            this._txtDatapath = new System.Windows.Forms.TextBox();
            this._Label1 = new System.Windows.Forms.Label();
            this._Label2 = new System.Windows.Forms.Label();
            this._Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _txtDatapath
            // 
            this._txtDatapath.Location = new System.Drawing.Point(149, 102);
            this._txtDatapath.Margin = new System.Windows.Forms.Padding(2);
            this._txtDatapath.Name = "_txtDatapath";
            this._txtDatapath.Size = new System.Drawing.Size(387, 20);
            this._txtDatapath.TabIndex = 0;
            // 
            // _Label1
            // 
            this._Label1.AutoSize = true;
            this._Label1.Location = new System.Drawing.Point(62, 105);
            this._Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._Label1.Name = "_Label1";
            this._Label1.Size = new System.Drawing.Size(84, 13);
            this._Label1.TabIndex = 1;
            this._Label1.Text = "Pastel data path";
            // 
            // _Label2
            // 
            this._Label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._Label2.AutoSize = true;
            this._Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label2.Location = new System.Drawing.Point(213, 46);
            this._Label2.Name = "_Label2";
            this._Label2.Size = new System.Drawing.Size(205, 24);
            this._Label2.TabIndex = 11;
            this._Label2.Text = "Pastel Data Path Set Up";
            // 
            // _Button1
            // 
            this._Button1.BackColor = System.Drawing.Color.Transparent;
            this._Button1.FlatAppearance.BorderSize = 0;
            this._Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this._Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Button1.Image = global::POButler.Properties.Resources.Save2;
            this._Button1.Location = new System.Drawing.Point(540, 99);
            this._Button1.Margin = new System.Windows.Forms.Padding(2);
            this._Button1.Name = "_Button1";
            this._Button1.Size = new System.Drawing.Size(95, 24);
            this._Button1.TabIndex = 2;
            this._Button1.Text = "  SAVE  ";
            this._Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._Button1.UseVisualStyleBackColor = true;
            this._Button1.Click += new System.EventHandler(this._Button1_Click);
            // 
            // ConnectionPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 206);
            this.Controls.Add(this._Label2);
            this.Controls.Add(this._Button1);
            this.Controls.Add(this._Label1);
            this.Controls.Add(this._txtDatapath);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConnectionPath";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pastel Connection Path";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox _txtDatapath;

        internal TextBox txtDatapath
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtDatapath;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtDatapath != null)
                {
                }

                _txtDatapath = value;
                if (_txtDatapath != null)
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

        private Button _Button1;

        internal Button Button1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button1 != null)
                {
                    _Button1.Click -= _Button1_Click;
                }

                _Button1 = value;
                if (_Button1 != null)
                {
                    _Button1.Click += _Button1_Click;
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
    }
}
