
namespace demo
{
    partial class fBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBill));
            this.dgvBillDetail = new System.Windows.Forms.DataGridView();
            this.IDProductDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.cbBillType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiachi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblchange = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pButton = new System.Windows.Forms.Panel();
            this.txtNgayLap = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaHD = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenNv = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNewProduct = new Guna.UI2.WinForms.Guna2Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCK = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSL = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalck = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotals = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.txtDG = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMasp = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetail)).BeginInit();
            this.panel1.SuspendLayout();
            this.pButton.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBillDetail
            // 
            this.dgvBillDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvBillDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProductDetail,
            this.ProductName,
            this.Number,
            this.Price,
            this.Column2,
            this.Column3,
            this.Discount,
            this.Column1});
            this.dgvBillDetail.GridColor = System.Drawing.SystemColors.Control;
            this.dgvBillDetail.Location = new System.Drawing.Point(21, 97);
            this.dgvBillDetail.Name = "dgvBillDetail";
            this.dgvBillDetail.RowHeadersWidth = 51;
            this.dgvBillDetail.Size = new System.Drawing.Size(1100, 353);
            this.dgvBillDetail.TabIndex = 17;
            // 
            // IDProductDetail
            // 
            this.IDProductDetail.FillWeight = 58.06451F;
            this.IDProductDetail.HeaderText = "Mã Chi Tiết Sản Phẩm";
            this.IDProductDetail.MinimumWidth = 6;
            this.IDProductDetail.Name = "IDProductDetail";
            this.IDProductDetail.ReadOnly = true;
            this.IDProductDetail.Width = 180;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.FillWeight = 58.06451F;
            this.ProductName.HeaderText = "Tên Sản Phẩm";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.FillWeight = 309.6774F;
            this.Number.HeaderText = "Số Lượng";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 91;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.FillWeight = 58.06451F;
            this.Price.HeaderText = "Đơn Giá";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Tổng Cộng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "%Chiết khấu";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 90;
            // 
            // Discount
            // 
            this.Discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Discount.FillWeight = 58.06451F;
            this.Discount.HeaderText = "Chiết Khấu";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 58.06451F;
            this.Column1.HeaderText = "Thành Tiền";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNewCustomer);
            this.panel1.Controls.Add(this.cbBillType);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtDiachi);
            this.panel1.Controls.Add(this.txtTKH);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblchange);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(7, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 128);
            this.panel1.TabIndex = 1;
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.BorderRadius = 9;
            this.btnNewCustomer.CheckedState.Parent = this.btnNewCustomer;
            this.btnNewCustomer.CustomImages.Parent = this.btnNewCustomer;
            this.btnNewCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(195)))), ((int)(((byte)(228)))));
            this.btnNewCustomer.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnNewCustomer.HoverState.Parent = this.btnNewCustomer;
            this.btnNewCustomer.Location = new System.Drawing.Point(209, 90);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.ShadowDecoration.Parent = this.btnNewCustomer;
            this.btnNewCustomer.Size = new System.Drawing.Size(220, 32);
            this.btnNewCustomer.TabIndex = 37;
            this.btnNewCustomer.Text = "Thêm khách hàng";
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
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
            this.cbBillType.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbBillType.ForeColor = System.Drawing.Color.Black;
            this.cbBillType.HoverState.Parent = this.cbBillType;
            this.cbBillType.ItemHeight = 30;
            this.cbBillType.Items.AddRange(new object[] {
            "Hóa Ðơn Bán",
            "Hóa Ðơn Nhập"});
            this.cbBillType.ItemsAppearance.Parent = this.cbBillType;
            this.cbBillType.Location = new System.Drawing.Point(115, 14);
            this.cbBillType.Name = "cbBillType";
            this.cbBillType.ShadowDecoration.Parent = this.cbBillType;
            this.cbBillType.Size = new System.Drawing.Size(174, 36);
            this.cbBillType.TabIndex = 35;
            this.cbBillType.SelectedIndexChanged += new System.EventHandler(this.cbBillType_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(19, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 23);
            this.label16.TabIndex = 19;
            this.label16.Text = "Loại Hóa Đơn:";
            // 
            // txtSDT
            // 
            this.txtSDT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSDT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtSDT.BorderRadius = 10;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.Parent = this.txtSDT;
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.FocusedState.Parent = this.txtSDT;
            this.txtSDT.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtSDT.ForeColor = System.Drawing.Color.Black;
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.HoverState.Parent = this.txtSDT;
            this.txtSDT.Location = new System.Drawing.Point(115, 57);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.SelectedText = "";
            this.txtSDT.ShadowDecoration.Parent = this.txtSDT;
            this.txtSDT.Size = new System.Drawing.Size(172, 29);
            this.txtSDT.TabIndex = 1;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL_KeyPress);
            // 
            // txtDiachi
            // 
            this.txtDiachi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtDiachi.BorderRadius = 10;
            this.txtDiachi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiachi.DefaultText = "";
            this.txtDiachi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiachi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiachi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiachi.DisabledState.Parent = this.txtDiachi;
            this.txtDiachi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiachi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiachi.FocusedState.Parent = this.txtDiachi;
            this.txtDiachi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.ForeColor = System.Drawing.Color.Black;
            this.txtDiachi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiachi.HoverState.Parent = this.txtDiachi;
            this.txtDiachi.Location = new System.Drawing.Point(431, 58);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.PasswordChar = '\0';
            this.txtDiachi.PlaceholderText = "";
            this.txtDiachi.ReadOnly = true;
            this.txtDiachi.SelectedText = "";
            this.txtDiachi.ShadowDecoration.Parent = this.txtDiachi;
            this.txtDiachi.Size = new System.Drawing.Size(160, 29);
            this.txtDiachi.TabIndex = 4;
            // 
            // txtTKH
            // 
            this.txtTKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtTKH.BorderRadius = 10;
            this.txtTKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTKH.DefaultText = "";
            this.txtTKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTKH.DisabledState.Parent = this.txtTKH;
            this.txtTKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTKH.FocusedState.Parent = this.txtTKH;
            this.txtTKH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTKH.ForeColor = System.Drawing.Color.Black;
            this.txtTKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTKH.HoverState.Parent = this.txtTKH;
            this.txtTKH.Location = new System.Drawing.Point(431, 14);
            this.txtTKH.Name = "txtTKH";
            this.txtTKH.PasswordChar = '\0';
            this.txtTKH.PlaceholderText = "";
            this.txtTKH.ReadOnly = true;
            this.txtTKH.SelectedText = "";
            this.txtTKH.ShadowDecoration.Parent = this.txtTKH;
            this.txtTKH.Size = new System.Drawing.Size(160, 29);
            this.txtTKH.TabIndex = 1;
            this.txtTKH.TextChanged += new System.EventHandler(this.txtTKH_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Địa Chỉ:";
            // 
            // lblchange
            // 
            this.lblchange.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchange.Location = new System.Drawing.Point(316, 20);
            this.lblchange.Name = "lblchange";
            this.lblchange.Size = new System.Drawing.Size(126, 23);
            this.lblchange.TabIndex = 19;
            this.lblchange.Text = "Tên Khách Hàng:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "SĐT:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(266, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tên Nhân Viên:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã Nhân Viên:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ngày lập:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 23);
            this.label10.TabIndex = 24;
            this.label10.Text = "Mã Hóa Đơn:";
            // 
            // pButton
            // 
            this.pButton.Controls.Add(this.txtNgayLap);
            this.pButton.Controls.Add(this.txtMaHD);
            this.pButton.Controls.Add(this.txtTenNv);
            this.pButton.Controls.Add(this.txtIDNV);
            this.pButton.Controls.Add(this.label1);
            this.pButton.Controls.Add(this.label5);
            this.pButton.Controls.Add(this.label9);
            this.pButton.Controls.Add(this.label10);
            this.pButton.Location = new System.Drawing.Point(619, 24);
            this.pButton.Name = "pButton";
            this.pButton.Size = new System.Drawing.Size(536, 128);
            this.pButton.TabIndex = 5;
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtNgayLap.BorderRadius = 10;
            this.txtNgayLap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNgayLap.DefaultText = "";
            this.txtNgayLap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNgayLap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNgayLap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNgayLap.DisabledState.Parent = this.txtNgayLap;
            this.txtNgayLap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNgayLap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNgayLap.FocusedState.Parent = this.txtNgayLap;
            this.txtNgayLap.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayLap.ForeColor = System.Drawing.Color.Black;
            this.txtNgayLap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNgayLap.HoverState.Parent = this.txtNgayLap;
            this.txtNgayLap.Location = new System.Drawing.Point(98, 57);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.PasswordChar = '\0';
            this.txtNgayLap.PlaceholderText = "";
            this.txtNgayLap.ReadOnly = true;
            this.txtNgayLap.SelectedText = "";
            this.txtNgayLap.ShadowDecoration.Parent = this.txtNgayLap;
            this.txtNgayLap.Size = new System.Drawing.Size(163, 29);
            this.txtNgayLap.TabIndex = 1;
            // 
            // txtMaHD
            // 
            this.txtMaHD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtMaHD.BorderRadius = 10;
            this.txtMaHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaHD.DefaultText = "";
            this.txtMaHD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHD.DisabledState.Parent = this.txtMaHD;
            this.txtMaHD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHD.FocusedState.Parent = this.txtMaHD;
            this.txtMaHD.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.ForeColor = System.Drawing.Color.Black;
            this.txtMaHD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHD.HoverState.Parent = this.txtMaHD;
            this.txtMaHD.Location = new System.Drawing.Point(98, 14);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.PasswordChar = '\0';
            this.txtMaHD.PlaceholderText = "";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.SelectedText = "";
            this.txtMaHD.ShadowDecoration.Parent = this.txtMaHD;
            this.txtMaHD.Size = new System.Drawing.Size(163, 29);
            this.txtMaHD.TabIndex = 1;
            // 
            // txtTenNv
            // 
            this.txtTenNv.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtTenNv.BorderRadius = 10;
            this.txtTenNv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNv.DefaultText = "";
            this.txtTenNv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNv.DisabledState.Parent = this.txtTenNv;
            this.txtTenNv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNv.FocusedState.Parent = this.txtTenNv;
            this.txtTenNv.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNv.ForeColor = System.Drawing.Color.Black;
            this.txtTenNv.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNv.HoverState.Parent = this.txtTenNv;
            this.txtTenNv.Location = new System.Drawing.Point(367, 58);
            this.txtTenNv.Name = "txtTenNv";
            this.txtTenNv.PasswordChar = '\0';
            this.txtTenNv.PlaceholderText = "";
            this.txtTenNv.ReadOnly = true;
            this.txtTenNv.SelectedText = "";
            this.txtTenNv.ShadowDecoration.Parent = this.txtTenNv;
            this.txtTenNv.Size = new System.Drawing.Size(157, 29);
            this.txtTenNv.TabIndex = 1;
            // 
            // txtIDNV
            // 
            this.txtIDNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtIDNV.BorderRadius = 10;
            this.txtIDNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDNV.DefaultText = "";
            this.txtIDNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDNV.DisabledState.Parent = this.txtIDNV;
            this.txtIDNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDNV.FocusedState.Parent = this.txtIDNV;
            this.txtIDNV.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNV.ForeColor = System.Drawing.Color.Black;
            this.txtIDNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDNV.HoverState.Parent = this.txtIDNV;
            this.txtIDNV.Location = new System.Drawing.Point(367, 14);
            this.txtIDNV.Name = "txtIDNV";
            this.txtIDNV.PasswordChar = '\0';
            this.txtIDNV.PlaceholderText = "";
            this.txtIDNV.ReadOnly = true;
            this.txtIDNV.SelectedText = "";
            this.txtIDNV.ShadowDecoration.Parent = this.txtIDNV;
            this.txtIDNV.Size = new System.Drawing.Size(157, 29);
            this.txtIDNV.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNewProduct);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCK);
            this.groupBox1.Controls.Add(this.txtSL);
            this.groupBox1.Controls.Add(this.txtTotalck);
            this.groupBox1.Controls.Add(this.txtTotals);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtDG);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtMasp);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dgvBillDetail);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 167);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1148, 626);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hóa Đơn";
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.BorderRadius = 9;
            this.btnNewProduct.CheckedState.Parent = this.btnNewProduct;
            this.btnNewProduct.CustomImages.Parent = this.btnNewProduct;
            this.btnNewProduct.FillColor = System.Drawing.Color.White;
            this.btnNewProduct.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnNewProduct.ForeColor = System.Drawing.Color.Black;
            this.btnNewProduct.HoverState.Parent = this.btnNewProduct;
            this.btnNewProduct.Location = new System.Drawing.Point(209, 39);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.ShadowDecoration.Parent = this.btnNewProduct;
            this.btnNewProduct.Size = new System.Drawing.Size(87, 29);
            this.btnNewProduct.TabIndex = 37;
            this.btnNewProduct.Text = "thêm";
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(590, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "Đơn Giá";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.UseMnemonic = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(688, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "% Chiết Khấu";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.UseMnemonic = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(344, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Tên Sản Phẩm";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.UseMnemonic = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(479, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Số Lượng";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(86, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Mã Sản Phẩm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseMnemonic = false;
            // 
            // txtCK
            // 
            this.txtCK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCK.DefaultText = "";
            this.txtCK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCK.DisabledState.Parent = this.txtCK;
            this.txtCK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCK.FocusedState.Parent = this.txtCK;
            this.txtCK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCK.HoverState.Parent = this.txtCK;
            this.txtCK.Location = new System.Drawing.Point(698, 39);
            this.txtCK.Margin = new System.Windows.Forms.Padding(2);
            this.txtCK.Name = "txtCK";
            this.txtCK.PasswordChar = '\0';
            this.txtCK.PlaceholderText = "";
            this.txtCK.SelectedText = "";
            this.txtCK.ShadowDecoration.Parent = this.txtCK;
            this.txtCK.Size = new System.Drawing.Size(86, 29);
            this.txtCK.TabIndex = 3;
            this.txtCK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCK_KeyPress);
            // 
            // txtSL
            // 
            this.txtSL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSL.DefaultText = "";
            this.txtSL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSL.DisabledState.Parent = this.txtSL;
            this.txtSL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSL.FocusedState.Parent = this.txtSL;
            this.txtSL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSL.HoverState.Parent = this.txtSL;
            this.txtSL.Location = new System.Drawing.Point(482, 39);
            this.txtSL.Margin = new System.Windows.Forms.Padding(2);
            this.txtSL.Name = "txtSL";
            this.txtSL.PasswordChar = '\0';
            this.txtSL.PlaceholderText = "";
            this.txtSL.SelectedText = "";
            this.txtSL.ShadowDecoration.Parent = this.txtSL;
            this.txtSL.Size = new System.Drawing.Size(58, 29);
            this.txtSL.TabIndex = 2;
            this.txtSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL_KeyPress);
            // 
            // txtTotalck
            // 
            this.txtTotalck.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalck.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalck.DefaultText = "0";
            this.txtTotalck.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalck.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalck.DisabledState.Parent = this.txtTotalck;
            this.txtTotalck.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalck.FillColor = System.Drawing.SystemColors.Control;
            this.txtTotalck.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalck.FocusedState.Parent = this.txtTotalck;
            this.txtTotalck.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalck.ForeColor = System.Drawing.Color.Black;
            this.txtTotalck.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalck.HoverState.Parent = this.txtTotalck;
            this.txtTotalck.Location = new System.Drawing.Point(933, 521);
            this.txtTotalck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotalck.Name = "txtTotalck";
            this.txtTotalck.PasswordChar = '\0';
            this.txtTotalck.PlaceholderText = "";
            this.txtTotalck.ReadOnly = true;
            this.txtTotalck.SelectedText = "";
            this.txtTotalck.SelectionStart = 1;
            this.txtTotalck.ShadowDecoration.Parent = this.txtTotalck;
            this.txtTotalck.Size = new System.Drawing.Size(191, 29);
            this.txtTotalck.TabIndex = 33;
            this.txtTotalck.Tag = "";
            this.txtTotalck.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotals
            // 
            this.txtTotals.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotals.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotals.DefaultText = "0";
            this.txtTotals.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotals.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotals.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotals.DisabledState.Parent = this.txtTotals;
            this.txtTotals.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotals.FillColor = System.Drawing.SystemColors.Control;
            this.txtTotals.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotals.FocusedState.Parent = this.txtTotals;
            this.txtTotals.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotals.ForeColor = System.Drawing.Color.Black;
            this.txtTotals.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotals.HoverState.Parent = this.txtTotals;
            this.txtTotals.Location = new System.Drawing.Point(933, 468);
            this.txtTotals.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotals.Name = "txtTotals";
            this.txtTotals.PasswordChar = '\0';
            this.txtTotals.PlaceholderText = "";
            this.txtTotals.ReadOnly = true;
            this.txtTotals.SelectedText = "";
            this.txtTotals.SelectionStart = 1;
            this.txtTotals.ShadowDecoration.Parent = this.txtTotals;
            this.txtTotals.Size = new System.Drawing.Size(191, 29);
            this.txtTotals.TabIndex = 33;
            this.txtTotals.Tag = "";
            this.txtTotals.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.txtTotal.Location = new System.Drawing.Point(933, 571);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PlaceholderText = "";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionStart = 1;
            this.txtTotal.ShadowDecoration.Parent = this.txtTotal;
            this.txtTotal.Size = new System.Drawing.Size(191, 29);
            this.txtTotal.TabIndex = 33;
            this.txtTotal.Tag = "";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSP.DefaultText = "";
            this.txtTenSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSP.DisabledState.Parent = this.txtTenSP;
            this.txtTenSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSP.FocusedState.Parent = this.txtTenSP;
            this.txtTenSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSP.HoverState.Parent = this.txtTenSP;
            this.txtTenSP.Location = new System.Drawing.Point(291, 39);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.PasswordChar = '\0';
            this.txtTenSP.PlaceholderText = "";
            this.txtTenSP.ReadOnly = true;
            this.txtTenSP.SelectedText = "";
            this.txtTenSP.ShadowDecoration.Parent = this.txtTenSP;
            this.txtTenSP.Size = new System.Drawing.Size(191, 29);
            this.txtTenSP.TabIndex = 17;
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 9;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(195)))), ((int)(((byte)(228)))));
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(911, 32);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(98, 36);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 9;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(195)))), ((int)(((byte)(228)))));
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(808, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(98, 36);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDG
            // 
            this.txtDG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDG.DefaultText = "";
            this.txtDG.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDG.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDG.DisabledState.Parent = this.txtDG;
            this.txtDG.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDG.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDG.FocusedState.Parent = this.txtDG;
            this.txtDG.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDG.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDG.HoverState.Parent = this.txtDG;
            this.txtDG.Location = new System.Drawing.Point(538, 39);
            this.txtDG.Margin = new System.Windows.Forms.Padding(2);
            this.txtDG.Name = "txtDG";
            this.txtDG.PasswordChar = '\0';
            this.txtDG.PlaceholderText = "";
            this.txtDG.ReadOnly = true;
            this.txtDG.SelectedText = "";
            this.txtDG.ShadowDecoration.Parent = this.txtDG;
            this.txtDG.Size = new System.Drawing.Size(164, 29);
            this.txtDG.TabIndex = 33;
            this.txtDG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(706, 527);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(222, 23);
            this.label13.TabIndex = 24;
            this.label13.Text = "Tổng Chiết Khấu:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMasp
            // 
            this.txtMasp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMasp.DefaultText = "";
            this.txtMasp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMasp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMasp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMasp.DisabledState.Parent = this.txtMasp;
            this.txtMasp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMasp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMasp.FocusedState.Parent = this.txtMasp;
            this.txtMasp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMasp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMasp.HoverState.Parent = this.txtMasp;
            this.txtMasp.Location = new System.Drawing.Point(21, 39);
            this.txtMasp.Margin = new System.Windows.Forms.Padding(2);
            this.txtMasp.Name = "txtMasp";
            this.txtMasp.PasswordChar = '\0';
            this.txtMasp.PlaceholderText = "";
            this.txtMasp.SelectedText = "";
            this.txtMasp.ShadowDecoration.Parent = this.txtMasp;
            this.txtMasp.Size = new System.Drawing.Size(191, 29);
            this.txtMasp.TabIndex = 1;
            this.txtMasp.TextChanged += new System.EventHandler(this.txtMasp_TextChanged);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(778, 474);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 23);
            this.label12.TabIndex = 24;
            this.label12.Text = "Tổng Cộng:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(778, 578);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 23);
            this.label15.TabIndex = 24;
            this.label15.Text = "Tổng Tiền:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 9;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(195)))), ((int)(((byte)(228)))));
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(976, 800);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(98, 36);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = " Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnExit.Location = new System.Drawing.Point(1090, 797);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(34, 38);
            this.btnExit.TabIndex = 5;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // fBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 850);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fBill";
            this.Load += new System.EventHandler(this.fBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pButton.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblchange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtIDNV;
        private Guna.UI2.WinForms.Guna2TextBox txtNgayLap;
        private Guna.UI2.WinForms.Guna2TextBox txtMaHD;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNv;
        private Guna.UI2.WinForms.Guna2ComboBox cbBillType;
        private Guna.UI2.WinForms.Guna2TextBox txtDiachi;
        private Guna.UI2.WinForms.Guna2TextBox txtTKH;
        private System.Windows.Forms.DataGridView dgvBillDetail;
        private Guna.UI2.WinForms.Guna2TextBox txtSL;
        private Guna.UI2.WinForms.Guna2TextBox txtMasp;
        private Guna.UI2.WinForms.Guna2TextBox txtTotal;
        private Guna.UI2.WinForms.Guna2TextBox txtTenSP;
        private Guna.UI2.WinForms.Guna2TextBox txtDG;
        private Guna.UI2.WinForms.Guna2TextBox txtCK;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProductDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalck;
        private Guna.UI2.WinForms.Guna2TextBox txtTotals;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Button btnNewProduct;
        private Guna.UI2.WinForms.Guna2Button btnNewCustomer;
    }
}