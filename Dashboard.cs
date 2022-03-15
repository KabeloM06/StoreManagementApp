using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagementApp
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(String user)
        {
            InitializeComponent();

            if (user == "Guest")
            {
                btnAddItems.Hide();
                btnRemoveItems.Hide();
                btnEditItems.Hide();
            }
            else if (user == "Admin")
             {
                btnAddItems.Show();
                btnRemoveItems.Show();
                btnEditItems.Show();
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            addItems1.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login ds = new Login();
            ds.Show();
            this.Hide();
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            addItems1.Visible = true;
            addItems1.BringToFront();
        }
    }
}
