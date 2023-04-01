using System;
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
    public partial class Administrator : Form
    {
        String user = "";
        public Administrator()
        {
            InitializeComponent();
        }
        public string ID
        {
            get { return user.ToString(); }
        }
        public Administrator(String username)
        {
            InitializeComponent();
            UserLabel.Text = username;
            user = username;
            uC_ViewUser2.ID = ID;
            uC_profile1.ID = ID;

        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = true;
            uC_Dashboard1.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            uC_ViewUser2.Visible = true;
            uC_ViewUser2.BringToFront();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = false;
            uC_Adduser1.Visible = false;
            uC_ViewUser2.Visible = false;
            uC_profile1.Visible = false;
            btnDasboard.PerformClick();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            uC_profile1.Visible = true;
            uC_profile1.BringToFront();
        }

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            uC_Adduser1.Visible = true;
            uC_Adduser1.BringToFront();
        }

        private void uC_ViewUser2_Load(object sender, EventArgs e)
        {

        }
    }
}
