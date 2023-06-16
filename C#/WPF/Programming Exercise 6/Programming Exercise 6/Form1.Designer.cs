namespace Programming_Exercise_6
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
            this.Die2 = new System.Windows.Forms.Label();
            this.RollButton = new System.Windows.Forms.Button();
            this.Die1Label = new System.Windows.Forms.Label();
            this.Die2Label = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SetButton = new System.Windows.Forms.Button();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.Die1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RollCounterLabel = new System.Windows.Forms.Label();
            this.CounterLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Die2
            // 
            this.Die2.BackColor = System.Drawing.Color.Maroon;
            this.Die2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Die2.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Die2.ForeColor = System.Drawing.Color.White;
            this.Die2.Location = new System.Drawing.Point(0, 0);
            this.Die2.Name = "Die2";
            this.Die2.Size = new System.Drawing.Size(81, 76);
            this.Die2.TabIndex = 1;
            this.Die2.Text = "1";
            this.Die2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Die2.Visible = false;
            // 
            // RollButton
            // 
            this.RollButton.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollButton.Location = new System.Drawing.Point(257, 216);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(263, 76);
            this.RollButton.TabIndex = 2;
            this.RollButton.Text = "Roll Dice";
            this.RollButton.UseVisualStyleBackColor = true;
            this.RollButton.Visible = false;
            this.RollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // Die1Label
            // 
            this.Die1Label.AutoSize = true;
            this.Die1Label.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Die1Label.Location = new System.Drawing.Point(175, 402);
            this.Die1Label.Name = "Die1Label";
            this.Die1Label.Size = new System.Drawing.Size(206, 32);
            this.Die1Label.TabIndex = 3;
            this.Die1Label.Text = "20 sided die.";
            this.Die1Label.Visible = false;
            // 
            // Die2Label
            // 
            this.Die2Label.AutoSize = true;
            this.Die2Label.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Die2Label.Location = new System.Drawing.Point(415, 402);
            this.Die2Label.Name = "Die2Label";
            this.Die2Label.Size = new System.Drawing.Size(206, 32);
            this.Die2Label.TabIndex = 4;
            this.Die2Label.Text = "20 sided die.";
            this.Die2Label.Visible = false;
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.Location = new System.Drawing.Point(164, 72);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(463, 32);
            this.QuestionLabel.TabIndex = 5;
            this.QuestionLabel.Text = "How many sides for the dice?";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(257, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 20);
            this.textBox1.TabIndex = 6;
            // 
            // SetButton
            // 
            this.SetButton.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetButton.Location = new System.Drawing.Point(257, 144);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(263, 66);
            this.SetButton.TabIndex = 7;
            this.SetButton.Text = "Set Die";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.Location = new System.Drawing.Point(226, 3);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(332, 57);
            this.HeaderLabel.TabIndex = 8;
            this.HeaderLabel.Text = "Dice Roller";
            // 
            // Die1
            // 
            this.Die1.BackColor = System.Drawing.Color.Maroon;
            this.Die1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Die1.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Die1.ForeColor = System.Drawing.Color.White;
            this.Die1.Location = new System.Drawing.Point(0, 0);
            this.Die1.Name = "Die1";
            this.Die1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Die1.Size = new System.Drawing.Size(81, 76);
            this.Die1.TabIndex = 0;
            this.Die1.Text = "1";
            this.Die1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Die1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.Die1);
            this.panel1.Location = new System.Drawing.Point(226, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(81, 76);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Die2);
            this.panel2.Location = new System.Drawing.Point(466, 317);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(81, 76);
            this.panel2.TabIndex = 10;
            this.panel2.Visible = false;
            // 
            // RollCounterLabel
            // 
            this.RollCounterLabel.AutoSize = true;
            this.RollCounterLabel.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollCounterLabel.Location = new System.Drawing.Point(592, 216);
            this.RollCounterLabel.Name = "RollCounterLabel";
            this.RollCounterLabel.Size = new System.Drawing.Size(171, 25);
            this.RollCounterLabel.TabIndex = 11;
            this.RollCounterLabel.Text = "Roll Counter";
            this.RollCounterLabel.Visible = false;
            // 
            // CounterLabel
            // 
            this.CounterLabel.AutoSize = true;
            this.CounterLabel.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CounterLabel.Location = new System.Drawing.Point(662, 260);
            this.CounterLabel.Name = "CounterLabel";
            this.CounterLabel.Size = new System.Drawing.Size(32, 32);
            this.CounterLabel.TabIndex = 12;
            this.CounterLabel.Text = "0";
            this.CounterLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CounterLabel);
            this.Controls.Add(this.RollCounterLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.Die2Label);
            this.Controls.Add(this.Die1Label);
            this.Controls.Add(this.RollButton);
            this.Name = "Form1";
            this.Text = "Dice Roller";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Die2;
        private System.Windows.Forms.Button RollButton;
        private System.Windows.Forms.Label Die1Label;
        private System.Windows.Forms.Label Die2Label;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label Die1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label RollCounterLabel;
        private System.Windows.Forms.Label CounterLabel;
    }
}

