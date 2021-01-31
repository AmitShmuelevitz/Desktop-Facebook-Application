using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktop
{
    public class MainFormNavigator : INavigator
    {
        public TreeView FavoritesTreeView { get; set; }

        public User LoggedInUser { get; set; }

        public FriendsForm OpenFriendsForm()
        {
            FriendsForm friendsForm = new FriendsForm();
            openForm(friendsForm);

            new Thread(() =>
            {
                // Load friends:
                Collection<User> friends = LoggedInUser.Friends;

                // Invoke UI thread to show the friends
                friendsForm.Invoke(new Action(() =>
                    friendsForm.Friends = friends));
            }).Start();

            return friendsForm;
        }

        public PhotoAlbumsForm OpenPhotoAlbumsForm()
        {
            PhotoAlbumsForm photoAlbumsForm = new PhotoAlbumsForm();
            photoAlbumsForm.Albums = LoggedInUser.Albums;
            openForm(photoAlbumsForm);

            return photoAlbumsForm;
        }

        public CheckinsForm OpenCheckinsForm()
        {
            CheckinsForm checkinsForm = new CheckinsForm();
            checkinsForm.LoadingData = true;
            openForm(checkinsForm);

            new Thread(() =>
            {
                // Load checkins:
                Collection<Checkin> checkins = LoggedInUser.Checkins;

                // Invoke UI thread to show the checkins
                checkinsForm.Invoke(new Action(() =>
                    checkinsForm.Checkins = checkins));
            }).Start();

            return checkinsForm;
        }

        private void openForm(Form i_Form)
        {
            if (FavoritesTreeView != null)
            {
                FavoritesTreeView.Nodes.Clear();
            }

            i_Form.Show();
            i_Form.FormClosed += Form_FormClosed;
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FavoritesTreeView != null)
            {
                FavoritesTreeView.Nodes.Add(FavoritesSingleton.Instance.Root);
                FavoritesTreeView.ExpandAll();
            }
        }
    }
}
