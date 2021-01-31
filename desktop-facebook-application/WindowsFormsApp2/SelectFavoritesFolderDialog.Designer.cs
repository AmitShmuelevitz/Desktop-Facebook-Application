namespace FacebookDesktop
{
    public partial class SelectFavoritesFolderDialog
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.m_NewFolderButton = new System.Windows.Forms.Button();
            this.m_FavoritesTreeView = new System.Windows.Forms.TreeView();
            this.m_NewFolderNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.okButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // m_NewFolderButton
            // 
            this.m_NewFolderButton.Enabled = false;
            this.m_NewFolderButton.Location = new System.Drawing.Point(135, 275);
            this.m_NewFolderButton.Name = "m_NewFolderButton";
            this.m_NewFolderButton.Size = new System.Drawing.Size(75, 23);
            this.m_NewFolderButton.TabIndex = 2;
            this.m_NewFolderButton.Text = "New Folder";
            this.m_NewFolderButton.UseVisualStyleBackColor = true;
            this.m_NewFolderButton.Click += new System.EventHandler(this.newFolderButton_Click);
            // 
            // m_FavoritesTreeView
            // 
            this.m_FavoritesTreeView.Location = new System.Drawing.Point(12, 12);
            this.m_FavoritesTreeView.Name = "m_FavoritesTreeView";
            this.m_FavoritesTreeView.Size = new System.Drawing.Size(198, 257);
            this.m_FavoritesTreeView.TabIndex = 3;
            // 
            // m_NewFolderNameTextBox
            // 
            this.m_NewFolderNameTextBox.Location = new System.Drawing.Point(12, 275);
            this.m_NewFolderNameTextBox.Name = "m_NewFolderNameTextBox";
            this.m_NewFolderNameTextBox.Size = new System.Drawing.Size(117, 20);
            this.m_NewFolderNameTextBox.TabIndex = 4;
            this.m_NewFolderNameTextBox.TextChanged += new System.EventHandler(this.m_NewFolderNameTextBox_TextChanged);
            // 
            // SelectFavoritesFolderDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 332);
            this.Controls.Add(this.m_NewFolderNameTextBox);
            this.Controls.Add(this.m_FavoritesTreeView);
            this.Controls.Add(this.m_NewFolderButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "SelectFavoritesFolderDialog";
            this.Text = "Select a Favorites Folder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button m_NewFolderButton;
        private System.Windows.Forms.TreeView m_FavoritesTreeView;
        private System.Windows.Forms.TextBox m_NewFolderNameTextBox;
    }
}