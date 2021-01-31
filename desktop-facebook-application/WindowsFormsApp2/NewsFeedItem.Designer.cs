namespace FacebookDesktop
{
    public partial class NewsFeedItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_IconPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_TypeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_CreatedAtLabel = new System.Windows.Forms.Label();
            this.m_NameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_PictureBox = new System.Windows.Forms.PictureBox();
            this.m_MessageLabel = new System.Windows.Forms.Label();
            this.m_CaptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_IconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // m_IconPictureBox
            // 
            this.m_IconPictureBox.Location = new System.Drawing.Point(14, 31);
            this.m_IconPictureBox.Name = "m_IconPictureBox";
            this.m_IconPictureBox.Size = new System.Drawing.Size(46, 49);
            this.m_IconPictureBox.TabIndex = 0;
            this.m_IconPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type:";
            // 
            // m_TypeLabel
            // 
            this.m_TypeLabel.AutoSize = true;
            this.m_TypeLabel.Location = new System.Drawing.Point(133, 31);
            this.m_TypeLabel.Name = "m_TypeLabel";
            this.m_TypeLabel.Size = new System.Drawing.Size(35, 13);
            this.m_TypeLabel.TabIndex = 2;
            this.m_TypeLabel.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Created At:";
            // 
            // m_CreatedAtLabel
            // 
            this.m_CreatedAtLabel.AutoSize = true;
            this.m_CreatedAtLabel.Location = new System.Drawing.Point(133, 54);
            this.m_CreatedAtLabel.Name = "m_CreatedAtLabel";
            this.m_CreatedAtLabel.Size = new System.Drawing.Size(35, 13);
            this.m_CreatedAtLabel.TabIndex = 4;
            this.m_CreatedAtLabel.Text = "label2";
            // 
            // m_NameLabel
            // 
            this.m_NameLabel.AutoSize = true;
            this.m_NameLabel.Location = new System.Drawing.Point(133, 78);
            this.m_NameLabel.Name = "m_NameLabel";
            this.m_NameLabel.Size = new System.Drawing.Size(35, 13);
            this.m_NameLabel.TabIndex = 6;
            this.m_NameLabel.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name:";
            // 
            // m_PictureBox
            // 
            this.m_PictureBox.Location = new System.Drawing.Point(395, 31);
            this.m_PictureBox.Name = "m_PictureBox";
            this.m_PictureBox.Size = new System.Drawing.Size(189, 79);
            this.m_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.m_PictureBox.TabIndex = 7;
            this.m_PictureBox.TabStop = false;
            // 
            // m_MessageLabel
            // 
            this.m_MessageLabel.AutoSize = true;
            this.m_MessageLabel.Location = new System.Drawing.Point(392, 15);
            this.m_MessageLabel.Name = "m_MessageLabel";
            this.m_MessageLabel.Size = new System.Drawing.Size(35, 13);
            this.m_MessageLabel.TabIndex = 8;
            this.m_MessageLabel.Text = "label2";
            // 
            // m_CaptionLabel
            // 
            this.m_CaptionLabel.AutoSize = true;
            this.m_CaptionLabel.Location = new System.Drawing.Point(392, 113);
            this.m_CaptionLabel.Name = "m_CaptionLabel";
            this.m_CaptionLabel.Size = new System.Drawing.Size(35, 13);
            this.m_CaptionLabel.TabIndex = 9;
            this.m_CaptionLabel.Text = "label2";
            // 
            // NewsFeedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_CaptionLabel);
            this.Controls.Add(this.m_MessageLabel);
            this.Controls.Add(this.m_PictureBox);
            this.Controls.Add(this.m_NameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_CreatedAtLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_TypeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_IconPictureBox);
            this.Name = "NewsFeedItem";
            this.Size = new System.Drawing.Size(620, 140);
            ((System.ComponentModel.ISupportInitialize)(this.m_IconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox m_IconPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label m_TypeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label m_CreatedAtLabel;
        private System.Windows.Forms.Label m_NameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox m_PictureBox;
        private System.Windows.Forms.Label m_MessageLabel;
        private System.Windows.Forms.Label m_CaptionLabel;
    }
}
