
namespace demo
{
    partial class fBillSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBillSearch));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cboStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbBillType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.IDBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBillDetail = new System.Windows.Forms.DataGridView();
            this.IDProductDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.txtTHD = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnIn = new Guna.UI2.WinForms.Guna2Button();
            this.txtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnChange = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.cboStatus);
            this.panel1.Controls.Add(this.cbBillType);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(21, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 150);
            this.panel1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(22, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "Loại Hóa Đơn";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(22, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(210, 23);
            this.label16.TabIndex = 39;
            this.label16.Text = "Trạng Thái Hóa Đơn";
            // 
            // cboStatus
            // 
            this.cboStatus.BackColor = System.Drawing.Color.Transparent;
            this.cboStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cboStatus.BorderRadius = 10;
            this.cboStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.DropDownWidth = 140;
            this.cboStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboStatus.FocusedState.Parent = this.cboStatus;
            this.cboStatus.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.cboStatus.ForeColor = System.Drawing.Color.Black;
            this.cboStatus.HoverState.Parent = this.cboStatus;
            this.cboStatus.ItemHeight = 30;
            this.cboStatus.Items.AddRange(new object[] {
            "Tất Cả",
            "Đã Hủy",
            "Đã Bán"});
            this.cboStatus.ItemsAppearance.Parent = this.cboStatus;
            this.cboStatus.Location = new System.Drawing.Point(21, 102);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.ShadowDecoration.Parent = this.cboStatus;
            this.cboStatus.Size = new System.Drawing.Size(204, 36);
            this.cboStatus.TabIndex = 38;
            // 
            // cbBillType
            // 
            this.cbBillType.BackColor = System.Drawing.Color.Transparent;
            this.cbBillType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cbBillType.BorderRadius = 10;
            this.cbBillType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBillType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBillType.DropDownWidth = 140;
            this.cbBillType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBillType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBillType.FocusedState.Parent = this.cbBillType;
            this.cbBillType.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.cbBillType.ForeColor = System.Drawing.Color.Black;
            this.cbBillType.HoverState.Parent = this.cbBillType;
            this.cbBillType.ItemHeight = 30;
            this.cbBillType.Items.AddRange(new object[] {
            "Tất Cả",
            "Hóa Ðơn Bán",
            "Hóa Ðơn Nhập"});
            this.cbBillType.ItemsAppearance.Parent = this.cbBillType;
            this.cbBillType.Location = new System.Drawing.Point(21, 37);
            this.cbBillType.Name = "cbBillType";
            this.cbBillType.ShadowDecoration.Parent = this.cbBillType;
            this.cbBillType.Size = new System.Drawing.Size(204, 36);
            this.cbBillType.TabIndex = 38;
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 9;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(195)))), ((int)(((byte)(228)))));
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(719, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(148, 36);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(229, 40);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Mã Sản Phẩm";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(477, 29);
            this.txtSearch.TabIndex = 35;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(527, 102);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(138, 27);
            this.dateTimePicker2.TabIndex = 36;
            this.dateTimePicker2.Value = new System.DateTime(2021, 5, 17, 9, 38, 48, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(299, 102);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(138, 27);
            this.dateTimePicker1.TabIndex = 35;
            this.dateTimePicker1.Value = new System.DateTime(2021, 5, 17, 9, 38, 48, 0);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(471, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Đến";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(242, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Từ";
            // 
            // dgvBill
            // 
            this.dgvBill.BackgroundColor = System.Drawing.Color.White;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDBill,
            this.Date,
            this.IDCustomer,
            this.IDStaff,
            this.TypeBill});
            this.dgvBill.Location = new System.Drawing.Point(21, 28);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.Size = new System.Drawing.Size(888, 222);
            this.dgvBill.TabIndex = 13;
            this.dgvBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellContentClick);
            this.dgvBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellContentClick);
            // 
            // IDBill
            // 
            this.IDBill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDBill.DataPropertyName = "IDBill";
            this.IDBill.HeaderText = "Mã Hóa Đơn";
            this.IDBill.MinimumWidth = 6;
            this.IDBill.Name = "IDBill";
            this.IDBill.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Ngày Lập";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // IDCustomer
            // 
            this.IDCustomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDCustomer.DataPropertyName = "IDCustomer";
            this.IDCustomer.HeaderText = "Mã Khách Hàng";
            this.IDCustomer.MinimumWidth = 6;
            this.IDCustomer.Name = "IDCustomer";
            this.IDCustomer.ReadOnly = true;
            // 
            // IDStaff
            // 
            this.IDStaff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDStaff.DataPropertyName = "IDStaff";
            this.IDStaff.HeaderText = "Mã Nhân Viên";
            this.IDStaff.MinimumWidth = 6;
            this.IDStaff.Name = "IDStaff";
            this.IDStaff.ReadOnly = true;
            // 
            // TypeBill
            // 
            this.TypeBill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TypeBill.DataPropertyName = "TypeBill";
            this.TypeBill.HeaderText = "Loại Hóa Đơn";
            this.TypeBill.MinimumWidth = 6;
            this.TypeBill.Name = "TypeBill";
            this.TypeBill.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvBill);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 171);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(922, 273);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Hóa Đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvBillDetail);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 507);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(922, 251);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Hóa Đơn";
            // 
            // dgvBillDetail
            // 
            this.dgvBillDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvBillDetail.ColumnHeadersHeight = 29;
            this.dgvBillDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProductDetail,
            this.Number,
            this.Price,
            this.Discount,
            this.TotalPrice});
            this.dgvBillDetail.Location = new System.Drawing.Point(21, 28);
            this.dgvBillDetail.Name = "dgvBillDetail";
            this.dgvBillDetail.RowHeadersWidth = 51;
            this.dgvBillDetail.Size = new System.Drawing.Size(888, 205);
            this.dgvBillDetail.TabIndex = 13;
            // 
            // IDProductDetail
            // 
            this.IDProductDetail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDProductDetail.DataPropertyName = "IDProductDetail";
            this.IDProductDetail.HeaderText = "Mã Chi Tiết Sản Phẩm";
            this.IDProductDetail.MinimumWidth = 6;
            this.IDProductDetail.Name = "IDProductDetail";
            this.IDProductDetail.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Số lượng";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Giá";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "Giảm Giá";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "Thành Tiền";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // btnExit
            // 
            this.btnExit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(54)))), ((int)(((byte)(128)))));
            this.btnExit.BorderRadius = 9;
            this.btnExit.BorderThickness = 3;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.SystemColors.Control;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.HoverState.BorderColor = System.Drawing.SystemColors.Control;
            this.btnExit.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(908, 821);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(34, 38);
            this.btnExit.TabIndex = 34;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // txtTHD
            // 
            this.txtTHD.BackColor = System.Drawing.SystemColors.Control;
            this.txtTHD.BorderColor = System.Drawing.SystemColors.Control;
            this.txtTHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTHD.DefaultText = "";
            this.txtTHD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTHD.DisabledState.Parent = this.txtTHD;
            this.txtTHD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTHD.FillColor = System.Drawing.SystemColors.Control;
            this.txtTHD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTHD.FocusedState.Parent = this.txtTHD;
            this.txtTHD.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTHD.ForeColor = System.Drawing.Color.Red;
            this.txtTHD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTHD.HoverState.Parent = this.txtTHD;
            this.txtTHD.Location = new System.Drawing.Point(260, 460);
            this.txtTHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTHD.Name = "txtTHD";
            this.txtTHD.PasswordChar = '\0';
            this.txtTHD.PlaceholderForeColor = System.Drawing.SystemColors.Control;
            this.txtTHD.PlaceholderText = "";
            this.txtTHD.SelectedText = "";
            this.txtTHD.ShadowDecoration.Parent = this.txtTHD;
            this.txtTHD.Size = new System.Drawing.Size(466, 41);
            this.txtTHD.TabIndex = 35;
            this.txtTHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnIn
            // 
            this.btnIn.BorderRadius = 9;
            this.btnIn.CheckedState.Parent = this.btnIn;
            this.btnIn.CustomImages.Parent = this.btnIn;
            this.btnIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(195)))), ((int)(((byte)(228)))));
            this.btnIn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.Color.Black;
            this.btnIn.HoverState.Parent = this.btnIn;
            this.btnIn.Location = new System.Drawing.Point(762, 821);
            this.btnIn.Name = "btnIn";
            this.btnIn.ShadowDecoration.Parent = this.btnIn;
            this.btnIn.Size = new System.Drawing.Size(127, 36);
            this.btnIn.TabIndex = 36;
            this.btnIn.Text = "Thống kê";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.DefaultText = "0";
            this.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.DisabledState.Parent = this.txtTotal;
            this.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.FillColor = System.Drawing.SystemColors.Control;
            this.txtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.FocusedState.Parent = this.txtTotal;
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.HoverState.Parent = this.txtTotal;
            this.txtTotal.Location = new System.Drawing.Point(739, 773);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PlaceholderText = "";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionStart = 1;
            this.txtTotal.ShadowDecoration.Parent = this.txtTotal;
            this.txtTotal.Size = new System.Drawing.Size(191, 29);
            this.txtTotal.TabIndex = 39;
            this.txtTotal.Tag = "";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(584, 779);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 23);
            this.label15.TabIndex = 38;
            this.label15.Text = "Tổng Tiền:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnChange
            // 
            this.btnChange.BorderRadius = 9;
            this.btnChange.CheckedState.Parent = this.btnChange;
            this.btnChange.CustomImages.Parent = this.btnChange;
            this.btnChange.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(195)))), ((int)(((byte)(228)))));
            this.btnChange.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.Black;
            this.btnChange.HoverState.Parent = this.btnChange;
            this.btnChange.Location = new System.Drawing.Point(643, 821);
            this.btnChange.Name = "btnChange";
            this.btnChange.ShadowDecoration.Parent = this.btnChange;
            this.btnChange.Size = new System.Drawing.Size(106, 36);
            this.btnChange.TabIndex = 40;
            this.btnChange.Text = "Xóa";
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // fBillSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(964, 865);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtTHD);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fBillSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fBillDetail";
            this.Load += new System.EventHandler(this.fBillDetail_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.DataGridView dgvBillDetail;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtTHD;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProductDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private Guna.UI2.WinForms.Guna2ComboBox cbBillType;
        private Guna.UI2.WinForms.Guna2TextBox txtTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Guna.UI2.WinForms.Guna2Button btnChange;
        private Guna.UI2.WinForms.Guna2ComboBox cboStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeBill;
    }
}