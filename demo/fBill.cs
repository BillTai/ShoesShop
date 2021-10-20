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
        string idproduct = "";
        public fBill()
        {
            InitializeComponent();
        }
        public void GETVALUE(string value)
        {
            txtIDNV.Text = value;
        }
        // Load combobox
        private void fBill_Load(object sender, System.EventArgs e)
        {
            cbBillType.SelectedIndex = 0;
            //mã HD
            int countbill = 1;
            Bill = ConnectSQL.ExcuteQuery("Select IDBill from Bill");
            for (int i = 0; i <= Bill.Rows.Count; i++)
            {
                countbill++;
            }              
            txtMaHD.Text = "HD" + countbill;
            //ngày
            DateTime today = DateTime.Today;
            txtNgayLap.Text = today.ToString("MM/dd/yyyy");
            //items SDT
                AutoCompleteStringCollection namecollection = new AutoCompleteStringCollection();
                string temp = "Select PhoneNum from Customer where CustomerType=N'Khách Hàng'";
                Customer = ConnectSQL.ExcuteQuery(temp);
                if (Customer.Rows.Count > 0)
                {
                    int i = 0;
                    while (i <= Customer.Rows.Count - 1)
                    { namecollection.Add(Customer.Rows[i][0].ToString()); i++; }
                }
                txtSDT.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtSDT.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSDT.AutoCompleteCustomSource = namecollection;
            //items ten ncc
                AutoCompleteStringCollection namecollectionss = new AutoCompleteStringCollection();
                string temp2 = "Select CustomerName from Customer where CustomerType=N'Nhà Cung Cấp'";
                Customer = ConnectSQL.ExcuteQuery(temp2);
                if (Customer.Rows.Count > 0)
                {
                    int i = 0;
                    while (i <= Customer.Rows.Count - 1)
                    { namecollectionss.Add(Customer.Rows[i][0].ToString()); i++; }
                }
                txtTKH.AutoCompleteCustomSource = namecollectionss;
                txtTKH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtTKH.AutoCompleteSource = AutoCompleteSource.CustomSource;       
            //nhan vien
            string query = "select Account.[IDStaff], [StaffName] from Account,Staff where Account.Status=1 and Account.IDStaff=Staff.IDStaff";
            Account = ConnectSQL.ExcuteQuery(query);
            txtIDNV.Text = Account.Rows[0][0].ToString();
            txtTenNv.Text = Account.Rows[0][1].ToString();
            disableButton();

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
        //them datagrid
        public void add()
        {
            var index = dgvBillDetail.Rows.Add();
            this.dgvBillDetail.Rows[index].Cells[0].Value = txtMasp.Text;
            this.dgvBillDetail.Rows[index].Cells[1].Value = txtTenSP.Text;
            this.dgvBillDetail.Rows[index].Cells[2].Value = txtSL.Text;            
            this.dgvBillDetail.Rows[index].Cells[3].Value = txtDG.Text;
            double tong = Convert.ToDouble(txtSL.Text) * Convert.ToDouble(txtDG.Text);
            this.dgvBillDetail.Rows[index].Cells[4].Value = tong.ToString();
            this.dgvBillDetail.Rows[index].Cells[5].Value = txtCK.Text;
            double ck = (Convert.ToDouble(txtCK.Text) *tong)/100 ;
            this.dgvBillDetail.Rows[index].Cells[6].Value = ck.ToString();
            double a = totalPrice();
            this.dgvBillDetail.Rows[index].Cells[7].Value = a;
        }
        public void enableButton()
        {
            btnDelete.Enabled = true;
            btnSave.Enabled = true;
        }
        public void disableButton()
        {
            btnDelete.Enabled = false; 
            btnSave.Enabled = false;
        }
        // clear dữ liệu
        public void clear()
        {
            txtSDT.Text = "";
            txtTKH.Text = "";
            txtMasp.Text = "";
            dgvBillDetail.Rows.Clear();
            dgvBillDetail.Refresh();
        }
        //  kiểm tra số lượng
        public bool check(string a, int b)
        {
            string str = "Select Number from ProductDetail where IDProductDetail = N'" + a + "'";
            ProductDetail = ConnectSQL.ExcuteQuery(str);
            if (ProductDetail.Rows.Count > 0)
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
            sl = Convert.ToInt32(Product.Rows[0][0].ToString());
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
            sl = Convert.ToInt32(Product.Rows[0][0].ToString());
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
            sl = Convert.ToInt32(ProductDetail.Rows[0][0].ToString());
            sl += b;
            string str1 = "UPDATE ProductDetail set Number= " + sl + " WHERE IDProductDetail=  N'" + a + "'";
            ProductDetail = ConnectSQL.ExcuteQuery(str1);
        }
        // trừ số lượng sản phẩm
        public void subtractSL(string a, int b)
        {
            int sl = 0;
            string str = "Select Number from ProductDetail where IDProductDetail = N'" + a + "'";
            ProductDetail = ConnectSQL.ExcuteQuery(str);
            sl = (Convert.ToInt32(ProductDetail.Rows[0][0].ToString()));
            sl -= b;
            string str1 = "UPDATE ProductDetail set Number= " + sl + " WHERE IDProductDetail=  N'" + a + "'";
            ProductDetail = ConnectSQL.ExcuteQuery(str1);
        }
        // tính tổng tiền 
        public double totalPrice()
        {
            double tt, sl, dg, gg;
            if (txtSL.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSL.Text);
            if (txtCK.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtCK.Text);
            if (txtDG.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDG.Text);
            tt = sl * dg - sl * dg * gg / 100;
            return tt;

        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbBillType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBillType.Text == "Hóa Ðơn Bán")
            {
                clear();
                txtSDT.Enabled = true;
                txtTKH.ReadOnly = true;
                lblchange.Text = "Tên Khách Hàng:";
            }
            else if (cbBillType.Text == "Hóa Ðơn Nhập")
            {
                clear();
                txtSDT.ReadOnly = true;
                txtTKH.ReadOnly = false;
                lblchange.Text = "Tên NCC:";
            }
            //items masp
            if (cbBillType.Text == "Hóa Ðơn Bán")
            {
                AutoCompleteStringCollection namecollectionsb = new AutoCompleteStringCollection();
                string temp1 = "Select IDProductDetail from ProductDetail";
                ProductDetail = ConnectSQL.ExcuteQuery(temp1);
                if (ProductDetail.Rows.Count > 0)
                {
                    int i = 0;
                    while (i <= ProductDetail.Rows.Count - 1)
                    { namecollectionsb.Add(ProductDetail.Rows[i][0].ToString()); i++; }
                }
                txtMasp.AutoCompleteCustomSource = namecollectionsb;
                txtMasp.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtMasp.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }          
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        //auto complete kh
        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbBillType.Text == "Hóa Ðơn Bán")
            {
                if (txtSDT.Text == "")
                {
                    txtTKH.Text = "";
                    txtDiachi.Text = "";
                }
                else
                {
                    str = "Select CustomerName,Customer.Address from Customer where CustomerType=N'Khách Hàng'and PhoneNum=" + txtSDT.Text;
                    Staff = ConnectSQL.ExcuteQuery(str);
                    if (Staff.Rows.Count == 0)
                    {
                        txtTKH.Text = "";
                        txtDiachi.Text = "";
                    }
                    else
                    {
                        txtTKH.Text = Staff.Rows[0][0].ToString();
                        txtDiachi.Text = Staff.Rows[0][1].ToString();
                    }
                }
            }
            else if (cbBillType.Text == "Hóa Ðơn Nhập")
            {
                AutoCompleteStringCollection namecollectionsn = new AutoCompleteStringCollection();
                string temp5 = "Select IDProductDetail from Product, ProductDetail where Product.IDProduct=ProductDetail.IDProduct and Product.IDCustomer='" + txtSDT.Text + "'";
                ProductDetail = ConnectSQL.ExcuteQuery(temp5);
                if (ProductDetail.Rows.Count > 0)
                {
                    int i = 0;
                    while (i <= ProductDetail.Rows.Count - 1)
                    { namecollectionsn.Add(ProductDetail.Rows[i][0].ToString()); i++; }
                }
                txtMasp.AutoCompleteCustomSource = namecollectionsn;
                txtMasp.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtMasp.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }

        private void txtCK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }
        // nhan
        private double multiply(double a,double b)
        {
            double kq = 0;
            kq = a * b;
            return kq;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool flag1 = true;
            bool flag= true;
            if(txtTenSP.Text=="")
            {
                flag = false;
                MessageBox.Show("Vui lòng nhập thông tin sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(flag)
            {
                for (int i = 0; i < dgvBillDetail.Rows.Count - 1; i++)
            {
                if (this.dgvBillDetail.Rows[i].Cells[0].Value.ToString() == txtMasp.Text)
                {
                    double dg = Convert.ToDouble(txtDG.Text);
                    int slban = Convert.ToInt32(dgvBillDetail.Rows[i].Cells[2].Value);
                    slban += Convert.ToInt32(txtSL.Text);
                    //check số lượng
                    if (cbBillType.Text == "Hóa Ðơn Bán")
                    {
                        if (!check(txtMasp.Text, slban))
                        {
                            MessageBox.Show("Số lượng sản phẩm không đủ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            this.dgvBillDetail.Rows[i].Cells[2].Value = slban;
                            double tongcong = dg * (double)slban;
                            this.dgvBillDetail.Rows[i].Cells[4].Value = tongcong;
                            double gg =Convert.ToInt32( txtCK.Text);
                            double tongck = (tongcong* gg)/100;
                            this.dgvBillDetail.Rows[i].Cells[6].Value = tongck;
                            double a = totalPrice();
                            double b = 0;
                            b = (double)this.dgvBillDetail.Rows[i].Cells[7].Value;
                            b += a;
                            this.dgvBillDetail.Rows[i].Cells[7].Value = b;
                        }
                        flag1 = false;
                        break;
                    }
                }

            }
            if (flag1)
            {
                if (cbBillType.Text == "Hóa Ðơn Bán")
                {
                    int sl = Convert.ToInt32(txtSL.Text);
                    if (!check(txtMasp.Text,sl))
                    {
                        MessageBox.Show("Số lượng sản phẩm không đủ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        add();
                        enableButton();
                    }
                }
                else
                {
                    add();
                    enableButton();
                }
            }
            // hiển thị tổng cộng
            double tc = 0;
            for (int i = 0; i < dgvBillDetail.Rows.Count - 1; i++)
            {
                tc += Convert.ToDouble( this.dgvBillDetail.Rows[i].Cells[4].Value.ToString());
                txtTotals.Text = tc.ToString();
            }
            // hiển thị tổng chiết khấu
            double tck = 0;
            for (int i = 0; i < dgvBillDetail.Rows.Count - 1; i++)
            {
                tck +=Convert.ToDouble( this.dgvBillDetail.Rows[i].Cells[6].Value.ToString());
                txtTotalck.Text = tck.ToString();
            }
            // hiển thị tổng tiền
            double tt = 0;
            for (int i = 0; i < dgvBillDetail.Rows.Count - 1; i++)
            {
                tt += (double)this.dgvBillDetail.Rows[i].Cells[7].Value;
                txtTotal.Text = tt.ToString();
            }
        }
        }




        private void btnDelete_Click(object sender, EventArgs e)
        {
            double a = 0;
            foreach (DataGridViewCell oneCell in dgvBillDetail.SelectedCells)
            {
                int i = 0;
                if (oneCell.Selected)
                {
                    a = (double)this.dgvBillDetail.Rows[i].Cells[7].Value;
                    dgvBillDetail.Rows.RemoveAt(oneCell.RowIndex);
                }
                i++;
            }
            double tt = Convert.ToDouble(txtTotal.Text);
            tt -= a;
            if (tt < 0)
                tt = 0;
            txtTotal.Text = tt.ToString();
            if(dgvBillDetail.Rows.Count==1)
            {
                disableButton();
            }
        }

        private void txtMasp_TextChanged(object sender, EventArgs e)
        {
            
            string str = "", str1 = "";
            try
            {

                if (cbBillType.Text == "Hóa Ðơn Bán")
                { 
                    str1 = "Select PriceOut,IDProduct,Size from ProductDetail where ProductDetail.IDProductDetail =N'" + txtMasp.Text + "'";
 
                }
                else if (cbBillType.Text == "Hóa Ðơn Nhập")
                { str1 = "Select PriceIn,IDProduct,Size from ProductDetail where ProductDetail.IDProductDetail =N'" + txtMasp.Text + "'"; }
                ProductDetail = ConnectSQL.ExcuteQuery(str1);


            }
            catch { };
            
            if (ProductDetail.Rows.Count > 0)
            {
                idproduct = ProductDetail.Rows[0][1].ToString();
                str = "Select ProductName from Product where  IDProduct = N'" + idproduct + "'";
                Product = ConnectSQL.ExcuteQuery(str);

                txtTenSP.Text = Product.Rows[0][0].ToString() + "-" + ProductDetail.Rows[0][2].ToString() + "-";
                txtDG.Text = ProductDetail.Rows[0][0].ToString();
                txtSL.Text = "1";
                txtCK.Text = "0";
            }else
            {
                txtTenSP.Text = "";
                txtDG.Text = "";
                txtSL.Text = "";
                txtCK.Text = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (txtDiachi.Text == "")
            {
                flag = false;
                MessageBox.Show("Lưu hóa đơn không thành công, Xin vui lòng nhập đầy đủ thông tin khách hàng ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(flag)
            {
                string checka = "select IDBill from Bill";
                Bill = ConnectSQL.ExcuteQuery(checka);
                int SIZE = Bill.Rows.Count;
                string query = "";
                string query1 = "";
                if(cbBillType.Text=="Hóa Ðơn Nhập")
                {
                    string thu = "Select PhoneNum from Customer where CustomerName =N'" + txtTKH.Text + "'";
                    Customer = ConnectSQL.ExcuteQuery(thu);
                    txtSDT.Text = Customer.Rows[0][0].ToString();
                }
                query = "INSERT INTO Bill (IDBill, Date, IDCustomer,IDStaff, TypeBill,Status,TotalPrice) VALUES('"+ txtMaHD.Text + "','" + txtNgayLap.Text + "','" + txtSDT.Text + "', '" + txtIDNV.Text + "', N'" + cbBillType.Text + "', '1',  '" + txtTotal.Text + "')";
                DialogResult Question = MessageBox.Show("Bạn Có Muốn Thêm Hóa đơn", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Question == DialogResult.Yes)
                {
                    ConnectSQL.ExcuteQuery(query);
                    for (int i = 0; i < dgvBillDetail.Rows.Count - 1; i++)
                    {
                        string IDProductDetail, Number, Price, Discount, TotalPrice;
                        IDProductDetail = dgvBillDetail.Rows[i].Cells[0].Value.ToString();
                        Number = dgvBillDetail.Rows[i].Cells[2].Value.ToString();
                        Price = dgvBillDetail.Rows[i].Cells[3].Value.ToString();
                        Discount = dgvBillDetail.Rows[i].Cells[5].Value.ToString();
                        TotalPrice = dgvBillDetail.Rows[i].Cells[7].Value.ToString();
                        query1 = "INSERT INTO BillDetail (IDBill, IDProductDetail, Number, Price, Discount,TotalPrice) VALUES('" + txtMaHD.Text + "', '" + IDProductDetail + "', '" + Number + "', '" + Price + "', '" + Discount + "', '" + TotalPrice + "')";
                        ConnectSQL.ExcuteQuery(query1);
                        if (cbBillType.Text == "Hóa Ðơn Bán")
                        {
                            subtractSL(IDProductDetail, Convert.ToInt32(Number));
                            subtractTSL(IDProductDetail, Convert.ToInt32(Number));
                        }
                        else if (cbBillType.Text == "Hóa Ðơn Nhập")
                        {
                            addSL(IDProductDetail, Convert.ToInt32(Number));
                            addTSL(IDProductDetail, Convert.ToInt32(Number));
                        }
                    }
                }
                this.Hide();
                fBill bill1 = new fBill();
                bill1.Size = new Size(1200, 900);
                bill1.ShowDialog();
                this.Close();
            }
        }
        //auto complete ncc
        private void txtTKH_TextChanged(object sender, EventArgs e)
        {
            if(cbBillType.Text== "Hóa Ðơn Nhập")
            {
                string str;
                if (txtTKH.Text =="")
                {
                    txtDiachi.Text = "";
                    txtSDT.Text = "";
                }
                else
                {
                    str = "Select Customer.Address,PhoneNum from Customer where CustomerType=N'Nhà Cung Cấp'and CustomerName=N'" + txtTKH.Text+"'";
                    Staff = ConnectSQL.ExcuteQuery(str);
                    if (Staff.Rows.Count == 0)
                    {
                        txtSDT.Text = "";
                        txtDiachi.Text = "";
                    }
                    else
                    {
                        txtSDT.Text= Staff.Rows[0][1].ToString();
                        txtDiachi.Text = Staff.Rows[0][0].ToString();
                    }
                }
            }
        }



        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            fProduct nProduct = new fProduct();
            nProduct.ShowDialog();
            this.Close();
            fBill bill1 = new fBill();
            bill1.Size = new Size(1200, 800);
            bill1.ShowDialog();

        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            fCustomer nCustomer = new fCustomer();
            nCustomer.ShowDialog();
            this.Close();
            fBill bill1 = new fBill();
            bill1.Size = new Size(1200, 800);
            bill1.ShowDialog();

        }
    }

}

