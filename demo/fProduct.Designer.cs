
namespace demo
{
    partial class fProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pButton = new System.Windows.Forms.Panel();
            this.cbSearch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtIDProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnUpdateProduct = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteProduct = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefreshText = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddProduct = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTypeProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbProductType = new System.Windows.Forms.ComboBox();
            this.cbProvider = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProduct = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtImageName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPriceOut = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPriceIn = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.pProduct = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDProductDetail = new Guna.UI2.WinForms.Guna2TextBox();
            this.pButton.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProduct)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // pButton
            // 
            this.pButton.Controls.Add(this.cbSearch);
            this.pButton.Controls.Add(this.txtID);
            this.pButton.Controls.Add(this.btnUpdateProduct);
            this.pButton.Controls.Add(this.btnDeleteProduct);
            this.pButton.Controls.Add(this.btnExit);
            this.pButton.Controls.Add(this.btnRefreshText);
            this.pButton.Controls.Add(this.btnAddProduct);
            this.pButton.Controls.Add(this.btnSearchProduct);
            this.pButton.Location = new System.Drawing.Point(869, 17);
            this.pButton.Name = "pButton";
            this.pButton.Size = new System.Drawing.Size(352, 211);
            this.pButton.TabIndex = 0;
            // 
            // cbSearch
            // 
            this.cbSearch.BackColor = System.Drawing.Color.Transparent;
            this.cbSearch.BorderColor = System.Drawing.Color.Black;
            this.cbSearch.BorderRadius = 5;
            this.cbSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSearch.DropDownHeight = 100;
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.DropDownWidth = 260;
            this.cbSearch.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearch.FocusedState.Parent = this.cbSearch;
            this.cbSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSearch.HoverState.Parent = this.cbSearch;
            this.cbSearch.IntegralHeight = false;
            this.cbSearch.ItemHeight = 30;
            this.cbSearch.ItemsAppearance.Parent = this.cbSearch;
            this.cbSearch.Location = new System.Drawing.Point(37, 73);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.cbSearch.ShadowDecoration.Parent = this.cbSearch;
            this.cbSearch.Size = new System.Drawing.Size(260, 36);
            this.cbSearch.TabIndex = 12;
            this.cbSearch.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // txtIDProduct
            // 
            this.txtIDProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtIDProduct.BorderRadius = 10;
            this.txtIDProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDProduct.DefaultText = "";
            this.txtIDProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDProduct.DisabledState.Parent = this.txtIDProduct;
            this.txtIDProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDProduct.FocusedState.Parent = this.txtIDProduct;
            this.txtIDProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDProduct.ForeColor = System.Drawing.Color.Black;
            this.txtIDProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDProduct.HoverState.Parent = this.txtIDProduct;
            this.txtIDProduct.Location = new System.Drawing.Point(126, 4);
            this.txtIDProduct.Name = "txtIDProduct";
            this.txtIDProduct.PasswordChar = '\0';
            this.txtIDProduct.PlaceholderText = "";
            this.txtIDProduct.SelectedText = "";
            this.txtIDProduct.ShadowDecoration.Parent = this.txtIDProduct;
            this.txtIDProduct.Size = new System.Drawing.Size(138, 27);
            this.txtIDProduct.TabIndex = 11;
            this.txtIDProduct.TextChanged += new System.EventHandler(this.txtIDProduct_TextChanged_1);
            this.txtIDProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDProduct_KeyPress_1);
            this.txtIDProduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIDProduct_KeyUp);
            // 
            // txtID
            // 
            this.txtID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtID.BorderRadius = 10;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.Parent = this.txtID;
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.FocusedState.Parent = this.txtID;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.HoverState.Parent = this.txtID;
            this.txtID.Location = new System.Drawing.Point(71, 115);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderText = "";
            this.txtID.SelectedText = "";
            this.txtID.ShadowDecoration.Parent = this.txtID;
            this.txtID.Size = new System.Drawing.Size(189, 27);
            this.txtID.TabIndex = 11;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BorderRadius = 9;
            this.btnUpdateProduct.CheckedState.Parent = this.btnUpdateProduct;
            this.btnUpdateProduct.CustomImages.Parent = this.btnUpdateProduct;
            this.btnUpdateProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateProduct.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateProduct.HoverState.Parent = this.btnUpdateProduct;
            this.btnUpdateProduct.Location = new System.Drawing.Point(220, 7);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.ShadowDecoration.Parent = this.btnUpdateProduct;
            this.btnUpdateProduct.Size = new System.Drawing.Size(82, 27);
            this.btnUpdateProduct.TabIndex = 10;
            this.btnUpdateProduct.Text = "Cập Nhật";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BorderRadius = 9;
            this.btnDeleteProduct.CheckedState.Parent = this.btnDeleteProduct;
            this.btnDeleteProduct.CustomImages.Parent = this.btnDeleteProduct;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteProduct.HoverState.Parent = this.btnDeleteProduct;
            this.btnDeleteProduct.Location = new System.Drawing.Point(132, 7);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.ShadowDecoration.Parent = this.btnDeleteProduct;
            this.btnDeleteProduct.Size = new System.Drawing.Size(82, 27);
            this.btnDeleteProduct.TabIndex = 10;
            this.btnDeleteProduct.Text = "Xoá";
            // 
            // btnExit
            // 
            this.btnExit.BorderRadius = 9;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.HoverState.BorderColor = System.Drawing.SystemColors.Control;
            this.btnExit.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(220, 40);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(82, 27);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnRefreshText
            // 
            this.btnRefreshText.BorderRadius = 9;
            this.btnRefreshText.CheckedState.Parent = this.btnRefreshText;
            this.btnRefreshText.CustomImages.Parent = this.btnRefreshText;
            this.btnRefreshText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshText.ForeColor = System.Drawing.Color.Black;
            this.btnRefreshText.HoverState.Parent = this.btnRefreshText;
            this.btnRefreshText.Location = new System.Drawing.Point(37, 40);
            this.btnRefreshText.Name = "btnRefreshText";
            this.btnRefreshText.ShadowDecoration.Parent = this.btnRefreshText;
            this.btnRefreshText.Size = new System.Drawing.Size(82, 27);
            this.btnRefreshText.TabIndex = 10;
            this.btnRefreshText.Text = "Nhập Lại";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BorderRadius = 9;
            this.btnAddProduct.CheckedState.Parent = this.btnAddProduct;
            this.btnAddProduct.CustomImages.Parent = this.btnAddProduct;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddProduct.ForeColor = System.Drawing.Color.Black;
            this.btnAddProduct.HoverState.Parent = this.btnAddProduct;
            this.btnAddProduct.Location = new System.Drawing.Point(37, 7);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.ShadowDecoration.Parent = this.btnAddProduct;
            this.btnAddProduct.Size = new System.Drawing.Size(82, 27);
            this.btnAddProduct.TabIndex = 10;
            this.btnAddProduct.Text = "Thêm";
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(37, 170);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(263, 23);
            this.btnSearchProduct.TabIndex = 8;
            this.btnSearchProduct.Text = "Tìm Kiếm";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProduct);
            this.groupBox1.Location = new System.Drawing.Point(12, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1237, 315);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.IDTypeProduct,
            this.IDProvider,
            this.dataGridViewTextBoxColumn7,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvProduct.Location = new System.Drawing.Point(3, 16);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(1228, 296);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDProduct";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Sản Phẩm";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Sản Phẩm";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // IDTypeProduct
            // 
            this.IDTypeProduct.DataPropertyName = "IDProductType";
            this.IDTypeProduct.HeaderText = "Mã Loại Sản Phẩm";
            this.IDTypeProduct.Name = "IDTypeProduct";
            this.IDTypeProduct.ReadOnly = true;
            // 
            // IDProvider
            // 
            this.IDProvider.DataPropertyName = "IDCustomer";
            this.IDProvider.HeaderText = "Mã Nhà Cung Cấp";
            this.IDProvider.Name = "IDProvider";
            this.IDProvider.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn7.HeaderText = "Trang Thái";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IDProductDetail";
            this.Column1.HeaderText = "Mã Chi Tiết Sản Phẩm";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Size";
            this.Column2.HeaderText = "Kích Thước";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Color";
            this.Column3.HeaderText = "Màu Sắc";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "image";
            this.Column4.HeaderText = "Hình Ảnh";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "PriceIn";
            this.Column5.HeaderText = "Giá Nhập";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "PriceOut";
            this.Column6.HeaderText = "Giá Xuất";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Number";
            this.Column7.HeaderText = "Số Lượng";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbProductType);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.txtIDProduct);
            this.panel1.Controls.Add(this.cbProvider);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(15, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 208);
            this.panel1.TabIndex = 7;
            // 
            // cbProductType
            // 
            this.cbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductType.Location = new System.Drawing.Point(126, 76);
            this.cbProductType.Name = "cbProductType";
            this.cbProductType.Size = new System.Drawing.Size(136, 21);
            this.cbProductType.TabIndex = 5;
            this.cbProductType.SelectedIndexChanged += new System.EventHandler(this.cbIDProductType_SelectedIndexChanged);
            this.cbProductType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbProductType_KeyPress);
            // 
            // cbProvider
            // 
            this.cbProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvider.FormattingEnabled = true;
            this.cbProvider.Location = new System.Drawing.Point(126, 110);
            this.cbProvider.Name = "cbProvider";
            this.cbProvider.Size = new System.Drawing.Size(136, 21);
            this.cbProvider.TabIndex = 6;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(126, 142);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(136, 21);
            this.cbStatus.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tên Loại Sản Phẩm";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Trạng Thái:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tên Nhà Cung Cấp";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tên Sản Phẩm:";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(12, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 24;
            this.label10.Text = "Mã Sản Phẩm:";
            // 
            // errorProduct
            // 
            this.errorProduct.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtImageName);
            this.panel2.Controls.Add(this.txtIDProductDetail);
            this.panel2.Controls.Add(this.txtPriceOut);
            this.panel2.Controls.Add(this.txtPriceIn);
            this.panel2.Controls.Add(this.cbSize);
            this.panel2.Controls.Add(this.cbColor);
            this.panel2.Controls.Add(this.btnOpenFolder);
            this.panel2.Controls.Add(this.pProduct);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.nudNumber);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(300, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 208);
            this.panel2.TabIndex = 9;
            // 
            // txtImageName
            // 
            this.txtImageName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtImageName.BorderRadius = 10;
            this.txtImageName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtImageName.DefaultText = "";
            this.txtImageName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtImageName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtImageName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtImageName.DisabledState.Parent = this.txtImageName;
            this.txtImageName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtImageName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtImageName.FocusedState.Parent = this.txtImageName;
            this.txtImageName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtImageName.ForeColor = System.Drawing.Color.Black;
            this.txtImageName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtImageName.HoverState.Parent = this.txtImageName;
            this.txtImageName.Location = new System.Drawing.Point(55, 168);
            this.txtImageName.Name = "txtImageName";
            this.txtImageName.PasswordChar = '\0';
            this.txtImageName.PlaceholderText = "";
            this.txtImageName.SelectedText = "";
            this.txtImageName.ShadowDecoration.Parent = this.txtImageName;
            this.txtImageName.Size = new System.Drawing.Size(103, 27);
            this.txtImageName.TabIndex = 11;
            // 
            // txtPriceOut
            // 
            this.txtPriceOut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtPriceOut.BorderRadius = 10;
            this.txtPriceOut.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPriceOut.DefaultText = "";
            this.txtPriceOut.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPriceOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPriceOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriceOut.DisabledState.Parent = this.txtPriceOut;
            this.txtPriceOut.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriceOut.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriceOut.FocusedState.Parent = this.txtPriceOut;
            this.txtPriceOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPriceOut.ForeColor = System.Drawing.Color.Black;
            this.txtPriceOut.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriceOut.HoverState.Parent = this.txtPriceOut;
            this.txtPriceOut.Location = new System.Drawing.Point(358, 104);
            this.txtPriceOut.Name = "txtPriceOut";
            this.txtPriceOut.PasswordChar = '\0';
            this.txtPriceOut.PlaceholderText = "";
            this.txtPriceOut.SelectedText = "";
            this.txtPriceOut.ShadowDecoration.Parent = this.txtPriceOut;
            this.txtPriceOut.Size = new System.Drawing.Size(144, 27);
            this.txtPriceOut.TabIndex = 11;
            this.txtPriceOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceIn_KeyPress);
            // 
            // txtPriceIn
            // 
            this.txtPriceIn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtPriceIn.BorderRadius = 10;
            this.txtPriceIn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPriceIn.DefaultText = "";
            this.txtPriceIn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPriceIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPriceIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriceIn.DisabledState.Parent = this.txtPriceIn;
            this.txtPriceIn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriceIn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriceIn.FocusedState.Parent = this.txtPriceIn;
            this.txtPriceIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPriceIn.ForeColor = System.Drawing.Color.Black;
            this.txtPriceIn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriceIn.HoverState.Parent = this.txtPriceIn;
            this.txtPriceIn.Location = new System.Drawing.Point(358, 70);
            this.txtPriceIn.Name = "txtPriceIn";
            this.txtPriceIn.PasswordChar = '\0';
            this.txtPriceIn.PlaceholderText = "";
            this.txtPriceIn.SelectedText = "";
            this.txtPriceIn.ShadowDecoration.Parent = this.txtPriceIn;
            this.txtPriceIn.Size = new System.Drawing.Size(144, 27);
            this.txtPriceIn.TabIndex = 11;
            this.txtPriceIn.TextChanged += new System.EventHandler(this.txtPriceIn_TextChanged);
            this.txtPriceIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceIn_KeyPress);
            // 
            // cbSize
            // 
            this.cbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Location = new System.Drawing.Point(358, 167);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(144, 21);
            this.cbSize.TabIndex = 34;
            // 
            // cbColor
            // 
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(358, 140);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(144, 21);
            this.cbColor.TabIndex = 34;
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(164, 24);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(50, 23);
            this.btnOpenFolder.TabIndex = 33;
            this.btnOpenFolder.Text = "...";
            this.btnOpenFolder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // pProduct
            // 
            this.pProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pProduct.Location = new System.Drawing.Point(18, 14);
            this.pProduct.Name = "pProduct";
            this.pProduct.Size = new System.Drawing.Size(140, 147);
            this.pProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pProduct.TabIndex = 32;
            this.pProduct.TabStop = false;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(242, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 23);
            this.label12.TabIndex = 28;
            this.label12.Text = "Màu Sắc:";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(242, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 23);
            this.label13.TabIndex = 29;
            this.label13.Text = "Kích Thước:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(242, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Số Lượng:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(3, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 23);
            this.label8.TabIndex = 25;
            this.label8.Text = "Tên Ảnh";
            // 
            // nudNumber
            // 
            this.nudNumber.Location = new System.Drawing.Point(358, 45);
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(59, 20);
            this.nudNumber.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(242, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Giá Nhập:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(242, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Giá Xuất:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(242, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mã Chi Tiết  Sản Phẩm:";
            // 
            // txtProductName
            // 
            this.txtProductName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtProductName.BorderRadius = 10;
            this.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.DefaultText = "";
            this.txtProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.DisabledState.Parent = this.txtProductName;
            this.txtProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductName.FocusedState.Parent = this.txtProductName;
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductName.ForeColor = System.Drawing.Color.Black;
            this.txtProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductName.HoverState.Parent = this.txtProductName;
            this.txtProductName.Location = new System.Drawing.Point(126, 37);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.PlaceholderText = "";
            this.txtProductName.SelectedText = "";
            this.txtProductName.ShadowDecoration.Parent = this.txtProductName;
            this.txtProductName.Size = new System.Drawing.Size(136, 27);
            this.txtProductName.TabIndex = 11;
            // 
            // txtIDProductDetail
            // 
            this.txtIDProductDetail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtIDProductDetail.BorderRadius = 10;
            this.txtIDProductDetail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDProductDetail.DefaultText = "";
            this.txtIDProductDetail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDProductDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDProductDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDProductDetail.DisabledState.Parent = this.txtIDProductDetail;
            this.txtIDProductDetail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDProductDetail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDProductDetail.FocusedState.Parent = this.txtIDProductDetail;
            this.txtIDProductDetail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDProductDetail.ForeColor = System.Drawing.Color.Black;
            this.txtIDProductDetail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDProductDetail.HoverState.Parent = this.txtIDProductDetail;
            this.txtIDProductDetail.Location = new System.Drawing.Point(355, 11);
            this.txtIDProductDetail.Name = "txtIDProductDetail";
            this.txtIDProductDetail.PasswordChar = '\0';
            this.txtIDProductDetail.PlaceholderText = "";
            this.txtIDProductDetail.ReadOnly = true;
            this.txtIDProductDetail.SelectedText = "";
            this.txtIDProductDetail.ShadowDecoration.Parent = this.txtIDProductDetail;
            this.txtIDProductDetail.Size = new System.Drawing.Size(147, 27);
            this.txtIDProductDetail.TabIndex = 11;
            // 
            // fProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1298, 617);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fEditProduct";
            this.Load += new System.EventHandler(this.fEditProduct_Load);
            this.pButton.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProduct)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pButton;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbProductType;
        private System.Windows.Forms.ComboBox cbProvider;
        private System.Windows.Forms.ErrorProvider errorProduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.PictureBox pProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTypeProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.ComboBox cbColor;
        private Guna.UI2.WinForms.Guna2Button btnAddProduct;
        private Guna.UI2.WinForms.Guna2Button btnUpdateProduct;
        private Guna.UI2.WinForms.Guna2Button btnDeleteProduct;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnRefreshText;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private Guna.UI2.WinForms.Guna2TextBox txtPriceOut;
        private Guna.UI2.WinForms.Guna2TextBox txtPriceIn;
        private Guna.UI2.WinForms.Guna2TextBox txtImageName;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtIDProduct;
        private Guna.UI2.WinForms.Guna2TextBox txtProductName;
        private Guna.UI2.WinForms.Guna2TextBox txtIDProductDetail;
    }
}