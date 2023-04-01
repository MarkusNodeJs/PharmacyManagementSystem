﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class Pharmacist : Form
    {
        public Pharmacist()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();

        }

        private void btnDasboard_Click(object sender, EventArgs e)
        {
            uC_P_Dashboard1.Visible = true;
            uC_P_Dashboard1.BringToFront();

        }

        private void Pharmacist_Load(object sender, EventArgs e)
        {
            uC_P_Dashboard1.Visible = false;
            uC_P_AddMedicine1.Visible = false;
            uC_P_ViewMedicine1.Visible = false;
            uC_P_ModifyMedicine1.Visible = false;
            uC_P_MedicineValidityCheck1.Visible = false;
            uC_P_SellMedicine1.Visible = false;
            btnDasboard.PerformClick();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            uC_P_AddMedicine1.Visible = true;
            uC_P_AddMedicine1.BringToFront();
        }

        private void uC_P_AddMedicine1_Load(object sender, EventArgs e)
        {

        }

        private void btnViewMedicine_Click(object sender, EventArgs e)
        {
            uC_P_ViewMedicine1.Visible = true;
            uC_P_ViewMedicine1.BringToFront();
        }

        private void txtModifyMedicine_Click(object sender, EventArgs e)
        {
            uC_P_ModifyMedicine1.Visible = true;
            uC_P_ModifyMedicine1.BringToFront();
        }

        private void uC_P_ModifyMedicine1_Load(object sender, EventArgs e)
        {

        }

        private void btnValidityCheck_Click(object sender, EventArgs e)
        {
            uC_P_MedicineValidityCheck1.Visible = true;
            uC_P_MedicineValidityCheck1.BringToFront();
        }

        private void btnSellMedicine_Click(object sender, EventArgs e)
        {
            uC_P_SellMedicine1.Visible = true;
            uC_P_SellMedicine1.BringToFront();
        }
    }
}
