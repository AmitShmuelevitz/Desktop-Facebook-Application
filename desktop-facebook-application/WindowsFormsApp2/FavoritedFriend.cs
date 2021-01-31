using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktop
{
    public class FavoritedFriend : FavoritedFacebookObject
    {
        public FavoritedFriend(FavoritesFolder i_Folder) : base(i_Folder)
        {
        }

        public User Friend
        {
            get
            {
                return m_Friend;
            }

            set
            {
                m_Friend = value;
                Text = m_Friend.Name;
            }
        }

        private User m_Friend;

        public override void Open(INavigator i_Navigator)
        {
            FriendsForm friendsForm = i_Navigator.OpenFriendsForm();

            friendsForm.InitialSelectedFriend = Friend;
        }
    }
}
