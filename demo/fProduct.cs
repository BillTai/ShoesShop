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
        
        //Kết nối query và dgv với sql

        // Danh sách sản phẩm
        void ShowProduct()
        {            
            Product = ConnectSQL.ExcuteQuery("select * from Product");
            dgvProduct.DataSource = Product;         
        }
        void ShowProductDetail(int vt)
        {
            ProductDetail = ConnectSQL.ExcuteQuery("Select * from ProductDetail where IDProduct = '" + Product.Rows[vt][0] + "'");
            dgvProductDetail.DataSource = ProductDetail;
        }
        private void fEditProduct_Load(object sender, EventArgs e)
        {
            pValues.Visible = false;
            foreach (DataGridViewColumn column in dgvProduct.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn column in dgvProductDetail.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            DataTable TypeName = new DataTable();
            TypeName = ConnectSQL.ExcuteQuery("Select ProductTypeName from ProductType");
            Customer = ConnectSQL.ExcuteQuery("Select * from Customer where CustomerType = 0");
            Color = ConnectSQL.ExcuteQuery("Select * from Color");
            Size = ConnectSQL.ExcuteQuery("Select * from Size");
            flp1.Controls.Clear();
            flp2.Controls.Clear();
            int SizeNum = Size.Rows.Count;
            int ColorNum = Color.Rows.Count;
            for (int i = 0; i < SizeNum; i++)
            {
                CheckBox cSize = new CheckBox();
                cSize.Text = Size.Rows[i][0].ToString();
                cSize.Name = "ckb" + cSize.Text;
                cSize.Width = 38;
                cSize.Height = 17;
                flp1.Controls.Add(cSize);
            }
            for (int i = 0; i < ColorNum; i++)
            {
                CheckBox cColor = new CheckBox();
                cColor.Text = Color.Rows[i][1].ToString();
                cColor.Name = "ckb" + cColor.Text;
                cColor.Width = 80;
                cColor.Height = 17;
                flp2.Controls.Add(cColor);
            }
            ShowProduct();                   
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
                ShowProductDetail(0);
                ShowDetailInTextBox(0);
            }           
        }          
        void ShowInTextBox(int vt)
        {          
            DataTable TypeName = new DataTable();
            DataTable ProviderName = new DataTable();            
            txtIDProduct.Text = Product.Rows[vt][0].ToString();
            txtProductName.Text = Product.Rows[vt][1].ToString();
            TypeName = ConnectSQL.ExcuteQuery("Select ProductTypeName from ProductType where IDProductType LIKE N'" + Product.Rows[vt][2].ToString() + "'");
            cbProductType.SelectedItem = TypeName.Rows[0][0].ToString();
            ProviderName = ConnectSQL.ExcuteQuery("Select CustomerName from Customer where PhoneNum = '" + Product.Rows[vt][3].ToString() + "'");
            cbProvider.SelectedItem = ProviderName.Rows[0][0].ToString();
            if (Convert.ToInt32(Product.Rows[vt][4]) == 1)
                cbStatus.SelectedIndex = 1;
            else
                cbStatus.SelectedIndex = 0;                            
        }
        void ShowDetailInTextBox(int vt)
        {
            if (ProductDetail.Rows.Count > 0)
            {
                DataTable ColorName = new DataTable();
                txtIDProductDetail.Text = ProductDetail.Rows[vt][0].ToString();
                ColorName = ConnectSQL.ExcuteQuery("Select ColorName from Color where IDColor = '" + ProductDetail.Rows[vt][2].ToString() + "'");
                int SizeNum = Size.Rows.Count;
                for (int i = 0; i < SizeNum; i++)
                {
                    CheckBox n = (CheckBox)flp1.Controls[i];

                    if (n.Text != ProductDetail.Rows[vt][1].ToString())
                    {
                        n.Checked = false;
                    }
                    else
                        n.Checked = true;

                }
                int ColorNum = Color.Rows.Count;

                for (int i = 0; i < ColorNum; i++)
                {
                    CheckBox n = (CheckBox)flp2.Controls[i];

                    if (n.Text != ColorName.Rows[0][0].ToString())
                    {
                        n.Checked = false;
                    }
                    else
                        n.Checked = true;

                }
                txtImageName.Text = ProductDetail.Rows[vt][3].ToString();
                string filename = @".\image" + @"\";
                filename += txtImageName.Text;
                Bitmap img = new Bitmap(filename);
                pProduct.Image = img;
                txtPriceIn.Text = ProductDetail.Rows[vt][4].ToString();
                txtPriceOut.Text = ProductDetail.Rows[vt][5].ToString();
                nudNumber.Value = Convert.ToInt32(ProductDetail.Rows[vt][6]);
            }
        }
        bool CheckID()
        {
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
        int CheckNullProduct()
        {
            if (string.IsNullOrEmpty(txtIDProduct.Text))
            {
                errorProduct.SetError(txtIDProduct, "Nhập giá trị");
                return 0;
            }
            else if (string.IsNullOrEmpty(txtProductName.Text))
            {
                errorProduct.SetError(txtProductName, "Nhập giá trị");
                return 1;
            }
            return -1;
        }
        void Add()
        {
            try
            {
                DataTable IDType = new DataTable();
                DataTable IDProvider = new DataTable();
                IDType = ConnectSQL.ExcuteQuery("Select IDProductType from ProductType Where ProductTypeName = N'" + cbProductType.SelectedItem + "'");
                string ProductType = IDType.Rows[0][0].ToString();
                IDProvider = ConnectSQL.ExcuteQuery("Select PhoneNum from Customer Where CustomerName = N'" + cbProvider.SelectedItem + "'");
                string ProductProvider = IDProvider.Rows[0][0].ToString();
                int SIZE = Product.Rows.Count;
                string query = "insert into Product([IDProduct],[ProductName],[IDProductType],[IDCustomer],[Status]) values('"+txtIDProduct.Text+ "', '" + txtProductName.Text + "', '"+ProductType+ "', '" + ProductProvider + "', '0')";
                if (CheckNullProduct() == -1 && !CheckID())
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
                else if (CheckNullProduct() == 0)
                    txtIDProduct.Focus();
                else if (CheckNullProduct() == 1)
                    txtProductName.Focus();
                else if (CheckID())
                {
                    MessageBox.Show("Sản phẩm đã tồn tại!", "Thông Báo");
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!", "Thông Báo");
            }
        }
        void Delete()
        {
            try
            {
                if (!CheckID())
                {
                    MessageBox.Show("Kiểm tra lại mã sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDProduct.Focus();
                    errorProduct.SetError(txtIDProduct, "Nhập lại giá trị");
                }
                else
                {
                    int SIZE = Product.Rows.Count;
                    string query = "delete from ProductDetail where IDProduct = '" + txtIDProduct.Text + "'";
                    string query1 = "delete from Product where IDProduct = '" + txtIDProduct.Text + "'";
                    DialogResult Question = MessageBox.Show("Bạn Có Muốn Xoá Sản Phẩm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Question == DialogResult.Yes)
                    {
                        ConnectSQL.ExcuteQuery(query);
                        ConnectSQL.ExcuteQuery(query1);
                        ShowProduct();
                        int SIZE2 = Product.Rows.Count;
                        if(SIZE2>0)
                        {
                            ShowProductDetail(0);
                        }    
                        if (SIZE != SIZE2)

                            MessageBox.Show("Xoá Sản Phẩm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Xoá Sản Phẩm Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        errorProduct.Clear();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!", "Thông Báo");
            }
        }
        void Update()
        {
            try
            {
                DataTable IDType = new DataTable();
                DataTable IDProvider = new DataTable();
                IDType = ConnectSQL.ExcuteQuery("Select IDProductType from ProductType Where ProductTypeName = N'" + cbProductType.SelectedItem + "'");
                string ProductType = IDType.Rows[0][0].ToString();
                IDProvider = ConnectSQL.ExcuteQuery("Select PhoneNum from Customer Where CustomerName = N'" + cbProvider.SelectedItem + "'");
                string ProductProvider = IDProvider.Rows[0][0].ToString();
                string query = "UPDATE Product SET ProductName = N'" + txtProductName.Text + "', IDProductType = '"+ProductType+ "',  IDCustomer = '" + ProductProvider + "',Status = '"+cbStatus.SelectedIndex+"'  WHERE IDProduct = '" + txtIDProduct.Text + "'";
                if (CheckID() && CheckNullProduct() == -1 )
                {
                    DialogResult Question = MessageBox.Show("Bạn Có Muốn Cập Nhật Sản Phẩm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Question == DialogResult.Yes)
                    {
                        ConnectSQL.ExcuteQuery(query);
                        if (ConnectSQL.ExcuteNonQuery(query) > 0)
                        {
                            MessageBox.Show("Cập Nhật Sản Phẩm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Cập Nhật Sản Phẩm Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        errorProduct.Clear();
                    }
                    ShowProduct();
                }
                else if (CheckNullProduct() == 0)
                    txtIDProduct.Focus();
                else if (CheckNullProduct() == 1)
                    txtProductName.Focus();             
                else if (!CheckID())
                {
                    MessageBox.Show("Kiểm tra lại mã sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDProduct.Focus();
                    errorProduct.SetError(txtIDProduct, "Nhập lại giá trị");
                }
            }
            catch
            {
                MessageBox.Show("Vui Lòng Kiểm Tra Lại", "Thông Báo");
            }
        }
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            int SIZE = Product.Rows.Count;
            if (vt >= 0 && vt != SIZE)
            {
                ShowInTextBox(vt);
                ShowProductDetail(vt);
                ShowDetailInTextBox(0);
            }
        }
        private void dgvProductDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt1 = e.RowIndex;
            int SIZE = ProductDetail.Rows.Count;
            if (vt1 >= 0 && vt1 != SIZE)
            {
                ShowDetailInTextBox(vt1);
            }
        }
        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearch.SelectedIndex > 1 && cbSearch.SelectedIndex < 5)
            {
                txtSearch.Text = "";
                txtSearch.Enabled = false;
                
            }
            else
            {
                txtSearch.Text = "";
                txtSearch.Enabled = true;
               
            }
        
            txtSearch.Focus();
        }
        private void txtIDProduct_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            errorProduct.Clear();
        }
        private void txtIDProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtPriceIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFrom.Text = "";
            txtTo.Text = "";
            txtSearch.Text = "";
            if (cbSearch.SelectedIndex == 6  || cbSearch.SelectedIndex == 9 || cbSearch.SelectedIndex == 10 || cbSearch.SelectedIndex == 11)
            {
                pValues.Visible = true;
                txtFrom.Focus();
            }
            else
            {
                pValues.Visible = false;
                txtSearch.Focus();                
            }          
        }
        private void txtIDProduct_TextChanged_1(object sender, EventArgs e)
        {
            
            
        }
        private void txtIDProduct_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }
        private void txtID_KeyUp(object sender, KeyEventArgs e)
        {
            //string query = "";
            //string x = "";
            //for (int i = 0; i < Product.Columns.Count; i++)
            //{
            //    if (i == cbSearch.SelectedIndex)
            //    {               
            //            if (i < 5)
            //                x = "Product.";
            //            else x = "ProductDetail.";
            //            query = qPro + " And " + x + Product.Columns[i].ToString() + " LIKE '%" + txtID.Text + "%'";
            //            break;                 
            //    }
            //}
            //ConnectSql(query, dgvProduct);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
        private void btnSize_Click(object sender, EventArgs e)
        {
            this.Hide();
            fSize fSize = new fSize();
            fSize.ShowDialog();
            this.Close();
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            this.Hide();
            fColor fColor = new fColor();
            fColor.ShowDialog();
            this.Close();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            errorProduct.Clear();
            Update();
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Image = new OpenFileDialog();
                Image.InitialDirectory = Path.GetDirectoryName(@"C:\Users\Bill\Desktop\Shoesshop1\ShoesShop\demo\bin\Debug\image\");
                if (Image.ShowDialog() == DialogResult.Yes)
                {
                    Image.ShowDialog();
                }
                if (Image.FileName != "")
                {
                    Bitmap i = new Bitmap(Image.FileName);
                    pProduct.Image = i;
                    pProduct.SizeMode = PictureBoxSizeMode.StretchImage;
                    string[] Name;
                    Name = Image.FileName.Split('\\');
                    txtImageName.Text = Name[Name.Count() - 1];
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn lại ảnh!", "Thông Báo");
            }
        }
    }
}

    