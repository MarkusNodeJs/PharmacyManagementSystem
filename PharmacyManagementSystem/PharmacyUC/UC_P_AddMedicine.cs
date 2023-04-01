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
    public partial class UC_P_AddMedicine : UserControl
    {
        function fn = new function();
        String query;
        public UC_P_AddMedicine()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMedicineId.Text != "" && txtMedicineName.Text != "" && TxtQuantity.Text != "" && txtPricePerUnit.Text != "")
            {
                String mid = txtMedicineId.Text;
                String mname = txtMedicineName.Text;
                String mnumber = txtMedicineNumber.Text;
                String mdate = txtManufacturingDate.Text;
                String edate = txtExpireDate.Text;
                Int64 quantity = Int64.Parse(TxtQuantity.Text);
                Int64 perunit = Int64.Parse(txtPricePerUnit.Text);

                query = "Insert into medic(mid,mname,mnumber,mdate,edate,quantity,perUnit) values ('"+mid+ "','" +mname+ "','" +mnumber+ "','" +mdate+ "','" +edate+ "'," +quantity+ "," +perunit+ ")";
                fn.setData(query, "Medicine Added to Database");



            }
            else
            {
                MessageBox.Show("Enter all Data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtMedicineId.Clear();
            txtMedicineName.Clear();
            txtMedicineNumber.Clear();
            txtManufacturingDate.ResetText();
            txtExpireDate.ResetText();
            TxtQuantity.Clear();
            txtPricePerUnit.Clear();
        }
    }
}
