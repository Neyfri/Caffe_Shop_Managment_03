using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffe_Shop_Management.All_Controls
{
    public partial class UC_Users : UserControl
    {
        funtions fn = new funtions();
        string query;
        public UC_Users()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to add this new User","Information",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                query = "INSERT INTO users (uname, upassword, user_delete) VALUES('"+txtUsername.Text+"','"+txtpass.Text+"',0)";
                fn.setData(query,"User Added Successfully");
                ClearAll();
            }
        }

        public void ClearAll()
        {
            txtpass.Clear();
            txtUsername.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            query = "SELECT uname,upassword FROM users";
            DataSet ds = fn.getData(query);
            dgvUserDetails.DataSource = ds.Tables[0];
        }
    }
}
