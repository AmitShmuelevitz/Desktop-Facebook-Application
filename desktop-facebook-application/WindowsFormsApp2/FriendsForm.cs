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
    public partial class FriendsForm : Form
    {
        private Collection<User> m_Friends;

        public User InitialSelectedFriend { get; set; }

        public Collection<User> Friends
        {
            get
            {
                return m_Friends;
            }

            set
            {
                m_Friends = value;
                userBindingSource.DataSource = m_Friends;

                if (InitialSelectedFriend != null)
                {
                    int position = 0;
                    foreach (User user in userBindingSource)
                    {
                        if (user.Id == InitialSelectedFriend.Id)
                        {
                            userBindingSource.Position = position;
                            break;
                        }

                        position++;
                    }
                }
            }
        }

        public FriendsForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }

        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            // The Facebook API function to send a message is not yet implemented
            MessageBox.Show(m_SendMessageTextBox.Text);
        }

        private void addToFavoritesButton_Click(object sender, EventArgs e)
        {
            SelectFavoritesFolderDialog dialog = new SelectFavoritesFolderDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FavoritedFriend item = new FavoritedFriend(dialog.SelectedFavoritesFolder);
                item.Friend = (User)userBindingSource.Current;
                dialog.SelectedFavoritesFolder.AddChildItem(item);
                MessageBox.Show(string.Format("Added friend to Favorites Folder: {0}", dialog.SelectedFavoritesFolder.FolderName));
            }
        }
    }
}
