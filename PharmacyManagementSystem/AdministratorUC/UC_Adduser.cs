using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem.AdministratorUC
{
    public partial class UC_Adduser : UserControl
    {
        function fn = new function();
        String query;

        public UC_Adduser()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtName.Clear();
            txtDob.ResetText();
            txtMobleNo.Clear();
            txtEmail.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserRole.SelectedIndex = -1;
        }
        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            String role = txtUserRole.Text;
            String name = txtName.Text;
            String dob = txtDob.Text;
            Int64 mobile = Int64.Parse(txtMobleNo.Text);
            String email = txtEmail.Text;
            String username = txtUserName.Text;
            String pass = txtPassword.Text;


            try
            {
                query = "insert into users (userRole,name,dob,mobile,email,username,password) values ('"+role+"','"+name+"','"+dob+"',"+mobile+",'"+email+"','"+username+ "','"+pass+"')";
                fn.setData(query, "Sign Up Successful");

            }
            catch (Exception)
            {
                MessageBox.Show("Username Already exist.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username = '"+txtUserName.Text+"'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                pictureBox1.ImageLocation = @"C:\Users\MarKusTech\source\repos\PharmacyManagementSystem\icon\yes.png";

            }
            else
            {
                pictureBox1.ImageLocation = @"C:\Users\MarKusTech\source\repos\PharmacyManagementSystem\icon\no.png";
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
