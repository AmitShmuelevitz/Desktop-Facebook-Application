using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktop
{
    public class FavoritedPhoto : FavoritedFacebookObject
    {
        public FavoritedPhoto(FavoritesFolder i_Folder) : base(i_Folder)
        {
        }

        public Photo Photo
        {
            get
            {
                return m_Photo;
            }

            set
            {
                m_Photo = value;
                if (m_Photo.Name == null || m_Photo.Name == string.Empty)
                {
                    Text = "Unnamed Photo";
                }
                else
                {
                    Text = m_Photo.Name;
                }
            }
        }

        private Photo m_Photo;

        public override void Open(INavigator i_Navigator)
        {
            PictureForm form = new PictureForm();
            form.Photo = Photo;
            form.ShowDialog();
        }
    }
}
