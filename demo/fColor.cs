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
    public partial class fColor : Form
    {
        public fColor()
        {
            InitializeComponent();
        }

        private void fColor_Load(object sender, EventArgs e)
        {

        }
        Connect ConnectSQL = new Connect();
        DataTable Colors = new DataTable();
        //------------------------Hàm------------------------//
        //Kết Nối SQL
        void ConnectSql(string query, DataGridView dgv)
        {
            Colors = ConnectSQL.ExcuteQuery(query);
            dgv.DataSource = Colors;
        }
        void ShowColor()
        {
            string query = "Select * from Color";
            ConnectSql(query, dgvColor);
        }
    }
}
