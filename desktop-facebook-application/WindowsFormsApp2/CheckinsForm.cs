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
    public partial class CheckinsForm : Form
    {
        private Collection<Checkin> m_Checkins;

        public Collection<Checkin> Checkins
        {
            get
            {
                return m_Checkins;
            }

            set
            {
                m_Checkins = value;
                checkinBindingSource.DataSource = m_Checkins;
                LoadingData = false;

                if (checkinBindingSource.Count > 0)
                {
                    m_AddFavoritesButton.Enabled = true;
                }

                if (InitialSelectedCheckin != null)
                {
                    int position = 0;
                    foreach (Checkin checkin in checkinBindingSource)
                    {
                        if (checkin.Id == InitialSelectedCheckin.Id)
                        {
                            checkinBindingSource.Position = position;
                            break;
                        }

                        position++;
                    }
                }
            }
        }

        public bool LoadingData
        {
            get
            {
                return m_ProgressBar.Visible;
            }

            set
            {
                m_ProgressBar.Visible = value;
            }
        }

        public Checkin InitialSelectedCheckin { get; set; }

        public CheckinsForm()
        {
            InitializeComponent();
        }

        private void m_CheckinsListBox_Format(object sender, ListControlConvertEventArgs e)
        {
            Checkin checkin = (Checkin)e.ListItem;
            e.Value = string.Format("{0} {1}", checkin.CreatedTime, checkin.Name);
        }

        private void addToFavoritesButton_Click(object sender, EventArgs e)
        {
            SelectFavoritesFolderDialog dialog = new SelectFavoritesFolderDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FavoritedCheckin item = new FavoritedCheckin(dialog.SelectedFavoritesFolder);
                item.Checkin = (Checkin)checkinBindingSource.Current;
                dialog.SelectedFavoritesFolder.AddChildItem(item);
                MessageBox.Show(string.Format("Added Checkin to Favorites Folder: {0}", dialog.SelectedFavoritesFolder.FolderName));
            }
        }
    }
}
