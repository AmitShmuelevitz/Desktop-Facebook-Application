namespace FacebookDesktop
{
    public partial class CheckinsForm
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
            System.Windows.Forms.Label captionLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label messageLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label pictureURLLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.m_CheckinsListBox = new System.Windows.Forms.ListBox();
            this.checkinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_panelCheckinDetails = new System.Windows.Forms.Panel();
            this.captionLabel1 = new System.Windows.Forms.Label();
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.messageLabel1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.pictureURLPictureBox = new System.Windows.Forms.PictureBox();
            this.m_ProgressBar = new System.Windows.Forms.ProgressBar();
            this.m_AddFavoritesButton = new System.Windows.Forms.Button();
            captionLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            pictureURLLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.checkinBindingSource)).BeginInit();
            this.m_panelCheckinDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureURLPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // captionLabel
            // 
            captionLabel.AutoSize = true;
            captionLabel.Location = new System.Drawing.Point(51, 48);
            captionLabel.Name = "captionLabel";
            captionLabel.Size = new System.Drawing.Size(46, 13);
            captionLabel.TabIndex = 0;
            captionLabel.Text = "Caption:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(51, 71);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(51, 94);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(53, 13);
            messageLabel.TabIndex = 4;
            messageLabel.Text = "Message:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(51, 117);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Name:";
            // 
            // pictureURLLabel
            // 
            pictureURLLabel.AutoSize = true;
            pictureURLLabel.Location = new System.Drawing.Point(51, 143);
            pictureURLLabel.Name = "pictureURLLabel";
            pictureURLLabel.Size = new System.Drawing.Size(68, 13);
            pictureURLLabel.TabIndex = 8;
            pictureURLLabel.Text = "Picture URL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "My Checkins";
            // 
            // m_CheckinsListBox
            // 
            this.m_CheckinsListBox.DataSource = this.checkinBindingSource;
            this.m_CheckinsListBox.DisplayMember = "Name";
            this.m_CheckinsListBox.FormattingEnabled = true;
            this.m_CheckinsListBox.Location = new System.Drawing.Point(15, 61);
            this.m_CheckinsListBox.Name = "m_CheckinsListBox";
            this.m_CheckinsListBox.Size = new System.Drawing.Size(426, 368);
            this.m_CheckinsListBox.TabIndex = 3;
            this.m_CheckinsListBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.m_CheckinsListBox_Format);
            // 
            // checkinBindingSource
            // 
            this.checkinBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Checkin);
            // 
            // m_panelCheckinDetails
            // 
            this.m_panelCheckinDetails.BackColor = System.Drawing.SystemColors.Control;
            this.m_panelCheckinDetails.Controls.Add(captionLabel);
            this.m_panelCheckinDetails.Controls.Add(this.captionLabel1);
            this.m_panelCheckinDetails.Controls.Add(descriptionLabel);
            this.m_panelCheckinDetails.Controls.Add(this.descriptionLabel1);
            this.m_panelCheckinDetails.Controls.Add(messageLabel);
            this.m_panelCheckinDetails.Controls.Add(this.messageLabel1);
            this.m_panelCheckinDetails.Controls.Add(nameLabel);
            this.m_panelCheckinDetails.Controls.Add(this.nameLabel1);
            this.m_panelCheckinDetails.Controls.Add(pictureURLLabel);
            this.m_panelCheckinDetails.Controls.Add(this.pictureURLPictureBox);
            this.m_panelCheckinDetails.Location = new System.Drawing.Point(447, 61);
            this.m_panelCheckinDetails.Name = "m_panelCheckinDetails";
            this.m_panelCheckinDetails.Size = new System.Drawing.Size(440, 368);
            this.m_panelCheckinDetails.TabIndex = 14;
            // 
            // captionLabel1
            // 
            this.captionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.checkinBindingSource, "Caption", true));
            this.captionLabel1.Location = new System.Drawing.Point(125, 48);
            this.captionLabel1.Name = "captionLabel1";
            this.captionLabel1.Size = new System.Drawing.Size(100, 23);
            this.captionLabel1.TabIndex = 1;
            this.captionLabel1.Text = "label3";
            // 
            // descriptionLabel1
            // 
            this.descriptionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.checkinBindingSource, "Description", true));
            this.descriptionLabel1.Location = new System.Drawing.Point(125, 71);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(100, 23);
            this.descriptionLabel1.TabIndex = 3;
            this.descriptionLabel1.Text = "label3";
            // 
            // messageLabel1
            // 
            this.messageLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.checkinBindingSource, "Message", true));
            this.messageLabel1.Location = new System.Drawing.Point(125, 94);
            this.messageLabel1.Name = "messageLabel1";
            this.messageLabel1.Size = new System.Drawing.Size(100, 23);
            this.messageLabel1.TabIndex = 5;
            this.messageLabel1.Text = "label3";
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.checkinBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(125, 117);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameLabel1.TabIndex = 7;
            this.nameLabel1.Text = "label3";
            // 
            // pictureURLPictureBox
            // 
            this.pictureURLPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.checkinBindingSource, "PictureURL", true));
            this.pictureURLPictureBox.Location = new System.Drawing.Point(125, 143);
            this.pictureURLPictureBox.Name = "pictureURLPictureBox";
            this.pictureURLPictureBox.Size = new System.Drawing.Size(100, 50);
            this.pictureURLPictureBox.TabIndex = 9;
            this.pictureURLPictureBox.TabStop = false;
            // 
            // m_ProgressBar
            // 
            this.m_ProgressBar.Location = new System.Drawing.Point(15, 470);
            this.m_ProgressBar.MarqueeAnimationSpeed = 5;
            this.m_ProgressBar.Name = "m_ProgressBar";
            this.m_ProgressBar.Size = new System.Drawing.Size(426, 23);
            this.m_ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.m_ProgressBar.TabIndex = 15;
            // 
            // m_AddFavoritesButton
            // 
            this.m_AddFavoritesButton.Enabled = false;
            this.m_AddFavoritesButton.Location = new System.Drawing.Point(489, 435);
            this.m_AddFavoritesButton.Name = "m_AddFavoritesButton";
            this.m_AddFavoritesButton.Size = new System.Drawing.Size(158, 30);
            this.m_AddFavoritesButton.TabIndex = 16;
            this.m_AddFavoritesButton.Text = "Add Checkin to Favorites";
            this.m_AddFavoritesButton.UseVisualStyleBackColor = true;
            this.m_AddFavoritesButton.Click += new System.EventHandler(this.addToFavoritesButton_Click);
            // 
            // CheckinsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 570);
            this.Controls.Add(this.m_AddFavoritesButton);
            this.Controls.Add(this.m_ProgressBar);
            this.Controls.Add(this.m_panelCheckinDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_CheckinsListBox);
            this.Name = "CheckinsForm";
            this.Text = "My Checkins";
            ((System.ComponentModel.ISupportInitialize)(this.checkinBindingSource)).EndInit();
            this.m_panelCheckinDetails.ResumeLayout(false);
            this.m_panelCheckinDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureURLPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox m_CheckinsListBox;
        private System.Windows.Forms.Panel m_panelCheckinDetails;
        private System.Windows.Forms.BindingSource checkinBindingSource;
        private System.Windows.Forms.Label captionLabel1;
        private System.Windows.Forms.Label descriptionLabel1;
        private System.Windows.Forms.Label messageLabel1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.PictureBox pictureURLPictureBox;
        private System.Windows.Forms.ProgressBar m_ProgressBar;
        private System.Windows.Forms.Button m_AddFavoritesButton;
    }
}