namespace InventoryManagement
{
    partial class MainMenu
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
            this.MenuSubHeader = new System.Windows.Forms.Label();
            this.MenuHeader = new System.Windows.Forms.Label();
            this.ViewInventoryButton = new System.Windows.Forms.Button();
            this.ViewOrdersButton = new System.Windows.Forms.Button();
            this.Logoutbutton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MenuSubHeader
            // 
            this.MenuSubHeader.AutoSize = true;
            this.MenuSubHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuSubHeader.Location = new System.Drawing.Point(307, 68);
            this.MenuSubHeader.Name = "MenuSubHeader";
            this.MenuSubHeader.Size = new System.Drawing.Size(158, 29);
            this.MenuSubHeader.TabIndex = 8;
            this.MenuSubHeader.Text = "MAIN MENU";
            // 
            // MenuHeader
            // 
            this.MenuHeader.AutoSize = true;
            this.MenuHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuHeader.Location = new System.Drawing.Point(201, 9);
            this.MenuHeader.Name = "MenuHeader";
            this.MenuHeader.Size = new System.Drawing.Size(391, 39);
            this.MenuHeader.TabIndex = 7;
            this.MenuHeader.Text = "Inventory Management";
            // 
            // ViewInventoryButton
            // 
            this.ViewInventoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewInventoryButton.Location = new System.Drawing.Point(301, 197);
            this.ViewInventoryButton.Name = "ViewInventoryButton";
            this.ViewInventoryButton.Size = new System.Drawing.Size(182, 43);
            this.ViewInventoryButton.TabIndex = 9;
            this.ViewInventoryButton.Text = "View Inventory";
            this.ViewInventoryButton.UseVisualStyleBackColor = true;
            // 
            // ViewOrdersButton
            // 
            this.ViewOrdersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewOrdersButton.Location = new System.Drawing.Point(301, 281);
            this.ViewOrdersButton.Name = "ViewOrdersButton";
            this.ViewOrdersButton.Size = new System.Drawing.Size(182, 43);
            this.ViewOrdersButton.TabIndex = 10;
            this.ViewOrdersButton.Text = "View Orders";
            this.ViewOrdersButton.UseVisualStyleBackColor = true;
            // 
            // Logoutbutton
            // 
            this.Logoutbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutbutton.Location = new System.Drawing.Point(301, 365);
            this.Logoutbutton.Name = "Logoutbutton";
            this.Logoutbutton.Size = new System.Drawing.Size(182, 43);
            this.Logoutbutton.TabIndex = 11;
            this.Logoutbutton.Text = "Logout";
            this.Logoutbutton.UseVisualStyleBackColor = true;
            this.Logoutbutton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(326, 116);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(63, 13);
            this.usernameLabel.TabIndex = 12;
            this.usernameLabel.Text = "Welcome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 13;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.Logoutbutton);
            this.Controls.Add(this.ViewOrdersButton);
            this.Controls.Add(this.ViewInventoryButton);
            this.Controls.Add(this.MenuSubHeader);
            this.Controls.Add(this.MenuHeader);
            this.Name = "MainMenu";
            this.Text = "Inventory Management - MAIN MENU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MenuSubHeader;
        private System.Windows.Forms.Label MenuHeader;
        private System.Windows.Forms.Button ViewInventoryButton;
        private System.Windows.Forms.Button ViewOrdersButton;
        private System.Windows.Forms.Button Logoutbutton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label label1;
    }
}