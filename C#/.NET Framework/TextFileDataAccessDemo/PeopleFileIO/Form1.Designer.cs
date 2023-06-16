namespace PeopleFileIO
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.addToListButton = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.peopleListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(12, 30);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(70, 15);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name: ";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 56);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(69, 15);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name: ";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(12, 81);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(34, 15);
            this.urlLabel.TabIndex = 2;
            this.urlLabel.Text = "URL: ";
            // 
            // addToListButton
            // 
            this.addToListButton.Location = new System.Drawing.Point(55, 120);
            this.addToListButton.Name = "addToListButton";
            this.addToListButton.Size = new System.Drawing.Size(97, 23);
            this.addToListButton.TabIndex = 3;
            this.addToListButton.Text = "Add To List -->";
            this.addToListButton.UseVisualStyleBackColor = true;
            this.addToListButton.Click += new System.EventHandler(this.addToListButton_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(87, 27);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(87, 53);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(87, 78);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(100, 23);
            this.urlTextBox.TabIndex = 6;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(56, 170);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(96, 36);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save To File";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(56, 212);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(96, 36);
            this.loadButton.TabIndex = 8;
            this.loadButton.Text = "Load From File";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // peopleListBox
            // 
            this.peopleListBox.FormattingEnabled = true;
            this.peopleListBox.ItemHeight = 15;
            this.peopleListBox.Location = new System.Drawing.Point(208, 23);
            this.peopleListBox.Name = "peopleListBox";
            this.peopleListBox.Size = new System.Drawing.Size(415, 214);
            this.peopleListBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 319);
            this.Controls.Add(this.peopleListBox);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.addToListButton);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Button addToListButton;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.ListBox peopleListBox;
    }
}

