using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmer_Representive_Final_Project_DB_.UI.OrganisationManagerUI
{
    public partial class OrganisationManagerForm : Form
    {
        public OrganisationManagerForm()
        {
            InitializeComponent();
            organizationManagerDashBoardUC1.BringToFront();
        }

        private void btnApproveOrganization_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnApproveOrganization.Top;
            approveOrganzationUC1.BringToFront();
        }

        private void btnApproveOrders_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnApproveOrders.Top;
            approveOrdersUC1.BringToFront();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnViewOrders.Top;
            viewOrganizationOrdersUC1.BringToFront();
        }

        private void btnWallet_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnWallet.Top;
            walletPnl1.BringToFront();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnSettings.Top;
            changeAccount1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnHome.Top;
            organizationManagerDashBoardUC1.BringToFront();
        }

        private void maxBtnFarmer_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void minBtnFarmer_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeBtnFarmer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
