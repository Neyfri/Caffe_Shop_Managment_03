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
            if (txtpass.Text !="" && txtUsername.Text !="")
            {
                if (MessageBox.Show("Are you sure you want to add this new User", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    query = "INSERT INTO users (uname, upassword, user_delete) VALUES('" + txtUsername.Text + "','" + txtpass.Text + "',0)";
                    fn.setData(query, "User Added Successfully");
                    ClearAll();
                }
            }
            else
            {
                MessageBox.Show("Fill All Fields","Attention!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }


        public void getUsers(DataGridView dgv)
        {
            query = "SELECT * FROM users";
            DataSet ds = fn.getData(query);
            dgv.DataSource = ds.Tables[0];
        }

        private void UC_Users_Load(object sender, EventArgs e)
        {
            getUsers(dgvUserDetails);
            getUsers(dgvUDelete);
        }

        private void txtSearhById_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM users WHERE id LIKE '"+txtSearhById.Text+"%'";
            DataSet ds = fn.getData(query);
            dgvUDelete.DataSource = ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtSearhById.Text != "")
            {
                if (MessageBox.Show("Are Sure that you want delete this User?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    query = "DELETE FROM users WHERE id LIKE '" + txtSearhById.Text + "'";
                    fn.setData(query, "User Deleted Successfully");
                }
            }
            else
            {
                MessageBox.Show("Fill All Fields","Warning!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
        public void ClearAll()
        {
            txtpass.Clear();
            txtUsername.Clear();
            txtSearhById.Clear();
            txtSearhByname.Clear();
        }

        private void txtSearhByname_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM users WHERE uname LIKE '" + txtSearhByname.Text + "%'";
            DataSet ds = fn.getData(query);
            dgvUserDetails.DataSource = ds.Tables[0];
        }

        private void dgvUDelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSearhById.Text = dgvUDelete.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
