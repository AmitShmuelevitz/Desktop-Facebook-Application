using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktop
{
    public partial class PhotoAlbumsForm : Form
    {
        private Collection<Album> m_Albums;

        public Collection<Album> Albums
        {
            get 
            {
                return m_Albums; 
            }

            set
            {
                m_Albums = value;
            }
        }

        public PhotoAlbumsForm()
        {
            InitializeComponent();
        }

        public Album InitialAlbum { get; set; }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            foreach (Album album in Albums)
            {
                m_AlbumsListBox.Items.Add(album.Name);
                if (InitialAlbum != null && album.Id == InitialAlbum.Id)
                {
                    m_AlbumsListBox.SelectedIndex = m_AlbumsListBox.Items.Count - 1;
                }
            }
        }

        private void PhotoAlbums_Load(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;

            if (listBox.SelectedIndex < 0)
            {
                return;
            }

            Album album = Albums[listBox.SelectedIndex];

            showAlbumPhotos(album.Photos);
        }

        private void showAlbumPhotos(Collection<Photo> photos)
        {
            m_PhotosPanel.Controls.Clear();

            int x = 0;
            int y = 0;

            const int k_photoWidth = 80;
            const int k_photoHeight = 80;

            foreach (Photo photo in photos)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.ImageLocation = photo.PictureThumbURL;
                pictureBox.Tag = photo;
                m_PhotosPanel.Controls.Add(pictureBox);

                pictureBox.Location = new Point(x, y);
                x += k_photoWidth;
                if (x + k_photoWidth > m_PhotosPanel.Width)
                {
                    x = 0;
                    y += k_photoHeight;
                }

                pictureBox.Width = k_photoWidth;
                pictureBox.Height = k_photoHeight;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                pictureBox.Click += photo_Click;

                pictureBox.Show();
            }
        }

        private void photo_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            Photo photo = (Photo)pictureBox.Tag;

            PictureForm pictureForm = new PictureForm();
            pictureForm.Photo = photo;
            pictureForm.ShowDialog(this);
        }

        private void addToFavoritesButton_Click(object sender, EventArgs e)
        {
            if (m_AlbumsListBox.SelectedIndex < 0)
            {
                return;
            }

            Album album = Albums[m_AlbumsListBox.SelectedIndex];

            SelectFavoritesFolderDialog dialog = new SelectFavoritesFolderDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FavoritedAlbum item = new FavoritedAlbum(dialog.SelectedFavoritesFolder);
                item.Album = album;
                dialog.SelectedFavoritesFolder.AddChildItem(item);
                MessageBox.Show(string.Format("Added Album to Favorites Folder: {0}", dialog.SelectedFavoritesFolder.FolderName));
            }
        }
    }
}
