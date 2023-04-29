using Farmer_Representive_Final_Project_DB_.UI.CEO_UI;
using Farmer_Representive_Final_Project_DB_.UI.Components;
using Farmer_Representive_Final_Project_DB_.UI.DriverUI;
using Farmer_Representive_Final_Project_DB_.UI.FarmerManagerUI;
using Farmer_Representive_Final_Project_DB_.UI.FarmerUI;
using Farmer_Representive_Final_Project_DB_.UI.OrganisationManagerUI;
using Farmer_Representive_Final_Project_DB_.UI.OrganizationUI;
using Farmer_Representive_Final_Project_DB_.UI.RegionHeadUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmer_Representive_Final_Project_DB_
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OrganizationSignUpForm());
        }
    }
}
