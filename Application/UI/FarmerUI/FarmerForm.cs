﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmer_Representive_Final_Project_DB_
{
    public partial class userControlFarmerPanel : Form
    {
        public userControlFarmerPanel()
        {
            InitializeComponent();
            dashBoard1.BringToFront();

        }

        private void maxBtnFarmer_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void btnMngPpl_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnManageField.Top;
            fieldCrud1.BringToFront();
        }

        private void panelMainMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnWallet.Top;
            walletPnl1.BringToFront();
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnManageCrops.Top;
            cropsCrud1.BringToFront();
        }

        private void panelManagePpl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnManageAdvisor_Click(object sender, EventArgs e)
        {

        }

        private void ManageStudent_Click(object sender, EventArgs e)
        {

        }

        private void sidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnHome.Top;
            dashBoard1.BringToFront();

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void maxBtnFamer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeBtnFarmer_Click(object sender, EventArgs e)
        {

        }

        private void minBtnFarmer_Click(object sender, EventArgs e)
        {

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnSettings.Top;
            changeAccount1.BringToFront();
        }
    }
}
