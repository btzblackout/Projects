namespace HeroMaker
{
    partial class HeroMakerForm
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
            this.heroNameLabel = new System.Windows.Forms.Label();
            this.heroNameTextBox = new System.Windows.Forms.TextBox();
            this.attributesGroupBox = new System.Windows.Forms.GroupBox();
            this.teleportationCheckBox = new System.Windows.Forms.CheckBox();
            this.superStrengthCheckBox = new System.Windows.Forms.CheckBox();
            this.mindControlCheckBox = new System.Windows.Forms.CheckBox();
            this.telepathyCheckBox = new System.Windows.Forms.CheckBox();
            this.timeManipulationCheckBox = new System.Windows.Forms.CheckBox();
            this.xrayCheckBox = new System.Windows.Forms.CheckBox();
            this.invisibilityCheckBox = new System.Windows.Forms.CheckBox();
            this.regenerationCheckBox = new System.Windows.Forms.CheckBox();
            this.movementGroupBox = new System.Windows.Forms.GroupBox();
            this.movementComboBox = new System.Windows.Forms.ComboBox();
            this.headquartersListBox = new System.Windows.Forms.ListBox();
            this.heroesHeadquartersLabel = new System.Windows.Forms.Label();
            this.strengthScrollBar = new System.Windows.Forms.HScrollBar();
            this.sexGroupBox = new System.Windows.Forms.GroupBox();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.staminaScrollBar = new System.Windows.Forms.HScrollBar();
            this.speedScrollBar = new System.Windows.Forms.HScrollBar();
            this.strengthNameLabel = new System.Windows.Forms.Label();
            this.strengthLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.viewHeroesButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.capeColorButton = new System.Windows.Forms.Button();
            this.capeColorLabel = new System.Windows.Forms.Label();
            this.heroImageButton = new System.Windows.Forms.Button();
            this.heroImageLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.staminaLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.pointsToSpendLabel = new System.Windows.Forms.Label();
            this.strengthCountLabel = new System.Windows.Forms.Label();
            this.staminaCountLabel = new System.Windows.Forms.Label();
            this.speedCountLabel = new System.Windows.Forms.Label();
            this.darkSideTrackBar = new System.Windows.Forms.TrackBar();
            this.darkSidePropensityLabel = new System.Windows.Forms.Label();
            this.darksideDataLabel = new System.Windows.Forms.Label();
            this.attributesGroupBox.SuspendLayout();
            this.movementGroupBox.SuspendLayout();
            this.sexGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.darkSideTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // heroNameLabel
            // 
            this.heroNameLabel.AutoSize = true;
            this.heroNameLabel.Location = new System.Drawing.Point(260, 22);
            this.heroNameLabel.Name = "heroNameLabel";
            this.heroNameLabel.Size = new System.Drawing.Size(74, 15);
            this.heroNameLabel.TabIndex = 1;
            this.heroNameLabel.Text = "Hero Name: ";
            // 
            // heroNameTextBox
            // 
            this.heroNameTextBox.Location = new System.Drawing.Point(340, 19);
            this.heroNameTextBox.Name = "heroNameTextBox";
            this.heroNameTextBox.Size = new System.Drawing.Size(221, 23);
            this.heroNameTextBox.TabIndex = 2;
            // 
            // attributesGroupBox
            // 
            this.attributesGroupBox.Controls.Add(this.teleportationCheckBox);
            this.attributesGroupBox.Controls.Add(this.superStrengthCheckBox);
            this.attributesGroupBox.Controls.Add(this.mindControlCheckBox);
            this.attributesGroupBox.Controls.Add(this.telepathyCheckBox);
            this.attributesGroupBox.Controls.Add(this.timeManipulationCheckBox);
            this.attributesGroupBox.Controls.Add(this.xrayCheckBox);
            this.attributesGroupBox.Controls.Add(this.invisibilityCheckBox);
            this.attributesGroupBox.Controls.Add(this.regenerationCheckBox);
            this.attributesGroupBox.Location = new System.Drawing.Point(12, 72);
            this.attributesGroupBox.Name = "attributesGroupBox";
            this.attributesGroupBox.Size = new System.Drawing.Size(275, 133);
            this.attributesGroupBox.TabIndex = 3;
            this.attributesGroupBox.TabStop = false;
            this.attributesGroupBox.Text = "Attributes";
            // 
            // teleportationCheckBox
            // 
            this.teleportationCheckBox.AutoSize = true;
            this.teleportationCheckBox.Location = new System.Drawing.Point(166, 23);
            this.teleportationCheckBox.Name = "teleportationCheckBox";
            this.teleportationCheckBox.Size = new System.Drawing.Size(95, 19);
            this.teleportationCheckBox.TabIndex = 7;
            this.teleportationCheckBox.Text = "Teleportation";
            this.teleportationCheckBox.UseVisualStyleBackColor = true;
            // 
            // superStrengthCheckBox
            // 
            this.superStrengthCheckBox.AutoSize = true;
            this.superStrengthCheckBox.Location = new System.Drawing.Point(166, 99);
            this.superStrengthCheckBox.Name = "superStrengthCheckBox";
            this.superStrengthCheckBox.Size = new System.Drawing.Size(104, 19);
            this.superStrengthCheckBox.TabIndex = 6;
            this.superStrengthCheckBox.Text = "Super Strength";
            this.superStrengthCheckBox.UseVisualStyleBackColor = true;
            // 
            // mindControlCheckBox
            // 
            this.mindControlCheckBox.AutoSize = true;
            this.mindControlCheckBox.Location = new System.Drawing.Point(166, 74);
            this.mindControlCheckBox.Name = "mindControlCheckBox";
            this.mindControlCheckBox.Size = new System.Drawing.Size(97, 19);
            this.mindControlCheckBox.TabIndex = 5;
            this.mindControlCheckBox.Text = "Mind Control";
            this.mindControlCheckBox.UseVisualStyleBackColor = true;
            // 
            // telepathyCheckBox
            // 
            this.telepathyCheckBox.AutoSize = true;
            this.telepathyCheckBox.Location = new System.Drawing.Point(166, 48);
            this.telepathyCheckBox.Name = "telepathyCheckBox";
            this.telepathyCheckBox.Size = new System.Drawing.Size(76, 19);
            this.telepathyCheckBox.TabIndex = 4;
            this.telepathyCheckBox.Text = "Telepathy";
            this.telepathyCheckBox.UseVisualStyleBackColor = true;
            // 
            // timeManipulationCheckBox
            // 
            this.timeManipulationCheckBox.AutoSize = true;
            this.timeManipulationCheckBox.Location = new System.Drawing.Point(7, 100);
            this.timeManipulationCheckBox.Name = "timeManipulationCheckBox";
            this.timeManipulationCheckBox.Size = new System.Drawing.Size(126, 19);
            this.timeManipulationCheckBox.TabIndex = 3;
            this.timeManipulationCheckBox.Text = "Time Manipulation";
            this.timeManipulationCheckBox.UseVisualStyleBackColor = true;
            // 
            // xrayCheckBox
            // 
            this.xrayCheckBox.AutoSize = true;
            this.xrayCheckBox.Location = new System.Drawing.Point(7, 74);
            this.xrayCheckBox.Name = "xrayCheckBox";
            this.xrayCheckBox.Size = new System.Drawing.Size(92, 19);
            this.xrayCheckBox.TabIndex = 2;
            this.xrayCheckBox.Text = "X-Ray Vision";
            this.xrayCheckBox.UseVisualStyleBackColor = true;
            // 
            // invisibilityCheckBox
            // 
            this.invisibilityCheckBox.AutoSize = true;
            this.invisibilityCheckBox.Location = new System.Drawing.Point(7, 48);
            this.invisibilityCheckBox.Name = "invisibilityCheckBox";
            this.invisibilityCheckBox.Size = new System.Drawing.Size(79, 19);
            this.invisibilityCheckBox.TabIndex = 1;
            this.invisibilityCheckBox.Text = "Invisibility";
            this.invisibilityCheckBox.UseVisualStyleBackColor = true;
            // 
            // regenerationCheckBox
            // 
            this.regenerationCheckBox.AutoSize = true;
            this.regenerationCheckBox.Location = new System.Drawing.Point(7, 23);
            this.regenerationCheckBox.Name = "regenerationCheckBox";
            this.regenerationCheckBox.Size = new System.Drawing.Size(96, 19);
            this.regenerationCheckBox.TabIndex = 0;
            this.regenerationCheckBox.Text = "Regeneration";
            this.regenerationCheckBox.UseVisualStyleBackColor = true;
            // 
            // movementGroupBox
            // 
            this.movementGroupBox.Controls.Add(this.movementComboBox);
            this.movementGroupBox.Location = new System.Drawing.Point(144, 225);
            this.movementGroupBox.Name = "movementGroupBox";
            this.movementGroupBox.Size = new System.Drawing.Size(143, 72);
            this.movementGroupBox.TabIndex = 4;
            this.movementGroupBox.TabStop = false;
            this.movementGroupBox.Text = "Movement";
            // 
            // movementComboBox
            // 
            this.movementComboBox.FormattingEnabled = true;
            this.movementComboBox.Items.AddRange(new object[] {
            "Flight",
            "Super Speed",
            "Wall Crawling"});
            this.movementComboBox.Location = new System.Drawing.Point(7, 22);
            this.movementComboBox.Name = "movementComboBox";
            this.movementComboBox.Size = new System.Drawing.Size(121, 23);
            this.movementComboBox.TabIndex = 0;
            // 
            // headquartersListBox
            // 
            this.headquartersListBox.FormattingEnabled = true;
            this.headquartersListBox.ItemHeight = 15;
            this.headquartersListBox.Items.AddRange(new object[] {
            "Spawn\'s Alley",
            "The Legion Clubhouse",
            "Dr. Strang\'s Sanctum Sanctorum",
            "The S.H.I.E.L.D. Helicarrier",
            "Avengers\' Tower",
            "The Hall of Justice",
            "Titans\' Tower",
            "Xavier\'s School for Gifted Youngsters",
            "The Baxter Building",
            "The JLA Satellite",
            "Avengers\' Mansion",
            "The Fortress of Solitude",
            "The Bat Cave"});
            this.headquartersListBox.Location = new System.Drawing.Point(12, 337);
            this.headquartersListBox.Name = "headquartersListBox";
            this.headquartersListBox.Size = new System.Drawing.Size(229, 169);
            this.headquartersListBox.TabIndex = 5;
            // 
            // heroesHeadquartersLabel
            // 
            this.heroesHeadquartersLabel.AutoSize = true;
            this.heroesHeadquartersLabel.Location = new System.Drawing.Point(70, 319);
            this.heroesHeadquartersLabel.Name = "heroesHeadquartersLabel";
            this.heroesHeadquartersLabel.Size = new System.Drawing.Size(107, 15);
            this.heroesHeadquartersLabel.TabIndex = 6;
            this.heroesHeadquartersLabel.Text = "Hero Headquarters";
            // 
            // strengthScrollBar
            // 
            this.strengthScrollBar.LargeChange = 1;
            this.strengthScrollBar.Location = new System.Drawing.Point(3, 179);
            this.strengthScrollBar.Name = "strengthScrollBar";
            this.strengthScrollBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.strengthScrollBar.Size = new System.Drawing.Size(327, 17);
            this.strengthScrollBar.TabIndex = 7;
            this.strengthScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.strengthScrollBar_Scroll);
            // 
            // sexGroupBox
            // 
            this.sexGroupBox.Controls.Add(this.femaleRadioButton);
            this.sexGroupBox.Controls.Add(this.maleRadioButton);
            this.sexGroupBox.Location = new System.Drawing.Point(19, 225);
            this.sexGroupBox.Name = "sexGroupBox";
            this.sexGroupBox.Size = new System.Drawing.Size(119, 72);
            this.sexGroupBox.TabIndex = 8;
            this.sexGroupBox.TabStop = false;
            this.sexGroupBox.Text = "Sex";
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(7, 47);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(63, 19);
            this.femaleRadioButton.TabIndex = 1;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(7, 22);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(51, 19);
            this.maleRadioButton.TabIndex = 0;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // staminaScrollBar
            // 
            this.staminaScrollBar.LargeChange = 1;
            this.staminaScrollBar.Location = new System.Drawing.Point(3, 114);
            this.staminaScrollBar.Name = "staminaScrollBar";
            this.staminaScrollBar.Size = new System.Drawing.Size(327, 17);
            this.staminaScrollBar.TabIndex = 9;
            this.staminaScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.staminaScrollBar_Scroll);
            // 
            // speedScrollBar
            // 
            this.speedScrollBar.LargeChange = 1;
            this.speedScrollBar.Location = new System.Drawing.Point(3, 57);
            this.speedScrollBar.Name = "speedScrollBar";
            this.speedScrollBar.Size = new System.Drawing.Size(327, 17);
            this.speedScrollBar.TabIndex = 10;
            this.speedScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.speedScrollBar_Scroll);
            // 
            // strengthNameLabel
            // 
            this.strengthNameLabel.AutoSize = true;
            this.strengthNameLabel.Location = new System.Drawing.Point(6, 149);
            this.strengthNameLabel.Name = "strengthNameLabel";
            this.strengthNameLabel.Size = new System.Drawing.Size(58, 15);
            this.strengthNameLabel.TabIndex = 11;
            this.strengthNameLabel.Text = "Strength: ";
            // 
            // strengthLabel
            // 
            this.strengthLabel.AutoSize = true;
            this.strengthLabel.Location = new System.Drawing.Point(324, 459);
            this.strengthLabel.Name = "strengthLabel";
            this.strengthLabel.Size = new System.Drawing.Size(0, 15);
            this.strengthLabel.TabIndex = 12;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(613, 489);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(87, 31);
            this.createButton.TabIndex = 13;
            this.createButton.Text = "Create Hero";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // viewHeroesButton
            // 
            this.viewHeroesButton.Location = new System.Drawing.Point(706, 489);
            this.viewHeroesButton.Name = "viewHeroesButton";
            this.viewHeroesButton.Size = new System.Drawing.Size(82, 31);
            this.viewHeroesButton.TabIndex = 14;
            this.viewHeroesButton.Text = "View Heroes";
            this.viewHeroesButton.UseVisualStyleBackColor = true;
            this.viewHeroesButton.Click += new System.EventHandler(this.viewHeroesButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(375, 185);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Birthdate";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(436, 247);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Years Experience";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(613, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 107);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(613, 236);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(162, 95);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // capeColorButton
            // 
            this.capeColorButton.Location = new System.Drawing.Point(613, 337);
            this.capeColorButton.Name = "capeColorButton";
            this.capeColorButton.Size = new System.Drawing.Size(75, 23);
            this.capeColorButton.TabIndex = 21;
            this.capeColorButton.Text = "Color";
            this.capeColorButton.UseVisualStyleBackColor = true;
            this.capeColorButton.Click += new System.EventHandler(this.capeColorButton_Click);
            // 
            // capeColorLabel
            // 
            this.capeColorLabel.AutoSize = true;
            this.capeColorLabel.Location = new System.Drawing.Point(660, 218);
            this.capeColorLabel.Name = "capeColorLabel";
            this.capeColorLabel.Size = new System.Drawing.Size(66, 15);
            this.capeColorLabel.TabIndex = 22;
            this.capeColorLabel.Text = "Cape Color";
            // 
            // heroImageButton
            // 
            this.heroImageButton.Location = new System.Drawing.Point(613, 185);
            this.heroImageButton.Name = "heroImageButton";
            this.heroImageButton.Size = new System.Drawing.Size(75, 23);
            this.heroImageButton.TabIndex = 23;
            this.heroImageButton.Text = "Image";
            this.heroImageButton.UseVisualStyleBackColor = true;
            this.heroImageButton.Click += new System.EventHandler(this.heroImageButton_Click);
            // 
            // heroImageLabel
            // 
            this.heroImageLabel.AutoSize = true;
            this.heroImageLabel.Location = new System.Drawing.Point(660, 53);
            this.heroImageLabel.Name = "heroImageLabel";
            this.heroImageLabel.Size = new System.Drawing.Size(46, 15);
            this.heroImageLabel.TabIndex = 24;
            this.heroImageLabel.Text = "Portrait";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "File to Open";
            this.openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bm" +
    "p";
            // 
            // staminaLabel
            // 
            this.staminaLabel.AutoSize = true;
            this.staminaLabel.Location = new System.Drawing.Point(6, 89);
            this.staminaLabel.Name = "staminaLabel";
            this.staminaLabel.Size = new System.Drawing.Size(53, 15);
            this.staminaLabel.TabIndex = 25;
            this.staminaLabel.Text = "Stamina:";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(6, 31);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(42, 15);
            this.speedLabel.TabIndex = 26;
            this.speedLabel.Text = "Speed:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pointsLabel);
            this.groupBox1.Controls.Add(this.pointsToSpendLabel);
            this.groupBox1.Controls.Add(this.strengthCountLabel);
            this.groupBox1.Controls.Add(this.staminaCountLabel);
            this.groupBox1.Controls.Add(this.speedCountLabel);
            this.groupBox1.Controls.Add(this.speedLabel);
            this.groupBox1.Controls.Add(this.staminaLabel);
            this.groupBox1.Controls.Add(this.speedScrollBar);
            this.groupBox1.Controls.Add(this.staminaScrollBar);
            this.groupBox1.Controls.Add(this.strengthNameLabel);
            this.groupBox1.Controls.Add(this.strengthScrollBar);
            this.groupBox1.Location = new System.Drawing.Point(260, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 210);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Speed-Stamina-Strength";
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Location = new System.Drawing.Point(277, 27);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(0, 15);
            this.pointsLabel.TabIndex = 31;
            // 
            // pointsToSpendLabel
            // 
            this.pointsToSpendLabel.AutoSize = true;
            this.pointsToSpendLabel.Location = new System.Drawing.Point(176, 27);
            this.pointsToSpendLabel.Name = "pointsToSpendLabel";
            this.pointsToSpendLabel.Size = new System.Drawing.Size(95, 15);
            this.pointsToSpendLabel.TabIndex = 30;
            this.pointsToSpendLabel.Text = "Points to spend: ";
            // 
            // strengthCountLabel
            // 
            this.strengthCountLabel.AutoSize = true;
            this.strengthCountLabel.Location = new System.Drawing.Point(64, 149);
            this.strengthCountLabel.Name = "strengthCountLabel";
            this.strengthCountLabel.Size = new System.Drawing.Size(0, 15);
            this.strengthCountLabel.TabIndex = 29;
            // 
            // staminaCountLabel
            // 
            this.staminaCountLabel.AutoSize = true;
            this.staminaCountLabel.Location = new System.Drawing.Point(64, 89);
            this.staminaCountLabel.Name = "staminaCountLabel";
            this.staminaCountLabel.Size = new System.Drawing.Size(0, 15);
            this.staminaCountLabel.TabIndex = 28;
            // 
            // speedCountLabel
            // 
            this.speedCountLabel.AutoSize = true;
            this.speedCountLabel.Location = new System.Drawing.Point(64, 31);
            this.speedCountLabel.Name = "speedCountLabel";
            this.speedCountLabel.Size = new System.Drawing.Size(0, 15);
            this.speedCountLabel.TabIndex = 27;
            // 
            // darkSideTrackBar
            // 
            this.darkSideTrackBar.Location = new System.Drawing.Point(339, 108);
            this.darkSideTrackBar.Name = "darkSideTrackBar";
            this.darkSideTrackBar.Size = new System.Drawing.Size(192, 45);
            this.darkSideTrackBar.TabIndex = 28;
            this.darkSideTrackBar.Scroll += new System.EventHandler(this.darkSideTrackBar_Scroll);
            // 
            // darkSidePropensityLabel
            // 
            this.darkSidePropensityLabel.AutoSize = true;
            this.darkSidePropensityLabel.Location = new System.Drawing.Point(369, 90);
            this.darkSidePropensityLabel.Name = "darkSidePropensityLabel";
            this.darkSidePropensityLabel.Size = new System.Drawing.Size(118, 15);
            this.darkSidePropensityLabel.TabIndex = 29;
            this.darkSidePropensityLabel.Text = "Dark Side Propensity:";
            // 
            // darksideDataLabel
            // 
            this.darksideDataLabel.AutoSize = true;
            this.darksideDataLabel.Location = new System.Drawing.Point(505, 90);
            this.darksideDataLabel.Name = "darksideDataLabel";
            this.darksideDataLabel.Size = new System.Drawing.Size(0, 15);
            this.darksideDataLabel.TabIndex = 30;
            // 
            // HeroMakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.darksideDataLabel);
            this.Controls.Add(this.darkSidePropensityLabel);
            this.Controls.Add(this.darkSideTrackBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.heroImageLabel);
            this.Controls.Add(this.heroImageButton);
            this.Controls.Add(this.capeColorLabel);
            this.Controls.Add(this.capeColorButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.viewHeroesButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.strengthLabel);
            this.Controls.Add(this.sexGroupBox);
            this.Controls.Add(this.heroesHeadquartersLabel);
            this.Controls.Add(this.headquartersListBox);
            this.Controls.Add(this.movementGroupBox);
            this.Controls.Add(this.attributesGroupBox);
            this.Controls.Add(this.heroNameTextBox);
            this.Controls.Add(this.heroNameLabel);
            this.Name = "HeroMakerForm";
            this.Text = "HeroMaker";
            this.Load += new System.EventHandler(this.HeroMakerForm_Load);
            this.attributesGroupBox.ResumeLayout(false);
            this.attributesGroupBox.PerformLayout();
            this.movementGroupBox.ResumeLayout(false);
            this.sexGroupBox.ResumeLayout(false);
            this.sexGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.darkSideTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label heroNameLabel;
        private System.Windows.Forms.TextBox heroNameTextBox;
        private System.Windows.Forms.GroupBox attributesGroupBox;
        private System.Windows.Forms.CheckBox teleportationCheckBox;
        private System.Windows.Forms.CheckBox superStrengthCheckBox;
        private System.Windows.Forms.CheckBox mindControlCheckBox;
        private System.Windows.Forms.CheckBox telepathyCheckBox;
        private System.Windows.Forms.CheckBox timeManipulationCheckBox;
        private System.Windows.Forms.CheckBox xrayCheckBox;
        private System.Windows.Forms.CheckBox invisibilityCheckBox;
        private System.Windows.Forms.CheckBox regenerationCheckBox;
        private System.Windows.Forms.GroupBox movementGroupBox;
        private System.Windows.Forms.ComboBox movementComboBox;
        private System.Windows.Forms.ListBox headquartersListBox;
        private System.Windows.Forms.Label heroesHeadquartersLabel;
        private System.Windows.Forms.HScrollBar strengthScrollBar;
        private System.Windows.Forms.GroupBox sexGroupBox;
        private System.Windows.Forms.HScrollBar staminaSrollBar;
        private System.Windows.Forms.HScrollBar speedScrollBar;
        private System.Windows.Forms.Label strengthNameLabel;
        private System.Windows.Forms.Label strengthLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.Button viewHeroesButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button capeColorButton;
        private System.Windows.Forms.Label capeColorLabel;
        private System.Windows.Forms.Button heroImageButton;
        private System.Windows.Forms.Label heroImageLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label staminaLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.HScrollBar staminaScrollBar;
        private System.Windows.Forms.Label strengthCountLabel;
        private System.Windows.Forms.Label staminaCountLabel;
        private System.Windows.Forms.Label speedCountLabel;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Label pointsToSpendLabel;
        private System.Windows.Forms.TrackBar darkSideTrackBar;
        private System.Windows.Forms.Label darkSidePropensityLabel;
        private System.Windows.Forms.Label darksideDataLabel;
    }
}

