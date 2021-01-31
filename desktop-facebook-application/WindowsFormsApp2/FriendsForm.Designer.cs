namespace FacebookDesktop
{
    public partial class FriendsForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label birthdayLabel;
            this.m_FriendsListBox = new System.Windows.Forms.ListBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_SendMessageTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.emailLabel1 = new System.Windows.Forms.Label();
            this.lastNameLabel1 = new System.Windows.Forms.Label();
            this.firstNameLabel1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(19, 94);
            firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(19, 114);
            lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(19, 135);
            emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(19, 156);
            birthdayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(48, 13);
            birthdayLabel.TabIndex = 6;
            birthdayLabel.Text = "Birthday:";
            // 
            // m_FriendsListBox
            // 
            this.m_FriendsListBox.DataSource = this.userBindingSource;
            this.m_FriendsListBox.DisplayMember = "Name";
            this.m_FriendsListBox.FormattingEnabled = true;
            this.m_FriendsListBox.Location = new System.Drawing.Point(29, 46);
            this.m_FriendsListBox.Name = "m_FriendsListBox";
            this.m_FriendsListBox.Size = new System.Drawing.Size(219, 433);
            this.m_FriendsListBox.TabIndex = 0;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // m_SendMessageTextBox
            // 
            this.m_SendMessageTextBox.Location = new System.Drawing.Point(300, 323);
            this.m_SendMessageTextBox.Multiline = true;
            this.m_SendMessageTextBox.Name = "m_SendMessageTextBox";
            this.m_SendMessageTextBox.Size = new System.Drawing.Size(274, 81);
            this.m_SendMessageTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Send Message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imageNormalPictureBox);
            this.panel1.Controls.Add(birthdayLabel);
            this.panel1.Controls.Add(this.birthdayLabel1);
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Controls.Add(this.emailLabel1);
            this.panel1.Controls.Add(lastNameLabel);
            this.panel1.Controls.Add(this.lastNameLabel1);
            this.panel1.Controls.Add(firstNameLabel);
            this.panel1.Controls.Add(this.firstNameLabel1);
            this.panel1.Location = new System.Drawing.Point(289, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 194);
            this.panel1.TabIndex = 13;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(21, 8);
            this.imageNormalPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(98, 84);
            this.imageNormalPictureBox.TabIndex = 9;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // birthdayLabel1
            // 
            this.birthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayLabel1.Location = new System.Drawing.Point(81, 156);
            this.birthdayLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.birthdayLabel1.Name = "birthdayLabel1";
            this.birthdayLabel1.Size = new System.Drawing.Size(67, 15);
            this.birthdayLabel1.TabIndex = 7;
            this.birthdayLabel1.Text = "label3";
            // 
            // emailLabel1
            // 
            this.emailLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailLabel1.Location = new System.Drawing.Point(83, 135);
            this.emailLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel1.Name = "emailLabel1";
            this.emailLabel1.Size = new System.Drawing.Size(67, 15);
            this.emailLabel1.TabIndex = 5;
            this.emailLabel1.Text = "label3";
            // 
            // lastNameLabel1
            // 
            this.lastNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "LastName", true));
            this.lastNameLabel1.Location = new System.Drawing.Point(83, 114);
            this.lastNameLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastNameLabel1.Name = "lastNameLabel1";
            this.lastNameLabel1.Size = new System.Drawing.Size(67, 15);
            this.lastNameLabel1.TabIndex = 3;
            this.lastNameLabel1.Text = "label3";
            // 
            // firstNameLabel1
            // 
            this.firstNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "FirstName", true));
            this.firstNameLabel1.Location = new System.Drawing.Point(83, 94);
            this.firstNameLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNameLabel1.Name = "firstNameLabel1";
            this.firstNameLabel1.Size = new System.Drawing.Size(67, 15);
            this.firstNameLabel1.TabIndex = 1;
            this.firstNameLabel1.Text = "label3";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(289, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 30);
            this.button2.TabIndex = 14;
            this.button2.Text = "Add to Favorites";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.addToFavoritesButton_Click);
            // 
            // FriendsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.m_SendMessageTextBox);
            this.Controls.Add(this.m_FriendsListBox);
            this.Name = "FriendsForm";
            this.Text = "FriendsForm";
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox m_FriendsListBox;
        private System.Windows.Forms.TextBox m_SendMessageTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.Label birthdayLabel1;
        private System.Windows.Forms.Label emailLabel1;
        private System.Windows.Forms.Label lastNameLabel1;
        private System.Windows.Forms.Label firstNameLabel1;
        private System.Windows.Forms.Button button2;
    }
}