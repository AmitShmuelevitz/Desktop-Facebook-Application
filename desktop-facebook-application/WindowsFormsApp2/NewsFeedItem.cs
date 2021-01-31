using System;
using System.Collections.Generic;
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
    public partial class NewsFeedItem : UserControl
    {
        private Post m_Post;

        public Post Post
        {
            get
            {
                return m_Post;
            }

            set
            {
                m_Post = value;
                m_IconPictureBox.ImageLocation = m_Post.IconURL;
                m_TypeLabel.Text = m_Post.Type.ToString();
                m_CreatedAtLabel.Text = m_Post.CreatedTime.ToString();
                m_NameLabel.Text = m_Post.Name;
                m_PictureBox.ImageLocation = m_Post.PictureURL;
                m_MessageLabel.Text = m_Post.Message;
                m_CaptionLabel.Text = m_Post.Caption;
            }
        }

        public NewsFeedItem()
        {
            InitializeComponent();
        }
    }
}
