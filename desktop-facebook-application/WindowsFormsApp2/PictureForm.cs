using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktop
{
    public partial class PictureForm : Form
    {
        private Photo m_Photo;

        public Photo Photo
        {
            get
            {
                return m_Photo;
            }

            set
            {
                m_Photo = value;
                m_PictureBox.ImageLocation = m_Photo.PictureNormalURL;
            }
        }

        public PictureForm()
        {
            InitializeComponent();
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            savePicture();
        }

        private void savePicture()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image|*.jpg";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                m_PictureBox.Image.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                MessageBox.Show(string.Format("Saved to file: {0}", saveFileDialog.FileName));
            }
        }

        private void addToFavoritesButton_Click(object sender, EventArgs e)
        {
            SelectFavoritesFolderDialog dialog = new SelectFavoritesFolderDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FavoritedPhoto item = new FavoritedPhoto(dialog.SelectedFavoritesFolder);
                item.Photo = Photo;
                dialog.SelectedFavoritesFolder.AddChildItem(item);
                MessageBox.Show(string.Format("Added photo to Favorites Folder: {0}", dialog.SelectedFavoritesFolder.FolderName));
            }
        }
    }
}
