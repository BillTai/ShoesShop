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
                cColor.Width = 60;
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
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void txtPriceIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFrom.Text = "";
            txtTo.Text = "";
            txtID.Text = "";
            if (cbSearch.SelectedIndex == 6  || cbSearch.SelectedIndex == 9 || cbSearch.SelectedIndex == 10 || cbSearch.SelectedIndex == 11)
            {
                pValues.Visible = true;
                txtFrom.Focus();

            }
            else
            {
                pValues.Visible = false;
                txtID.Focus();
                
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

        private void pButton_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

    