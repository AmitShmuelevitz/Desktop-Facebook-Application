using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktop
{
    public class HometownMap
    {
        private City m_City;

        public City City
        {
            get
            {
                return m_City;
            }

            set
            {
                m_City = value;
            }
        }

        public void OpenMap()
        {
            if (City == null)
            {
                MessageBox.Show("Your profile doesn't have a Hometown" + Environment.NewLine + "I Will show you a map of Herzliya Israel instead", "Missing Hometown", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                openMapLocationString("Herzliya, Israel");
            }
            else
            {
                MessageBox.Show(string.Format("I Will show you a map of {0}", City.Name), "Hometown Map", MessageBoxButtons.OK, MessageBoxIcon.Information);
                openMapLocationString(City.Name);
            }
        }

        private string buildGoogleMapsUrl(string location)
        {
            return "https://www.google.com/maps/search/?api=1&query=" + Uri.EscapeUriString(location);
        }

        private void openMapLocationString(string location)
        {
            string url = buildGoogleMapsUrl(location);
            System.Diagnostics.Process.Start(url);
        }
    }
}
