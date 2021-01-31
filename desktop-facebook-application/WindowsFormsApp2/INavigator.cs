using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookDesktop
{
    public interface INavigator
    {
        FriendsForm OpenFriendsForm();

        PhotoAlbumsForm OpenPhotoAlbumsForm();

        CheckinsForm OpenCheckinsForm();
    }
}
