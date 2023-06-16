namespace Programming_Project_5
{
    partial class LuckyNumbers
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
            this.label1 = new System.Windows.Forms.Label();
            this.BirthYearComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BirthMonthComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BirthDayComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FavoriteColorComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your birth year: ";
            // 
            // BirthYearComboBox
            // 
            this.BirthYearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BirthYearComboBox.FormattingEnabled = true;
            this.BirthYearComboBox.Location = new System.Drawing.Point(263, 49);
            this.BirthYearComboBox.Name = "BirthYearComboBox";
            this.BirthYearComboBox.Size = new System.Drawing.Size(121, 21);
            this.BirthYearComboBox.TabIndex = 1;
            this.BirthYearComboBox.SelectedIndexChanged += new System.EventHandler(this.BirthYearComboBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(8, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(376, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get Your Lucky Number!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter your birth month:";
            // 
            // BirthMonthComboBox
            // 
            this.BirthMonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BirthMonthComboBox.FormattingEnabled = true;
            this.BirthMonthComboBox.Location = new System.Drawing.Point(263, 101);
            this.BirthMonthComboBox.Name = "BirthMonthComboBox";
            this.BirthMonthComboBox.Size = new System.Drawing.Size(121, 21);
            this.BirthMonthComboBox.TabIndex = 4;
            this.BirthMonthComboBox.SelectedIndexChanged += new System.EventHandler(this.BirthMonthComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter your birth day: ";
            // 
            // BirthDayComboBox
            // 
            this.BirthDayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BirthDayComboBox.FormattingEnabled = true;
            this.BirthDayComboBox.Location = new System.Drawing.Point(263, 159);
            this.BirthDayComboBox.Name = "BirthDayComboBox";
            this.BirthDayComboBox.Size = new System.Drawing.Size(121, 21);
            this.BirthDayComboBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter your favorite color: ";
            // 
            // FavoriteColorComboBox
            // 
            this.FavoriteColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FavoriteColorComboBox.FormattingEnabled = true;
            this.FavoriteColorComboBox.Location = new System.Drawing.Point(263, 219);
            this.FavoriteColorComboBox.Name = "FavoriteColorComboBox";
            this.FavoriteColorComboBox.Size = new System.Drawing.Size(121, 21);
            this.FavoriteColorComboBox.TabIndex = 8;
            this.FavoriteColorComboBox.SelectedIndexChanged += new System.EventHandler(this.FavoriteColorComboBox_SelectedIndexChanged);
            // 
            // LuckyNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(409, 364);
            this.Controls.Add(this.FavoriteColorComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BirthDayComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BirthMonthComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BirthYearComboBox);
            this.Controls.Add(this.label1);
            this.Name = "LuckyNumbers";
            this.Text = "Lucky Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BirthYearComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox BirthMonthComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BirthDayComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox FavoriteColorComboBox;
    }
}

