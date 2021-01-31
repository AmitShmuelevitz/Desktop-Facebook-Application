using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookDesktop
{
    public class FavoritesSingleton
    {
        private FavoritesSingleton()
        {
            Root = new FavoritesFolder();
            Root.FolderName = "Favorites";
        }

        public static FavoritesSingleton Instance
        {
            get
            {
                // Simple Singleton - Not Thread Safe (Used only from the Main thread)
                if (m_Instance == null)
                {
                    m_Instance = new FavoritesSingleton();
                }

                return m_Instance;
            }
        }

        public FavoritesFolder Root { get; set; }

        private static FavoritesSingleton m_Instance = null;
    }
}
