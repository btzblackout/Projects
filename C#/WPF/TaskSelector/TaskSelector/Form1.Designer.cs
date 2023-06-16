namespace PlaygroundApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Calculate = new System.Windows.Forms.Button();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.MinutesTextBox = new System.Windows.Forms.TextBox();
            this.MinutesLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Calculate.BackColor = System.Drawing.SystemColors.Control;
            this.Calculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calculate.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Calculate.ForeColor = System.Drawing.Color.Black;
            this.Calculate.Location = new System.Drawing.Point(13, 208);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(100, 31);
            this.Calculate.TabIndex = 4;
            this.Calculate.Text = "Next Task";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.HeaderLabel.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HeaderLabel.ForeColor = System.Drawing.Color.Black;
            this.HeaderLabel.Location = new System.Drawing.Point(87, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(459, 57);
            this.HeaderLabel.TabIndex = 7;
            this.HeaderLabel.Text = "*TASK SELECTOR*";
            // 
            // MinutesTextBox
            // 
            this.MinutesTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MinutesTextBox.Location = new System.Drawing.Point(13, 183);
            this.MinutesTextBox.Name = "MinutesTextBox";
            this.MinutesTextBox.ReadOnly = true;
            this.MinutesTextBox.Size = new System.Drawing.Size(230, 23);
            this.MinutesTextBox.TabIndex = 3;
            // 
            // MinutesLabel
            // 
            this.MinutesLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MinutesLabel.AutoSize = true;
            this.MinutesLabel.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MinutesLabel.ForeColor = System.Drawing.Color.Black;
            this.MinutesLabel.Location = new System.Drawing.Point(12, 158);
            this.MinutesLabel.Name = "MinutesLabel";
            this.MinutesLabel.Size = new System.Drawing.Size(209, 22);
            this.MinutesLabel.TabIndex = 1;
            this.MinutesLabel.Text = "What should I do?";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(119, 220);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 19);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Completed";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(334, 183);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(277, 254);
            this.textBox1.TabIndex = 9;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateButton.BackColor = System.Drawing.SystemColors.Control;
            this.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateButton.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateButton.Location = new System.Drawing.Point(511, 146);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(100, 31);
            this.UpdateButton.TabIndex = 10;
            this.UpdateButton.Text = "Refresh ";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Want to add a task?";
            // 
            // AddTextBox
            // 
            this.AddTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddTextBox.Location = new System.Drawing.Point(13, 365);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(230, 23);
            this.AddTextBox.TabIndex = 12;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddButton.Location = new System.Drawing.Point(13, 394);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 31);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Add Task";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(393, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Task List";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(623, 449);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AddTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.MinutesLabel);
            this.Controls.Add(this.MinutesTextBox);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.Calculate);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "TASK SELECTOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.TextBox MinutesTextBox;
        private System.Windows.Forms.Label MinutesLabel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label2;
    }
}

