using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace demo
{
    public partial class fProduct : Form
    {
        public fProduct()
        {
            InitializeComponent();
        }
        // Load danh sách sản phẩm + combobox
        //------------------------Khai Báo Biến------------------------//
        Connect ConnectSQL = new Connect();
        DataTable Product = new DataTable();
        DataTable ProductType = new DataTable();
        DataTable Customer = new DataTable();
        DataTable ProductDetail = new DataTable();
        DataTable Color = new DataTable();
        DataTable Size = new DataTable();

        private void fEditProduct_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dgvProduct.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            DataTable TypeName = new DataTable();
            TypeName = ConnectSQL.ExcuteQuery("Select ProductTypeName from ProductType");
            Customer = ConnectSQL.ExcuteQuery("Select * from Customer where CustomerType = 0");
            ProductDetail = ConnectSQL.ExcuteQuery("Select IDProductDetail from ProductDetail");
            Color = ConnectSQL.ExcuteQuery("Select * from Color");
            Size = ConnectSQL.ExcuteQuery("Select * from Size");

            ShowProduct();
            for (int i = 0; i < Size.Rows.Count; i++)
            {
                cbSize.Items.Add(Size.Rows[i][0]);
            }
            for (int i = 0; i < Color.Rows.Count; i++)
            {
                cbColor.Items.Add(Color.Rows[i][1]);
            }
            for (int i = 0; i < TypeName.Rows.Count; i++)
            {
                cbProductType.Items.Add(TypeName.Rows[i][0]);
            }
            for (int i = 0; i < Customer.Rows.Count; i++)
            {
                cbProvider.Items.Add(Customer.Rows[i][1]);
            }
            for (int i = 0; i < Product.Columns.Count; i++)
            {
                cbSearch.Items.Add(dgvProduct.Columns[i].HeaderText);
            }
            
            cbSearch.SelectedIndex = 0;
            cbStatus.Items.Add("Còn hàng");
            cbStatus.Items.Add("Hết hàng");
            if (Product.Rows.Count >= 1)
            {
                ShowInTextBox(0);
            }
            if (txtIDProduct.Text == "")
            {
                btnAddProduct.Enabled = false;
                btnDeleteProduct.Enabled = false;
                btnUpdateProduct.Enabled = false;
            }
        }
        //------------------------Hàm------------------------//
        //Kết nối query và dgv với sql
        void ConnectSql(string query, DataGridView dgv)
        {
            Product = ConnectSQL.ExcuteQuery(query);
            dgv.DataSource = Product;
        }
        // Danh sách sản phẩm
        void ShowProduct()
        {
            String query = "select Product.IDProduct, ProductName, IDProductType, IDCustomer, Status, IDProductDetail, Size, Color, image, PriceIn, PriceOut, Number from Product, ProductDetail where Product.IDProduct = ProductDetail.IDProduct";
            ConnectSql(query, dgvProduct);

        }
        //Kiểm tra ID nhập vào có trùng không
        bool CheckID()
        {
            Product = ConnectSQL.ExcuteQuery("SELECT * FROM PRODUCT");
            int SIZE = Product.Rows.Count;
            for (int i = 0; i < SIZE; i++)
            {
                if (txtIDProduct.Text == Product.Rows[i][0].ToString())
                {
                    return true;
                    break;
                }
            }
            return false;
        }
        //Kiểm tra không nhập dữ liệu
      
        //Tìm kiếm sản phẩm
        void SearchProduct()
        {
            string query = "";
            for (int i = 0; i < Product.Columns.Count; i++)
            {
                if (cbSearch.SelectedIndex == 0)
                {
                    query = "select * from Product where IDProduct LIKE '%" + txtID.Text + "%'";
                }
                else if (cbSearch.SelectedIndex == 1)
                {
                    query = "select * from Product where ProductName LIKE N'%" + txtID.Text + "%'";
                }
                
               
            }
            ConnectSql(query, dgvProduct);
        }
        //Thêm sản phẩm mới
        void AddProduct()
        {
            int SIZE = Product.Rows.Count;
            
            string query = "INSERT INTO Product (IDProduct, ProductName, Number, PriceIN, PriceOut, IDProductType, IDProvider, Status, IDProductDetail) VALUES('" + txtIDProduct.Text + "', '" + txtProductName.Text + "', '" + cbProductType.Text + "', '" + IDProvider + "', '" + cbStatus.SelectedIndex + "')";
            if (CheckID())
            {
                MessageBox.Show("ID Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDProduct.Focus();
                errorProduct.SetError(txtIDProduct, "Nhập lại giá trị");
            }
            else
            {
                DialogResult Question = MessageBox.Show("Bạn Có Muốn Thêm Sản Phẩm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Question == DialogResult.Yes)
                {
                    ConnectSQL.ExcuteQuery(query);
                }                   
                ShowProduct();
                int SIZE2 = Product.Rows.Count;
                if (SIZE != SIZE2)
                {
                    MessageBox.Show("Thêm Sản Phẩm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm Sản Phẩm Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                errorProduct.Clear();
            }
        }
        // Xoá sản phẩm
        void DeleteProduct()
        {
            if (!CheckID())
            {
                MessageBox.Show("Kiểm tra lại ID", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDProduct.Focus();
                errorProduct.SetError(txtIDProduct, "Nhập lại giá trị");
            }
            else
            {
                int SIZE = Product.Rows.Count;                
                string query = "delete from Product where IDProduct = '" + txtIDProduct.Text+ "'";
                DialogResult Question = MessageBox.Show("Bạn Có Muốn Xoá Sản Phẩm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Question == DialogResult.Yes)
                {
                    ConnectSQL.ExcuteQuery(query);
                }
                ShowProduct();
                int SIZE2 = Product.Rows.Count;
                if (SIZE != SIZE2)
   
                    MessageBox.Show("Xoá Sản Phẩm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xoá Sản Phẩm Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorProduct.Clear();
            }
        }
        // Chỉnh sửa sản phẩm
        void UpdateProduct()
        {
            if (!CheckID())
            {
                txtIDProduct.Focus();
                MessageBox.Show("Kiểm tra lại ID", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDProduct.Focus();
                errorProduct.SetError(txtIDProduct, "Nhập lại giá trị");
            }
            else
            {
                string query = "update Product set [ProductName] = '" + txtProductName.Text + "',[IDProductType]= '" + cbProductType.Text + "',[IDProvider]= '" + cbProvider.Text + "',[Status]= " + cbStatus.SelectedIndex + ", where[IDProduct] = '" + txtIDProduct.Text + "'";
                DialogResult Question = MessageBox.Show("Bạn Có Muốn Cập Nhật Sản Phẩm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Question == DialogResult.Yes)
                {
                if (ConnectSQL.ExcuteNonQuery(query) >= 0)
                {
                        ConnectSQL.ExcuteQuery(query);
                        MessageBox.Show("Cập Nhật Sản Phẩm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập Nhật Sản Phẩm Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                  
                }
                ShowProduct();

                errorProduct.Clear();
            }

        }
        //Hiển thị vào textbox
        void ShowInTextBox(int vt)
        {
            DataTable TypeName = new DataTable();
            DataTable ProviderName = new DataTable();
            DataTable ColorName = new DataTable();

            txtIDProduct.Text = Product.Rows[vt][0].ToString();
            txtProductName.Text = Product.Rows[vt][1].ToString();
            TypeName = ConnectSQL.ExcuteQuery("Select ProductTypeName from ProductType where IDProductType LIKE N'"+Product.Rows[vt][2].ToString()+"'");
            cbProductType.SelectedItem = TypeName.Rows[0][0].ToString();
            ProviderName = ConnectSQL.ExcuteQuery("Select CustomerName from Customer where PhoneNum = '" + Product.Rows[vt][3].ToString() + "'");
            
            cbProvider.SelectedItem = ProviderName.Rows[0][0].ToString();
            if (Convert.ToInt32(Product.Rows[vt][4]) == 1)
                cbStatus.SelectedIndex = 1;
            else
                cbStatus.SelectedIndex = 0;
            txtIDProductDetail.Text = Product.Rows[vt][5].ToString();
            cbSize.Text = Product.Rows[vt][6].ToString();
            ColorName = ConnectSQL.ExcuteQuery("Select ColorName from Color where IDColor = '" + Product.Rows[vt][7].ToString() + "'");

            cbColor.Text = ColorName.Rows[0][0].ToString();

            txtImageName.Text = Product.Rows[vt][8].ToString();
            //string filename = Path.GetFullPath(@"image") + @"\";
            string filename = @".\image" + @"\";
            filename += txtImageName.Text;
            Bitmap i = new Bitmap(filename);
            pProduct.Image = i;
            txtPriceIn.Text = Product.Rows[vt][9].ToString();
            txtPriceOut.Text = Product.Rows[vt][10].ToString();
            nudNumber.Value = Convert.ToInt32(Product.Rows[vt][11]);



        }
        //------------------------Sự Kiện------------------------//
        // Chỉ nhập số
       
        // Chỉ nhập số
        
        // Chỉ nhập số
      
        // Chỉ nhập số
       
        // Lấy vị trí click trên dgv
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            int SIZE = Product.Rows.Count;
            if (vt >= 0 && vt != SIZE)
                ShowInTextBox(vt);
        }
        //Ẩn hiện panel search from to
        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearch.SelectedIndex > 1 && cbSearch.SelectedIndex < 5)
            {
                txtID.Text = "";
                txtID.Enabled = false;
                
            }
            else
            {
                txtID.Text = "";
                txtID.Enabled = true;
               
            }
        
            txtID.Focus();
        }
        //Ẩn Hiện Nút Thêm Xoá Sửa Khi Không Nhập ID
        private void txtIDProduct_TextChanged(object sender, EventArgs e)
        {
            if (txtIDProduct.Text == "")
            {
                btnDeleteProduct.Enabled = false;
                btnAddProduct.Enabled = false;
                btnUpdateProduct.Enabled = false;
            }
            else
            {
                errorProduct.Clear();
                btnDeleteProduct.Enabled = true;
                btnAddProduct.Enabled = true;
                btnUpdateProduct.Enabled = true;
            }
        }
        //Tắt báo lỗi
        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            errorProduct.Clear();
        }
        //Viết Hoa
        private void txtIDProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }
        //------------------------Nút------------------------//
        //Nút nhập lại
        private void btnRefreshText_Click(object sender, EventArgs e)
        {
            
        }
        //Nút tìm sản phẩm
        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            SearchProduct();
        }
        //Nút xoá sản phẩm
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            errorProduct.Clear();              
            DeleteProduct();
        }
        //Nút chỉnh sửa sản phẩm
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
           
        }
        //Nút thêm sản phẩm
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            

        }
        //Nút load lại sanh sách sản phẩm
        private void btnReload_Click(object sender, EventArgs e)
        {
            ShowProduct();
        }
        //Nút thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbIDProductType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbProductType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) == true && char.IsControl(e.KeyChar) == false && char.IsWhiteSpace(e.KeyChar) == false)
                e.Handled = true;
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            OpenFileDialog Image = new OpenFileDialog();
            Image.InitialDirectory = Path.GetDirectoryName(@"C:\Users\Bill\Desktop\Shoesshop1\ShoesShop\demo\bin\Debug\image");
            if (Image.ShowDialog() == DialogResult.Cancel)
            {
                Image.ShowDialog();
            }
            Bitmap i = new Bitmap(Image.FileName);
            pProduct.Image = i;
            pProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            string[] Name;
            Name = Image.FileName.Split('\\');
            txtImageName.Text = Name[Name.Count() - 1];
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPriceIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPriceIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearch.SelectedIndex > 1 && cbSearch.SelectedIndex < 5)
            {
                txtID.Text = "";
                txtID.Enabled = false;

            }
            else
            {
                txtID.Text = "";
                txtID.Enabled = true;

            }

            txtID.Focus();
        }

        private void txtIDProduct_TextChanged_1(object sender, EventArgs e)
        {
            if (txtIDProduct.Text == "")
            {
                btnDeleteProduct.Enabled = false;
                btnAddProduct.Enabled = false;
                btnUpdateProduct.Enabled = false;
            }
            else
            {
                errorProduct.Clear();
                btnDeleteProduct.Enabled = true;
                btnAddProduct.Enabled = true;
                btnUpdateProduct.Enabled = true;
            }
        }

        private void txtIDProduct_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }

        private void txtIDProduct_KeyUp(object sender, KeyEventArgs e)
        {
            txtIDProductDetail.Text = "CT_" + txtIDProduct.Text;
        }
    }
}

    