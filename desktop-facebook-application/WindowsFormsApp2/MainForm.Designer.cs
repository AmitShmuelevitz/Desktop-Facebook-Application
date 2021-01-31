namespace FacebookDesktop
{
    public partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.m_FirstNameLabel = new System.Windows.Forms.Label();
            this.m_LastNameLabel = new System.Windows.Forms.Label();
            this.m_ProfilePicture = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_NewsFeedBox = new System.Windows.Forms.GroupBox();
            this.m_NewsFeedPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.m_GenderLabel = new System.Windows.Forms.Label();
            this.m_BirthdayLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.m_HometownLabel = new System.Windows.Forms.Label();
            this.m_EmailLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.m_ReligionLabel = new System.Windows.Forms.Label();
            this.m_LanguagesLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.m_WorkExperiencesLabel = new System.Windows.Forms.Label();
            this.m_EducationsLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.m_FavoritesTreeView = new System.Windows.Forms.TreeView();
            this.label10 = new System.Windows.Forms.Label();
            this.menuButton7 = new FacebookDesktop.MenuButton();
            this.menuButton6 = new FacebookDesktop.MenuButton();
            this.menuButton5 = new FacebookDesktop.MenuButton();
            this.menuButton4 = new FacebookDesktop.MenuButton();
            this.menuButton3 = new FacebookDesktop.MenuButton();
            this.menuButton2 = new FacebookDesktop.MenuButton();
            this.menuButton1 = new FacebookDesktop.MenuButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_ProfilePicture)).BeginInit();
            this.m_NewsFeedBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // m_FirstNameLabel
            // 
            this.m_FirstNameLabel.AutoSize = true;
            this.m_FirstNameLabel.Location = new System.Drawing.Point(194, 19);
            this.m_FirstNameLabel.Name = "m_FirstNameLabel";
            this.m_FirstNameLabel.Size = new System.Drawing.Size(35, 13);
            this.m_FirstNameLabel.TabIndex = 2;
            this.m_FirstNameLabel.Text = "label3";
            // 
            // m_LastNameLabel
            // 
            this.m_LastNameLabel.AutoSize = true;
            this.m_LastNameLabel.Location = new System.Drawing.Point(194, 46);
            this.m_LastNameLabel.Name = "m_LastNameLabel";
            this.m_LastNameLabel.Size = new System.Drawing.Size(35, 13);
            this.m_LastNameLabel.TabIndex = 3;
            this.m_LastNameLabel.Text = "label4";
            // 
            // m_ProfilePicture
            // 
            this.m_ProfilePicture.Location = new System.Drawing.Point(17, 12);
            this.m_ProfilePicture.Name = "m_ProfilePicture";
            this.m_ProfilePicture.Size = new System.Drawing.Size(73, 59);
            this.m_ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.m_ProfilePicture.TabIndex = 4;
            this.m_ProfilePicture.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Menu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // m_NewsFeedBox
            // 
            this.m_NewsFeedBox.Controls.Add(this.m_NewsFeedPanel);
            this.m_NewsFeedBox.Location = new System.Drawing.Point(420, 139);
            this.m_NewsFeedBox.Name = "m_NewsFeedBox";
            this.m_NewsFeedBox.Size = new System.Drawing.Size(641, 428);
            this.m_NewsFeedBox.TabIndex = 10;
            this.m_NewsFeedBox.TabStop = false;
            this.m_NewsFeedBox.Text = "News Feed";
            // 
            // m_NewsFeedPanel
            // 
            this.m_NewsFeedPanel.AutoScroll = true;
            this.m_NewsFeedPanel.BackColor = System.Drawing.SystemColors.Control;
            this.m_NewsFeedPanel.Location = new System.Drawing.Point(6, 19);
            this.m_NewsFeedPanel.Name = "m_NewsFeedPanel";
            this.m_NewsFeedPanel.Size = new System.Drawing.Size(629, 403);
            this.m_NewsFeedPanel.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 44);
            this.button2.TabIndex = 11;
            this.button2.Text = "Post Photo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.postPhotoButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Actions";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // m_GenderLabel
            // 
            this.m_GenderLabel.AutoSize = true;
            this.m_GenderLabel.Location = new System.Drawing.Point(400, 46);
            this.m_GenderLabel.Name = "m_GenderLabel";
            this.m_GenderLabel.Size = new System.Drawing.Size(35, 13);
            this.m_GenderLabel.TabIndex = 16;
            this.m_GenderLabel.Text = "label4";
            // 
            // m_BirthdayLabel
            // 
            this.m_BirthdayLabel.AutoSize = true;
            this.m_BirthdayLabel.Location = new System.Drawing.Point(400, 19);
            this.m_BirthdayLabel.Name = "m_BirthdayLabel";
            this.m_BirthdayLabel.Size = new System.Drawing.Size(35, 13);
            this.m_BirthdayLabel.TabIndex = 15;
            this.m_BirthdayLabel.Text = "label3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Gender:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Birthday:";
            // 
            // m_HometownLabel
            // 
            this.m_HometownLabel.AutoSize = true;
            this.m_HometownLabel.Location = new System.Drawing.Point(607, 46);
            this.m_HometownLabel.Name = "m_HometownLabel";
            this.m_HometownLabel.Size = new System.Drawing.Size(35, 13);
            this.m_HometownLabel.TabIndex = 20;
            this.m_HometownLabel.Text = "label4";
            // 
            // m_EmailLabel
            // 
            this.m_EmailLabel.AutoSize = true;
            this.m_EmailLabel.Location = new System.Drawing.Point(607, 19);
            this.m_EmailLabel.Name = "m_EmailLabel";
            this.m_EmailLabel.Size = new System.Drawing.Size(35, 13);
            this.m_EmailLabel.TabIndex = 19;
            this.m_EmailLabel.Text = "label3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(509, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Hometown:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(509, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Email:";
            // 
            // m_ReligionLabel
            // 
            this.m_ReligionLabel.AutoSize = true;
            this.m_ReligionLabel.Location = new System.Drawing.Point(810, 46);
            this.m_ReligionLabel.Name = "m_ReligionLabel";
            this.m_ReligionLabel.Size = new System.Drawing.Size(35, 13);
            this.m_ReligionLabel.TabIndex = 24;
            this.m_ReligionLabel.Text = "label4";
            // 
            // m_LanguagesLabel
            // 
            this.m_LanguagesLabel.AutoSize = true;
            this.m_LanguagesLabel.Location = new System.Drawing.Point(810, 19);
            this.m_LanguagesLabel.Name = "m_LanguagesLabel";
            this.m_LanguagesLabel.Size = new System.Drawing.Size(35, 13);
            this.m_LanguagesLabel.TabIndex = 23;
            this.m_LanguagesLabel.Text = "label3";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(712, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Religion:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(712, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Languages:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Educations:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Work Experiences:";
            // 
            // m_WorkExperiencesLabel
            // 
            this.m_WorkExperiencesLabel.AutoSize = true;
            this.m_WorkExperiencesLabel.Location = new System.Drawing.Point(203, 102);
            this.m_WorkExperiencesLabel.Name = "m_WorkExperiencesLabel";
            this.m_WorkExperiencesLabel.Size = new System.Drawing.Size(35, 13);
            this.m_WorkExperiencesLabel.TabIndex = 28;
            this.m_WorkExperiencesLabel.Text = "label4";
            // 
            // m_EducationsLabel
            // 
            this.m_EducationsLabel.AutoSize = true;
            this.m_EducationsLabel.Location = new System.Drawing.Point(203, 75);
            this.m_EducationsLabel.Name = "m_EducationsLabel";
            this.m_EducationsLabel.Size = new System.Drawing.Size(35, 13);
            this.m_EducationsLabel.TabIndex = 27;
            this.m_EducationsLabel.Text = "label3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Extra";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // m_FavoritesTreeView
            // 
            this.m_FavoritesTreeView.Location = new System.Drawing.Point(191, 177);
            this.m_FavoritesTreeView.Name = "m_FavoritesTreeView";
            this.m_FavoritesTreeView.Size = new System.Drawing.Size(223, 375);
            this.m_FavoritesTreeView.TabIndex = 37;
            this.m_FavoritesTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.m_FavoritesTreeView_NodeMouseDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(194, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Favorites";
            // 
            // menuButton7
            // 
            this.menuButton7.BackColor = System.Drawing.Color.Khaki;
            this.menuButton7.Location = new System.Drawing.Point(20, 483);
            this.menuButton7.Name = "menuButton7";
            this.menuButton7.Size = new System.Drawing.Size(158, 39);
            this.menuButton7.TabIndex = 36;
            this.menuButton7.Text = "Friend Hometown Guessing Game";
            this.menuButton7.UseVisualStyleBackColor = false;
            this.menuButton7.Click += new System.EventHandler(this.friendHometownGuessingGameButton_Click);
            // 
            // menuButton6
            // 
            this.menuButton6.BackColor = System.Drawing.Color.Khaki;
            this.menuButton6.Location = new System.Drawing.Point(20, 438);
            this.menuButton6.Name = "menuButton6";
            this.menuButton6.Size = new System.Drawing.Size(158, 39);
            this.menuButton6.TabIndex = 35;
            this.menuButton6.Text = "Friend Age Guessing Game";
            this.menuButton6.UseVisualStyleBackColor = false;
            this.menuButton6.Click += new System.EventHandler(this.friendAgeGuessingGameButton_Click);
            // 
            // menuButton5
            // 
            this.menuButton5.BackColor = System.Drawing.Color.Khaki;
            this.menuButton5.Location = new System.Drawing.Point(20, 528);
            this.menuButton5.Name = "menuButton5";
            this.menuButton5.Size = new System.Drawing.Size(158, 39);
            this.menuButton5.TabIndex = 34;
            this.menuButton5.Text = "Hometown Map";
            this.menuButton5.UseVisualStyleBackColor = false;
            this.menuButton5.Click += new System.EventHandler(this.hometownMapButton_Click);
            // 
            // menuButton4
            // 
            this.menuButton4.BackColor = System.Drawing.Color.Khaki;
            this.menuButton4.Location = new System.Drawing.Point(20, 393);
            this.menuButton4.Name = "menuButton4";
            this.menuButton4.Size = new System.Drawing.Size(158, 39);
            this.menuButton4.TabIndex = 33;
            this.menuButton4.Text = "Photo Guessing Game";
            this.menuButton4.UseVisualStyleBackColor = false;
            this.menuButton4.Click += new System.EventHandler(this.photoGuessingGameButton_Click);
            // 
            // menuButton3
            // 
            this.menuButton3.Location = new System.Drawing.Point(17, 250);
            this.menuButton3.Name = "menuButton3";
            this.menuButton3.Size = new System.Drawing.Size(158, 39);
            this.menuButton3.TabIndex = 31;
            this.menuButton3.Text = "Checkins";
            this.menuButton3.UseVisualStyleBackColor = true;
            this.menuButton3.Click += new System.EventHandler(this.checkinsButton_Click);
            // 
            // menuButton2
            // 
            this.menuButton2.Location = new System.Drawing.Point(17, 204);
            this.menuButton2.Name = "menuButton2";
            this.menuButton2.Size = new System.Drawing.Size(158, 39);
            this.menuButton2.TabIndex = 30;
            this.menuButton2.Text = "Friends";
            this.menuButton2.UseVisualStyleBackColor = true;
            this.menuButton2.Click += new System.EventHandler(this.friendsButton_Click);
            // 
            // menuButton1
            // 
            this.menuButton1.Location = new System.Drawing.Point(17, 159);
            this.menuButton1.Name = "menuButton1";
            this.menuButton1.Size = new System.Drawing.Size(158, 39);
            this.menuButton1.TabIndex = 29;
            this.menuButton1.Text = "Photos";
            this.menuButton1.UseVisualStyleBackColor = true;
            this.menuButton1.Click += new System.EventHandler(this.photosButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 629);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.m_FavoritesTreeView);
            this.Controls.Add(this.menuButton7);
            this.Controls.Add(this.menuButton6);
            this.Controls.Add(this.menuButton5);
            this.Controls.Add(this.menuButton4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.menuButton3);
            this.Controls.Add(this.menuButton2);
            this.Controls.Add(this.menuButton1);
            this.Controls.Add(this.m_WorkExperiencesLabel);
            this.Controls.Add(this.m_EducationsLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.m_ReligionLabel);
            this.Controls.Add(this.m_LanguagesLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.m_HometownLabel);
            this.Controls.Add(this.m_EmailLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.m_GenderLabel);
            this.Controls.Add(this.m_BirthdayLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.m_NewsFeedBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_ProfilePicture);
            this.Controls.Add(this.m_LastNameLabel);
            this.Controls.Add(this.m_FirstNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "My Facebook";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_ProfilePicture)).EndInit();
            this.m_NewsFeedBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label m_FirstNameLabel;
        private System.Windows.Forms.Label m_LastNameLabel;
        private System.Windows.Forms.PictureBox m_ProfilePicture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox m_NewsFeedBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel m_NewsFeedPanel;
        private System.Windows.Forms.Label m_GenderLabel;
        private System.Windows.Forms.Label m_BirthdayLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label m_HometownLabel;
        private System.Windows.Forms.Label m_EmailLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label m_ReligionLabel;
        private System.Windows.Forms.Label m_LanguagesLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label m_WorkExperiencesLabel;
        private System.Windows.Forms.Label m_EducationsLabel;
        private MenuButton menuButton1;
        private MenuButton menuButton2;
        private MenuButton menuButton3;
        private System.Windows.Forms.Label label9;
        private MenuButton menuButton4;
        private MenuButton menuButton5;
        private MenuButton menuButton6;
        private MenuButton menuButton7;
        private System.Windows.Forms.TreeView m_FavoritesTreeView;
        private System.Windows.Forms.Label label10;
    }
}