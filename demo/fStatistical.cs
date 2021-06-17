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
    public partial class fStatistical : Form
    {
        public fStatistical()
        {
            InitializeComponent();
        }
        //------------------------Khai Báo Biến------------------------//
        Connect ConnectSQL = new Connect();
        DataTable Bill = new DataTable();
        DataTable BillDetail = new DataTable();

        //------------------------Hàm------------------------//
        //Kết Nối SQL
        void ConnectSql(string query, DataGridView dgv, DataTable d)
        {
            d = ConnectSQL.ExcuteQuery(query);
            dgv.DataSource = d;
        }
        void ShowBillDetail(int vt)
        {

            string query = "Select * from BillDetail where IDBill = '"+Bill.Rows[vt][0].ToString()+"'";
            ConnectSql(query, dgvBillDetail, BillDetail);
        }
        private void fStatistical_Load(object sender, EventArgs e)
        {
            string query = "Select * from Bill";
            Bill = ConnectSQL.ExcuteQuery(query);
            ConnectSql(query, dgvBill, Bill);
            ShowBillDetail(0);
            cbTK.Items.Add("Tất Cả");
            cbTK.Items.Add("Loại Hoá Đơn");
            cbTK.Items.Add("Khác Hàng");
            cbTK.Items.Add("Thời Gian");
            cbTK.Items.Add("Nhân Viên");
            cbTK.SelectedIndex = 0;
            cbBillType.Items.Add("Hoá Đơn Nhập");
            cbBillType.Items.Add("Hóa Ðơn Bán");


        }
        void Search()
        {
            try
            {
                int SIZE = Bill.Rows.Count;
                ConnectSql("select * from bill", dgvBill, Bill);
                ShowBillDetail(0);
                string query = "";
                if(cbTK.SelectedIndex == 1)
                {
                    if (cbBillType.SelectedIndex == 0)
                    {
                        query = "select * from Bill where TypeBill = N'Hóa Ðơn Nhập'";
                    }
                    else if (cbBillType.SelectedIndex == 1)
                    {
                        query = "select* from Bill where TypeBill = N'Hóa Ðơn Bán'";
                    }

                }else if(cbTK.SelectedIndex ==2)
                {
                        query = "select* from Bill where IDCustomer like N'%"+txtSearch.Text+"%'";
                }
                ConnectSql(query, dgvBill, Bill);
                ShowBillDetail(0);

            }
            catch
            {
                MessageBox.Show("Vui Lòng Kiểm Tra Lại", "Thông Báo");
            }
        }
        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            int SIZE = Bill.Rows.Count;
            if(SIZE >0)
            {
                ShowBillDetail(vt);
            }    
        }

        private void cbTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTK.SelectedIndex == 1)
            {
                cbBillType.Visible = true;
                txtSearch.Visible = false;
            }
            else
            {
                cbBillType.Visible = false;
                txtSearch.Visible = true;
            }    
        }

        private void cbBillType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            Search();
        }
    }
}
