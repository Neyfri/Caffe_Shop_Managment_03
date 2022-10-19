using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffe_Shop_Management
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you really want to exit?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            pnmove.Left = btnShop.Left + 24;
            uC_Shop1.Visible = true;
            uC_Shop1.BringToFront();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            pnmove.Left = btnUser.Left + 25;
            uC_Users1.Visible = true;
            uC_Users1.BringToFront();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            pnmove.Left = btnDetails.Left + 25;
            uC_ShopDetails1.Visible = true;
            uC_ShopDetails1.BringToFront();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_Users1.Visible = false;
            uC_ShopDetails1.Visible = false;
        }
    }
}
