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

namespace Farmer_Representive_Final_Project_DB_.UI.FarmerManagerUI
{
    public partial class FarmerManagerForm : Form
    {
        public FarmerManagerForm()
        {
            InitializeComponent();
            farmerManangerDashBoardUC1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnHome.Top;
            farmerManangerDashBoardUC1.BringToFront();
        }

        private void btnApproveFarmer_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnApproveFarmer.Top;
            approveFarmersUC1.BringToFront();
        }

        private void btnApproveField_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnApproveField.Top;
            approveFieldsUC1.BringToFront();
        }

        private void btnApproveCrops_Click(object sender, EventArgs e)
        {
            sidePanel.Top= btnApproveCrops.Top;
            approveCropsUC1.BringToFront();
        }

        private void btnViewWearhouseCrop_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnViewWearhouseCrop.Top;
            viewWearHouseCropUC1.BringToFront();
        }

        private void btnViewFarmerFields_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnViewFarmerFields.Top;
            viewFarmerFieldUC1.BringToFront();
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

        private void FarmerManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnReports.Top;
            reports1.BringToFront();
        }
    }
}
