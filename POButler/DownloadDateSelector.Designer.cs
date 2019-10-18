using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace POButler
{
    [DesignerGenerated()]
    public partial class DownloadDateSelector : Form
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
            this._Label1 = new System.Windows.Forms.Label();
            this._Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _Label1
            // 
            this._Label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._Label1.AutoSize = true;
            this._Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label1.Location = new System.Drawing.Point(128, 69);
            this._Label1.Name = "_Label1";
            this._Label1.Size = new System.Drawing.Size(231, 20);
            this._Label1.TabIndex = 11;
            this._Label1.Text = "Select email attachment criteria";
            // 
            // _Button1
            // 
            this._Button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this._Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Button1.ForeColor = System.Drawing.SystemColors.Control;
            this._Button1.Location = new System.Drawing.Point(106, 135);
            this._Button1.Name = "_Button1";
            this._Button1.Size = new System.Drawing.Size(275, 37);
            this._Button1.TabIndex = 15;
            this._Button1.Text = "Download PO Attachments";
            this._Button1.UseVisualStyleBackColor = false;
            this._Button1.Click += new System.EventHandler(this._Button1_Click);
            // 
            // DownloadDateSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 262);
            this.Controls.Add(this._Button1);
            this.Controls.Add(this._Label1);
            this.Name = "DownloadDateSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Download Date Selector";
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
    }
}
