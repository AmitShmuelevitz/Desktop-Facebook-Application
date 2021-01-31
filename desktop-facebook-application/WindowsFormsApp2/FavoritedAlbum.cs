using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktop
{
    public class FavoritedAlbum : FavoritedFacebookObject
    {
        public FavoritedAlbum(FavoritesFolder i_Folder) : base(i_Folder)
        {
        }

        public Album Album
        {
            get
            {
                return m_Album;
            }

            set
            {
                m_Album = value;
                if (m_Album.Name == null || m_Album.Name == string.Empty)
                {
                    Text = "Unnamed Album";
                }
                else
                {
                    Text = m_Album.Name;
                }
            }
        }

        private Album m_Album;

        public override void Open(INavigator i_Navigator)
        {
            PhotoAlbumsForm form = i_Navigator.OpenPhotoAlbumsForm();

            form.InitialAlbum = Album;
        }
    }
}
