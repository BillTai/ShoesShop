using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class fRegister : Form
    {
        public fRegister()
        {
            InitializeComponent();
        }
        // Form load
        private void fRegister_Load(object sender, EventArgs e)
        {
            cbStatus.Items.Add("Giám đốc");
            cbStatus.Items.Add("Nhân viên bán hàng");
            cbStatus.Items.Add("Kế Toán");
            cbStatus.SelectedIndex = 0;
            btnSaveQrcode.Visible = false;
        }
        //------------------------Khai Báo Biến------------------------//
        // Tạo lớp + datatable
        Connect ConnectSQL = new Connect();
        DataTable Staff = new DataTable();
        //------------------------Hàm------------------------//
        // So sánh dữ liệu nhập vào với database
        bool CheckRegister()
        {
            bool Flag = false;
            string query = " select [IDStaff], [StaffName], [PhoneNum], [Email], [Status] from Staff where IDStaff = '"+txtIDStaff.Text+"' and [Status] < 3";
            Staff = ConnectSQL.ExcuteQuery(query);
            int SIZE = Staff.Rows.Count;
            if(SIZE>0)
            {
                if (txtIDStaff.Text == Staff.Rows[0][0].ToString() && txtUsername.Text == Staff.Rows[0][1].ToString() && txtPhoneNum.Text == Staff.Rows[0][2].ToString() && txtEmail.Text == Staff.Rows[0][3].ToString() && cbStatus.SelectedIndex == Convert.ToInt32(Staff.Rows[0][4]))
                {
                    Flag = true;
                    
                }
            }    
            return Flag;         
        }
        //Kiểm tra giá trị rỗng
        void CheckNullValue()
        {
            if (string.IsNullOrEmpty(txtIDStaff.Text))
            {
                txtIDStaff.Focus();
                errorRegister.SetError(txtIDStaff, "Nhập giá trị");
            }
            else if (string.IsNullOrEmpty(txtUsername.Text))
            {
                txtUsername.Focus();
                errorRegister.SetError(txtUsername, "Nhập giá trị");
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.Focus();
                errorRegister.SetError(txtEmail, "Nhập giá trị");
            }
            else if (string.IsNullOrEmpty(txtPhoneNum.Text))
            {
                txtPhoneNum.Focus();
                errorRegister.SetError(txtPhoneNum, "Nhập giá trị");
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Focus();
                errorRegister.SetError(txtPassword, "Nhập giá trị");
            }
            else if (string.IsNullOrEmpty(txtRePassword.Text))
            {
                txtRePassword.Focus();
                errorRegister.SetError(txtRePassword, "Nhập giá trị");
            }
        }
        //Kiểm tra tài khoản đã tồn tại
        bool CheckAccount()
        {
            bool Flag = false;
            string query = "select [IDStaff] from Account where IDStaff = '" + txtIDStaff.Text + "'";
            Staff = ConnectSQL.ExcuteQuery(query);
            int SIZE = Staff.Rows.Count;
            for (int i = 0; i < SIZE;i++)
            {
                if (txtIDStaff.Text == Staff.Rows[i][0].ToString())
                {
                    Flag = true;
                    break;
                }
            }             
            return Flag;
        }   
        //Kiểm tra không nhập dữ liệu
        int CheckNull()
        {
            if (txtIDStaff.Text == "")
                return 0;
            else if (txtUsername.Text == "")
                return 1;
            else if (txtEmail.Text == "")
                return 2;
            else if (txtPhoneNum.Text == "")
                return 3;
            else if (txtPassword.Text =="")
            {
                return 4;
            }
            else if (txtRePassword.Text == "")
            {
                return 5;
            }
            else if (txtPassword.Text != txtRePassword.Text)
            {
                return 6;
            }
            else
            return -1;
        }
        //------------------------Nút------------------------//
        //Nút Trở về form đăng nhập
        private void lblfLogIn_Click(object sender, EventArgs e)
        {
            Form fLog = new fLogin();
            this.Hide();
            fLog.ShowDialog();
            this.Close();
        }
        // Nút đăng ký
        
        //------------------------Sự kiện------------------------//
        //Chỉ Nhập Số
     

        private void txtIDStaff_TextChanged_1(object sender, EventArgs e)
        {
            errorRegister.Clear();
        }

        private void txtIDStaff_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            errorRegister.Clear();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            errorRegister.Clear();

        }

        private void txtPhoneNum_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void txtPhoneNum_TextChanged(object sender, EventArgs e)
        {
            errorRegister.Clear();

        }

        private void txtPassword_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) == true)
                e.Handled = true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            errorRegister.Clear();

        }

        private void txtRePassword_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) == true)
                e.Handled = true;
        }

        private void txtRePassword_TextChanged(object sender, EventArgs e)
        {
            errorRegister.Clear();

        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            //try
            //{
                CheckNullValue();

                if (CheckNull() == -1)
                {
                    if (CheckRegister())
                    {
                        if (CheckAccount())
                        {
                            MessageBox.Show("Tài khoản đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string a = txtPassword.Text;
                            byte[] temp = ASCIIEncoding.ASCII.GetBytes(a);
                            byte[] pass = new MD5CryptoServiceProvider().ComputeHash(temp);
                            string password = "";
                            foreach (byte item in pass)
                            {
                                password += item;
                            }
                            string query = "INSERT INTO Account VALUES(N'" + txtUsername.Text + "', '" +password + "', '" + txtPhoneNum.Text + "', '" + txtEmail.Text + "', '" + txtIDStaff.Text + "','0')";
                            Staff = ConnectSQL.ExcuteQuery(query);
                            MessageBox.Show("Tạo tài khoản thành công:" + "\nUsername: " + txtUsername.Text + "\nIDStaff: " + txtIDStaff.Text + "\nChức vụ: " + cbStatus.SelectedItem, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            string qrcode = txtIDStaff.Text + " " + txtPassword.Text;
                            pQrcode.Image = null;
                            Zen.Barcode.CodeQrBarcodeDraw qrcodec = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                            pQrcode.Image = qrcodec.Draw(qrcode, 50);
                            btnSaveQrcode.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể tạo tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (CheckNull() == 0)
                {
                    MessageBox.Show("Vui lòng nhập mã nhân viên", "Thông báo");
                    txtIDStaff.Focus();
                }
                else if (CheckNull() == 1)
                {
                    MessageBox.Show("Vui lòng nhập tên nhân viên", "Thông báo");
                    txtUsername.Focus();
                }
                else if (CheckNull() == 2)
                {
                    MessageBox.Show("Vui lòng nhập email", "Thông báo");
                    txtEmail.Focus();
                }
                else if (CheckNull() == 3)
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại", "Thông báo");
                    txtPhoneNum.Focus();
                }
                else if (CheckNull() == 4)
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo");
                    txtPassword.Focus();
                }
                else if (CheckNull() == 5)
                {
                    MessageBox.Show("Vui lòng nhập xác nhận mật khẩu", "Thông báo");
                    txtRePassword.Focus();
                }
                else if (CheckNull() == 6)
                {
                    MessageBox.Show("Vui lòng kiểm tra lại mật khẩu", "Thông báo");
                    txtRePassword.Focus();
                }
            //}catch
            //{
            //    MessageBox.Show("Vui lòng kiểm tra lại", "Thông báo");
            //}
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            fLogin login = new fLogin();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void btnSaveQrcode_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Path.GetFullPath("Barcode") + @"\";
            saveFileDialog1.Title = "Save Image Files";
            saveFileDialog1.DefaultExt = "png";
            saveFileDialog1.Filter = "(*.jpg);(*.png)|*.jpg;*.png";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (pQrcode.Image != null)
                    pQrcode.Image.Save(saveFileDialog1.FileName);
                else
                    MessageBox.Show("Vui Lòng Chọn Ảnh", "Thông Báo");
            }
        }
    }
}
