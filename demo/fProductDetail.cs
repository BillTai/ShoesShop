using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class fProductDetail : Form
    {
        public fProductDetail()
        {
            InitializeComponent();
        }
        DataTable ProductDetail = new DataTable();
        Connect ConnectSQL = new Connect();
        private void fProductDetail_Load(object sender, EventArgs e)
        {
            ShowProductDetail();
            for(int i = 0;i<ProductDetail.Columns.Count;i++)
            {
                cbSearch.Items.Add(dgvProductDetail.Columns[i].HeaderText);
            }
            cbSearch.SelectedIndex = 0;
            ShowInTextBox(0,ProductDetail);
        }
        void ConnectSql(string query, DataGridView dgv)
        {
            ProductDetail = ConnectSQL.ExcuteQuery(query);
            dgv.DataSource = ProductDetail;
        }
        // Danh sách sản phẩm
        void ShowProductDetail()
        {
            String query = "select * from ProductDetail";
            ConnectSql(query, dgvProductDetail);

        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtFrom.Text = "";
            txtTo.Text = "";
            if(cbSearch.SelectedIndex==1)
            {
                pValues.Visible = true;
                txtSearch.Enabled = false;
                txtFrom.Focus();
            }    
            else
            {
                pValues.Visible = false;
                txtSearch.Enabled = true;
                txtSearch.Focus();
            }    
        }
        void ShowInTextBox(int vt, DataTable dvg)
        {
            txtIDProductDetail.Text = ProductDetail.Rows[vt][0].ToString();
            txtSize.Text = ProductDetail.Rows[vt][1].ToString();
            txtColor.Text = ProductDetail.Rows[vt][2].ToString();
        }
        private void dgvProductDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            int SIZE = ProductDetail.Rows.Count;
            if (vt >= 0 && vt != SIZE)
                ShowInTextBox(vt, ProductDetail);
        }
    }
}
