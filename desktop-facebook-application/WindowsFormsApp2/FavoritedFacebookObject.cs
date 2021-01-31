using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookDesktop
{
    public abstract class FavoritedFacebookObject : FavoritedItem
    {
        public FavoritedFacebookObject(FavoritesFolder i_Folder)
        {
            m_Folder = i_Folder;

            this.Text = "FavoritedFacebookObject";
        }

        private FavoritesFolder m_Folder;

        public override FavoritesFolder Folder
        {
            get
            {
                return m_Folder;
            }
        }
    }
}
