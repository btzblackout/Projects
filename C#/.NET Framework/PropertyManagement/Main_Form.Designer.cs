
namespace PropertyManagement
{
    partial class Main_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Logout = new System.Windows.Forms.Button();
            this.label_Username = new System.Windows.Forms.Label();
            this.label_Hello = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.navButton_Home = new Guna.UI2.WinForms.Guna2Button();
            this.button_Pay_Rent = new Guna.UI2.WinForms.Guna2Button();
            this.navButton_Properties = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.panel_Content = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.button_Logout);
            this.panel1.Controls.Add(this.label_Username);
            this.panel1.Controls.Add(this.label_Hello);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 47);
            this.panel1.TabIndex = 0;
            // 
            // button_Logout
            // 
            this.button_Logout.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.button_Logout.FlatAppearance.BorderSize = 2;
            this.button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Logout.Location = new System.Drawing.Point(10, 8);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(99, 32);
            this.button_Logout.TabIndex = 2;
            this.button_Logout.Text = "Logout";
            this.button_Logout.UseVisualStyleBackColor = true;
            // 
            // label_Username
            // 
            this.label_Username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.Location = new System.Drawing.Point(1016, 18);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(71, 16);
            this.label_Username.TabIndex = 1;
            this.label_Username.Text = "Username";
            // 
            // label_Hello
            // 
            this.label_Hello.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Hello.AutoSize = true;
            this.label_Hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Hello.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Hello.Location = new System.Drawing.Point(956, 18);
            this.label_Hello.Name = "label_Hello";
            this.label_Hello.Size = new System.Drawing.Size(40, 16);
            this.label_Hello.TabIndex = 0;
            this.label_Hello.Text = "Hello";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.navButton_Home);
            this.flowLayoutPanel1.Controls.Add(this.button_Pay_Rent);
            this.flowLayoutPanel1.Controls.Add(this.navButton_Properties);
            this.flowLayoutPanel1.Controls.Add(this.guna2Button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 47);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1099, 47);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // navButton_Home
            // 
            this.navButton_Home.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.navButton_Home.Checked = true;
            this.navButton_Home.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(60)))));
            this.navButton_Home.CheckedState.FillColor = System.Drawing.Color.White;
            this.navButton_Home.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.navButton_Home.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.navButton_Home.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.navButton_Home.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.navButton_Home.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.navButton_Home.FillColor = System.Drawing.Color.White;
            this.navButton_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navButton_Home.ForeColor = System.Drawing.Color.Black;
            this.navButton_Home.Location = new System.Drawing.Point(3, 3);
            this.navButton_Home.Name = "navButton_Home";
            this.navButton_Home.Size = new System.Drawing.Size(159, 44);
            this.navButton_Home.TabIndex = 2;
            this.navButton_Home.Text = "Home";
            // 
            // button_Pay_Rent
            // 
            this.button_Pay_Rent.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.button_Pay_Rent.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(60)))));
            this.button_Pay_Rent.CheckedState.FillColor = System.Drawing.Color.White;
            this.button_Pay_Rent.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.button_Pay_Rent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Pay_Rent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Pay_Rent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Pay_Rent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Pay_Rent.FillColor = System.Drawing.Color.White;
            this.button_Pay_Rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Pay_Rent.ForeColor = System.Drawing.Color.Black;
            this.button_Pay_Rent.Location = new System.Drawing.Point(168, 3);
            this.button_Pay_Rent.Name = "button_Pay_Rent";
            this.button_Pay_Rent.Size = new System.Drawing.Size(159, 44);
            this.button_Pay_Rent.TabIndex = 4;
            this.button_Pay_Rent.Text = "Pay Rent";
            this.button_Pay_Rent.CheckedChanged += new System.EventHandler(this.button_Pay_Rent_CheckedChanged);
            // 
            // navButton_Properties
            // 
            this.navButton_Properties.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.navButton_Properties.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(60)))));
            this.navButton_Properties.CheckedState.FillColor = System.Drawing.Color.White;
            this.navButton_Properties.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.navButton_Properties.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.navButton_Properties.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.navButton_Properties.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.navButton_Properties.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.navButton_Properties.FillColor = System.Drawing.Color.White;
            this.navButton_Properties.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navButton_Properties.ForeColor = System.Drawing.Color.Black;
            this.navButton_Properties.Location = new System.Drawing.Point(333, 3);
            this.navButton_Properties.Name = "navButton_Properties";
            this.navButton_Properties.Size = new System.Drawing.Size(159, 44);
            this.navButton_Properties.TabIndex = 3;
            this.navButton_Properties.Text = "Payoff Information";
            // 
            // guna2Button2
            // 
            this.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button2.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(60)))));
            this.guna2Button2.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.Location = new System.Drawing.Point(498, 3);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(159, 44);
            this.guna2Button2.TabIndex = 5;
            this.guna2Button2.Text = "Contract Lookup";
            // 
            // panel_Content
            // 
            this.panel_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Content.Location = new System.Drawing.Point(0, 94);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(1099, 616);
            this.panel_Content.TabIndex = 2;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BorderThickness = 10;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CaptionBarHeight = 40;
            this.ClientSize = new System.Drawing.Size(1099, 710);
            this.Controls.Add(this.panel_Content);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Hello;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button navButton_Home;
        private Guna.UI2.WinForms.Guna2Button navButton_Properties;
        private Guna.UI2.WinForms.Guna2Button button_Pay_Rent;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Panel panel_Content;
    }
}