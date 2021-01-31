using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;

namespace FacebookDesktop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            // AppId: 817000839081940
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string appID = "817000839081940";
            LoginResult result = FacebookService.Login(
                appID,
                    "public_profile",
                    "email",
                    "user_birthday",
                    "user_age_range",
                    "user_gender",
                    "user_link",
                    "user_tagged_places",
                    "user_videos",
                    "pages_show_list",
                    "user_friends",
                    "user_events",
                    "user_likes",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_hometown",
                    "user_status");

            MainForm mainForm = new MainForm();
            mainForm.LoggedInUser = result.LoggedInUser;
            mainForm.Show();
            mainForm.FormClosed += MainForm_FormClosed;
            this.Hide();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
