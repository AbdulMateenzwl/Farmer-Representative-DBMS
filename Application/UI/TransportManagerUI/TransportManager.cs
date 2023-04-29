using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmer_Representive_Final_Project_DB_.UI.FarmerManagerUI
{
    public partial class TransportManager : Form
    {
        public TransportManager()
        {
            InitializeComponent();
        }

        private void btnManageCrops_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnApproveVehicle.Top;
            approve_Vehicle1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnHome.Top;
            farmerManagerDashBoard2.BringToFront();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnSettings.Top;
            changeAccount1.BringToFront();
        }

        private void btnApproveDriver_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnApproveDriver.Top;
            approveDrivers1.BringToFront();
        }

        private void btnViewDriverVehicle_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnViewDriverVehicle.Top;
            view_Drivers_and_Vehicles1.BringToFront();
        }

        private void btnViewDriverDelivery_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnViewDriverDelivery.Top;
            view_Drivers_and_Deliveries1.BringToFront();
        }

        private void btnAssignDriverTask_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnAssignDriverTask.Top;
            assign_Delivery_To_Driver1.BringToFront();
        }

        private void btnWallet_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnWallet.Top;
            walletPnl1.BringToFront();
        }

        private void closeBtnFarmer_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
