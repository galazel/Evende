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
    public partial class GetStarted : Form
    {

        public GetStarted()
        {
            InitializeComponent();
        }
        private void getStarted_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            LandingPageStates.panelName = "landing";
            new LandingPage().Show();
        }
    }
}
