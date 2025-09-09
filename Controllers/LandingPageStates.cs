using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Evende.Controllers
{
    internal class LandingPageStates
    {
        public static Dictionary<string, UserControl> states = new Dictionary<string, UserControl>()
        {
            { "login", new Login(){ Dock = DockStyle.Fill }},
            { "register", new Register() { Dock = DockStyle.Fill } },
            { "landing", new Landing() { Dock = DockStyle.Fill } },
            { "back", new Landing(){ Dock = DockStyle.Fill } },
        };

        public static string panelName = "";
        public UserControl SetStates(string className)
        {
            if (states.ContainsKey(className))
            {
                Console.WriteLine($"Found: {className}");
                return states[className];
            }

            Console.WriteLine($"Not found: {className}");
            return null;
        }


    }
}
