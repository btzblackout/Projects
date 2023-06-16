namespace HeroMaker
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.portraitBox = new System.Windows.Forms.PictureBox();
            this.capeBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.portraitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.portraitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(28, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(111, 94);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Heroes:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 203);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(317, 175);
            this.textBox1.TabIndex = 2;
            // 
            // portraitBox
            // 
            this.portraitBox.Location = new System.Drawing.Point(181, 44);
            this.portraitBox.Name = "portraitBox";
            this.portraitBox.Size = new System.Drawing.Size(156, 138);
            this.portraitBox.TabIndex = 3;
            this.portraitBox.TabStop = false;
            // 
            // capeBox
            // 
            this.capeBox.Location = new System.Drawing.Point(375, 44);
            this.capeBox.Name = "capeBox";
            this.capeBox.Size = new System.Drawing.Size(42, 100);
            this.capeBox.TabIndex = 4;
            this.capeBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cape";
            // 
            // portraitLabel
            // 
            this.portraitLabel.AutoSize = true;
            this.portraitLabel.Location = new System.Drawing.Point(216, 25);
            this.portraitLabel.Name = "portraitLabel";
            this.portraitLabel.Size = new System.Drawing.Size(46, 15);
            this.portraitLabel.TabIndex = 6;
            this.portraitLabel.Text = "Portrait";
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(494, 390);
            this.Controls.Add(this.portraitLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.capeBox);
            this.Controls.Add(this.portraitBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.portraitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heroesLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox portraitBox;
        private System.Windows.Forms.PictureBox capeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label portraitLabel;
    }
}