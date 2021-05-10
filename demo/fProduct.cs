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
        private void fEditProduct_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dgvProduct.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            ProductType = ConnectSQL.ExcuteQuery("Select * from ProductType");
            Provider = ConnectSQL.ExcuteQuery("Select * from Provider");
            ProductDetail = ConnectSQL.ExcuteQuery("Select IDProductDetail from ProductDetail");
            ShowProduct();
            for (int i = 0; i < ProductType.Rows.Count; i++)
            {
                cbProductType.Items.Add(ProductType.Rows[i][0]);
            }

            string ProviderName = "Select DISTINCT ProviderName from Provider";
            DataTable Name = new DataTable();
            Name = ConnectSQL.ExcuteQuery(ProviderName);
            for (int i = 1; i < Name.Rows.Count; i++)
            {
                cbProvider.Items.Add(Name.Rows[i][0]);
            }
            for (int i = 0; i < Product.Columns.Count; i++)
            {
                cbSearch.Items.Add(dgvProduct.Columns[i].HeaderText);
            }
            for (int i = 0; i < ProductDetail.Rows.Count; i++)
            {
                cbIDProductDetail.Items.Add(ProductDetail.Rows[i][0]);
            }
            cbSearch.SelectedIndex = 0;
            cbStatus.Items.Add("Còn hàng");
            cbStatus.Items.Add("Hết hàng");
            if (Product.Rows.Count >= 1)
            {
                ShowInTextBox(0, Product);
            }
            if (txtIDProduct.Text == "")
            {
                btnAddProduct.Enabled = false;
                btnDeleteProduct.Enabled = false;
                btnUpdateProduct.Enabled = false;
            }
        }
        //------------------------Khai Báo Biến------------------------//
        Connect ConnectSQL = new Connect();
        DataTable Product = new DataTable();
        DataTable ProductType = new DataTable();
        DataTable Provider = new DataTable();
        DataTable ProductDetail = new DataTable();
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
            String query = "select * from product";
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
        int CheckNull()
        {
            if(string.IsNullOrEmpty(txtProductName.Text))
            {
                errorProduct.SetError(txtProductName, "Nhập giá trị");
                return 0;
            }    
            else if(string.IsNullOrEmpty(nudNumber.Text))
            {
                errorProduct.SetError(nudNumber, "Nhập giá trị");
                return 1;
            }    
            else if (string.IsNullOrEmpty(txtPriceIn.Text))
            {
                errorProduct.SetError(txtPriceIn, "Nhập giá trị");
                return 2;
            }
            else if (string.IsNullOrEmpty(txtPriceOut.Text))
            {
                errorProduct.SetError(txtPriceOut, "Nhập giá trị");
                return 3;
            }
            return -1;
        }
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
                else if (cbSearch.SelectedIndex == 2)
                {
                    query = "select * from Product where Number between '" + txtFrom.Text + "' and '" + txtTo.Text + "'";
                }
                else if (cbSearch.SelectedIndex == 3)
                {
                    query = "select * from Product where PriceIn between '" + txtFrom.Text + "' and '" + txtTo.Text + "'";
                }
                else if (cbSearch.SelectedIndex == 4)
                {
                    query = "select * from Product where PriceOut between '" + txtFrom.Text + "' and '" + txtTo.Text + "'";
                }
                else if (cbSearch.SelectedIndex == 5)
                {
                    query = "select * from Product where IDProductType LIKE '%" + txtID.Text + "%'";
                }
                else if (cbSearch.SelectedIndex == 6)
                {
                    query = "select * from Product where IDProvider LIKE '%" + txtID.Text + "%'";
                }
                else if (cbSearch.SelectedIndex == 7)
                    query = "select * from Product where Status LIKE '%" + txtID.Text + "%'";
                else
                    query = "select * from Product where IDProductDetail LIKE '%" + txtID.Text + "%'";
                
            }
            ConnectSql(query, dgvProduct);
        }
        //Thêm sản phẩm mới
        void AddProduct()
        {
            int SIZE = Product.Rows.Count;

            //string ProviderName = "Select DISTINCT ProviderName from Provider";
            //DataTable Name = new DataTable();
            //Name = ConnectSQL.ExcuteQuery(ProviderName);
          
















            string IDProvider = Provider.Rows[0][0].ToString();
            string query = "INSERT INTO Product (IDProduct, ProductName, Number, PriceIN, PriceOut, IDProductType, IDProvider, Status, IDProductDetail) VALUES('" + txtIDProduct.Text + "', '" + txtProductName.Text + "', '" + nudNumber.Value + "', '" + txtPriceIn.Text + "', '" + txtPriceOut.Text + "', '" + cbProductType.Text + "', '" + IDProvider + "', '" + cbStatus.SelectedIndex + "', '" + cbIDProductDetail.Text + "')";
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
                string query = "update Product set [ProductName] = '" + txtProductName.Text + "', [Number] = " + nudNumber.Value + ", [PriceIN] = " + txtPriceIn.Text + ", [PriceOut]= " + txtPriceOut.Text + ",[IDProductType]= '" + cbProductType.Text + "',[IDProvider]= '" + cbProvider.Text + "',[Status]= " + cbStatus.SelectedIndex + ",[IDProductDetail]= '" + cbIDProductDetail.Text + "' where[IDProduct] = '" + txtIDProduct.Text + "'";
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
        void ShowInTextBox(int vt, DataTable ds)
        {

            txtIDProduct.Text = ds.Rows[vt][0].ToString();
            txtProductName.Text = ds.Rows[vt][1].ToString();
            nudNumber.Text = ds.Rows[vt][2].ToString();
            txtPriceIn.Text = ds.Rows[vt][3].ToString();
            txtPriceOut.Text = ds.Rows[vt][4].ToString();
            cbProductType.Text = ds.Rows[vt][5].ToString();            
            cbProvider.Text = ds.Rows[vt][6].ToString();
            cbIDProductDetail.Text = ds.Rows[vt][8].ToString();
            if ((ds.Rows[vt][7]).ToString() == "0")
            {
                cbStatus.SelectedIndex = 0;
            }
            else
                cbStatus.SelectedIndex = 1;
            txtImageName.Text = ds.Rows[vt][9].ToString();
            string filename = Path.GetFullPath("image") + @"\";
            filename += txtImageName.Text;
            Bitmap i = new Bitmap(filename);
            pProduct.Image = i;
            
          
        }
        //------------------------Sự Kiện------------------------//
        // Chỉ nhập số
        private void txtPriceIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false )
                e.Handled = true;
        }
        // Chỉ nhập số
        private void txtPriceOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }
        // Chỉ nhập số
        private void txtFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }
        // Chỉ nhập số
        private void txtTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }
        // Lấy vị trí click trên dgv
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            int SIZE = Product.Rows.Count;
            if (vt >= 0 && vt != SIZE)
                ShowInTextBox(vt, Product);
        }
        //Ẩn hiện panel search from to
        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearch.SelectedIndex > 1 && cbSearch.SelectedIndex < 5)
            {
                txtID.Text = "";
                txtID.Enabled = false;
                pValues.Visible = true;
                txtFrom.Focus();
            }
            else
            {
                txtID.Text = "";
                txtID.Enabled = true;
                pValues.Visible = false;
            }
            txtFrom.Text = "";
            txtTo.Text = "";
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
            txtIDProduct.Text = "";
            txtProductName.Text = "";
            nudNumber.Value = 0;
            txtPriceIn.Text = "";
            txtPriceOut.Text = "";
            cbIDProductDetail.Text = "";
            cbProductType.Text = "";
            cbProvider.Text = "";
            cbStatus.Text = "";
            txtID.Text = "";
            txtTo.Text = "";
            txtFrom.Text = "";
            txtIDProduct.Focus();
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
            errorProduct.Clear();
            if (CheckNull() == 0)
                txtProductName.Focus();
            else if (CheckNull() == 1)
                nudNumber.Select();
            else if (CheckNull() == 2)
                txtPriceIn.Focus();
            else if (CheckNull() == 3)
                txtPriceOut.Focus();
            else
            {               
                UpdateProduct();
            }
        }
        //Nút thêm sản phẩm
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            errorProduct.Clear();
            if (CheckNull() == 0)
                txtProductName.Focus();
            else if (CheckNull() == 1)
                nudNumber.Select();
            else if (CheckNull() == 2)
                txtPriceIn.Focus();
            else if (CheckNull() == 3)
                txtPriceOut.Focus();
            else
            {              
                AddProduct();

            }

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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Image = new OpenFileDialog();
            Image.InitialDirectory = Path.GetDirectoryName("Image");
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
    }
}

