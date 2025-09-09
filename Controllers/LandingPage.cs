using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evende.Controllers
{
    public partial class landingPage_form : Form
    {
        public landingPage_form()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            landingPage_panel.Controls.Clear();
            Login login = new Login();
            login.Dock = DockStyle.Fill;
            landingPage_panel.Controls.Add(login);
        }

        private void register_button_Click(object sender, EventArgs e)
        {

        }

        private void landingPage_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
