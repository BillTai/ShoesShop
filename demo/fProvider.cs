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
    public partial class fProvider : Form
    {
        public fProvider()
        {
            InitializeComponent();
        }
        //Load đầu form
        private void fProvider_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dgvProvider.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 0; i<dgvProvider.Columns.Count;i++)
            {
                cbSearch.Items.Add(dgvProvider.Columns[i].HeaderText);
            }
            cbSearch.SelectedIndex = 0;
            ShowProvider();
            ShowInTextBox(0);
        }
        //------------------------Khai báo biến------------------------//
        Connect ConnectSQL = new Connect();
        DataTable Provider = new DataTable();
        //------------------------Hàm------------------------//
        //Kết nối query và dgv với sql
        void ConnectSql(string query, DataGridView dgv)
        {
            Provider = ConnectSQL.ExcuteQuery(query);
            dgv.DataSource = Provider;
        }
        // Danh sách NHÀ CUNG CẤP
        void ShowProvider()
        {
            String query = "select * from Provider";
            ConnectSql(query, dgvProvider);

        }
        //Hiểm thi textbox khi click datagridview
        void ShowInTextBox(int vt)
        {
            txtIDProvider.Text = Provider.Rows[vt][0].ToString();
            txtProviderName.Text = Provider.Rows[vt][1].ToString();
            txtIDCard.Text = Provider.Rows[vt][2].ToString();
            txtPhoneNum.Text = Provider.Rows[vt][3].ToString();
            txtEmail.Text = Provider.Rows[vt][4].ToString();
            txtAddress.Text = Provider.Rows[vt][5].ToString();
        }
        //Kiểm tra không nhập vào
        int CheckNull()
        {
            if (string.IsNullOrEmpty(txtProviderName.Text))
            {
                errorProvider.SetError(txtProviderName, "Nhập giá trị");
                return 0;
            }
            else if (string.IsNullOrEmpty(txtIDCard.Text))
            {
                errorProvider.SetError(txtIDCard, "Nhập giá trị");
                return 1;
            }
            else if (string.IsNullOrEmpty(txtPhoneNum.Text))
            {
                errorProvider.SetError(txtPhoneNum, "Nhập giá trị");
                return 2;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "Nhập giá trị");
                return 3;
            }
            else if (string.IsNullOrEmpty(txtAddress.Text))
            {
                errorProvider.SetError(txtAddress, "Nhập giá trị");
                return 4;
            }
            return -1;
        }
        //Kiểm tra trước khi cập nhật
        int CheckUpdate()
        {
            int Icheck = 0;
            int SIZE = Provider.Rows.Count;
            DataTable EmailPhoneCard = new DataTable();
            EmailPhoneCard = ConnectSQL.ExcuteQuery("Select IDCard, Email, PhoneNum from Provider where IDProvider = '" + txtIDProvider.Text + "'");
            for (int i = 0; i < SIZE; i++)
            {
                if (txtIDCard.Text == Provider.Rows[i][2].ToString())
                {
                    if (txtIDCard.Text == EmailPhoneCard.Rows[0][0].ToString())
                    {
                        continue;
                    }
                    Icheck = 1;
                    break;
                }              
                else if (txtPhoneNum.Text == Provider.Rows[i][3].ToString())
                {
                    if (txtPhoneNum.Text == EmailPhoneCard.Rows[0][2].ToString())
                    {
                        continue;
                    }
                    Icheck = 2;
                    break;
                }
                else if (txtEmail.Text == Provider.Rows[i][4].ToString())
                {
                    if (txtEmail.Text == EmailPhoneCard.Rows[0][1].ToString())
                    {
                        continue;
                    }
                    Icheck = 3;
                    break;
                }
            }
            return Icheck;
        }
        //Kiểm tra ID
        bool CheckID()
        {
            Provider = ConnectSQL.ExcuteQuery("SELECT * FROM Provider");
            for (int i = 0; i < Provider.Rows.Count; i++)
            {
                if (txtIDProvider.Text == Provider.Rows[i][0].ToString())
                {
                    return true;
                    break;
                }
            }
            return false;
        }
        //Kiểm tra trướk khi thêm
        int CheckAdd()
        {
            int Icheck = 0;
            int SIZE = Provider.Rows.Count;


            for (int i = 0; i < SIZE; i++)
            {
                if (txtIDProvider.Text == Provider.Rows[i][0].ToString())
                {
                    Icheck = 1;
                    break;
                }
                else if (txtIDCard.Text == Provider.Rows[i][2].ToString())
                   
                {

                    Icheck = 2;
                    break;
                }
                else if (txtPhoneNum.Text == Provider.Rows[i][3].ToString())
                {

                    Icheck = 3;
                    break;
                }
                else if (txtEmail.Text == Provider.Rows[i][4].ToString())
                {                   
                    Icheck = 4;
                    break;
                }
            }

            return Icheck;
        }
        //Tìm kiếm NCC
        void SearchProvider()
        {
            string query = "";
            for (int i = 0; i < Provider.Columns.Count; i++)
            {
                if (cbSearch.SelectedIndex == 0)
                {
                    query = "select * from Provider where IDProvider LIKE '%" + txtSearch.Text + "%'";
                }
                else if (cbSearch.SelectedIndex == 1)
                {
                    query = "select * from Provider where ProviderName LIKE '%" + txtSearch.Text + "%'";
                }
                else if (cbSearch.SelectedIndex == 2)
                {
                    query = "select * from Provider where IDCard LIKE '%" + txtSearch.Text + "%'";
                }
                else if (cbSearch.SelectedIndex == 3)
                {
                    query = "select * from Provider where PhoneNum LIKE '%" + txtSearch.Text + "%'";
                }
                else if (cbSearch.SelectedIndex == 4)
                {
                    query = "select * from Provider where Email LIKE '%" + txtSearch.Text + "%'";
                }
                else if (cbSearch.SelectedIndex == 5)
                {
                    query = "select * from Provider where Address LIKE '%" + txtSearch.Text + "%'";
                }               
                ConnectSql(query, dgvProvider);
            }
        }
        //Thêm NCC
        void AddProvider()
        {

            int SIZE = Provider.Rows.Count;
            string query = "INSERT INTO Provider (IDProvider, ProviderName, IDCard, PhoneNum, Email, Address) VALUES ('" + txtIDProvider.Text + "', N'" + txtProviderName.Text + "', '" + txtIDCard.Text + "', '" + txtPhoneNum.Text + "', '" + txtEmail.Text + "', N'" + txtAddress.Text + "')";
            if (CheckAdd() == 1)
            {
                MessageBox.Show("ID Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorProvider.SetError(txtIDProvider, "Nhập giá trị");
                txtIDProvider.Focus();
            }
            else if (CheckAdd() == 2)
            {
                MessageBox.Show("Mã Thẻ Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorProvider.SetError(txtIDCard, "Nhập giá trị");
                txtIDCard.Focus();
            }
            else if (CheckAdd() == 3)
            {
                MessageBox.Show("SĐT Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorProvider.SetError(txtPhoneNum, "Nhập giá trị");
                txtPhoneNum.Focus();
            }    
            else if (CheckAdd() == 4)
            {
                MessageBox.Show("Email Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorProvider.SetError(txtEmail, "Nhập giá trị");
                txtEmail.Focus();
            }
            else
            {
                DialogResult Question = MessageBox.Show("Bạn Có Muốn Thêm Nhà Cung Cấp", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Question == DialogResult.Yes)
                {
                    ConnectSQL.ExcuteQuery(query);
                }
                ShowProvider();

                int SIZE2 = Provider.Rows.Count;
                if (SIZE != SIZE2)
                {
                    MessageBox.Show("Thêm Nhân Viên Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }
        //Kiểm tra với sản phẩm trước khi xoá
        bool CheckWithProduct()
        {
            bool flag = false;
            DataTable Product = new DataTable();
            Product = ConnectSQL.ExcuteQuery("Select IDProvider from Product");
            for (int i = 0; i < Product.Rows.Count; i++)
            {
                if (txtIDProvider.Text == Product.Rows[i][0].ToString())
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        // Xoá NCC
        void DeleteProvider()
        {
            int SIZE = Provider.Rows.Count;
            if(CheckWithProduct())
            {
                MessageBox.Show("Còn Sản Phẩm Thuôc Nhà Cung Cấp Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDProvider.Focus();
                errorProvider.SetError(txtIDProvider, "Nhập lại giá trị");
            }
            else
            {

                string query = "delete from Provider where IDProvider = '" + txtIDProvider.Text + "'";
                DialogResult Question = MessageBox.Show("Bạn Có Muốn Xoá Nhà Cung Cấp", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Question == DialogResult.Yes)
                {
                    ConnectSQL.ExcuteQuery(query);
                }
                ShowProvider();
                int SIZE2 = Provider.Rows.Count;
                if (SIZE != SIZE2)
                {
                    MessageBox.Show("Xoá Nhà Cung Cấp Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xoá Nhà Cung Cấp Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        // Chỉnh sửa thông tin NCC
        void UpdateProvider()
        {
            string query = "update Provider set [ProviderName] = N'" + txtProviderName.Text + "',[IDCard] = '" + txtIDCard.Text + "', [PhoneNum] = '" + txtPhoneNum.Text + "', [Email] = '" + txtEmail.Text + "', [Address] = N'" + txtAddress.Text + "' where[IDProvider] = '" + txtIDProvider.Text + "'";
            if(!CheckID())
            {
                MessageBox.Show("Kiểm Tra Lại ID", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorProvider.SetError(txtIDProvider, "Nhập giá trị");
                txtIDProvider.Focus();
            }    
            else
            {
                if (CheckUpdate() == 1)
                {
                    MessageBox.Show("Mã Thẻ Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    errorProvider.SetError(txtIDCard, "Nhập giá trị");
                    txtIDCard.Focus();
                }
                else if (CheckUpdate() == 2)
                {
                    MessageBox.Show("SĐT Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    errorProvider.SetError(txtPhoneNum, "Nhập giá trị");
                    txtPhoneNum.Focus();
                }
                else if (CheckAdd() == 3)
                {
                    MessageBox.Show("Email Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    errorProvider.SetError(txtEmail, "Nhập giá trị");
                    txtEmail.Focus();
                }
                else
                {
                    DialogResult Question = MessageBox.Show("Bạn Có Muốn Cập Nhật Nhà Cung Cấp", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Question == DialogResult.Yes)
                    {
                        ConnectSQL.ExcuteQuery(query);
                    }
                    ShowProvider();
                    if (ConnectSQL.ExcuteNonQuery(query) > 0)
                    {
                        MessageBox.Show("Cập Nhật Thông Tin Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập Nhật Thông Tin Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }

        }
        //------------------------Sự kiện------------------------//
        //Lấy vị trí khi chọn dgv
        private void dgvProvider_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            int SIZE = Provider.Rows.Count;
            if (vt >= 0 && vt != SIZE)
                ShowInTextBox(vt);

        }
        //Tắt báo lỗi + ẩn hiện nút
        private void txtIDProvider_TextChanged(object sender, EventArgs e)
        {
            if(txtIDProvider.Text=="")
            {
                btnAddProvider.Enabled = false;
                btnDeleteProvider.Enabled = false;
                btnUpdateProvider.Enabled = false;
            }    
            else
            {
                errorProvider.Clear();
                btnAddProvider.Enabled = true;
                btnDeleteProvider.Enabled = true;
                btnUpdateProvider.Enabled = true;
            }    
        }
        //Tắt báo lỗi
        private void txtIDCard_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }
        //Thay dổi khi tìm kiếm
        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();
        }
        //Chỉ nhập số
        private void txtIDCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }
        //------------------------Nút------------------------//
        //Nút Thêm
        private void btnAddProvider_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (CheckNull() == 0)
                txtProviderName.Focus();
            else if (CheckNull() == 1)
                txtIDCard.Focus();
            else if (CheckNull() == 2)
                txtPhoneNum.Focus();
            else if (CheckNull() == 3)
                txtEmail.Focus();
            else if (CheckNull() == 4)
                txtAddress.Focus();
            else
            {
                AddProvider();
            }
        }
        //Nút xoá
        private void btnDeleteProvider_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            DeleteProvider();
        }
        //Nút tìm kiếm
        private void btnSearchProvider_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            SearchProvider();
        }
        //Nút thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Nút cập nhật
        private void btnUpdateProvider_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (CheckNull() == 0)
                txtProviderName.Focus();
            else if (CheckNull() == 1)
                txtIDCard.Focus();
            else if (CheckNull() == 2)
                txtPhoneNum.Focus();
            else if (CheckNull() == 3)
                txtEmail.Focus();
            else if (CheckNull() == 4)
                txtAddress.Focus();
            else
            {
                UpdateProvider();
            }    
        }
        //Nuta load lại
        private void btnReload_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            ShowProvider();
        }
        //Nút nhập lại
        private void btnRefreshText_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            txtIDProvider.Text = "";
            txtProviderName.Text = "";
            txtIDCard.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtPhoneNum.Text = "";
        }

        private void txtIDProvider_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }
    }
}
