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
    public partial class FRM_Login : Form
    {
        funtions fn = new funtions();
        string query;
        public FRM_Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPass.Text != "")
            {
                query = "SELECT uname, upassword FROM users WHERE uname LIKE '"+txtUsername.Text+"' AND upassword LIKE '"+txtPass.Text+"' AND user_delete = 0";
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lblwrong.Visible = false;
                    Dashboard dashboard = new Dashboard();
                    this.Hide();
                    dashboard.Show();
                }
                else
                {
                    lblwrong.Visible = true;
                    txtPass.Clear();
                }

            }
            else
            {
                MessageBox.Show("Fill All Fields","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void FRM_Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
