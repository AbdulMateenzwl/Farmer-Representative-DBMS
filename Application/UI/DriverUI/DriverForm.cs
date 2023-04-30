using Farmer_Representive_Final_Project_DB_.UI.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmer_Representive_Final_Project_DB_.UI.DriverUI
{
    public partial class DriverForm : Form
    {
        public DriverForm()
        {
            InitializeComponent();
            dashBoard1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnHome.Top;
            dashBoard1.BringToFront();
        }

        private void btnManageVehicle_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnManageVehicle.Top;
            vehicleCrud1.BringToFront();

        }

        private void btnWallet_Click(object sender, EventArgs e)
        {
            sidePanel.Top= btnWallet.Top;
            walletPnl1.BringToFront();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnSettings.Top;
            changeAccount1.BringToFront();
        }

        private void closeBtnFarmer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maxBtnDriver_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void minBtnDriver_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnManageDelivery_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnManageDelivery.Top;
            deliveries1.BringToFront();
        }

        private void btnSubscription_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnSubscription.Top;
            subscription1.BringToFront();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnReports.Top;
            reports1.BringToFront();
        }
    }
}
