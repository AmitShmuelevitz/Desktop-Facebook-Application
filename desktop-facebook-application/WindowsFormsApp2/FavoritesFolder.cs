using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookDesktop
{
    public class FavoritesFolder : FavoritedItem
    {
        public string FolderName
        {
            get
            {
                return m_FolderName;
            }

            set
            {
                m_FolderName = value;
                Text = m_FolderName;
            }
        }

        public override FavoritesFolder Folder
        {
            get
            {
                return this;
            }
        }

        private string m_FolderName;

        public FavoritesFolder AddChildFolder(string i_Name)
        {
            FavoritesFolder child = new FavoritesFolder();
            child.FolderName = i_Name;
            Nodes.Add(child);
            this.ExpandAll();
            return child;
        }

        public void AddChildItem(FavoritedItem i_Item)
        {
            Nodes.Add(i_Item);
        }

        public override void Open(INavigator i_Navigator)
        {
            // Folders have no action
        }
    }
}
