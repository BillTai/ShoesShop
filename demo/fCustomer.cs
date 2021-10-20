using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class fCustomer : Form
    {
        public fCustomer()
        {
            InitializeComponent();
           
        }
        //Load ban đầu
        private void fCustomer_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dgvCustomer.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            Province = ConnectSQL.ExcuteQuery("select * from location.province  order by location.province._name");
            for(int i = 0;i<Province.Rows.Count;i++)
            {
                cbProvince.Items.Add(Province.Rows[i][1].ToString());
            }
            cbProvince.SelectedIndex = 0;
            District = ConnectSQL.ExcuteQuery("select * from location.District where _province_id = " + Province.Rows[0][0] + " order by location.District._name");
            for (int i = 0; i < District.Rows.Count; i++)
            {
                cbDistrict.Items.Add(District.Rows[i][1].ToString());
            }
            cbDistrict.SelectedIndex = 0;
            Ward = ConnectSQL.ExcuteQuery("select * from location.Ward where _district_id = " + District.Rows[0][0] + " order by location.ward._name");
            for (int i = 0; i < Ward.Rows.Count; i++)
            {
                cbWard.Items.Add(Ward.Rows[i][1].ToString());
            }
            cbWard.SelectedIndex = 0;
            ShowCustomer();
            cbStatus.Items.Add("Khách Hàng Thân Thiết");
            cbStatus.Items.Add("Khách Hàng Mới");
            cbcustomertype.Items.Add("Nhà Cung Cấp");
            cbcustomertype.Items.Add("Khách Hàng");

            for (int i = 0; i < dgvCustomer.Columns.Count; i++)
            {
                cbSearch.Items.Add(dgvCustomer.Columns[i].HeaderText);
            }
            cbSearch.SelectedIndex = 0;
            ShowInTextBox(0, Customer);
        }
        //------------------------Khai Báo Biến------------------------//
        Connect ConnectSQL = new Connect();
        DataTable Province = new DataTable();
        DataTable District = new DataTable();
        DataTable Ward = new DataTable();
        DataTable Customer = new DataTable();
        //------------------------Hàm------------------------//
        //Kết Nối SQL
        void ConnectSql (string query, DataGridView dgv)
        {
            Customer = ConnectSQL.ExcuteQuery(query);
            dgv.DataSource = Customer;
        }
        //Danh Sách Khách Hàng
        void ShowCustomer()
        {
            string query = "select * from Customer";
            ConnectSql(query, dgvCustomer);
        }
        //Tìm Kiếm Khách Hàng
        void SearchCustomer()
        {
            string query = "";
            for(int i = 0; i < Customer.Columns.Count; i++)
            {
                if(cbSearch.SelectedIndex == i)
                {
                    query = "Select * from Customer where "+Customer.Columns[i].ColumnName+" like N'%" + txtSearch.Text + "%'";
                }    
            }    
            ConnectSql(query, dgvCustomer);

        }
        //Hiển Thị Vào Textbox Khi Click Vào Datagridview
        void ShowInTextBox(int vt, DataTable ds)
        {
            
                         
                
               
            txtPhoneNum.Text = ds.Rows[vt][0].ToString();
            txtCustomerName.Text = ds.Rows[vt][1].ToString();
            txtIDCard.Text = ds.Rows[vt][2].ToString();

            txtEmail.Text = ds.Rows[vt][3].ToString();
            string[] AddressInput = ds.Rows[vt][4].ToString().Split(',');
            txtAddress.Text = AddressInput[0];
            cbWard.Text = AddressInput[1];
            cbDistrict.Text = AddressInput[2];
            cbProvince.Text = AddressInput[3];
            if (Convert.ToInt32(ds.Rows[vt][5]) == 1)
                cbStatus.SelectedIndex = 1;
            else
                cbStatus.SelectedIndex = 0;

            cbcustomertype.SelectedItem = ds.Rows[vt][6].ToString();

        }
        //Kiểm Tra ID Có Tồn Tại Không
        bool CheckID()
        {
            Customer = ConnectSQL.ExcuteQuery("SELECT * FROM Customer");
            int SIZE = Customer.Rows.Count;
            for (int i = 0; i < SIZE; i++)
            {
                if (txtPhoneNum.Text == Customer.Rows[i][0].ToString())
                {
                    return true;
                    break;
                }
            }
            return false;
        }
        //Kiểm Tra Không Nhập Dữ Liệu
        int CheckNull()
        {
            if (string.IsNullOrEmpty(txtPhoneNum.Text))
            {
                errorCustomer.SetError(txtPhoneNum, "Nhập giá trị");
                return 0;
            }
            else if (string.IsNullOrEmpty(txtCustomerName.Text))
            {
                errorCustomer.SetError(txtCustomerName, "Nhập giá trị");
                return 1;
            }
            else if (string.IsNullOrEmpty(txtIDCard.Text))
            {
                errorCustomer.SetError(txtIDCard, "Nhập giá trị");
                return 2;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text) || !isEmail(txtEmail.Text))
            {
                errorCustomer.SetError(txtEmail, "Nhập giá trị");
                return 3;
            }
            else if (string.IsNullOrEmpty(txtAddress.Text))
            {
                errorCustomer.SetError(txtAddress, "Nhập giá trị");
                return 4;
            }

            return -1;
        }
        //Check ID, Email và Mã Thẻ Có Trùng Không Khi Thêm
        int CheckAdd()
        {
            int Icheck = 0;
            int SIZE = Customer.Rows.Count;

            for (int i = 0; i < SIZE; i++)
            {
                if (txtPhoneNum.Text == Customer.Rows[i][0].ToString())
                {
                    Icheck = 1;
                    break;
                }
                else if (txtIDCard.Text == Customer.Rows[i][2].ToString())
                {

                    Icheck = 2;
                    break;
                }
                else if (txtEmail.Text == Customer.Rows[i][3].ToString())
                {
                    Icheck = 3;
                    break;
                }
            }
            return Icheck;
        }
        //Check Email và Mã Thẻ Có Trùng Không Khi Cập Nhật
        int CheckUpdate()
        {
            int Icheck = 0;
            int SIZE = Customer.Rows.Count;
            DataTable IDCardEmail = new DataTable();
            IDCardEmail = ConnectSQL.ExcuteQuery("Select IDCard, Email from Customer where PhoneNum = '" + txtPhoneNum.Text + "'");
            for (int i = 0; i < SIZE; i++)
            {
                if (txtIDCard.Text == Customer.Rows[i][2].ToString())
                {
                    if (txtIDCard.Text == IDCardEmail.Rows[0][0].ToString())
                    {
                        continue;
                    }
                    Icheck = 1;
                }
                else if (txtEmail.Text == Customer.Rows[i][3].ToString())
                {
                    if (txtEmail.Text == IDCardEmail.Rows[0][1].ToString())
                    {
                        continue;
                    }
                    Icheck = 2;
                }
            }
            return Icheck;
        }
        //Hàm Thêm
        void AddCustomer()
        {
            int SIZE = Customer.Rows.Count;
            string address = ""+txtAddress.Text+"," + cbWard.Text + "," + cbDistrict.Text + "," + cbProvince.Text + "";
            string query = "INSERT INTO Customer (PhoneNum , CustomerName, IDCard, Email, Address, Status, CustomerType) VALUES('" + txtPhoneNum.Text + "', N'" + txtCustomerName.Text + "', '" + txtIDCard.Text + "', '" + txtEmail.Text + "', N'" + address + "', '" + cbStatus.SelectedIndex + "', N'" + cbcustomertype.SelectedItem + "')";
            if (CheckAdd()==1)
            {
                MessageBox.Show("SĐT Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhoneNum.Focus();
                errorCustomer.SetError(txtPhoneNum, "Nhập lại giá trị");
            }
            else if(CheckAdd()==2)
            {
                MessageBox.Show("Mã Thẻ Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDCard.Focus();
                errorCustomer.SetError(txtIDCard, "Nhập lại giá trị");
            }
            else if (CheckAdd() == 3)
            {
                MessageBox.Show("Email Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                errorCustomer.SetError(txtEmail, "Nhập lại giá trị");
            }
            else
            {
                DialogResult Question = MessageBox.Show("Bạn Có Muốn Thêm Khách Hàng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Question == DialogResult.Yes)
                {
                    ConnectSQL.ExcuteQuery(query);
                }
                ShowCustomer();
                int SIZE2 = Customer.Rows.Count;
                if (SIZE != SIZE2)
                {
                    MessageBox.Show("Thêm Khách Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm Khách Hàng Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                errorCustomer.Clear();
            }
        }
        //Hàm Xoá
        void DeleteCustomer()
        {
            if (!CheckID())
            {
                txtPhoneNum.Focus();
                MessageBox.Show("Kiểm tra lại SĐT", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhoneNum.Focus();
                errorCustomer.SetError(txtPhoneNum, "Nhập lại giá trị");
            }
            else
            {
                int SIZE = Customer.Rows.Count;
                string query = "delete from Customer where PhoneNum = '" + txtPhoneNum.Text + "'";
                DialogResult Question = MessageBox.Show("Bạn Có Muốn Xoá Khách Hàng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Question == DialogResult.Yes)
                {
                    ConnectSQL.ExcuteQuery(query);
                }
                ShowCustomer();
                int SIZE2 = Customer.Rows.Count;
                if (SIZE != SIZE2)

                    MessageBox.Show("Xoá Khách Hàng Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xoá Khách Hàng Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorCustomer.Clear();
            }
        }
        //Hàm Cập Nhật
        void UpdateCustomer()
        {
            if (!CheckID())
            {
                txtPhoneNum.Focus();
                MessageBox.Show("Kiểm tra lại SĐT", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhoneNum.Focus();
                errorCustomer.SetError(txtPhoneNum, "Nhập lại giá trị");
            }
            else if (CheckUpdate() == 1)
            {
                MessageBox.Show("Mã Thẻ Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDCard.Focus();
                errorCustomer.SetError(txtIDCard, "Nhập lại giá trị");
            }
            else if (CheckUpdate() == 2)
            {
                MessageBox.Show("Email Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                errorCustomer.SetError(txtEmail, "Nhập lại giá trị");
            }
            else
            {
                string address = "" + txtAddress.Text + "," + cbWard.Text + "," + cbDistrict.Text + "," + cbProvince.Text + "";
                string query = "update Customer set [PhoneNum] = '" + txtPhoneNum.Text + "', [CustomerName] = N'" + txtCustomerName.Text + "', [IDCard] = '" + txtIDCard.Text + "', [Email]= '" + txtEmail.Text + "',[Address]= N'" + address + "', [Status]= '" + cbStatus.SelectedIndex + "', [CustomerType]= N'" + cbcustomertype.SelectedItem + "' where [PhoneNum] = '" + txtPhoneNum.Text + "'";
                DialogResult Question = MessageBox.Show("Bạn Có Muốn Cập Nhật Khách Hàng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Question == DialogResult.Yes)
                {
                    ConnectSQL.ExcuteQuery(query);
                    if (ConnectSQL.ExcuteNonQuery(query) > 0)
                    {
                        MessageBox.Show("Cập Nhật Khách Hàng Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập Nhật Khách Hàng Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                ShowCustomer();

                errorCustomer.Clear();
            }

        }
        //------------------------Sự Kiện------------------------//
        //Lấy Vị Trí Khí Click Vào Datagridview
        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            int SIZE = Customer.Rows.Count;
            if (vt >= 0 && vt != SIZE)
                ShowInTextBox(vt, Customer);

        }
   
        //Chỉ Cho Nhập Số
        private void txtPhoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
            
        }
        //Chỉ Cho Nhập Số
        private void txtIDCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }
        //Chỉ Cho Nhập Số

        // Xoá Dữ Liệu Tìm Kiếm + Focus txt
        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();
        }
        // Tắt Báo Lỗi Tên
        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            if(txtCustomerName.Text!="")
            {
                errorCustomer.Clear();
            }    
        }
        // Tắt Báo Lỗi Mã Thẻ
        private void txtIDCard_TextChanged(object sender, EventArgs e)
        {
            if (txtIDCard.Text != "")
            {
                errorCustomer.Clear();
            }
        }
        public static bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        // Tắt Báo Lỗi Email
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text != ""|| isEmail(txtEmail.Text))
            {
                errorCustomer.Clear();
            }
        }
        // Tắt Báo Lỗi Địa Chỉ
        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text != "")
            {
                errorCustomer.Clear();
            }
        }
        //------------------------Nút------------------------//
        //Nút Nhập Lại
        private void btnRefreshText_Click(object sender, EventArgs e)
        {
            errorCustomer.Clear();
            txtPhoneNum.Text = "";
            txtCustomerName.Text = "";
            txtIDCard.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            cbStatus.Text = "";
            txtSearch.Text = "";
            txtPhoneNum.Focus();
        }
        //Nút Thêm
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                errorCustomer.Clear();
                if (CheckNull() == 0)
                    txtPhoneNum.Focus();
                else if (CheckNull() == 1)
                    txtCustomerName.Focus();
                else if (CheckNull() == 2)
                    txtIDCard.Focus();
                else if (CheckNull() == 3)
                    txtEmail.Focus();
                else if (CheckNull() == 4)
                    txtAddress.Focus();
                else
                {
                    AddCustomer();
                }
            }
            catch
            {
                MessageBox.Show("Vui Lòng Kiểm Tra Lại", "Thông Báo");
            }
        }
        //Nút Xoá
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {

                errorCustomer.Clear();
                DeleteCustomer();
            }
            catch
            {
                MessageBox.Show("Vui Lòng Kiểm Tra Lại", "Thông Báo");
            }

        }
        //Nút Cập Nhật
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                errorCustomer.Clear();
                if (CheckNull() == 0)
                    txtPhoneNum.Focus();
                else if (CheckNull() == 1)
                    txtCustomerName.Focus();
                else if (CheckNull() == 2)
                    txtIDCard.Focus();
                else if (CheckNull() == 3)
                    txtEmail.Focus();
                else if (CheckNull() == 4)
                    txtAddress.Focus();
                else
                {
                    UpdateCustomer();
                }
            }
            catch
            {
                MessageBox.Show("Vui Lòng Kiểm Tra Lại", "Thông Báo");
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                SearchCustomer();
            }
            catch
            {
                MessageBox.Show("Vui Lòng Kiểm Tra Lại", "Thông Báo");
            }
        }

        private void cbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDistrict.Items.Clear();
            DataTable IDProvince = new DataTable();
            
            IDProvince = ConnectSQL.ExcuteQuery("select id from location.province where _name LIKE N'" + cbProvince.Text + "' ");
            District = ConnectSQL.ExcuteQuery("select * from location.District where _province_id = " + IDProvince.Rows[0][0] + " order by location.District._name");
            for (int i = 0; i < District.Rows.Count; i++)
            {
                cbDistrict.Items.Add(District.Rows[i][1].ToString());
            }
            cbDistrict.SelectedIndex = 0;
        }

        private void cbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbWard.Items.Clear();
            DataTable IDDistrict = new DataTable();
            IDDistrict = ConnectSQL.ExcuteQuery("select id from location.District where _name LIKE N'" + cbDistrict.Text + "' ");

            Ward = ConnectSQL.ExcuteQuery("select * from location.Ward where _district_id = " + IDDistrict.Rows[0][0] + " order by location.Ward._name");
            for (int i = 0; i < Ward.Rows.Count; i++)
            {
                cbWard.Items.Add(Ward.Rows[i][1].ToString());
            }
            cbWard.SelectedIndex = 0;

        }
    }
}
