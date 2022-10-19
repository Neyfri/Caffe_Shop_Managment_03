using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Coffe_Shop_Management.All_Controls
{
    public partial class UC_Shop : UserControl
    {
        funtions fn = new funtions();
        string query;
        public UC_Shop()
        {
            InitializeComponent();
        }

        private void UC_Shop_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM coffes";
            DataSet ds = fn.getData(query);
            dgvCoffe.DataSource = ds.Tables[0];
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (txtCoffeName.Text != "" && txtCoffePrice.Text != "" && txtCoffeQty.Text != "" && txtCoffeType.Text != "")
            {
                string name = txtCoffeName.Text;
                string price = txtCoffePrice.Text;
                string type = txtCoffeType.Text;
                string qty = txtCoffeQty.Text;
                query = "INSERT INTO coffes (name,coffeTypeid,qty,price,del) VALUES('" + name + "','" + type + "','" + qty + "','" + price + "',0)";
                fn.setData(query, "Coffe Added");
                ClearAll();
                UC_Shop_Load(this, null);
            }
            else
            {
                MessageBox.Show("Fill all Fields.", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ClearAll()
        {
            txtCoffePrice.Clear();
            txtCoffeName.Clear();
            txtCoffeQty.Clear();
            txtCoffeType.ResetText();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are Sure that you want delete this Coffe Record?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                query = "DELETE FROM coffes WHERE id LIKE '" + txtCoffeId.Text + "'";
                fn.setData(query, "Coffe Record Deleted Successfully");
                UC_Shop_Load(this, null);
            }
        }

        private void dgvCoffe_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtCoffeId.Text = dgvCoffe.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void txtCoffePrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTotal.Text = (int.Parse(txtCoffeQty.Text) * int.Parse(txtCoffePrice.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
