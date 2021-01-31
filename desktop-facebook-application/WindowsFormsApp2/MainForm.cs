using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private User m_LoggedInUser;

        public User LoggedInUser
        {
            get 
            { 
                return m_LoggedInUser;
            }

            set
            {
                m_LoggedInUser = value; 
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            m_MainFormNavigator = new MainFormNavigator();
            m_MainFormNavigator.FavoritesTreeView = m_FavoritesTreeView;
            m_MainFormNavigator.LoggedInUser = LoggedInUser;

            m_FavoritesTreeView.Nodes.Add(FavoritesSingleton.Instance.Root);

            m_FirstNameLabel.Text = LoggedInUser.FirstName;
            m_LastNameLabel.Text = LoggedInUser.LastName;
            m_ProfilePicture.ImageLocation = LoggedInUser.PictureSmallURL;
            m_BirthdayLabel.Text = LoggedInUser.Birthday;
            m_GenderLabel.Text = LoggedInUser.Gender.ToString();
            m_EmailLabel.Text = LoggedInUser.Email;
            m_HometownLabel.Text = LoggedInUser.Hometown == null ? string.Empty : LoggedInUser.Hometown.Name;

            m_LanguagesLabel.Text = string.Empty;
            if (LoggedInUser.Languages != null)
            {
                foreach (Page language in LoggedInUser.Languages)
                {
                    m_LanguagesLabel.Text += " " + language.Name;
                }
            }

            m_ReligionLabel.Text = LoggedInUser.Religion;

            m_EducationsLabel.Text = string.Empty;
            if (LoggedInUser.Educations != null)
            {
                foreach (Education education in LoggedInUser.Educations)
                {
                    m_EducationsLabel.Text += " " + education.Type;
                }
            }

            m_WorkExperiencesLabel.Text = string.Empty;
            if (LoggedInUser.WorkExperiences != null)
            {
                foreach (WorkExperience workExperience in LoggedInUser.WorkExperiences)
                {
                    m_WorkExperiencesLabel.Text += " " + workExperience.Description;
                }
            }

            populateNewsFeed();
        }

        private MainFormNavigator m_MainFormNavigator;

        private void postPhotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg;*.jpeg;*.jpe;*.jfif;*.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    LoggedInUser.PostPhoto(fileDialog.FileName);
                } 
                catch (FacebookOAuthException exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void populateNewsFeed()
        {
            m_NewsFeedPanel.Controls.Clear();

            int y = 0;
            foreach (Post post in LoggedInUser.NewsFeed)
            {
                NewsFeedItem newsFeedItem = new NewsFeedItem();
                newsFeedItem.Post = post;
                m_NewsFeedPanel.Controls.Add(newsFeedItem);
                newsFeedItem.Location = new Point(0, y);
                y += newsFeedItem.Size.Height;
                newsFeedItem.Show();
            }
        }

        private void photosButton_Click(object sender, EventArgs e)
        {
            m_MainFormNavigator.OpenPhotoAlbumsForm();
        }

        private void friendsButton_Click(object sender, EventArgs e)
        {
            m_MainFormNavigator.OpenFriendsForm();
        }

        private void checkinsButton_Click(object sender, EventArgs e)
        {
            m_MainFormNavigator.OpenCheckinsForm();
        }

        private void photoGuessingGameButton_Click(object sender, EventArgs e)
        {
            MenuButton menuButton = (MenuButton)sender;

            PhotoGuessingGame photoGuessingGame = new PhotoGuessingGame();
            photoGuessingGame.Builder = new FormGuessingGameBuilder();
            photoGuessingGame.Albums = LoggedInUser.Albums;
            Form form = (Form)photoGuessingGame.Construct();

            menuButton.openForm(form);
        }

        private void friendAgeGuessingGameButton_Click(object sender, EventArgs e)
        {
            MenuButton menuButton = (MenuButton)sender;

            FriendAgeGuessingGame friendAgeGuessingGame = new FriendAgeGuessingGame();
            friendAgeGuessingGame.Builder = new FormGuessingGameBuilder();
            friendAgeGuessingGame.LoggedInUser = LoggedInUser;
            friendAgeGuessingGame.Friends = LoggedInUser.Friends;
            Form form = (Form)friendAgeGuessingGame.Construct();

            menuButton.openForm(form);
        }

        private void friendHometownGuessingGameButton_Click(object sender, EventArgs e)
        {
            MenuButton menuButton = (MenuButton)sender;

            FriendHometownGuessingGame friendHometownGuessingGame = new FriendHometownGuessingGame();
            friendHometownGuessingGame.Builder = new FormGuessingGameBuilder();
            friendHometownGuessingGame.LoggedInUser = LoggedInUser;
            friendHometownGuessingGame.Friends = LoggedInUser.Friends;
            Form form = (Form)friendHometownGuessingGame.Construct();

            menuButton.openForm(form);
        }

        private void hometownMapButton_Click(object sender, EventArgs e)
        {
            HometownMap hometownMap = new HometownMap();
            hometownMap.City = LoggedInUser.Hometown;
            hometownMap.OpenMap();
        }

        private void m_FavoritesTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            FavoritedItem item = (FavoritedItem)e.Node;
            item.Open(m_MainFormNavigator);
        }
    }
}
