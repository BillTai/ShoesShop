﻿
using System.Windows.Forms;

namespace demo
{
    partial class fHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHomePage));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mntHome = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wonmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsAddCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsProvider = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsAddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsEditProductType = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsEditStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hàngTrongKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêHàngTrongKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêNhậpKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêXuấtKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêXuấtKhoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsInfoAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.càiĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mstExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tHome = new System.Windows.Forms.TabControl();
            this.tProduct = new System.Windows.Forms.TabPage();
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
            this.tTypeProduct = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvProductType = new System.Windows.Forms.DataGridView();
            this.IDProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tStatistical = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvProductDetail = new System.Windows.Forms.DataGridView();
            this.IDDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAbouts = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvProvider = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Card = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Addre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.PhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.IDBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvBillDetail = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.IDStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            this.tHome.SuspendLayout();
            this.tProduct.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.tTypeProduct.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductType)).BeginInit();
            this.tStatistical.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetail)).BeginInit();
            this.tAbouts.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvider)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetail)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntHome,
            this.quảnLýKháchHàngToolStripMenuItem,
            this.quảnLýHàngToolStripMenuItem,
            this.trợGiúpToolStripMenuItem,
            this.quảnLýTàiKhoảnToolStripMenuItem,
            this.quảnLýTàiKhoảnToolStripMenuItem1,
            this.càiĐặtToolStripMenuItem,
            this.mstExit});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(837, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mntHome
            // 
            this.mntHome.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.đăngKýToolStripMenuItem,
            this.menToolStripMenuItem,
            this.wonmenToolStripMenuItem,
            this.gostoToolStripMenuItem});
            this.mntHome.Image = ((System.Drawing.Image)(resources.GetObject("mntHome.Image")));
            this.mntHome.Name = "mntHome";
            this.mntHome.Size = new System.Drawing.Size(87, 20);
            this.mntHome.Text = "Bán Hàng";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.đăngNhậpToolStripMenuItem.Text = "Tạo Đơn";
            // 
            // đăngKýToolStripMenuItem
            // 
            this.đăngKýToolStripMenuItem.Name = "đăngKýToolStripMenuItem";
            this.đăngKýToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.đăngKýToolStripMenuItem.Text = "Tìm hoá đơn cũ";
            // 
            // menToolStripMenuItem
            // 
            this.menToolStripMenuItem.Name = "menToolStripMenuItem";
            this.menToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.menToolStripMenuItem.Text = "Lọc doanh thu theo khách hàng";
            // 
            // wonmenToolStripMenuItem
            // 
            this.wonmenToolStripMenuItem.Name = "wonmenToolStripMenuItem";
            this.wonmenToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.wonmenToolStripMenuItem.Text = "Thống kê hàng đã bán";
            // 
            // gostoToolStripMenuItem
            // 
            this.gostoToolStripMenuItem.Name = "gostoToolStripMenuItem";
            this.gostoToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.gostoToolStripMenuItem.Text = "Tất cả hoá đơn";
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            this.quảnLýKháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsAddCustomer,
            this.mtsProvider});
            this.quảnLýKháchHàngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýKháchHàngToolStripMenuItem.Image")));
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            // 
            // mtsAddCustomer
            // 
            this.mtsAddCustomer.Name = "mtsAddCustomer";
            this.mtsAddCustomer.Size = new System.Drawing.Size(250, 22);
            this.mtsAddCustomer.Text = "Thêm mới và quản lý khách hàng";
            this.mtsAddCustomer.Click += new System.EventHandler(this.mtsAddCustomer_Click);
            // 
            // mtsProvider
            // 
            this.mtsProvider.Name = "mtsProvider";
            this.mtsProvider.Size = new System.Drawing.Size(250, 22);
            this.mtsProvider.Text = "Thêm mới và quản lý NCC";
            this.mtsProvider.Click += new System.EventHandler(this.mtsProvider_Click);
            // 
            // quảnLýHàngToolStripMenuItem
            // 
            this.quảnLýHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsAddProduct,
            this.mtsEditProductType});
            this.quảnLýHàngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýHàngToolStripMenuItem.Image")));
            this.quảnLýHàngToolStripMenuItem.Name = "quảnLýHàngToolStripMenuItem";
            this.quảnLýHàngToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.quảnLýHàngToolStripMenuItem.Text = "Quản lý hàng";
            // 
            // mtsAddProduct
            // 
            this.mtsAddProduct.Name = "mtsAddProduct";
            this.mtsAddProduct.Size = new System.Drawing.Size(225, 22);
            this.mtsAddProduct.Text = "Thêm và sửa đổi hàng";
            this.mtsAddProduct.Click += new System.EventHandler(this.mstAddProduct_Click_1);
            // 
            // mtsEditProductType
            // 
            this.mtsEditProductType.Name = "mtsEditProductType";
            this.mtsEditProductType.Size = new System.Drawing.Size(225, 22);
            this.mtsEditProductType.Text = "Thêm và sửa đổi nhóm hàng";
            this.mtsEditProductType.Click += new System.EventHandler(this.mtsEditProductType_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsEditStaff});
            this.trợGiúpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("trợGiúpToolStripMenuItem.Image")));
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.trợGiúpToolStripMenuItem.Text = "Quản lý nhân viên";
            // 
            // mtsEditStaff
            // 
            this.mtsEditStaff.Name = "mtsEditStaff";
            this.mtsEditStaff.Size = new System.Drawing.Size(195, 22);
            this.mtsEditStaff.Text = "Thêm và sửa nhân viên";
            this.mtsEditStaff.Click += new System.EventHandler(this.mtsEditStaff_Click);
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hàngTrongKhoToolStripMenuItem,
            this.thốngKêHàngTrongKhoToolStripMenuItem,
            this.thốngKêNhậpKhoToolStripMenuItem,
            this.thốngKêXuấtKhoToolStripMenuItem,
            this.thốngKêXuấtKhoToolStripMenuItem1});
            this.quảnLýTàiKhoảnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýTàiKhoảnToolStripMenuItem.Image")));
            this.quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý kho";
            // 
            // hàngTrongKhoToolStripMenuItem
            // 
            this.hàngTrongKhoToolStripMenuItem.Name = "hàngTrongKhoToolStripMenuItem";
            this.hàngTrongKhoToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.hàngTrongKhoToolStripMenuItem.Text = "Hàng trong kho";
            // 
            // thốngKêHàngTrongKhoToolStripMenuItem
            // 
            this.thốngKêHàngTrongKhoToolStripMenuItem.Name = "thốngKêHàngTrongKhoToolStripMenuItem";
            this.thốngKêHàngTrongKhoToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.thốngKêHàngTrongKhoToolStripMenuItem.Text = "Thống kê hàng theo loại";
            // 
            // thốngKêNhậpKhoToolStripMenuItem
            // 
            this.thốngKêNhậpKhoToolStripMenuItem.Name = "thốngKêNhậpKhoToolStripMenuItem";
            this.thốngKêNhậpKhoToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.thốngKêNhậpKhoToolStripMenuItem.Text = "Thống kê hàng theo chi tiết";
            // 
            // thốngKêXuấtKhoToolStripMenuItem
            // 
            this.thốngKêXuấtKhoToolStripMenuItem.Name = "thốngKêXuấtKhoToolStripMenuItem";
            this.thốngKêXuấtKhoToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.thốngKêXuấtKhoToolStripMenuItem.Text = "Thống kê nhập kho";
            // 
            // thốngKêXuấtKhoToolStripMenuItem1
            // 
            this.thốngKêXuấtKhoToolStripMenuItem1.Name = "thốngKêXuấtKhoToolStripMenuItem1";
            this.thốngKêXuấtKhoToolStripMenuItem1.Size = new System.Drawing.Size(219, 22);
            this.thốngKêXuấtKhoToolStripMenuItem1.Text = "Thống kê xuất kho";
            // 
            // quảnLýTàiKhoảnToolStripMenuItem1
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsInfoAccount});
            this.quảnLýTàiKhoảnToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýTàiKhoảnToolStripMenuItem1.Image")));
            this.quảnLýTàiKhoảnToolStripMenuItem1.Name = "quảnLýTàiKhoảnToolStripMenuItem1";
            this.quảnLýTàiKhoảnToolStripMenuItem1.Size = new System.Drawing.Size(128, 20);
            this.quảnLýTàiKhoảnToolStripMenuItem1.Text = "Quản lý tài khoản";
            // 
            // mtsInfoAccount
            // 
            this.mtsInfoAccount.Name = "mtsInfoAccount";
            this.mtsInfoAccount.Size = new System.Drawing.Size(177, 22);
            this.mtsInfoAccount.Text = "Thông tin tài khoản";
            this.mtsInfoAccount.Click += new System.EventHandler(this.mtsInfoAccount_Click);
            // 
            // càiĐặtToolStripMenuItem
            // 
            this.càiĐặtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsLogOut});
            this.càiĐặtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("càiĐặtToolStripMenuItem.Image")));
            this.càiĐặtToolStripMenuItem.Name = "càiĐặtToolStripMenuItem";
            this.càiĐặtToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.càiĐặtToolStripMenuItem.Text = "Cài đặt";
            // 
            // mtsLogOut
            // 
            this.mtsLogOut.Name = "mtsLogOut";
            this.mtsLogOut.Size = new System.Drawing.Size(129, 22);
            this.mtsLogOut.Text = "Đăng Xuất";
            this.mtsLogOut.Click += new System.EventHandler(this.mtsLogOut_Click);
            // 
            // mstExit
            // 
            this.mstExit.Image = ((System.Drawing.Image)(resources.GetObject("mstExit.Image")));
            this.mstExit.Name = "mstExit";
            this.mstExit.Size = new System.Drawing.Size(65, 20);
            this.mstExit.Text = "Thoát";
            this.mstExit.Click += new System.EventHandler(this.mstExit_Click_1);
            // 
            // tHome
            // 
            this.tHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tHome.Controls.Add(this.tProduct);
            this.tHome.Controls.Add(this.tTypeProduct);
            this.tHome.Controls.Add(this.tStatistical);
            this.tHome.Controls.Add(this.tAbouts);
            this.tHome.Controls.Add(this.tabPage1);
            this.tHome.Controls.Add(this.tabPage2);
            this.tHome.Controls.Add(this.tabPage3);
            this.tHome.Controls.Add(this.tabPage4);
            this.tHome.Location = new System.Drawing.Point(0, 24);
            this.tHome.Name = "tHome";
            this.tHome.SelectedIndex = 0;
            this.tHome.Size = new System.Drawing.Size(1044, 577);
            this.tHome.TabIndex = 1;
            // 
            // tProduct
            // 
            this.tProduct.Controls.Add(this.groupBox1);
            this.tProduct.Location = new System.Drawing.Point(4, 22);
            this.tProduct.Name = "tProduct";
            this.tProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tProduct.Size = new System.Drawing.Size(1036, 551);
            this.tProduct.TabIndex = 1;
            this.tProduct.Text = "Sản Phẩm";
            this.tProduct.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProduct);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1030, 545);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Sản Phẩm";
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
            this.IDProductDetail});
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.Location = new System.Drawing.Point(3, 16);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(1024, 526);
            this.dgvProduct.TabIndex = 1;
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
            // tTypeProduct
            // 
            this.tTypeProduct.Controls.Add(this.groupBox2);
            this.tTypeProduct.Location = new System.Drawing.Point(4, 22);
            this.tTypeProduct.Name = "tTypeProduct";
            this.tTypeProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tTypeProduct.Size = new System.Drawing.Size(1036, 551);
            this.tTypeProduct.TabIndex = 2;
            this.tTypeProduct.Text = "Loại Sản Phẩm";
            this.tTypeProduct.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvProductType);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1030, 545);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Loại Sản Phẩm";
            // 
            // dgvProductType
            // 
            this.dgvProductType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductType.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProductType,
            this.ProductTypeName});
            this.dgvProductType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductType.Location = new System.Drawing.Point(3, 16);
            this.dgvProductType.Name = "dgvProductType";
            this.dgvProductType.ReadOnly = true;
            this.dgvProductType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductType.Size = new System.Drawing.Size(1024, 526);
            this.dgvProductType.TabIndex = 2;
            // 
            // IDProductType
            // 
            this.IDProductType.DataPropertyName = "IDProductType";
            this.IDProductType.HeaderText = "Mã Loại Sản Phẩm";
            this.IDProductType.Name = "IDProductType";
            this.IDProductType.ReadOnly = true;
            // 
            // ProductTypeName
            // 
            this.ProductTypeName.DataPropertyName = "ProductTypeName";
            this.ProductTypeName.HeaderText = "Tên Loại Sản Phẩm";
            this.ProductTypeName.Name = "ProductTypeName";
            this.ProductTypeName.ReadOnly = true;
            // 
            // tStatistical
            // 
            this.tStatistical.Controls.Add(this.groupBox6);
            this.tStatistical.Location = new System.Drawing.Point(4, 22);
            this.tStatistical.Name = "tStatistical";
            this.tStatistical.Padding = new System.Windows.Forms.Padding(3);
            this.tStatistical.Size = new System.Drawing.Size(1036, 551);
            this.tStatistical.TabIndex = 3;
            this.tStatistical.Text = "Chi Tiết Sản Phẩm";
            this.tStatistical.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvProductDetail);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1030, 545);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Danh Sách Chi Tiết Sản Phẩm";
            // 
            // dgvProductDetail
            // 
            this.dgvProductDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDDetail,
            this.Size,
            this.Color});
            this.dgvProductDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductDetail.Location = new System.Drawing.Point(3, 16);
            this.dgvProductDetail.Name = "dgvProductDetail";
            this.dgvProductDetail.ReadOnly = true;
            this.dgvProductDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductDetail.Size = new System.Drawing.Size(1024, 526);
            this.dgvProductDetail.TabIndex = 2;
            // 
            // IDDetail
            // 
            this.IDDetail.DataPropertyName = "IDProductDetail";
            this.IDDetail.HeaderText = "Mã Chi Tiết Sản Phẩm";
            this.IDDetail.Name = "IDDetail";
            this.IDDetail.ReadOnly = true;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Size";
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // tAbouts
            // 
            this.tAbouts.Controls.Add(this.groupBox5);
            this.tAbouts.Location = new System.Drawing.Point(4, 22);
            this.tAbouts.Name = "tAbouts";
            this.tAbouts.Padding = new System.Windows.Forms.Padding(3);
            this.tAbouts.Size = new System.Drawing.Size(1036, 551);
            this.tAbouts.TabIndex = 4;
            this.tAbouts.Text = "Nhà Cung Cấp";
            this.tAbouts.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvProvider);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1030, 545);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh Sách Nhà Cung Cấp";
            // 
            // dgvProvider
            // 
            this.dgvProvider.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProvider.BackgroundColor = System.Drawing.Color.White;
            this.dgvProvider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvider.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NamePro,
            this.Card,
            this.Phone,
            this.Mail,
            this.Addre});
            this.dgvProvider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProvider.Location = new System.Drawing.Point(3, 16);
            this.dgvProvider.Name = "dgvProvider";
            this.dgvProvider.ReadOnly = true;
            this.dgvProvider.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProvider.Size = new System.Drawing.Size(1024, 526);
            this.dgvProvider.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "IDProvider";
            this.ID.HeaderText = "Mã Nhà Cung Cấp";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NamePro
            // 
            this.NamePro.DataPropertyName = "ProviderName";
            this.NamePro.HeaderText = "Tên Nhà Cung Cấp";
            this.NamePro.Name = "NamePro";
            this.NamePro.ReadOnly = true;
            // 
            // Card
            // 
            this.Card.DataPropertyName = "IDCard";
            this.Card.HeaderText = "Mã Thẻ";
            this.Card.Name = "Card";
            this.Card.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "PhoneNum";
            this.Phone.HeaderText = "Số Điện Thoại";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Mail
            // 
            this.Mail.DataPropertyName = "Email";
            this.Mail.HeaderText = "Email";
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            // 
            // Addre
            // 
            this.Addre.DataPropertyName = "Address";
            this.Addre.HeaderText = "Địa Chỉ";
            this.Addre.Name = "Addre";
            this.Addre.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1036, 551);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Khách Hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvCustomer);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1030, 545);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Khách Hàng";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PhoneNum,
            this.CustomerName,
            this.IDCard,
            this.Email,
            this.Address,
            this.Status});
            this.dgvCustomer.Location = new System.Drawing.Point(3, 16);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersWidth = 40;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(1024, 526);
            this.dgvCustomer.TabIndex = 14;
            // 
            // PhoneNum
            // 
            this.PhoneNum.DataPropertyName = "PhoneNum";
            this.PhoneNum.HeaderText = "Số Điện Thoại";
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Tên Khách Hàng";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // IDCard
            // 
            this.IDCard.DataPropertyName = "IDCard";
            this.IDCard.HeaderText = "Mã Thẻ";
            this.IDCard.Name = "IDCard";
            this.IDCard.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Địa Chỉ";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Trạng Thái";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1036, 551);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "Hoá Đơn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.dgvBill);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Location = new System.Drawing.Point(3, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(1030, 545);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Danh Sách Hoá Đơn";
            // 
            // dgvBill
            // 
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.BackgroundColor = System.Drawing.Color.White;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDBill,
            this.IDNCC,
            this.Date,
            this.IDCustomer,
            this.IDNV,
            this.TypeBill,
            this.TT});
            this.dgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBill.Location = new System.Drawing.Point(3, 16);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(1024, 526);
            this.dgvBill.TabIndex = 3;
            // 
            // IDBill
            // 
            this.IDBill.DataPropertyName = "IDBill";
            this.IDBill.HeaderText = "Mã Hoá Đơn";
            this.IDBill.Name = "IDBill";
            this.IDBill.ReadOnly = true;
            // 
            // IDNCC
            // 
            this.IDNCC.DataPropertyName = "IDProvider";
            this.IDNCC.HeaderText = "Mã Nhà Cung Cấp";
            this.IDNCC.Name = "IDNCC";
            this.IDNCC.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Ngày Bán";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // IDCustomer
            // 
            this.IDCustomer.DataPropertyName = "IDCustomer";
            this.IDCustomer.HeaderText = "Mã Khách Hàng";
            this.IDCustomer.Name = "IDCustomer";
            this.IDCustomer.ReadOnly = true;
            // 
            // IDNV
            // 
            this.IDNV.DataPropertyName = "IDStaff";
            this.IDNV.HeaderText = "Mã Nhân Viên";
            this.IDNV.Name = "IDNV";
            this.IDNV.ReadOnly = true;
            // 
            // TypeBill
            // 
            this.TypeBill.DataPropertyName = "TypeBill";
            this.TypeBill.HeaderText = "Loại Hoá Đơn";
            this.TypeBill.Name = "TypeBill";
            this.TypeBill.ReadOnly = true;
            // 
            // TT
            // 
            this.TT.DataPropertyName = "Status";
            this.TT.HeaderText = "Trạng Thái";
            this.TT.Name = "TT";
            this.TT.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1036, 551);
            this.tabPage3.TabIndex = 7;
            this.tabPage3.Text = "Chi Tiết Hoá Đơn";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dgvBillDetail);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(3, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1030, 545);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Danh Sách Chi Tiết Hoá Đơn";
            // 
            // dgvBillDetail
            // 
            this.dgvBillDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBillDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvBillDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDB,
            this.IDPro,
            this.Number,
            this.Price,
            this.Discount});
            this.dgvBillDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBillDetail.Location = new System.Drawing.Point(3, 16);
            this.dgvBillDetail.Name = "dgvBillDetail";
            this.dgvBillDetail.ReadOnly = true;
            this.dgvBillDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillDetail.Size = new System.Drawing.Size(1024, 526);
            this.dgvBillDetail.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1036, 551);
            this.tabPage4.TabIndex = 8;
            this.tabPage4.Text = "Nhân Viên";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvStaff);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1030, 545);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh Sách Nhân Viên";
            // 
            // dgvStaff
            // 
            this.dgvStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaff.BackgroundColor = System.Drawing.Color.White;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDStaff,
            this.StaffName,
            this.Salary,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvStaff.Location = new System.Drawing.Point(3, 16);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.Size = new System.Drawing.Size(1024, 526);
            this.dgvStaff.TabIndex = 14;
            // 
            // IDStaff
            // 
            this.IDStaff.DataPropertyName = "IDStaff";
            this.IDStaff.HeaderText = "Mã Nhân Viên";
            this.IDStaff.Name = "IDStaff";
            this.IDStaff.ReadOnly = true;
            // 
            // StaffName
            // 
            this.StaffName.DataPropertyName = "StaffName";
            this.StaffName.HeaderText = "Tên Nhân Viên";
            this.StaffName.Name = "StaffName";
            this.StaffName.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Lương";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PhoneNum";
            this.dataGridViewTextBoxColumn4.HeaderText = "Số Điện Thoại";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.HeaderText = "Email";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn8.HeaderText = "Địa Chỉ";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn9.HeaderText = "Chức Vụ";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // IDB
            // 
            this.IDB.DataPropertyName = "IDBill";
            this.IDB.HeaderText = "Mã Hoá Đơn";
            this.IDB.Name = "IDB";
            this.IDB.ReadOnly = true;
            // 
            // IDPro
            // 
            this.IDPro.DataPropertyName = "IDProduct";
            this.IDPro.HeaderText = "Mã Sản Phẩm";
            this.IDPro.Name = "IDPro";
            this.IDPro.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Số Lượng";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Giá Bán";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "Giảm Giá";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // fHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 603);
            this.Controls.Add(this.tHome);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "fHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePages";
            this.Load += new System.EventHandler(this.fHomePages_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tHome.ResumeLayout(false);
            this.tProduct.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.tTypeProduct.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductType)).EndInit();
            this.tStatistical.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetail)).EndInit();
            this.tAbouts.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvider)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetail)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mntHome;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wonmenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mtsAddCustomer;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mtsAddProduct;
        private System.Windows.Forms.ToolStripMenuItem mtsEditProductType;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hàngTrongKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêHàngTrongKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêNhậpKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêXuấtKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mtsInfoAccount;
        private System.Windows.Forms.ToolStripMenuItem càiĐặtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mtsEditStaff;
        private System.Windows.Forms.ToolStripMenuItem mstExit;
        private ToolStripMenuItem mtsProvider;
        private ToolStripMenuItem mtsLogOut;
        private ToolStripMenuItem thốngKêXuấtKhoToolStripMenuItem1;
        private TabControl tHome;
        private TabPage tProduct;
        private GroupBox groupBox1;
        private DataGridView dgvProduct;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn PriceOut;
        private DataGridViewTextBoxColumn IDTypeProduct;
        private DataGridViewTextBoxColumn IDProvider;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn IDProductDetail;
        private TabPage tTypeProduct;
        private GroupBox groupBox2;
        private DataGridView dgvProductType;
        private DataGridViewTextBoxColumn IDProductType;
        private DataGridViewTextBoxColumn ProductTypeName;
        private TabPage tStatistical;
        private GroupBox groupBox6;
        private DataGridView dgvProductDetail;
        private DataGridViewTextBoxColumn IDDetail;
        private DataGridViewTextBoxColumn Size;
        private DataGridViewTextBoxColumn Color;
        private TabPage tAbouts;
        private GroupBox groupBox5;
        private DataGridView dgvProvider;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NamePro;
        private DataGridViewTextBoxColumn Card;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Mail;
        private DataGridViewTextBoxColumn Addre;
        private TabPage tabPage1;
        private GroupBox groupBox3;
        private DataGridView dgvCustomer;
        private DataGridViewTextBoxColumn PhoneNum;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn IDCard;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Status;
        private TabPage tabPage2;
        private GroupBox groupBox8;
        private DataGridView dgvBill;
        private DataGridViewTextBoxColumn IDBill;
        private DataGridViewTextBoxColumn IDNCC;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn IDCustomer;
        private DataGridViewTextBoxColumn IDNV;
        private DataGridViewTextBoxColumn TypeBill;
        private DataGridViewTextBoxColumn TT;
        private TabPage tabPage3;
        private GroupBox groupBox7;
        private DataGridView dgvBillDetail;
        private TabPage tabPage4;
        private GroupBox groupBox4;
        private DataGridView dgvStaff;
        private DataGridViewTextBoxColumn IDStaff;
        private DataGridViewTextBoxColumn StaffName;
        private DataGridViewTextBoxColumn Salary;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn IDB;
        private DataGridViewTextBoxColumn IDPro;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Discount;
    }
}