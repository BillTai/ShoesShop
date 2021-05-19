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
           
        }
        void ConnectSql(string query, DataGridView dgv)
        {
            ProductDetail = ConnectSQL.ExcuteQuery(query);
            dgv.DataSource = ProductDetail;
        }
        // Danh sách sản phẩm
        
    }
}
