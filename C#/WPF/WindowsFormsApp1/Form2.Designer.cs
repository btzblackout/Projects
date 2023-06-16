namespace WindowsFormsApp1
{
    partial class Form2
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.marketTrillionCheckBox = new System.Windows.Forms.CheckBox();
            this.marketBillionCheckBox = new System.Windows.Forms.CheckBox();
            this.marketMillionCheckBox = new System.Windows.Forms.CheckBox();
            this.marketThousandCheckBox = new System.Windows.Forms.CheckBox();
            this.volumeTrillionCheckBox = new System.Windows.Forms.CheckBox();
            this.volumeBillionCheckBox = new System.Windows.Forms.CheckBox();
            this.volumeMillionCheckBox = new System.Windows.Forms.CheckBox();
            this.volumeThousandCheckBox = new System.Windows.Forms.CheckBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.changePercentLabel = new System.Windows.Forms.Label();
            this.lastChangeLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.marketCapLabel = new System.Windows.Forms.Label();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.symbolTextBox = new System.Windows.Forms.TextBox();
            this.symbolLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceNumeric = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.volumeNumeric = new System.Windows.Forms.NumericUpDown();
            this.marketCapNumeric = new System.Windows.Forms.NumericUpDown();
            this.lastChangeNumeric = new System.Windows.Forms.NumericUpDown();
            this.changePercentNumeric = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketCapNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastChangeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changePercentNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(25, 47);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.changePercentNumeric);
            this.groupBox1.Controls.Add(this.lastChangeNumeric);
            this.groupBox1.Controls.Add(this.marketCapNumeric);
            this.groupBox1.Controls.Add(this.volumeNumeric);
            this.groupBox1.Controls.Add(this.priceNumeric);
            this.groupBox1.Controls.Add(this.marketTrillionCheckBox);
            this.groupBox1.Controls.Add(this.marketBillionCheckBox);
            this.groupBox1.Controls.Add(this.marketMillionCheckBox);
            this.groupBox1.Controls.Add(this.marketThousandCheckBox);
            this.groupBox1.Controls.Add(this.volumeTrillionCheckBox);
            this.groupBox1.Controls.Add(this.volumeBillionCheckBox);
            this.groupBox1.Controls.Add(this.volumeMillionCheckBox);
            this.groupBox1.Controls.Add(this.volumeThousandCheckBox);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.changePercentLabel);
            this.groupBox1.Controls.Add(this.lastChangeLabel);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.marketCapLabel);
            this.groupBox1.Controls.Add(this.volumeLabel);
            this.groupBox1.Controls.Add(this.priceLabel);
            this.groupBox1.Controls.Add(this.symbolTextBox);
            this.groupBox1.Controls.Add(this.symbolLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Location = new System.Drawing.Point(17, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 256);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Company Information";
            // 
            // marketTrillionCheckBox
            // 
            this.marketTrillionCheckBox.AutoSize = true;
            this.marketTrillionCheckBox.Location = new System.Drawing.Point(466, 196);
            this.marketTrillionCheckBox.Name = "marketTrillionCheckBox";
            this.marketTrillionCheckBox.Size = new System.Drawing.Size(56, 17);
            this.marketTrillionCheckBox.TabIndex = 24;
            this.marketTrillionCheckBox.Text = "Trillion";
            this.marketTrillionCheckBox.UseVisualStyleBackColor = true;
            // 
            // marketBillionCheckBox
            // 
            this.marketBillionCheckBox.AutoSize = true;
            this.marketBillionCheckBox.Location = new System.Drawing.Point(406, 196);
            this.marketBillionCheckBox.Name = "marketBillionCheckBox";
            this.marketBillionCheckBox.Size = new System.Drawing.Size(53, 17);
            this.marketBillionCheckBox.TabIndex = 23;
            this.marketBillionCheckBox.Text = "Billion";
            this.marketBillionCheckBox.UseVisualStyleBackColor = true;
            // 
            // marketMillionCheckBox
            // 
            this.marketMillionCheckBox.AutoSize = true;
            this.marketMillionCheckBox.Location = new System.Drawing.Point(344, 196);
            this.marketMillionCheckBox.Name = "marketMillionCheckBox";
            this.marketMillionCheckBox.Size = new System.Drawing.Size(55, 17);
            this.marketMillionCheckBox.TabIndex = 22;
            this.marketMillionCheckBox.Text = "Million";
            this.marketMillionCheckBox.UseVisualStyleBackColor = true;
            // 
            // marketThousandCheckBox
            // 
            this.marketThousandCheckBox.AutoSize = true;
            this.marketThousandCheckBox.Location = new System.Drawing.Point(263, 197);
            this.marketThousandCheckBox.Name = "marketThousandCheckBox";
            this.marketThousandCheckBox.Size = new System.Drawing.Size(74, 17);
            this.marketThousandCheckBox.TabIndex = 21;
            this.marketThousandCheckBox.Text = "Thousand";
            this.marketThousandCheckBox.UseVisualStyleBackColor = true;
            // 
            // volumeTrillionCheckBox
            // 
            this.volumeTrillionCheckBox.AutoSize = true;
            this.volumeTrillionCheckBox.Location = new System.Drawing.Point(466, 159);
            this.volumeTrillionCheckBox.Name = "volumeTrillionCheckBox";
            this.volumeTrillionCheckBox.Size = new System.Drawing.Size(56, 17);
            this.volumeTrillionCheckBox.TabIndex = 20;
            this.volumeTrillionCheckBox.Text = "Trillion";
            this.volumeTrillionCheckBox.UseVisualStyleBackColor = true;
            // 
            // volumeBillionCheckBox
            // 
            this.volumeBillionCheckBox.AutoSize = true;
            this.volumeBillionCheckBox.Location = new System.Drawing.Point(406, 159);
            this.volumeBillionCheckBox.Name = "volumeBillionCheckBox";
            this.volumeBillionCheckBox.Size = new System.Drawing.Size(53, 17);
            this.volumeBillionCheckBox.TabIndex = 19;
            this.volumeBillionCheckBox.Text = "Billion";
            this.volumeBillionCheckBox.UseVisualStyleBackColor = true;
            // 
            // volumeMillionCheckBox
            // 
            this.volumeMillionCheckBox.AutoSize = true;
            this.volumeMillionCheckBox.Location = new System.Drawing.Point(344, 159);
            this.volumeMillionCheckBox.Name = "volumeMillionCheckBox";
            this.volumeMillionCheckBox.Size = new System.Drawing.Size(55, 17);
            this.volumeMillionCheckBox.TabIndex = 18;
            this.volumeMillionCheckBox.Text = "Million";
            this.volumeMillionCheckBox.UseVisualStyleBackColor = true;
            // 
            // volumeThousandCheckBox
            // 
            this.volumeThousandCheckBox.AutoSize = true;
            this.volumeThousandCheckBox.Location = new System.Drawing.Point(263, 160);
            this.volumeThousandCheckBox.Name = "volumeThousandCheckBox";
            this.volumeThousandCheckBox.Size = new System.Drawing.Size(74, 17);
            this.volumeThousandCheckBox.TabIndex = 17;
            this.volumeThousandCheckBox.Text = "Thousand";
            this.volumeThousandCheckBox.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(453, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(120, 17);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Negative Change (-)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(330, 47);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(117, 17);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Positive Change (+)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // changePercentLabel
            // 
            this.changePercentLabel.AutoSize = true;
            this.changePercentLabel.Location = new System.Drawing.Point(327, 123);
            this.changePercentLabel.Name = "changePercentLabel";
            this.changePercentLabel.Size = new System.Drawing.Size(87, 13);
            this.changePercentLabel.TabIndex = 13;
            this.changePercentLabel.Text = "Change Percent:";
            // 
            // lastChangeLabel
            // 
            this.lastChangeLabel.AutoSize = true;
            this.lastChangeLabel.Location = new System.Drawing.Point(327, 85);
            this.lastChangeLabel.Name = "lastChangeLabel";
            this.lastChangeLabel.Size = new System.Drawing.Size(70, 13);
            this.lastChangeLabel.TabIndex = 11;
            this.lastChangeLabel.Text = "Last Change:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(28, 233);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(196, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Randomly Generate Market Change";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // marketCapLabel
            // 
            this.marketCapLabel.AutoSize = true;
            this.marketCapLabel.Location = new System.Drawing.Point(25, 196);
            this.marketCapLabel.Name = "marketCapLabel";
            this.marketCapLabel.Size = new System.Drawing.Size(65, 13);
            this.marketCapLabel.TabIndex = 8;
            this.marketCapLabel.Text = "Market Cap:";
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Location = new System.Drawing.Point(25, 160);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(45, 13);
            this.volumeLabel.TabIndex = 6;
            this.volumeLabel.Text = "Volume:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(25, 122);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(34, 13);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Price:";
            // 
            // symbolTextBox
            // 
            this.symbolTextBox.Location = new System.Drawing.Point(96, 82);
            this.symbolTextBox.Name = "symbolTextBox";
            this.symbolTextBox.Size = new System.Drawing.Size(150, 20);
            this.symbolTextBox.TabIndex = 3;
            // 
            // symbolLabel
            // 
            this.symbolLabel.AutoSize = true;
            this.symbolLabel.Location = new System.Drawing.Point(25, 85);
            this.symbolLabel.Name = "symbolLabel";
            this.symbolLabel.Size = new System.Drawing.Size(44, 13);
            this.symbolLabel.TabIndex = 2;
            this.symbolLabel.Text = "Symbol:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(96, 44);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(150, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // priceNumeric
            // 
            this.priceNumeric.Location = new System.Drawing.Point(96, 120);
            this.priceNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.priceNumeric.Name = "priceNumeric";
            this.priceNumeric.Size = new System.Drawing.Size(150, 20);
            this.priceNumeric.TabIndex = 2;
            // 
            // volumeNumeric
            // 
            this.volumeNumeric.Location = new System.Drawing.Point(96, 159);
            this.volumeNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.volumeNumeric.Name = "volumeNumeric";
            this.volumeNumeric.Size = new System.Drawing.Size(150, 20);
            this.volumeNumeric.TabIndex = 25;
            // 
            // marketCapNumeric
            // 
            this.marketCapNumeric.Location = new System.Drawing.Point(96, 195);
            this.marketCapNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.marketCapNumeric.Name = "marketCapNumeric";
            this.marketCapNumeric.Size = new System.Drawing.Size(150, 20);
            this.marketCapNumeric.TabIndex = 26;
            // 
            // lastChangeNumeric
            // 
            this.lastChangeNumeric.Location = new System.Drawing.Point(438, 83);
            this.lastChangeNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.lastChangeNumeric.Name = "lastChangeNumeric";
            this.lastChangeNumeric.Size = new System.Drawing.Size(150, 20);
            this.lastChangeNumeric.TabIndex = 27;
            // 
            // changePercentNumeric
            // 
            this.changePercentNumeric.Location = new System.Drawing.Point(438, 120);
            this.changePercentNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.changePercentNumeric.Name = "changePercentNumeric";
            this.changePercentNumeric.Size = new System.Drawing.Size(150, 20);
            this.changePercentNumeric.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Company";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 337);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Add New Company";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketCapNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastChangeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changePercentNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label marketCapLabel;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox symbolTextBox;
        private System.Windows.Forms.Label symbolLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label lastChangeLabel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label changePercentLabel;
        private System.Windows.Forms.CheckBox marketTrillionCheckBox;
        private System.Windows.Forms.CheckBox marketBillionCheckBox;
        private System.Windows.Forms.CheckBox marketMillionCheckBox;
        private System.Windows.Forms.CheckBox marketThousandCheckBox;
        private System.Windows.Forms.CheckBox volumeTrillionCheckBox;
        private System.Windows.Forms.CheckBox volumeBillionCheckBox;
        private System.Windows.Forms.CheckBox volumeMillionCheckBox;
        private System.Windows.Forms.CheckBox volumeThousandCheckBox;
        private System.Windows.Forms.NumericUpDown priceNumeric;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown changePercentNumeric;
        private System.Windows.Forms.NumericUpDown lastChangeNumeric;
        private System.Windows.Forms.NumericUpDown marketCapNumeric;
        private System.Windows.Forms.NumericUpDown volumeNumeric;
        private System.Windows.Forms.Button button1;
    }
}