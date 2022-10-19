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
    public partial class UC_SalesReport : UserControl
    {
        funtions fn = new funtions();
        string query;
        public UC_SalesReport()
        {
            InitializeComponent();
        }

        private void UC_SalesReport_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM coffes";
            DataSet ds = fn.getData(query);
            dgvSalesReport.DataSource = ds.Tables[0];
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void dgvSalesReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblSid.Text = dgvSalesReport.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
