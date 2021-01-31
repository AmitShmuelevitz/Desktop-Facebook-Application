using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookDesktop
{
    public class MenuButton : Button
    {
        public void openForm(Form form)
        {
            this.Enabled = false;
            form.Show();
            form.FormClosed += Form_FormClosed;
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Enabled = true;
        }
    }
}
