namespace Programming_Project_2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.RGBCheckBox = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.DarkRadioButton = new System.Windows.Forms.RadioButton();
            this.Header = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Step2Label = new System.Windows.Forms.Label();
            this.Step3Label = new System.Windows.Forms.Label();
            this.NormalRadioButton = new System.Windows.Forms.RadioButton();
            this.BrightRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RedSlider = new System.Windows.Forms.TrackBar();
            this.GreenSlider = new System.Windows.Forms.TrackBar();
            this.BlueSlider = new System.Windows.Forms.TrackBar();
            this.RedValue = new System.Windows.Forms.TextBox();
            this.GreenValue = new System.Windows.Forms.TextBox();
            this.BlueValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // RGBCheckBox
            // 
            this.RGBCheckBox.AutoSize = true;
            this.RGBCheckBox.Location = new System.Drawing.Point(8, 421);
            this.RGBCheckBox.Name = "RGBCheckBox";
            this.RGBCheckBox.Size = new System.Drawing.Size(88, 17);
            this.RGBCheckBox.TabIndex = 0;
            this.RGBCheckBox.Text = "Custom Color";
            this.RGBCheckBox.UseVisualStyleBackColor = true;
            this.RGBCheckBox.CheckedChanged += new System.EventHandler(this.RGBCheckBox_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Blue",
            "Green",
            "Red"});
            this.listBox1.Location = new System.Drawing.Point(8, 148);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // DarkRadioButton
            // 
            this.DarkRadioButton.AutoSize = true;
            this.DarkRadioButton.Location = new System.Drawing.Point(8, 286);
            this.DarkRadioButton.Name = "DarkRadioButton";
            this.DarkRadioButton.Size = new System.Drawing.Size(48, 17);
            this.DarkRadioButton.TabIndex = 2;
            this.DarkRadioButton.TabStop = true;
            this.DarkRadioButton.Text = "Dark";
            this.DarkRadioButton.UseVisualStyleBackColor = true;
            this.DarkRadioButton.CheckedChanged += new System.EventHandler(this.DarkRadioButton_CheckedChanged);
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Onyx", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(233, 9);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(307, 54);
            this.Header.TabIndex = 3;
            this.Header.Text = "Color Display Program";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(433, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 267);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Playbill", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "This program is designed to sample colors and color variations.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Playbill", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select a color below.";
            // 
            // Step2Label
            // 
            this.Step2Label.AutoSize = true;
            this.Step2Label.Font = new System.Drawing.Font("Playbill", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Step2Label.Location = new System.Drawing.Point(3, 246);
            this.Step2Label.Name = "Step2Label";
            this.Step2Label.Size = new System.Drawing.Size(184, 27);
            this.Step2Label.TabIndex = 7;
            this.Step2Label.Text = "Choose brightness of color.";
            // 
            // Step3Label
            // 
            this.Step3Label.AutoSize = true;
            this.Step3Label.Font = new System.Drawing.Font("Playbill", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Step3Label.Location = new System.Drawing.Point(3, 382);
            this.Step3Label.Name = "Step3Label";
            this.Step3Label.Size = new System.Drawing.Size(153, 27);
            this.Step3Label.TabIndex = 8;
            this.Step3Label.Text = "Optional Custom Color";
            // 
            // NormalRadioButton
            // 
            this.NormalRadioButton.AutoSize = true;
            this.NormalRadioButton.Location = new System.Drawing.Point(8, 309);
            this.NormalRadioButton.Name = "NormalRadioButton";
            this.NormalRadioButton.Size = new System.Drawing.Size(58, 17);
            this.NormalRadioButton.TabIndex = 10;
            this.NormalRadioButton.TabStop = true;
            this.NormalRadioButton.Text = "Normal";
            this.NormalRadioButton.UseVisualStyleBackColor = true;
            this.NormalRadioButton.CheckedChanged += new System.EventHandler(this.NormalRadioButton_CheckedChanged);
            // 
            // BrightRadioButton
            // 
            this.BrightRadioButton.AutoSize = true;
            this.BrightRadioButton.Location = new System.Drawing.Point(8, 332);
            this.BrightRadioButton.Name = "BrightRadioButton";
            this.BrightRadioButton.Size = new System.Drawing.Size(52, 17);
            this.BrightRadioButton.TabIndex = 11;
            this.BrightRadioButton.TabStop = true;
            this.BrightRadioButton.Text = "Bright";
            this.BrightRadioButton.UseVisualStyleBackColor = true;
            this.BrightRadioButton.CheckedChanged += new System.EventHandler(this.BrightRadioButton_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Playbill", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(580, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "PREVIEW";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.70689F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.24138F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.620689F));
            this.tableLayoutPanel1.Controls.Add(this.RedSlider, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GreenSlider, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BlueSlider, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.RedValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.GreenValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BlueValue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Enabled = false;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(176, 342);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(232, 106);
            this.tableLayoutPanel1.TabIndex = 13;
            this.tableLayoutPanel1.Visible = false;
            // 
            // RedSlider
            // 
            this.RedSlider.Location = new System.Drawing.Point(3, 3);
            this.RedSlider.Maximum = 255;
            this.RedSlider.Name = "RedSlider";
            this.RedSlider.Size = new System.Drawing.Size(164, 29);
            this.RedSlider.TabIndex = 0;
            this.RedSlider.TickFrequency = 10;
            // 
            // GreenSlider
            // 
            this.GreenSlider.Location = new System.Drawing.Point(3, 38);
            this.GreenSlider.Maximum = 255;
            this.GreenSlider.Name = "GreenSlider";
            this.GreenSlider.Size = new System.Drawing.Size(164, 29);
            this.GreenSlider.TabIndex = 1;
            this.GreenSlider.TickFrequency = 10;
            // 
            // BlueSlider
            // 
            this.BlueSlider.Location = new System.Drawing.Point(3, 73);
            this.BlueSlider.Maximum = 255;
            this.BlueSlider.Name = "BlueSlider";
            this.BlueSlider.Size = new System.Drawing.Size(164, 30);
            this.BlueSlider.TabIndex = 2;
            this.BlueSlider.TickFrequency = 10;
            // 
            // RedValue
            // 
            this.RedValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RedValue.Location = new System.Drawing.Point(174, 7);
            this.RedValue.Name = "RedValue";
            this.RedValue.Size = new System.Drawing.Size(34, 20);
            this.RedValue.TabIndex = 3;
            // 
            // GreenValue
            // 
            this.GreenValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GreenValue.Location = new System.Drawing.Point(174, 42);
            this.GreenValue.Name = "GreenValue";
            this.GreenValue.Size = new System.Drawing.Size(34, 20);
            this.GreenValue.TabIndex = 4;
            // 
            // BlueValue
            // 
            this.BlueValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BlueValue.Location = new System.Drawing.Point(174, 78);
            this.BlueValue.Name = "BlueValue";
            this.BlueValue.Size = new System.Drawing.Size(34, 20);
            this.BlueValue.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(214, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "G";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(214, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "B";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "R";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BrightRadioButton);
            this.Controls.Add(this.NormalRadioButton);
            this.Controls.Add(this.Step3Label);
            this.Controls.Add(this.Step2Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.DarkRadioButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.RGBCheckBox);
            this.Name = "Form1";
            this.Text = "Color Display Program";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox RGBCheckBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton DarkRadioButton;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Step2Label;
        private System.Windows.Forms.Label Step3Label;
        private System.Windows.Forms.RadioButton NormalRadioButton;
        private System.Windows.Forms.RadioButton BrightRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TrackBar RedSlider;
        private System.Windows.Forms.TrackBar GreenSlider;
        private System.Windows.Forms.TrackBar BlueSlider;
        private System.Windows.Forms.TextBox RedValue;
        private System.Windows.Forms.TextBox GreenValue;
        private System.Windows.Forms.TextBox BlueValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}

