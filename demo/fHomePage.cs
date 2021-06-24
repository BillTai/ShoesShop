using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class fHomePage : Form
    {
        public fHomePage()
        {
            Connect ConnectSQL = new Connect();
            DataTable Account = new DataTable();
            InitializeComponent();
            ShowProduct();
            ShowProductType();
            ShowProductDetail();
            ShowCustomer();
            ShowBill();
            ShowBillDetail();
            ShowStaff();
        }
        DataTable Bill = new DataTable();
        private void fHomePages_Load(object sender, EventArgs e)
        {
            Account = ConnectSQL.ExcuteQuery("Select IDStaff, Status from Account");
            for (int i = 0; i < Account.Rows.Count; i++)
            {
                if (Account.Rows[i][1].ToString() == "1")
                {
                    ReturnIDAccount = Account.Rows[i][0].ToString();
                }
            }
            Bill = ConnectSQL.ExcuteQuery("select distinct YEAR(date) from Bill");
            for(int i = 0;i < Bill.Rows.Count; i++)
            {
                if (Bill.Rows[0][0] != DBNull.Value)
                    cbYear.Items.Add(Bill.Rows[i][0].ToString());
            }
            cbYear.SelectedIndex = 0;
            cMonth.Checked = true;
            chartMonth.ChartAreas[0].AxisX.Minimum = 1;
            chartMonth.ChartAreas[0].AxisX.Maximum = 12;
            timer1.Start();
            CreateChartMonth();
            CreateChartQuy();
            CreateChartProduct();
            CreateChartCustomer();
            rProduct.Checked = true;
            chartCustomer.Visible = false;

            }
        //------------------------Khai Báo Biến------------------------//
        Connect ConnectSQL = new Connect();
        DataTable Account = new DataTable();
        public string ReturnIDAccount;
        //------------------------Hàm------------------------//
        //Kết nối SQL
        void InputQuery(string query, DataGridView drv)
        {
            Connect connect = new Connect();
            drv.DataSource = connect.ExcuteQuery(query);
        }
        void CreateChartMonth()
        {
            chartMonth.Series["Doanh Thu"].Points.Clear();
            for (int i = 1; i < 13; i++)
            {
                Bill = ConnectSQL.ExcuteQuery("select sum(totalprice) from Bill where TypeBill =N'HDB' and  MONTH(date) = " + i + " and YEAR(Date) = " + cbYear.SelectedItem + " ");
                if (Bill.Rows[0][0] == DBNull.Value)
                    chartMonth.Series["Doanh Thu"].Points.AddXY(i, 0);
                else
                    chartMonth.Series["Doanh Thu"].Points.AddXY(i, Convert.ToDouble(Bill.Rows[0][0]));
            }
        }
        void CreateChartProduct()
        {
            chartProduct.Series["Sản Phẩm"].Points.Clear();
            DataTable ProductTop = new DataTable();

            ProductTop = ConnectSQL.ExcuteQuery("select top 5 Product.ProductName, sum(BillDetail.Number) as tong from BillDetail, Bill, ProductDetail, Product where Bill.IDBill = BillDetail.IDBill and BillDetail.IDProductDetail = ProductDetail.IDProductDetail and ProductDetail.IDProduct = Product.IDProduct and MONTH(Bill.Date) = MONTH(getdate()) and TypeBill = N'HDB' group by Product.IDProduct,  Product.ProductName order by sum(BillDetail.Number) desc");
            for (int i = 0; i < ProductTop.Rows.Count; i++)
            {                
                if (ProductTop.Rows[0][0] == DBNull.Value)
                    chartProduct.Series["Sản Phẩm"].Points.Clear();
                else
                    chartProduct.Series["Sản Phẩm"].Points.AddXY(ProductTop.Rows[i][0], Convert.ToDouble(ProductTop.Rows[i][1]));
            }
        }
        void CreateChartCustomer()
        {
            chartCustomer.Series["Khách Hàng"].Points.Clear();
            DataTable CustomerTop = new DataTable();

            CustomerTop = ConnectSQL.ExcuteQuery("select top 5 Customer.PhoneNum, sum(BillDetail.Number) as tong from BillDetail, Bill, Customer where Bill.IDBill = BillDetail.IDBill and Bill.IDCustomer = Customer.PhoneNum and MONTH(Bill.Date) = MONTH(getdate()) and TypeBill = N'HDB' group by  Customer.PhoneNum order by sum(BillDetail.Number) desc");
            for (int i = 0; i < CustomerTop.Rows.Count; i++)
            {
                if (CustomerTop.Rows[0][0] == DBNull.Value)
                    chartCustomer.Series["Khách Hàng"].Points.Clear();
                else
                    chartCustomer.Series["Khách Hàng"].Points.AddXY(CustomerTop.Rows[i][0].ToString(), Convert.ToDouble(CustomerTop.Rows[i][1]));
            }
        }
        void CreateChartQuy()
        {
            chartquy.Series["Quý"].Points.Clear();

            Bill = ConnectSQL.ExcuteQuery("select sum(totalprice) from Bill where TypeBill =N'HDB' and  MONTH(date) <= 12 and YEAR(Date) = " + cbYear.SelectedItem + " ");
            double TotalPrice = Convert.ToDouble(Bill.Rows[0][0]);
            int start = 1;
            int end = 3;
            for (int i = 1; i < 5; i++)
            {
                string query = "select sum(totalprice) from Bill where TypeBill =N'HDB' and MONTH(date) >= '" + start + "' and   MONTH(date) <= '" +end+ "' and YEAR(Date) = '" + cbYear.SelectedItem + "' ";
                Bill = ConnectSQL.ExcuteQuery(query);
                if (Bill.Rows[0][0] == DBNull.Value)
                    chartquy.Series["Quý"].Points.AddXY("Quý " + i, 0);
                else
                {
                    double s = (100 / (TotalPrice / Convert.ToDouble(Bill.Rows[0][0]))) / 100;
                    chartquy.Series["Quý"].Points.AddXY("Quý " + i, s);
                }

                start =end +1;
                end = start + 2;
            }
            txtTotalPrice.Text = string.Format("{0:n0}", TotalPrice);
        }
       
        //Danh sách loại sản phẩm
        void ShowProduct()
        {
            string query = "select * from PRODUCT";
            InputQuery(query, dgvProduct);
        }
        //Danh sách loại sản phẩm
        void ShowProductType()
        {
            string query = "select * from ProductType";
            InputQuery(query, dgvProductType);
        }
        //Danh sách chi tiết sản phẩm
        void ShowProductDetail()
        {
            string query = "select * from ProductDetail";
            InputQuery(query, dgvProductDetail);
        }
        //Danh sách nhà cung cấp
      
        //Danh sách khách hàng
        void ShowCustomer()
        {
            string query = "select * from Customer";
            InputQuery(query, dgvCustomer);
        }
        //Danh sách hoá đơn
        void ShowBill()
        {
            string query = "select * from Bill";
            InputQuery(query, dgvBill);
        }
        //Danh sách chi tiết hoá đơn
        void ShowBillDetail()
        {
            string query = "select * from BillDetail";
            InputQuery(query, dgvBillDetail);
        }
        //Danh sách nhân viên
        void ShowStaff()
        {
            string query = "select * from Staff";
            InputQuery(query, dgvStaff);
        }
        //------------------------Khai Báo Biến------------------------//
        //Nút quản lý sản phẩm
       
        //Nút quản lý loại sản phẩm
        private void mtsEditProductType_Click(object sender, EventArgs e)
        {
            fProductType fEditProType = new fProductType();
            fEditProType.ShowDialog();
        }
        //Nút quản lý nhân viên
        private void mtsEditStaff_Click(object sender, EventArgs e)
        {
          
            fStaff fS = new fStaff();
            fS.ShowDialog();

        }
        //Nút thông tin tài khoản
        private void mtsInfoAccount_Click(object sender, EventArgs e)
        {

            fInfoAccount fInfo = new fInfoAccount();
            fInfo.IDAccount = ReturnIDAccount;
            fInfo.ShowDialog();

        }
        //Nút quản lý khách hàng
        private void mtsAddCustomer_Click(object sender, EventArgs e)
        {
            fCustomer fCus = new fCustomer();
            fCus.ShowDialog();
        }
        //Nút đăng xuất
        private void mtsLogOut_Click(object sender, EventArgs e)
        {
            Account = ConnectSQL.ExcuteQuery("Update Account set Status = '0' where IDStaff = '" + ReturnIDAccount + "'");
            this.Hide();
            fLogin fLI = new fLogin();
            fLI.ShowDialog();
            this.Close();
        }
        //Nút quản lý nhà cung cấp
        
        //Nút thoát

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fProduct pro = new fProduct();
            pro.ShowDialog();

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //fBill bill = new fBill();
            //bill.ShowDialog();
            //this.Close();
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //fBillSearch bills = new fBillSearch();
            //bills.ShowDialog();
            //this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult Question = MessageBox.Show("Bạn Có Muốn Đăng Xuất ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Question == DialogResult.Yes)
            {
                mtsLogOut_Click(sender, e);
            }
            else
                this.Close();
        }

        private void cMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (cMonth.Checked)
            {

                chartquy.Visible = false;
                chartMonth.Visible = true;
            }
            else
            {
                chartquy.Visible = true;
                chartMonth.Visible = false;
            }    
        }

        private void cquy_CheckedChanged(object sender, EventArgs e)
        {
            if(cquy.Checked)
            {
                chartquy.Visible = true;
                chartMonth.Visible = false;
            }
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateChartMonth();
            CreateChartQuy();
        }

        private void rProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (rCustomer.Checked)
            {

                chartProduct.Visible = false;
                chartCustomer.Visible = true;
            }
            else
            {
                chartProduct.Visible = true;
                chartCustomer.Visible = false;
            }
        }

        private void rCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (rCustomer.Checked)
            {
                chartCustomer.Visible = true;
                chartProduct.Visible = false;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            fHomePages_Load(sender, e);
        }
    }
}
