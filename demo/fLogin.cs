using AForge.Video;
using AForge.Video.DirectShow;
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
using ZXing;

namespace demo
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        //Form load
        private void fLogin_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
                cbCamera.Items.Add(device.Name);
            cbCamera.SelectedIndex = 0;
            txtUserName.Focus();
            pbShowPassword.Visible = false;
        }
        //------------------------Khai Báo Biến------------------------//
        // Tạo lớp + datable
        Connect ConnectSQL = new Connect();
        DataTable Account = new DataTable();
        //------------------------Hàm------------------------//
        //Bắt lỗi Username
       
        //Kiểm tra thông tin tài khoản    
        bool CheckAccount()
        {
            bool Flag = false;
            string query = "select [UserName], [Password], [IDStaff] from Account";
            Account = ConnectSQL.ExcuteQuery(query);
            int Size = Account.Rows.Count;
            string a = txtPassword.Text;
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(a);
            byte[] pass = new MD5CryptoServiceProvider().ComputeHash(temp);
            string password = "";
            foreach (byte item in pass)
            {
                password += item;
            }
            for (int i = 0; i<Size;i++)
            {
                if (txtUserName.Text == Account.Rows[i][2].ToString() && password == Account.Rows[i][1].ToString())
                {
                    Flag = true;
                    break;
                }
                else
                    Flag = false;
            }    
            return Flag;
        }
        //------------------------Sự Kiện------------------------//
      
        // Hiện mật khẩu
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            
            txtPassword.UseSystemPasswordChar = false;
        }
        //Ẩn mật khẩu
        private void pbShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
        //------------------------Nút------------------------//
        //Nút đăng nhập
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckAccount())
            {
                Account = ConnectSQL.ExcuteQuery("Update Account set Status = '1' where IDStaff = '" + txtUserName.Text + "'");
                txtUserName.Text = "";
                txtPassword.Text = "";
                this.Hide();
                fHomePage fHP = new fHomePage();
                fHP.ReturnIDAccount = txtUserName.Text;
                fHP.ShowDialog();
                this.Close();
                
            }
            else
            {

                MessageBox.Show("Tài khoản hoặc mật khẩu sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
            }
        }    
        //Nút đăng ký
        private void btnRegister_Click(object sender, EventArgs e)
        {
            error.Clear();
            this.Hide();
            Form fRegis = new fRegister();          
            fRegis.ShowDialog();
            this.Close();
           
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbCamera.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += videoCaptureDevice_NewFrame;
                videoCaptureDevice.Start();    
        }

        private void videoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if(result!=null)
            {
                try
                {

                    txtPassword.Invoke(new MethodInvoker(delegate ()
                    {
                        string rs = result.ToString();
                        int user = rs.IndexOf(' ');
                        int pass = rs.LastIndexOf(' ');
                        txtUserName.Text = rs.Substring(0, user);
                        txtPassword.Text = rs.Substring(pass + 1);
                    }));
                }catch
                {
                    MessageBox.Show("Mã không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            picBarCode.Image = bitmap;


        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(videoCaptureDevice != null)
            {
                if(videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                }    
            }    
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            btnStop_Click(sender, e);
            txtUserName.Text = "";
            txtPassword.Text = "";
            using (OpenFileDialog o = new OpenFileDialog())
            {
                try
                {                  
                    
                    o.InitialDirectory = Path.GetFullPath("Barcode") + @"\";
                    o.Filter = "(*.jpg);(*.png)|*.jpg;*.png";
                    if (o.ShowDialog() == DialogResult.OK)
                    {
                        picBarCode.Image = Image.FromFile(o.FileName);
                        BarcodeReader reader = new BarcodeReader();
                        var result = reader.Decode((Bitmap)picBarCode.Image);
                        if (result != null)
                        {
                            string rs = result.ToString();
                            int user = rs.IndexOf(' ');
                            int pass = rs.LastIndexOf(' ');
                            txtUserName.Text = rs.Substring(0, user);
                            txtPassword.Text = rs.Substring(pass + 1);
                        }
                    }
                }catch
                {
                    MessageBox.Show("Vui lòng chọn lại mã", "Thông Báo");
                }
                  
            }    
        }
      


        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {
            pbShowPassword.Visible = true;
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            error.Clear();
            this.Hide();
            Form fRegis = new fRegister();
            fRegis.ShowDialog();
            this.Close();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            pbShowPassword.Visible = true;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {


            try
            {
                if (CheckAccount())
                {
                    this.Hide();
                    fHomePage fHP = new fHomePage();
                    fHP.ReturnIDAccount = txtUserName.Text;
                    fHP.ShowDialog();
                    this.Close();

                }
                else
                {

                    MessageBox.Show("Tài khoản hoặc mật khẩu sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserName.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại", "Thông báo");
            }

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text != "")
                error.Clear();
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                    picBarCode.Image = null;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                }
            }
            this.Close();
        }
    }
}
