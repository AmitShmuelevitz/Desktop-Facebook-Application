namespace FacebookDesktop
{
    public partial class PhotoAlbumsForm
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
            this.m_AlbumsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_PhotosPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_AlbumsListBox
            // 
            this.m_AlbumsListBox.FormattingEnabled = true;
            this.m_AlbumsListBox.Location = new System.Drawing.Point(34, 57);
            this.m_AlbumsListBox.Name = "m_AlbumsListBox";
            this.m_AlbumsListBox.Size = new System.Drawing.Size(234, 368);
            this.m_AlbumsListBox.TabIndex = 0;
            this.m_AlbumsListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Photo Albums";
            // 
            // m_PhotosPanel
            // 
            this.m_PhotosPanel.AutoScroll = true;
            this.m_PhotosPanel.Location = new System.Drawing.Point(326, 56);
            this.m_PhotosPanel.Name = "m_PhotosPanel";
            this.m_PhotosPanel.Size = new System.Drawing.Size(653, 371);
            this.m_PhotosPanel.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 30);
            this.button2.TabIndex = 15;
            this.button2.Text = "Add Album to Favorites";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.addToFavoritesButton_Click);
            // 
            // PhotoAlbumsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 505);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.m_PhotosPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_AlbumsListBox);
            this.Name = "PhotoAlbumsForm";
            this.Text = "PhotoAlbums";
            this.Load += new System.EventHandler(this.PhotoAlbums_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox m_AlbumsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel m_PhotosPanel;
        private System.Windows.Forms.Button button2;
    }
}