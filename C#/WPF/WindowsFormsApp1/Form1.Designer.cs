namespace WindowsFormsApp1
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
            this.marketTable = new System.Windows.Forms.DataGridView();
            this.marketOverviewLabel = new System.Windows.Forms.Label();
            this.examineButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.marketTable)).BeginInit();
            this.SuspendLayout();
            // 
            // marketTable
            // 
            this.marketTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marketTable.Location = new System.Drawing.Point(12, 43);
            this.marketTable.Name = "marketTable";
            this.marketTable.Size = new System.Drawing.Size(928, 402);
            this.marketTable.TabIndex = 0;
            // 
            // marketOverviewLabel
            // 
            this.marketOverviewLabel.AutoSize = true;
            this.marketOverviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marketOverviewLabel.Location = new System.Drawing.Point(369, 9);
            this.marketOverviewLabel.Name = "marketOverviewLabel";
            this.marketOverviewLabel.Size = new System.Drawing.Size(218, 31);
            this.marketOverviewLabel.TabIndex = 1;
            this.marketOverviewLabel.Text = "Market Overview";
            // 
            // examineButton
            // 
            this.examineButton.Location = new System.Drawing.Point(12, 488);
            this.examineButton.Name = "examineButton";
            this.examineButton.Size = new System.Drawing.Size(105, 35);
            this.examineButton.TabIndex = 2;
            this.examineButton.Text = "Examine Company";
            this.examineButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(834, 488);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(106, 37);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add Company";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(398, 488);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(108, 37);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh Market";
            this.refreshButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 543);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.examineButton);
            this.Controls.Add(this.marketOverviewLabel);
            this.Controls.Add(this.marketTable);
            this.Name = "Form1";
            this.Text = "Stock Market Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.marketTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView marketTable;
        private System.Windows.Forms.Label marketOverviewLabel;
        private System.Windows.Forms.Button examineButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button refreshButton;
    }
}

