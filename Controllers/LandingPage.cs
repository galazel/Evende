using Krypton.Toolkit;
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
    public partial class LandingPage : Form
    {
        
        public LandingPage()
        {
            InitializeComponent();
            SetSplitPanel();
        }
        public void SetSplitPanel()
        {
           landingPage_split.Panel2.Controls.Clear();
           landingPage_split.Panel2.Controls.Add(new LandingPageStates().SetStates(LandingPageStates.panelName));
        }

    }
}
