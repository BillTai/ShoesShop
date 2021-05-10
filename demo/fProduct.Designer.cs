
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
            this.pValues = new System.Windows.Forms.Panel();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.From = new System.Windows.Forms.Label();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefreshText = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTypeProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDProductDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pProduct = new System.Windows.Forms.PictureBox();
            this.cbIDProductDetail = new System.Windows.Forms.ComboBox();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.cbProductType = new System.Windows.Forms.ComboBox();
            this.cbProvider = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.txtImageName = new System.Windows.Forms.TextBox();
            this.txtPriceOut = new System.Windows.Forms.TextBox();
            this.txtPriceIn = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtIDProduct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProduct = new System.Windows.Forms.ErrorProvider(this.components);
            this.pButton.SuspendLayout();
            this.pValues.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pButton
            // 
            this.pButton.Controls.Add(this.pValues);
            this.pButton.Controls.Add(this.cbSearch);
            this.pButton.Controls.Add(this.btnReload);
            this.pButton.Controls.Add(this.btnSearchProduct);
            this.pButton.Controls.Add(this.btnUpdateProduct);
            this.pButton.Controls.Add(this.btnExit);
            this.pButton.Controls.Add(this.btnRefreshText);
            this.pButton.Controls.Add(this.btnAddProduct);
            this.pButton.Controls.Add(this.btnDeleteProduct);
            this.pButton.Controls.Add(this.txtID);
            this.pButton.Location = new System.Drawing.Point(765, 12);
            this.pButton.Name = "pButton";
            this.pButton.Size = new System.Drawing.Size(322, 179);
            this.pButton.TabIndex = 0;
            // 
            // pValues
            // 
            this.pValues.Controls.Add(this.txtTo);
            this.pValues.Controls.Add(this.label11);
            this.pValues.Controls.Add(this.txtFrom);
            this.pValues.Controls.Add(this.From);
            this.pValues.Location = new System.Drawing.Point(21, 107);
            this.pValues.Name = "pValues";
            this.pValues.Size = new System.Drawing.Size(291, 30);
            this.pValues.TabIndex = 35;
            this.pValues.Visible = false;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(184, 4);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(86, 20);
            this.txtTo.TabIndex = 1;
            this.txtTo.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            this.txtTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTo_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(142, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Đến:";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(45, 4);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(86, 20);
            this.txtFrom.TabIndex = 0;
            this.txtFrom.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            this.txtFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrom_KeyPress);
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Location = new System.Drawing.Point(3, 7);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(23, 13);
            this.From.TabIndex = 0;
            this.From.Text = "Từ:";
            // 
            // cbSearch
            // 
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(21, 79);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(117, 21);
            this.cbSearch.TabIndex = 6;
            this.cbSearch.SelectedIndexChanged += new System.EventHandler(this.cbSearch_SelectedIndexChanged);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(127, 41);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(82, 23);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Tải Lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(39, 143);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(263, 23);
            this.btnSearchProduct.TabIndex = 8;
            this.btnSearchProduct.Text = "Tìm Kiếm";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(220, 12);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(82, 23);
            this.btnUpdateProduct.TabIndex = 3;
            this.btnUpdateProduct.Text = "Cập Nhật";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(220, 41);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRefreshText
            // 
            this.btnRefreshText.Location = new System.Drawing.Point(37, 40);
            this.btnRefreshText.Name = "btnRefreshText";
            this.btnRefreshText.Size = new System.Drawing.Size(82, 23);
            this.btnRefreshText.TabIndex = 1;
            this.btnRefreshText.Text = "Nhập Lại";
            this.btnRefreshText.UseVisualStyleBackColor = true;
            this.btnRefreshText.Click += new System.EventHandler(this.btnRefreshText_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(37, 12);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(82, 23);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Thêm";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(127, 12);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(82, 23);
            this.btnDeleteProduct.TabIndex = 2;
            this.btnDeleteProduct.Text = "Xoá";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(176, 79);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(136, 20);
            this.txtID.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProduct);
            this.groupBox1.Location = new System.Drawing.Point(12, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1120, 315);
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
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn3,
            this.PriceOut,
            this.IDTypeProduct,
            this.IDProvider,
            this.dataGridViewTextBoxColumn7,
            this.IDProductDetail,
            this.Picture});
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvProduct.Location = new System.Drawing.Point(3, 16);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(1111, 296);
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
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Number";
            this.dataGridViewTextBoxColumn6.HeaderText = "Số Lượng";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PriceIn";
            this.dataGridViewTextBoxColumn3.HeaderText = "Giá Nhập";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // PriceOut
            // 
            this.PriceOut.DataPropertyName = "PriceOut";
            this.PriceOut.HeaderText = "Giá Xuất";
            this.PriceOut.Name = "PriceOut";
            this.PriceOut.ReadOnly = true;
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
            this.IDProvider.DataPropertyName = "IDProvider";
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
            // IDProductDetail
            // 
            this.IDProductDetail.DataPropertyName = "IDProductDetail";
            this.IDProductDetail.HeaderText = "Mã Chi Tiết Sản Phẩm";
            this.IDProductDetail.Name = "IDProductDetail";
            this.IDProductDetail.ReadOnly = true;
            // 
            // Picture
            // 
            this.Picture.DataPropertyName = "Image";
            this.Picture.HeaderText = "Hình Ảnh";
            this.Picture.Name = "Picture";
            this.Picture.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pProduct);
            this.panel1.Controls.Add(this.cbIDProductDetail);
            this.panel1.Controls.Add(this.nudNumber);
            this.panel1.Controls.Add(this.cbProductType);
            this.panel1.Controls.Add(this.cbProvider);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.txtImageName);
            this.panel1.Controls.Add(this.txtPriceOut);
            this.panel1.Controls.Add(this.txtPriceIn);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.txtIDProduct);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 175);
            this.panel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(681, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "...";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pProduct
            // 
            this.pProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pProduct.Location = new System.Drawing.Point(535, 12);
            this.pProduct.Name = "pProduct";
            this.pProduct.Size = new System.Drawing.Size(140, 147);
            this.pProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pProduct.TabIndex = 28;
            this.pProduct.TabStop = false;
            // 
            // cbIDProductDetail
            // 
            this.cbIDProductDetail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIDProductDetail.FormattingEnabled = true;
            this.cbIDProductDetail.Location = new System.Drawing.Point(395, 111);
            this.cbIDProductDetail.Name = "cbIDProductDetail";
            this.cbIDProductDetail.Size = new System.Drawing.Size(135, 21);
            this.cbIDProductDetail.TabIndex = 8;
            // 
            // nudNumber
            // 
            this.nudNumber.Location = new System.Drawing.Point(124, 78);
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(59, 20);
            this.nudNumber.TabIndex = 2;
            // 
            // cbProductType
            // 
            this.cbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductType.FormattingEnabled = true;
            this.cbProductType.Location = new System.Drawing.Point(393, 11);
            this.cbProductType.Name = "cbProductType";
            this.cbProductType.Size = new System.Drawing.Size(136, 21);
            this.cbProductType.TabIndex = 5;
            this.cbProductType.SelectedIndexChanged += new System.EventHandler(this.cbIDProductType_SelectedIndexChanged);
            // 
            // cbProvider
            // 
            this.cbProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvider.FormattingEnabled = true;
            this.cbProvider.Location = new System.Drawing.Point(394, 44);
            this.cbProvider.Name = "cbProvider";
            this.cbProvider.Size = new System.Drawing.Size(136, 21);
            this.cbProvider.TabIndex = 6;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(394, 79);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(136, 21);
            this.cbStatus.TabIndex = 7;
            // 
            // txtImageName
            // 
            this.txtImageName.Location = new System.Drawing.Point(393, 142);
            this.txtImageName.Name = "txtImageName";
            this.txtImageName.Size = new System.Drawing.Size(136, 20);
            this.txtImageName.TabIndex = 4;
            this.txtImageName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            this.txtImageName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceOut_KeyPress);
            // 
            // txtPriceOut
            // 
            this.txtPriceOut.Location = new System.Drawing.Point(124, 139);
            this.txtPriceOut.Name = "txtPriceOut";
            this.txtPriceOut.Size = new System.Drawing.Size(84, 20);
            this.txtPriceOut.TabIndex = 4;
            this.txtPriceOut.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            this.txtPriceOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceOut_KeyPress);
            // 
            // txtPriceIn
            // 
            this.txtPriceIn.Location = new System.Drawing.Point(124, 113);
            this.txtPriceIn.Name = "txtPriceIn";
            this.txtPriceIn.Size = new System.Drawing.Size(84, 20);
            this.txtPriceIn.TabIndex = 3;
            this.txtPriceIn.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            this.txtPriceIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceIn_KeyPress);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(124, 45);
            this.txtProductName.MaxLength = 20;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(138, 20);
            this.txtProductName.TabIndex = 1;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // txtIDProduct
            // 
            this.txtIDProduct.Location = new System.Drawing.Point(126, 12);
            this.txtIDProduct.MaxLength = 20;
            this.txtIDProduct.Name = "txtIDProduct";
            this.txtIDProduct.Size = new System.Drawing.Size(136, 20);
            this.txtIDProduct.TabIndex = 0;
            this.txtIDProduct.TextChanged += new System.EventHandler(this.txtIDProduct_TextChanged);
            this.txtIDProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDProduct_KeyPress);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(268, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mã Chi Tiết  Sản Phẩm:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(268, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tên Loại Sản Phẩm";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(268, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Trạng Thái:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Giá Nhập:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(268, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tên Nhà Cung Cấp";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(268, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 23);
            this.label8.TabIndex = 25;
            this.label8.Text = "Tên Hình";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(19, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tên Sản Phẩm:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(18, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Giá Xuất:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Số Lượng:";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(19, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 24;
            this.label10.Text = "Mã Sản Phẩm:";
            // 
            // errorProduct
            // 
            this.errorProduct.ContainerControl = this;
            // 
            // fProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 520);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fEditProduct";
            this.Load += new System.EventHandler(this.fEditProduct_Load);
            this.pButton.ResumeLayout(false);
            this.pButton.PerformLayout();
            this.pValues.ResumeLayout(false);
            this.pValues.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pButton;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button btnRefreshText;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox txtPriceOut;
        private System.Windows.Forms.TextBox txtPriceIn;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtIDProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.ComboBox cbProductType;
        private System.Windows.Forms.ComboBox cbProvider;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Panel pValues;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.ErrorProvider errorProduct;
        private System.Windows.Forms.ComboBox cbIDProductDetail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTypeProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProductDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Picture;
        private System.Windows.Forms.TextBox txtImageName;
        private System.Windows.Forms.Label label8;
    }
}