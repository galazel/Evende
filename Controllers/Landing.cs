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
    public partial class Landing : UserControl
    {
        public Landing()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            LandingPageStates.panelName = "login";
            ((LandingPage)this.ParentForm).SetSplitPanel();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            LandingPageStates.panelName = "register";
            ((LandingPage)this.ParentForm).SetSplitPanel();
        }

    }
}
