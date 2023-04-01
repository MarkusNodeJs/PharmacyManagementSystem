using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem.PharmacyUC
{
    public partial class UC_P_ModifyMedicine : UserControl
    {
        function fn = new function();
        String query;
        public UC_P_ModifyMedicine()
        {
            InitializeComponent();
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtMedicineId.Text != "")
            {
                query = "select * from medic where mid  = '" + txtMedicineId.Text + "'";
                DataSet ds = fn.getData(query);
                if(ds.Tables[0].Rows.Count != 0)
                {
                    txtMedicineName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtMedicineNumber.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtManufacturingDate.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtExpiryDate.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtPrice.Text = ds.Tables[0].Rows[0][7].ToString();
                }
                else
                {
                    MessageBox.Show("No Medicine with ID: " + txtMedicineId.Text + " exist.", "info", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                clearAll();
            }
        }
        private void clearAll()
        {
            txtMedicineId.Clear();
            txtMedicineName.Clear();
            txtMedicineNumber.Clear();
            txtManufacturingDate.ResetText();
            txtExpiryDate.ResetText();
            txtQuantity.Clear();
            txtPrice.Clear();
            if(txtAddQuantity.Text != "0")
            {
                txtAddQuantity.Text = "0";
            }
            else
            {
                txtAddQuantity.Text = "0";
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        Int64 totalQuantity;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String mid = txtMedicineId.Text;
            String mname = txtMedicineName.Text;
            String mnumber = txtMedicineNumber.Text;
            String mdate = txtManufacturingDate.Text;
            String edate = txtExpiryDate.Text;
            Int64 quantity = Int64.Parse(txtQuantity.Text);
            Int64 AddQuantity = Int64.Parse(txtAddQuantity.Text);
            Int64 unitprice = Int64.Parse(txtPrice.Text);

            totalQuantity = quantity + AddQuantity;

            query = "update medic set mid ='" + mid + "',mname ='" + mname+ "',mnumber ='" + mnumber + "',mdate ='" + mdate + "',edate ='" + edate + "',quantity =" + totalQuantity + ",perUnit =" + unitprice + " where mid = '"+txtMedicineId.Text+"'";
            fn.setData(query, "Medicine details updated.");


        }
    }
}
