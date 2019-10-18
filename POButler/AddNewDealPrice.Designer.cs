using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace POButler
{
    [DesignerGenerated()]
    public partial class AddNewDealPrice : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewDealPrice));
            _Label2 = new Label();
            _Label4 = new Label();
            _ComboItemCodes = new ComboBox();
            _ComboItemCodes.SelectedIndexChanged += ComboItemCodes_SelectedIndexChanged;
            _Label5 = new Label();
            _txtDatePicker1 = new DateTimePicker();
            _Label6 = new Label();
            _Label7 = new Label();
            _Label8 = new Label();
            _txtDatepicker2 = new DateTimePicker();
            _ToolStrip1 = new ToolStrip();
            _ToolStripSave = new ToolStripButton();
            _ToolStripSave.Click += ToolStripSave_Click;
            _txtUnitPrice = new TextBox();
            _txtUnitPrice.KeyPress += txtUnitPrice_KeyPress;
            _txtItemName = new TextBox();
            _PictureBox2 = new PictureBox();
            _ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_PictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Label2
            // 
            _Label2.Anchor = AnchorStyles.Top;
            _Label2.AutoSize = true;
            _Label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Underline, GraphicsUnit.Point, Conversions.ToByte(0));
            _Label2.Location = new Point(307, 57);
            _Label2.Margin = new Padding(4, 0, 4, 0);
            _Label2.Name = "Label2";
            _Label2.Size = new Size(230, 29);
            _Label2.TabIndex = 14;
            _Label2.Text = "Add New Deal Price";
            // 
            // Label4
            // 
            _Label4.AutoSize = true;
            _Label4.Location = new Point(112, 170);
            _Label4.Margin = new Padding(4, 0, 4, 0);
            _Label4.Name = "Label4";
            _Label4.Size = new Size(34, 17);
            _Label4.TabIndex = 19;
            _Label4.Text = "Item";
            // 
            // ComboItemCodes
            // 
            _ComboItemCodes.FormattingEnabled = true;
            _ComboItemCodes.Location = new Point(225, 133);
            _ComboItemCodes.Margin = new Padding(4, 4, 4, 4);
            _ComboItemCodes.Name = "ComboItemCodes";
            _ComboItemCodes.Size = new Size(160, 24);
            _ComboItemCodes.TabIndex = 1;
            // 
            // Label5
            // 
            _Label5.AutoSize = true;
            _Label5.Location = new Point(112, 137);
            _Label5.Margin = new Padding(4, 0, 4, 0);
            _Label5.Name = "Label5";
            _Label5.Size = new Size(71, 17);
            _Label5.TabIndex = 16;
            _Label5.Text = "Item Code";
            // 
            // txtDatePicker1
            // 
            _txtDatePicker1.CustomFormat = "dd MMM yyyy";
            _txtDatePicker1.Location = new Point(225, 198);
            _txtDatePicker1.Margin = new Padding(4, 4, 4, 4);
            _txtDatePicker1.Name = "txtDatePicker1";
            _txtDatePicker1.Size = new Size(160, 22);
            _txtDatePicker1.TabIndex = 2;
            // 
            // Label6
            // 
            _Label6.AutoSize = true;
            _Label6.Location = new Point(112, 266);
            _Label6.Margin = new Padding(4, 0, 4, 0);
            _Label6.Name = "Label6";
            _Label6.Size = new Size(92, 17);
            _Label6.TabIndex = 21;
            _Label6.Text = "Rate (Ex Vat)";
            // 
            // Label7
            // 
            _Label7.AutoSize = true;
            _Label7.Location = new Point(112, 237);
            _Label7.Margin = new Padding(4, 0, 4, 0);
            _Label7.Name = "Label7";
            _Label7.Size = new Size(25, 17);
            _Label7.TabIndex = 22;
            _Label7.Text = "To";
            // 
            // Label8
            // 
            _Label8.AutoSize = true;
            _Label8.Location = new Point(112, 205);
            _Label8.Margin = new Padding(4, 0, 4, 0);
            _Label8.Name = "Label8";
            _Label8.Size = new Size(40, 17);
            _Label8.TabIndex = 23;
            _Label8.Text = "From";
            // 
            // txtDatepicker2
            // 
            _txtDatepicker2.Location = new Point(225, 230);
            _txtDatepicker2.Margin = new Padding(4, 4, 4, 4);
            _txtDatepicker2.Name = "txtDatepicker2";
            _txtDatepicker2.Size = new Size(160, 22);
            _txtDatepicker2.TabIndex = 3;
            // 
            // ToolStrip1
            // 
            _ToolStrip1.ImageScalingSize = new Size(20, 20);
            _ToolStrip1.Items.AddRange(new ToolStripItem[] { _ToolStripSave });
            _ToolStrip1.Location = new Point(0, 0);
            _ToolStrip1.Name = "ToolStrip1";
            _ToolStrip1.Size = new Size(871, 27);
            _ToolStrip1.TabIndex = 26;
            _ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripSave
            // 
            _ToolStripSave.Alignment = ToolStripItemAlignment.Right;
            //_ToolStripSave.Image = POButler.resources.Resources.Save2;
            _ToolStripSave.ImageTransparentColor = Color.Magenta;
            _ToolStripSave.Name = "ToolStripSave";
            _ToolStripSave.Padding = new Padding(0, 0, 20, 0);
            _ToolStripSave.Size = new Size(154, 24);
            _ToolStripSave.Text = "Save deal price";
            // 
            // txtUnitPrice
            // 
            _txtUnitPrice.Location = new Point(225, 262);
            _txtUnitPrice.Margin = new Padding(4, 4, 4, 4);
            _txtUnitPrice.Name = "txtUnitPrice";
            _txtUnitPrice.Size = new Size(160, 22);
            _txtUnitPrice.TabIndex = 27;
            _txtUnitPrice.Text = "0.00";
            _txtUnitPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // txtItemName
            // 
            _txtItemName.Location = new Point(225, 170);
            _txtItemName.Margin = new Padding(4, 4, 4, 4);
            _txtItemName.Name = "txtItemName";
            _txtItemName.ReadOnly = true;
            _txtItemName.Size = new Size(596, 22);
            _txtItemName.TabIndex = 28;
            _txtItemName.TabStop = false;
            // 
            // PictureBox2
            // 
            //_PictureBox2.BackgroundImage = POButler.My.Resources.Resources.FDBicon;
            _PictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            _PictureBox2.Location = new Point(16, 6);
            _PictureBox2.Margin = new Padding(4, 4, 4, 4);
            _PictureBox2.Name = "PictureBox2";
            _PictureBox2.Size = new Size(92, 80);
            _PictureBox2.TabIndex = 29;
            _PictureBox2.TabStop = false;
            // 
            // AddNewDealPrice
            // 
            AutoScaleDimensions = new SizeF(8.0F, 16.0F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 425);
            Controls.Add(_PictureBox2);
            Controls.Add(_txtItemName);
            Controls.Add(_txtUnitPrice);
            Controls.Add(_ToolStrip1);
            Controls.Add(_txtDatepicker2);
            Controls.Add(_Label8);
            Controls.Add(_Label7);
            Controls.Add(_Label6);
            Controls.Add(_txtDatePicker1);
            Controls.Add(_Label4);
            Controls.Add(_ComboItemCodes);
            Controls.Add(_Label5);
            Controls.Add(_Label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "AddNewDealPrice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Deal Price";
            this.Load += AddNewDealPrice_Load;
            this.Closed += AddNewDealPrice_Closed;
            _ToolStrip1.ResumeLayout(false);
            _ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_PictureBox2).EndInit();
            this.Load += AddNewDealPrice_Load;
            this.Closed += AddNewDealPrice_Closed;
            ResumeLayout(false);
            PerformLayout();
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

        private ComboBox _ComboItemCodes;

        internal ComboBox ComboItemCodes
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboItemCodes;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboItemCodes != null)
                {
                    _ComboItemCodes.SelectedIndexChanged -= ComboItemCodes_SelectedIndexChanged;
                }

                _ComboItemCodes = value;
                if (_ComboItemCodes != null)
                {
                    _ComboItemCodes.SelectedIndexChanged += ComboItemCodes_SelectedIndexChanged;
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

        private DateTimePicker _txtDatePicker1;

        internal DateTimePicker txtDatePicker1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtDatePicker1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtDatePicker1 != null)
                {
                }

                _txtDatePicker1 = value;
                if (_txtDatePicker1 != null)
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

        private DateTimePicker _txtDatepicker2;

        internal DateTimePicker txtDatepicker2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtDatepicker2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtDatepicker2 != null)
                {
                }

                _txtDatepicker2 = value;
                if (_txtDatepicker2 != null)
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

        private TextBox _txtUnitPrice;

        internal TextBox txtUnitPrice
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtUnitPrice;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtUnitPrice != null)
                {
                    _txtUnitPrice.KeyPress -= txtUnitPrice_KeyPress;
                }

                _txtUnitPrice = value;
                if (_txtUnitPrice != null)
                {
                    _txtUnitPrice.KeyPress += txtUnitPrice_KeyPress;
                }
            }
        }

        private TextBox _txtItemName;

        internal TextBox txtItemName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtItemName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtItemName != null)
                {
                }

                _txtItemName = value;
                if (_txtItemName != null)
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
