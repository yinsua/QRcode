namespace QRcode
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_qrcode = new System.Windows.Forms.TextBox();
            this.button_print = new System.Windows.Forms.Button();
            this.button_serial = new System.Windows.Forms.Button();
            this.label_debug = new System.Windows.Forms.Label();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printPreviewControl = new System.Windows.Forms.PrintPreviewControl();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.qrCodeImgControl = new Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl();
            this.label_data = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_width = new System.Windows.Forms.TextBox();
            this.textBox_height = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_readme = new System.Windows.Forms.Button();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.trackBar_x = new System.Windows.Forms.TrackBar();
            this.trackBar_y = new System.Windows.Forms.TrackBar();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_printSetup = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.textBox_atcmd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrCodeImgControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_y)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "QRcode";
            // 
            // textBox_qrcode
            // 
            this.textBox_qrcode.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox_qrcode.Location = new System.Drawing.Point(70, 40);
            this.textBox_qrcode.Multiline = true;
            this.textBox_qrcode.Name = "textBox_qrcode";
            this.textBox_qrcode.Size = new System.Drawing.Size(111, 21);
            this.textBox_qrcode.TabIndex = 1;
            this.textBox_qrcode.TextChanged += new System.EventHandler(this.textBox_qrcode_TextChanged);
            // 
            // button_print
            // 
            this.button_print.Location = new System.Drawing.Point(298, 100);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(237, 55);
            this.button_print.TabIndex = 3;
            this.button_print.Text = "打印";
            this.button_print.UseVisualStyleBackColor = true;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // button_serial
            // 
            this.button_serial.Location = new System.Drawing.Point(12, 100);
            this.button_serial.Name = "button_serial";
            this.button_serial.Size = new System.Drawing.Size(237, 55);
            this.button_serial.TabIndex = 4;
            this.button_serial.Text = "获取MAC";
            this.button_serial.UseVisualStyleBackColor = true;
            this.button_serial.Click += new System.EventHandler(this.button_serial_Click);
            // 
            // label_debug
            // 
            this.label_debug.AutoSize = true;
            this.label_debug.Location = new System.Drawing.Point(0, 1);
            this.label_debug.Name = "label_debug";
            this.label_debug.Size = new System.Drawing.Size(35, 12);
            this.label_debug.TabIndex = 5;
            this.label_debug.Text = "DEBUG";
            // 
            // printDocument
            // 
            this.printDocument.DocumentName = "QRcode";
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.ShowIcon = false;
            this.printPreviewDialog.Visible = false;
            // 
            // printPreviewControl
            // 
            this.printPreviewControl.AutoZoom = false;
            this.printPreviewControl.Document = this.printDocument;
            this.printPreviewControl.Enabled = false;
            this.printPreviewControl.Location = new System.Drawing.Point(63, 219);
            this.printPreviewControl.MaximumSize = new System.Drawing.Size(460, 330);
            this.printPreviewControl.Name = "printPreviewControl";
            this.printPreviewControl.Size = new System.Drawing.Size(460, 330);
            this.printPreviewControl.TabIndex = 6;
            this.printPreviewControl.Zoom = 2D;
            // 
            // trackBar
            // 
            this.trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar.LargeChange = 1;
            this.trackBar.Location = new System.Drawing.Point(29, 556);
            this.trackBar.Maximum = 20;
            this.trackBar.Minimum = 1;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(518, 45);
            this.trackBar.TabIndex = 7;
            this.trackBar.Value = 10;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 556);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 556);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "-";
            // 
            // qrCodeImgControl
            // 
            this.qrCodeImgControl.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M;
            this.qrCodeImgControl.Image = ((System.Drawing.Image)(resources.GetObject("qrCodeImgControl.Image")));
            this.qrCodeImgControl.Location = new System.Drawing.Point(417, 2);
            this.qrCodeImgControl.Name = "qrCodeImgControl";
            this.qrCodeImgControl.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Zero;
            this.qrCodeImgControl.Size = new System.Drawing.Size(42, 42);
            this.qrCodeImgControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.qrCodeImgControl.TabIndex = 10;
            this.qrCodeImgControl.TabStop = false;
            this.qrCodeImgControl.Text = "1234567890AB";
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.Location = new System.Drawing.Point(269, 1);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(77, 12);
            this.label_data.TabIndex = 12;
            this.label_data.Text = "originalData";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "宽";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "高";
            // 
            // textBox_width
            // 
            this.textBox_width.Enabled = false;
            this.textBox_width.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox_width.Location = new System.Drawing.Point(297, 23);
            this.textBox_width.Name = "textBox_width";
            this.textBox_width.Size = new System.Drawing.Size(100, 21);
            this.textBox_width.TabIndex = 15;
            this.textBox_width.Text = "100";
            this.textBox_width.TextChanged += new System.EventHandler(this.textBox_width_TextChanged);
            // 
            // textBox_height
            // 
            this.textBox_height.Enabled = false;
            this.textBox_height.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox_height.Location = new System.Drawing.Point(297, 41);
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.Size = new System.Drawing.Size(100, 21);
            this.textBox_height.TabIndex = 16;
            this.textBox_height.Text = "100";
            this.textBox_height.TextChanged += new System.EventHandler(this.textBox_height_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "mm";
            // 
            // button_readme
            // 
            this.button_readme.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_readme.Location = new System.Drawing.Point(517, 0);
            this.button_readme.Name = "button_readme";
            this.button_readme.Size = new System.Drawing.Size(34, 23);
            this.button_readme.TabIndex = 18;
            this.button_readme.Text = "须知";
            this.button_readme.UseVisualStyleBackColor = true;
            this.button_readme.Click += new System.EventHandler(this.button_readme_Click);
            // 
            // printDialog
            // 
            this.printDialog.AllowCurrentPage = true;
            this.printDialog.AllowPrintToFile = false;
            this.printDialog.AllowSelection = true;
            this.printDialog.AllowSomePages = true;
            this.printDialog.Document = this.printDocument;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(205, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(54, 50);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 19;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // trackBar_x
            // 
            this.trackBar_x.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar_x.LargeChange = 1;
            this.trackBar_x.Location = new System.Drawing.Point(63, 167);
            this.trackBar_x.Maximum = 100;
            this.trackBar_x.Name = "trackBar_x";
            this.trackBar_x.Size = new System.Drawing.Size(460, 45);
            this.trackBar_x.TabIndex = 20;
            this.trackBar_x.TickFrequency = 10;
            this.trackBar_x.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar_x.Scroll += new System.EventHandler(this.trackBar_x_Scroll);
            // 
            // trackBar_y
            // 
            this.trackBar_y.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar_y.LargeChange = 1;
            this.trackBar_y.Location = new System.Drawing.Point(12, 219);
            this.trackBar_y.Maximum = 100;
            this.trackBar_y.Name = "trackBar_y";
            this.trackBar_y.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_y.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar_y.RightToLeftLayout = true;
            this.trackBar_y.Size = new System.Drawing.Size(45, 328);
            this.trackBar_y.TabIndex = 21;
            this.trackBar_y.TickFrequency = 10;
            this.trackBar_y.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar_y.Value = 100;
            this.trackBar_y.Scroll += new System.EventHandler(this.trackBar_y_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(52, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(27, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 23;
            this.label8.Text = "Y";
            // 
            // button_printSetup
            // 
            this.button_printSetup.Font = new System.Drawing.Font("宋体", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_printSetup.Location = new System.Drawing.Point(462, 0);
            this.button_printSetup.Name = "button_printSetup";
            this.button_printSetup.Size = new System.Drawing.Size(54, 23);
            this.button_printSetup.TabIndex = 24;
            this.button_printSetup.Text = "打印设置";
            this.button_printSetup.UseVisualStyleBackColor = true;
            this.button_printSetup.Click += new System.EventHandler(this.button_printSetup_Click);
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(2, 68);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(545, 20);
            this.comboBox.TabIndex = 26;
            // 
            // textBox_atcmd
            // 
            this.textBox_atcmd.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox_atcmd.Location = new System.Drawing.Point(70, 15);
            this.textBox_atcmd.Multiline = true;
            this.textBox_atcmd.Name = "textBox_atcmd";
            this.textBox_atcmd.Size = new System.Drawing.Size(111, 21);
            this.textBox_atcmd.TabIndex = 28;
            this.textBox_atcmd.Text = "AT+ADDR?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 27;
            this.label9.Text = "AT CMD";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Checked = true;
            this.checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox.Location = new System.Drawing.Point(464, 29);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(90, 16);
            this.checkBox.TabIndex = 29;
            this.checkBox.Text = "打印MAC字串";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(551, 591);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.textBox_atcmd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.button_printSetup);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.trackBar_y);
            this.Controls.Add(this.trackBar_x);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.button_readme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_height);
            this.Controls.Add(this.textBox_width);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_data);
            this.Controls.Add(this.qrCodeImgControl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.printPreviewControl);
            this.Controls.Add(this.label_debug);
            this.Controls.Add(this.button_serial);
            this.Controls.Add(this.button_print);
            this.Controls.Add(this.textBox_qrcode);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "QRcode";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrCodeImgControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_y)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_qrcode;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.Button button_serial;
        private System.Windows.Forms.Label label_debug;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl qrCodeImgControl;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_width;
        private System.Windows.Forms.TextBox textBox_height;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_readme;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TrackBar trackBar_x;
        private System.Windows.Forms.TrackBar trackBar_y;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_printSetup;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox textBox_atcmd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl;
    }
}

