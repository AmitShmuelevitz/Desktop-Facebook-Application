using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookDesktop
{
    public abstract class FavoritedItem : TreeNode
    {
        public abstract FavoritesFolder Folder
        {
            get;
        }

        public abstract void Open(INavigator i_Navigator);
    }
}
