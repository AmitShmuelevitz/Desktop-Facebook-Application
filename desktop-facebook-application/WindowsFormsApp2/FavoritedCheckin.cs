using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktop
{
    public class FavoritedCheckin : FavoritedFacebookObject
    {
        public FavoritedCheckin(FavoritesFolder i_Folder) : base(i_Folder)
        {
        }

        public Checkin Checkin
        {
            get
            {
                return m_Checkin;
            }

            set
            {
                m_Checkin = value;
                Text = m_Checkin.Name;
            }
        }

        private Checkin m_Checkin;

        public override void Open(INavigator i_Navigator)
        {
            CheckinsForm checkinsForm = i_Navigator.OpenCheckinsForm();

            checkinsForm.InitialSelectedCheckin = Checkin;
        }
    }
}
