using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmer_Representive_Final_Project_DB_.UI.OrganizationUI
{
    public partial class OrganizationForm : Form
    {
        public OrganizationForm()
        {
            InitializeComponent();
            organizationDashBoardUC1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnHome.Top;
            organizationDashBoardUC1.BringToFront();
        }

        private void btnSendOrderRequests_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnSendOrderRequests.Top;
            sendOrderRequestUC1.BringToFront();
        }

        private void btnViewWearhouseCrop_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnViewWearhouseCrop.Top;
            viewWearHouseCropUC1.BringToFront();
        }

        private void btnViewOrderStatus_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnViewOrderStatus.Top;
            viewOrdersStatus1.BringToFront();
        }

        private void btnWallet_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnWallet.Top;
            walletPnl1.BringToFront();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnSendOrderRequests.Top;
            changeAccount1.BringToFront();
        }

        private void maxBtnFarmer_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void closeBtnFarmer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minBtnFarmer_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
