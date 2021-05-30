using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace demo
{
    public partial class fBill : Form
    {
        int totalprice = 0;
        int countbill = 1;
        public fBill()
        {
            InitializeComponent();
        }
        // Load combobox
        private void fBill_Load(object sender, System.EventArgs e)
        {
            Product= ConnectSQL.ExcuteQuery("Select IDProduct from Product");
            for (int i = 0; i < Product.Rows.Count; i++)
            {
                cbIDProduct.Items.Add(Product.Rows[i][0]);
            }
            Staff= ConnectSQL.ExcuteQuery("Select IDStaff from Staff");
            for (int i = 0; i < Staff.Rows.Count; i++)
            {
                cbIDStaff.Items.Add(Staff.Rows[i][0]);
            }
            Bill= ConnectSQL.ExcuteQuery("Select IDBill from Bill");
            for (int i = 0; i < Bill.Rows.Count; i++)
            {
                countbill++;
            }
            lblIDBill.Text = "HD" + countbill;
            Customer = ConnectSQL.ExcuteQuery("Select PhoneNum from Customer");
            for (int i = 0; i < Customer.Rows.Count; i++)
            {
                cbIDCustomer.Items.Add(Customer.Rows[i][0]);
            }
            string ReturnIDAccount="";
            Account = ConnectSQL.ExcuteQuery("Select IDStaff, Status from Account");
            for (int i = 0; i < Account.Rows.Count; i++)
            {
                if (Account.Rows[i][1].ToString() == "1")
                {
                    ReturnIDAccount = Account.Rows[i][0].ToString();
                }
            }
            cbIDStaff.Text = ReturnIDAccount;
            btnSaveProduct.Enabled = false;
            btnDeleteProduct.Enabled = false;
            txtDiscount.Text = "0";
        }
        //------------------------Khai Báo Biến------------------------//
        Connect ConnectSQL = new Connect();
        DataTable Product = new DataTable();
        DataTable ProductDetail = new DataTable();
        DataTable BillDetail = new DataTable();
        DataTable Customer = new DataTable();
        DataTable Staff = new DataTable();
        DataTable Bill = new DataTable();
        DataTable Account = new DataTable();
        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
               e.Handled = true;
        }
        //thêm chi tiết hóa đơn
        public void add()
        {
            var index = dgvBillDetail.Rows.Add();
            this.dgvBillDetail.Rows[index].Cells[0].Value = cbProductDetail.Text;
            this.dgvBillDetail.Rows[index].Cells[1].Value = lblProductName.Text;
            this.dgvBillDetail.Rows[index].Cells[2].Value = txtNumber.Text;
            this.dgvBillDetail.Rows[index].Cells[3].Value = lblPrice.Text;
            this.dgvBillDetail.Rows[index].Cells[4].Value = txtDiscount.Text;
            double a = totalPrice();
            this.dgvBillDetail.Rows[index].Cells[5].Value = a;
        }
        //  kiểm tra số lượng
        public bool check(string a,int b)
        {
            string str = "Select Number from ProductDetail where IDProductDetail = N'" + a + "'";
            ProductDetail = ConnectSQL.ExcuteQuery(str);
            if(ProductDetail.Rows.Count>0)
            if (b <= (int)ProductDetail.Rows[0][0])
                return true;
            return false;
        }
        // cộng số lượng tổng sản phẩm
        public void addTSL(string a, int b)
        {
            string str2 = "Select IDProduct from ProductDetail where IDProductDetail = N'" + a + "'";
            ProductDetail = ConnectSQL.ExcuteQuery(str2);
            int sl = 0;
            string str = "Select Total from Product where IDProduct = N'" + ProductDetail.Rows[0][0].ToString() + "'";
            Product = ConnectSQL.ExcuteQuery(str);
            sl = (int)Product.Rows[0][0];
            sl += b;
            string str1 = "UPDATE Product set Total = " + sl + " WHERE IDProduct=  N'" + ProductDetail.Rows[0][0].ToString() + "'";
            ProductDetail = ConnectSQL.ExcuteQuery(str1);
        }
        // trừ số lượng tổng sản phẩm
        public void subtractTSL(string a, int b)
        {
            string str2 = "Select IDProduct from ProductDetail where IDProductDetail = N'" + a + "'";
            ProductDetail = ConnectSQL.ExcuteQuery(str2);
            int sl = 0;
            string str = "Select Total from Product where IDProduct = N'" + ProductDetail.Rows[0][0].ToString() + "'";
            Product = ConnectSQL.ExcuteQuery(str);
            sl = (int)Product.Rows[0][0];
            sl -= b;
            string str1 = "UPDATE Product set Total = " + sl + " WHERE IDProduct=  N'" + ProductDetail.Rows[0][0].ToString() + "'";
            ProductDetail = ConnectSQL.ExcuteQuery(str1);
        }
        // cộng số lượng sản phẩm
        public void addSL(string a, int b)
        {
            int sl = 0;
            string str = "Select Number from ProductDetail where IDProductDetail = N'" + a + "'";
            ProductDetail = ConnectSQL.ExcuteQuery(str);
            sl = (int)ProductDetail.Rows[0][0];
            sl += b;
            string str1 = "UPDATE ProductDetail set Number= " + sl + " WHERE IDProductDetail=  N'" + a + "'";
            ProductDetail = ConnectSQL.ExcuteQuery(str1);
        }
        // trừ số lượng sản phẩm
        public void subtractSL(string a, int b)
        {
            int sl= 0;
            string str = "Select Number from ProductDetail where IDProductDetail = N'" + a + "'";
            ProductDetail = ConnectSQL.ExcuteQuery(str);
            sl =(int) ProductDetail.Rows[0][0];
            sl -= b;
            string str1 = "UPDATE ProductDetail set Number= " + sl + " WHERE IDProductDetail=  N'" + a + "'";
            ProductDetail = ConnectSQL.ExcuteQuery(str1);
        }
        // tính tổng tiền 
        public double totalPrice()
        {
            double tt, sl, dg, gg;
            if (txtNumber.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtNumber.Text);
            if (txtDiscount.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtDiscount.Text);
            if (lblPrice.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(lblPrice.Text);
            tt = sl * dg - sl * dg * gg / 100;
            return tt;

        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {          
            bool flag = true;
            bool flag1 = true;
            if (cbProductDetail.Text=="")
            { MessageBox.Show("Chưa Nhập Mã sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); cbIDProduct.Focus(); flag = false; }
            if (txtNumber.Text == "")
            { MessageBox.Show("Chưa Nhập Số lượng sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); txtNumber.Focus(); flag = false; }
            if(flag)
            {
                    for (int i = 0; i < dgvBillDetail.Rows.Count - 1; i++)
                    {
                        flag1 = true;
                    if (this.dgvBillDetail.Rows[i].Cells[0].Value.ToString() == cbProductDetail.Text)
                    {
                        int slban = Convert.ToInt32(dgvBillDetail.Rows[i].Cells[2].Value);
                        slban += Convert.ToInt32(txtNumber.Text);
                        //check số lượng
                            if (!check(cbProductDetail.Text, slban))
                            {
                                MessageBox.Show("Số lượng sản phẩm không đủ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                this.dgvBillDetail.Rows[i].Cells[2].Value = slban;
                                double a = totalPrice();
                                double b = 0;
                                b = (double)this.dgvBillDetail.Rows[i].Cells[5].Value;
                                b += a;
                                this.dgvBillDetail.Rows[i].Cells[5].Value = b;
                            }
                            flag1 = false;
                            break;
                    }

                    }
                    if (flag1)
                    {
                    if (cbTypeBill.Text == "Hóa Đơn Bán")
                    {
                        if (!check(cbProductDetail.Text, Convert.ToInt32(txtNumber.Text)))
                        {
                            MessageBox.Show("Số lượng sản phẩm không đủ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            add();
                            btnDeleteProduct.Enabled = true;
                            btnSaveProduct.Enabled = true;
                        }
                    }else
                    {
                        add();
                        btnDeleteProduct.Enabled = true;
                        btnSaveProduct.Enabled = true;
                    }    
                }
            }
            // hiển thị tổng tiền
            double tt = 0;
            for (int i = 0; i < dgvBillDetail.Rows.Count - 1; i++)
            {             
                tt += (double)this.dgvBillDetail.Rows[i].Cells[5].Value;
                lblTotalCost.Text = tt.ToString();
            }
        }

        private void cbIDStaff_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbIDStaff.Text == "")
                lblStaffName.Text = "";
            else
            {
                    // Khi chọn Mã nhân viên thì tên nhân viên tự động hiện ra
                    str = "Select StaffName from Staff where IDStaff = N'" + cbIDStaff.Text + "'";
                    Staff = ConnectSQL.ExcuteQuery(str);
                    if (Staff.Rows.Count == 0)
                        lblStaffName.Text = "";
                    else
                        lblStaffName.Text = Staff.Rows[0][0].ToString();
            }
        }

        private void txtIDCustomer_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbIDCustomer.Text == "")
            {
                lblCustomerName.Text = "";
                lblAddress.Text = "";
            }
            else
            {
                // Khi chọn Mã khách hàng thì tên khach hang tự động hiện ra
                str = "Select CustomerName,Address from Customer where PhoneNum = N'" + cbIDCustomer.Text + "'";
                Customer = ConnectSQL.ExcuteQuery(str);
                if (Customer.Rows.Count == 0)
                {
                    lblCustomerName.Text = "";
                    lblAddress.Text = "";
                }
                else
                {
                    lblCustomerName.Text = Customer.Rows[0][0].ToString();
                    lblAddress.Text = Customer.Rows[0][1].ToString();
                }
            }
        }

        private void cbIDProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool flag = true;
            if (cbTypeBill.Text =="")
            { MessageBox.Show("Chưa Nhập loại hóa đơn sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); cbIDProduct.Focus(); flag = false;  }
            if (flag)
            {
                cbProductDetail.Items.Clear();
                lblProductName.Text = "";
                cbProductDetail.Text = "";
                lblPrice.Text = "";
                string str;
                string str1 = "";
                if (cbIDProduct.Text == "")
                {
                    lblProductName.Text = "";                 
                }
                else
                {
                    // Khi chọn Mã sản phẩm thì tên nhân viên tự động hiện ra
                    str = "Select ProductName from Product where  IDProduct = N'" + cbIDProduct.Text + "'";

                    if (cbTypeBill.Text == "Hóa Đơn Bán")
                    { str1 = "Select PriceOut,IDProductDetail from ProductDetail where ProductDetail.IDProduct =N'" + cbIDProduct.Text + "'"; }
                    else if (cbTypeBill.Text == "Hóa Đơn Nhập")
                    { str1 = "Select PriceIn,IDProductDetail from ProductDetail where ProductDetail.IDProduct =N'" + cbIDProduct.Text + "'"; }
                    Product = ConnectSQL.ExcuteQuery(str);
                    ProductDetail = ConnectSQL.ExcuteQuery(str1);
                    if (Product.Rows.Count == 0)
                        lblProductName.Text = "";
                    else
                        lblProductName.Text = Product.Rows[0][0].ToString();
                    if (ProductDetail.Rows.Count == 0)
                    {
                        lblPrice.Text = "0";
                        cbProductDetail.Text = "";
                    }
                    else
                    {
                        lblPrice.Text = ProductDetail.Rows[0][0].ToString();
                        for (int i = 0; i < ProductDetail.Rows.Count; i++)
                        {
                            cbProductDetail.Items.Add(ProductDetail.Rows[i][1]);
                        }
                    }
                }
            }
        }


        private void btnRefreshText_Click(object sender, EventArgs e)
        {
            cbIDStaff.Text = "";
            cbIDCustomer.Text = "";
            txtNumber.Text = "";
            cbIDProduct.Text = "";
            txtDiscount.Text = "";
            lblTotalCost.Text = "";
            totalprice = 0;
            dgvBillDetail.Rows.Clear();
            btnSaveProduct.Enabled = false;
            btnDeleteProduct.Enabled = false;
            cbIDCustomer.Focus();

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            double a =0;
            foreach (DataGridViewCell oneCell in dgvBillDetail.SelectedCells)
            {
                int i = 0;
                if (oneCell.Selected)
                {
                    a = (double)this.dgvBillDetail.Rows[i].Cells[5].Value;
                    dgvBillDetail.Rows.RemoveAt(oneCell.RowIndex);                 
                }
                i++;
            }
            double tt = Convert.ToDouble(lblTotalCost.Text);
            tt -= a;
            lblTotalCost.Text = tt.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            fHomePage HP = new fHomePage();
            HP.ShowDialog();
            this.Close();
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (cbTypeBill.Text == "")
            { MessageBox.Show("Chưa Nhập loại hóa đơn sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); cbIDProduct.Focus(); flag = false; }
            if (cbIDCustomer.Text == "")
            { MessageBox.Show("Chưa Nhập ID khách hàng sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); txtNumber.Focus(); flag = false; }
            if (cbIDStaff.Text == "")
            { MessageBox.Show("Chưa Nhập ID nhân viên sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); txtNumber.Focus(); flag = false; }
            if (flag)
            {
                string checka = "select IDBill from Bill";
                Bill = ConnectSQL.ExcuteQuery(checka);
                int SIZE = Bill.Rows.Count;
                string query = "";
                string query1 = "";
                query = "INSERT INTO Bill (IDBill, Date, IDCustomer,IDStaff, TypeBill,Status) VALUES('" + lblIDBill.Text + "', '" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "', '" + cbIDCustomer.Text + "', '" + cbIDStaff.Text + "', '" + cbTypeBill.Text + "', '" + "1" + "')";
                DialogResult Question = MessageBox.Show("Bạn Có Muốn Thêm Hóa đơn", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Question == DialogResult.Yes)
                {
                    ConnectSQL.ExcuteQuery(query);
                    for (int i = 0; i < dgvBillDetail.Rows.Count-1; i++)
                    {                    
                        string IDProductDetail, Number, Price, Discount, TotalPrice;
                        IDProductDetail = dgvBillDetail.Rows[i].Cells[0].Value.ToString();
                        Number=dgvBillDetail.Rows[i].Cells[2].Value.ToString();
                        Price=dgvBillDetail.Rows[i].Cells[3].Value.ToString();
                        Discount=dgvBillDetail.Rows[i].Cells[4].Value.ToString();
                        TotalPrice =dgvBillDetail.Rows[i].Cells[5].Value.ToString();
                        query1 = "INSERT INTO BillDetail (IDBill, IDProductDetail, Number, Price, Discount,TotalPrice) VALUES('" +lblIDBill.Text + "', '" + IDProductDetail + "', '" + Number + "', '" + Price + "', '" + Discount + "', '" + TotalPrice + "')";
                        ConnectSQL.ExcuteQuery(query1);
                        if (cbTypeBill.Text == "Hóa Đơn Bán")
                        {
                            subtractSL(IDProductDetail, Convert.ToInt32(Number));
                            subtractTSL(IDProductDetail, Convert.ToInt32(Number));
                        }
                        if (cbTypeBill.Text == "Hóa Đơn Nhập")
                        {
                            addSL(IDProductDetail, Convert.ToInt32(Number));
                            addTSL(IDProductDetail, Convert.ToInt32(Number));
                        }
                    }

                }
                Bill = ConnectSQL.ExcuteQuery(checka);
                int SIZE2 = Bill.Rows.Count;
                if (SIZE != SIZE2)
                {
                    MessageBox.Show("Thêm Hoá đơn Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm hóa đơn Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
        //private void ToExcel(DataGridView dataGridView1, string fileName, DataTable ds)
        //{
        //    Microsoft.Office.Interop.Excel.Application excel;
        //    Microsoft.Office.Interop.Excel.Workbook workbook;
        //    Microsoft.Office.Interop.Excel.Worksheet worksheet;

        //    try
        //    {

        //        excel = new Microsoft.Office.Interop.Excel.Application();
        //        excel.Visible = false;
        //        excel.DisplayAlerts = false;

        //        workbook = excel.Workbooks.Add(Type.Missing);

        //        worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
        //        worksheet.Name = "Danh sách sản phẩm";

        //        // export header
        //        for (int i = 0; i < dataGridView1.ColumnCount; i++)
        //        {
        //            worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
        //        }

        //        // export content
        //        for (int i = 0; i < ds.Rows.Count; i++)
        //        {
        //            for (int j = 0; j < ds.Columns.Count; j++)
        //            {
        //                worksheet.Cells[i + 2, j + 1] = ds.Rows[i][j].ToString();
        //            }
        //        }

        //        // save workbook
        //        workbook.SaveAs(fileName);
        //        workbook.Close();
        //        excel.Quit();
        //        MessageBox.Show("Export successful.!");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        workbook = null;
        //        worksheet = null;
        //    }
        //}
        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void cbTypeBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTypeBill.Text=="Hóa Đơn Bán")
            {
                cbIDCustomer.Items.Clear();
                Customer = ConnectSQL.ExcuteQuery("Select PhoneNum from Customer where CustomerType =N'Khách Hàng'");
                for (int i = 0; i < Customer.Rows.Count; i++)
                {
                    cbIDCustomer.Items.Add(Customer.Rows[i][0]);
                };
            }    
            if (cbTypeBill.Text == "Hóa Đơn Nhập")
            {
                cbIDCustomer.Items.Clear();
                Customer = ConnectSQL.ExcuteQuery("Select PhoneNum from Customer where CustomerType =N'Nhà Cung Cấp'");
                for (int i = 0; i < Customer.Rows.Count; i++)
                {
                    cbIDCustomer.Items.Add(Customer.Rows[i][0]);
                }
            }    
        }
    }
 }

