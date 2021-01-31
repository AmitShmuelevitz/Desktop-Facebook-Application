using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookDesktop
{
    public partial class SelectFavoritesFolderDialog : Form
    {
        public SelectFavoritesFolderDialog()
        {
            InitializeComponent();
        }

        public FavoritesFolder SelectedFavoritesFolder { get; set; }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            m_FavoritesTreeView.Nodes.Add(FavoritesSingleton.Instance.Root);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            m_FavoritesTreeView.Nodes.Clear();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            FavoritedItem item = (FavoritedItem)m_FavoritesTreeView.SelectedNode;
            if (item == null)
            {
                item = (FavoritedItem)m_FavoritesTreeView.Nodes[0];
            }

            FavoritesFolder folder = item.Folder;

            SelectedFavoritesFolder = folder;
            DialogResult = DialogResult.OK;
        }

        private void newFolderButton_Click(object sender, EventArgs e)
        {
            FavoritedItem item = (FavoritedItem)m_FavoritesTreeView.SelectedNode;
            if (item == null)
            {
                item = (FavoritedItem)m_FavoritesTreeView.Nodes[0];
            }

            FavoritesFolder folder = item.Folder;

            FavoritesFolder child = folder.AddChildFolder(m_NewFolderNameTextBox.Text);
            m_FavoritesTreeView.SelectedNode = child;

            m_NewFolderNameTextBox.Text = string.Empty;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void m_NewFolderNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (m_NewFolderNameTextBox.Text == string.Empty)
            {
                m_NewFolderButton.Enabled = false;
            }
            else
            {
                m_NewFolderButton.Enabled = true;
            }
        }
    }
}
