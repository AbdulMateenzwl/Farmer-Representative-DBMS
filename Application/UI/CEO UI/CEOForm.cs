﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmer_Representive_Final_Project_DB_.UI.CEO_UI
{
    public partial class CEOForm : Form
    {
        public CEOForm()
        {
            InitializeComponent();
            ceoDashBoardUC1.BringToFront();
        }

        private void btnBecomeManager_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnBecomeManager.Top;
            becomeManagerUC1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnHome.Top;
            ceoDashBoardUC1.BringToFront();
        }

        private void btnApproveManager_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnApproveManager.Top;
            approveRegionHeads1.BringToFront();
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

        private void btnReports_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnReports.Top;
            reports1.BringToFront();
        }
    }
}
