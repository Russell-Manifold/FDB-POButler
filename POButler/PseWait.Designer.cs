using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System;
using System.Xml.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace POButler
{
    [DesignerGenerated()]
    public partial class PseWait : Form
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
            _Label1 = new Label();
            _lblordercount = new Label();
           //_ProgressSpinner1 = new CNSpinner.ProgressSpinner();
            SuspendLayout();
            // 
            // Label1
            // 
            _Label1.AutoSize = true;
            _Label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _Label1.Location = new Point(87, 147);
            _Label1.Name = "Label1";
            _Label1.Size = new Size(92, 16);
            _Label1.TabIndex = 0;
            _Label1.Text = "Please wait ....";
            // 
            // lblordercount
            // 
            _lblordercount.AutoSize = true;
            _lblordercount.Location = new Point(87, 192);
            _lblordercount.Name = "lblordercount";
            _lblordercount.Size = new Size(0, 13);
            _lblordercount.TabIndex = 1;
            // 
            // ProgressSpinner1
            // 
            //_ProgressSpinner1.LoadGIFImage = POButler.My.Resources.Resources.spinner5;
            //_ProgressSpinner1.Location = new Point(99, 34);
            //_ProgressSpinner1.Name = "ProgressSpinner1";
            //_ProgressSpinner1.Size = new Size(81, 80);
            //_ProgressSpinner1.TabIndex = 2;
            // 
            // PseWait
            // 
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(284, 262);
            //Controls.Add(_ProgressSpinner1);
            Controls.Add(_lblordercount);
            Controls.Add(_Label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PseWait";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PseWait";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label _Label1;

        internal Label Label1
        {
            get
            {
                return _Label1;
            }
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

        private Label _lblordercount;

        internal Label lblordercount
        {
            get
            {
                return _lblordercount;
            }
            set
            {
                if (_lblordercount != null)
                {
                }
                _lblordercount = value;
                if (_lblordercount != null)
                {
                }
            }
        }

        //private CNSpinner.ProgressSpinner _ProgressSpinner1;

        //internal CNSpinner.ProgressSpinner ProgressSpinner1
        //{           
        //    get
        //    {
        //        return _ProgressSpinner1;
        //    }           
        //    set
        //    {
        //        if (_ProgressSpinner1 != null)
        //        {
        //        }
        //        _ProgressSpinner1 = value;
        //        if (_ProgressSpinner1 != null)
        //        {
        //        }
        //    }
        //}
    }
}
