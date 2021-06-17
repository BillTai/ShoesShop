
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHomePage));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mntHome = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wonmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsAddCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsEditProductType = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvBillDetail = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.tStatistical = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvProductDetail = new System.Windows.Forms.DataGridView();
            this.tTypeProduct = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvProductType = new System.Windows.Forms.DataGridView();
            this.IDProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tProduct = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.tHome = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chartquy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cquy = new Guna.UI2.WinForms.Guna2RadioButton();
            this.cMonth = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbYear = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chartMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTypeProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDProductDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetail)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.tStatistical.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetail)).BeginInit();
            this.tTypeProduct.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductType)).BeginInit();
            this.tProduct.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.tHome.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartquy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
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
            this.menuStrip.Size = new System.Drawing.Size(837, 38);
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
            this.mntHome.Size = new System.Drawing.Size(87, 34);
            this.mntHome.Text = "Bán Hàng";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.đăngNhậpToolStripMenuItem.Text = "Tạo Đơn";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // đăngKýToolStripMenuItem
            // 
            this.đăngKýToolStripMenuItem.Name = "đăngKýToolStripMenuItem";
            this.đăngKýToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.đăngKýToolStripMenuItem.Text = "Tìm hoá đơn cũ";
            this.đăngKýToolStripMenuItem.Click += new System.EventHandler(this.đăngKýToolStripMenuItem_Click);
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
            this.mtsAddCustomer});
            this.quảnLýKháchHàngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýKháchHàngToolStripMenuItem.Image")));
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(141, 34);
            this.quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            // 
            // mtsAddCustomer
            // 
            this.mtsAddCustomer.Name = "mtsAddCustomer";
            this.mtsAddCustomer.Size = new System.Drawing.Size(180, 22);
            this.mtsAddCustomer.Text = "Quản lý khách hàng";
            this.mtsAddCustomer.Click += new System.EventHandler(this.mtsAddCustomer_Click);
            // 
            // quảnLýHàngToolStripMenuItem
            // 
            this.quảnLýHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsEditProductType,
            this.quảnLýSảnPhẩmToolStripMenuItem});
            this.quảnLýHàngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýHàngToolStripMenuItem.Image")));
            this.quảnLýHàngToolStripMenuItem.Name = "quảnLýHàngToolStripMenuItem";
            this.quảnLýHàngToolStripMenuItem.Size = new System.Drawing.Size(119, 34);
            this.quảnLýHàngToolStripMenuItem.Text = "Quản sản phẩm";
            // 
            // mtsEditProductType
            // 
            this.mtsEditProductType.Name = "mtsEditProductType";
            this.mtsEditProductType.Size = new System.Drawing.Size(192, 22);
            this.mtsEditProductType.Text = "Quản lý loại sản phẩm";
            this.mtsEditProductType.Click += new System.EventHandler(this.mtsEditProductType_Click);
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            this.quảnLýSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý sản phẩm";
            this.quảnLýSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSảnPhẩmToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsEditStaff});
            this.trợGiúpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("trợGiúpToolStripMenuItem.Image")));
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(131, 34);
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
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(99, 34);
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
            this.quảnLýTàiKhoảnToolStripMenuItem1.Size = new System.Drawing.Size(128, 34);
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
            this.càiĐặtToolStripMenuItem.Size = new System.Drawing.Size(72, 34);
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
            this.mstExit.Size = new System.Drawing.Size(65, 34);
            this.mstExit.Text = "Thoát";
            this.mstExit.Click += new System.EventHandler(this.mstExit_Click_1);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1036, 543);
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
            this.groupBox4.Size = new System.Drawing.Size(1030, 537);
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
            this.dgvStaff.Size = new System.Drawing.Size(1024, 518);
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1036, 543);
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
            this.groupBox7.Size = new System.Drawing.Size(1030, 537);
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
            this.Discount,
            this.Column5});
            this.dgvBillDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBillDetail.Location = new System.Drawing.Point(3, 16);
            this.dgvBillDetail.Name = "dgvBillDetail";
            this.dgvBillDetail.ReadOnly = true;
            this.dgvBillDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillDetail.Size = new System.Drawing.Size(1024, 518);
            this.dgvBillDetail.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1036, 543);
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
            this.groupBox8.Size = new System.Drawing.Size(1030, 537);
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
            this.Date,
            this.IDCustomer,
            this.IDNV,
            this.TypeBill,
            this.TT,
            this.Column4});
            this.dgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBill.Location = new System.Drawing.Point(3, 16);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(1024, 518);
            this.dgvBill.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1036, 543);
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
            this.groupBox3.Size = new System.Drawing.Size(1030, 537);
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
            this.Status,
            this.Column3});
            this.dgvCustomer.Location = new System.Drawing.Point(3, 16);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersWidth = 40;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(1024, 518);
            this.dgvCustomer.TabIndex = 14;
            // 
            // tStatistical
            // 
            this.tStatistical.Controls.Add(this.groupBox6);
            this.tStatistical.Location = new System.Drawing.Point(4, 22);
            this.tStatistical.Name = "tStatistical";
            this.tStatistical.Padding = new System.Windows.Forms.Padding(3);
            this.tStatistical.Size = new System.Drawing.Size(1036, 543);
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
            this.groupBox6.Size = new System.Drawing.Size(1030, 537);
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
            this.IDProductDetail,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn10,
            this.PriceOut,
            this.Picture,
            this.Mau,
            this.Size,
            this.Column2});
            this.dgvProductDetail.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvProductDetail.Location = new System.Drawing.Point(3, 16);
            this.dgvProductDetail.Name = "dgvProductDetail";
            this.dgvProductDetail.ReadOnly = true;
            this.dgvProductDetail.RowHeadersVisible = false;
            this.dgvProductDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductDetail.Size = new System.Drawing.Size(1021, 518);
            this.dgvProductDetail.TabIndex = 1;
            // 
            // tTypeProduct
            // 
            this.tTypeProduct.Controls.Add(this.groupBox2);
            this.tTypeProduct.Location = new System.Drawing.Point(4, 22);
            this.tTypeProduct.Name = "tTypeProduct";
            this.tTypeProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tTypeProduct.Size = new System.Drawing.Size(1036, 543);
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
            this.groupBox2.Size = new System.Drawing.Size(1030, 537);
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
            this.dgvProductType.Size = new System.Drawing.Size(1024, 518);
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
            // tProduct
            // 
            this.tProduct.Controls.Add(this.groupBox1);
            this.tProduct.Location = new System.Drawing.Point(4, 22);
            this.tProduct.Name = "tProduct";
            this.tProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tProduct.Size = new System.Drawing.Size(1036, 543);
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
            this.groupBox1.Size = new System.Drawing.Size(1030, 537);
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
            this.IDTypeProduct,
            this.IDProvider,
            this.dataGridViewTextBoxColumn7,
            this.Column1});
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvProduct.Location = new System.Drawing.Point(3, 16);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(1024, 518);
            this.dgvProduct.TabIndex = 1;
            // 
            // tHome
            // 
            this.tHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tHome.Controls.Add(this.tProduct);
            this.tHome.Controls.Add(this.tTypeProduct);
            this.tHome.Controls.Add(this.tStatistical);
            this.tHome.Controls.Add(this.tabPage1);
            this.tHome.Controls.Add(this.tabPage2);
            this.tHome.Controls.Add(this.tabPage3);
            this.tHome.Controls.Add(this.tabPage4);
            this.tHome.Controls.Add(this.tabPage5);
            this.tHome.Controls.Add(this.tabPage6);
            this.tHome.Location = new System.Drawing.Point(0, 32);
            this.tHome.Name = "tHome";
            this.tHome.SelectedIndex = 0;
            this.tHome.Size = new System.Drawing.Size(1044, 569);
            this.tHome.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Controls.Add(this.txtTotalPrice);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.chartquy);
            this.tabPage5.Controls.Add(this.cquy);
            this.tabPage5.Controls.Add(this.cMonth);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.cbYear);
            this.tabPage5.Controls.Add(this.chartMonth);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1036, 543);
            this.tabPage5.TabIndex = 9;
            this.tabPage5.Text = "Biểu Đồ Doanh Thu";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(967, 496);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 14);
            this.label16.TabIndex = 46;
            this.label16.Text = "VNĐ";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.BorderRadius = 10;
            this.txtTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalPrice.DefaultText = "";
            this.txtTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.DisabledState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.FocusedState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.txtTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.HoverState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Location = new System.Drawing.Point(775, 490);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PasswordChar = '\0';
            this.txtTotalPrice.PlaceholderText = "";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.SelectedText = "";
            this.txtTotalPrice.ShadowDecoration.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Size = new System.Drawing.Size(230, 27);
            this.txtTotalPrice.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(645, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tổng Doanh Thu:";
            // 
            // chartquy
            // 
            chartArea7.Area3DStyle.Enable3D = true;
            chartArea7.Area3DStyle.Inclination = 23;
            chartArea7.Name = "ChartArea1";
            this.chartquy.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartquy.Legends.Add(legend7);
            this.chartquy.Location = new System.Drawing.Point(55, 81);
            this.chartquy.Name = "chartquy";
            this.chartquy.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series7.IsValueShownAsLabel = true;
            series7.LabelFormat = "#.##%";
            series7.Legend = "Legend1";
            series7.Name = "Quý";
            this.chartquy.Series.Add(series7);
            this.chartquy.Size = new System.Drawing.Size(921, 386);
            this.chartquy.TabIndex = 4;
            this.chartquy.Text = "chart1";
            title7.Name = "Title1";
            title7.Text = "Doanh Thu Theo Quý";
            this.chartquy.Titles.Add(title7);
            // 
            // cquy
            // 
            this.cquy.AutoSize = true;
            this.cquy.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cquy.CheckedState.BorderThickness = 0;
            this.cquy.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cquy.CheckedState.InnerColor = System.Drawing.Color.White;
            this.cquy.CheckedState.InnerOffset = -4;
            this.cquy.Location = new System.Drawing.Point(416, 16);
            this.cquy.Name = "cquy";
            this.cquy.Size = new System.Drawing.Size(122, 17);
            this.cquy.TabIndex = 3;
            this.cquy.Text = "Thống Kê Theo Quý";
            this.cquy.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cquy.UncheckedState.BorderThickness = 2;
            this.cquy.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.cquy.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.cquy.CheckedChanged += new System.EventHandler(this.cquy_CheckedChanged);
            // 
            // cMonth
            // 
            this.cMonth.AutoSize = true;
            this.cMonth.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cMonth.CheckedState.BorderThickness = 0;
            this.cMonth.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cMonth.CheckedState.InnerColor = System.Drawing.Color.White;
            this.cMonth.CheckedState.InnerOffset = -4;
            this.cMonth.Location = new System.Drawing.Point(261, 16);
            this.cMonth.Name = "cMonth";
            this.cMonth.Size = new System.Drawing.Size(134, 17);
            this.cMonth.TabIndex = 3;
            this.cMonth.Text = "Thống Kê Theo Tháng";
            this.cMonth.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cMonth.UncheckedState.BorderThickness = 2;
            this.cMonth.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.cMonth.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.cMonth.CheckedChanged += new System.EventHandler(this.cMonth_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Năm:";
            // 
            // cbYear
            // 
            this.cbYear.BackColor = System.Drawing.Color.Transparent;
            this.cbYear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cbYear.BorderRadius = 5;
            this.cbYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbYear.DropDownHeight = 100;
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.DropDownWidth = 260;
            this.cbYear.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbYear.FocusedState.Parent = this.cbYear;
            this.cbYear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbYear.HoverState.Parent = this.cbYear;
            this.cbYear.IntegralHeight = false;
            this.cbYear.ItemHeight = 30;
            this.cbYear.ItemsAppearance.Parent = this.cbYear;
            this.cbYear.Location = new System.Drawing.Point(73, 6);
            this.cbYear.Name = "cbYear";
            this.cbYear.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.cbYear.ShadowDecoration.Parent = this.cbYear;
            this.cbYear.Size = new System.Drawing.Size(131, 36);
            this.cbYear.TabIndex = 1;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // chartMonth
            // 
            chartArea8.Name = "ChartArea1";
            this.chartMonth.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartMonth.Legends.Add(legend8);
            this.chartMonth.Location = new System.Drawing.Point(55, 81);
            this.chartMonth.Name = "chartMonth";
            series8.BorderColor = System.Drawing.Color.White;
            series8.BorderWidth = 4;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Color = System.Drawing.Color.LimeGreen;
            series8.Legend = "Legend1";
            series8.Name = "Doanh Thu";
            series8.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series8.YValuesPerPoint = 4;
            this.chartMonth.Series.Add(series8);
            this.chartMonth.Size = new System.Drawing.Size(921, 386);
            this.chartMonth.TabIndex = 0;
            this.chartMonth.Text = "chart1";
            title8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title8.Name = "Title1";
            title8.Text = "Doanh Thu Theo Tháng";
            this.chartMonth.Titles.Add(title8);
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1036, 543);
            this.tabPage6.TabIndex = 10;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
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
            this.btnExit.Location = new System.Drawing.Point(1003, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(34, 38);
            this.btnExit.TabIndex = 11;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 7000;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
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
            this.Column1.DataPropertyName = "Total";
            this.Column1.HeaderText = "Số Lượng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // IDProductDetail
            // 
            this.IDProductDetail.DataPropertyName = "IDProductDetail";
            this.IDProductDetail.HeaderText = "Mã Chi Tiết Sản Phẩm";
            this.IDProductDetail.Name = "IDProductDetail";
            this.IDProductDetail.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDProduct";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã Sản Phẩm";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Number";
            this.dataGridViewTextBoxColumn6.HeaderText = "Số Lượng";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PriceIn";
            this.dataGridViewTextBoxColumn10.HeaderText = "Giá Nhập";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // PriceOut
            // 
            this.PriceOut.DataPropertyName = "PriceOut";
            this.PriceOut.HeaderText = "Giá Xuất";
            this.PriceOut.Name = "PriceOut";
            this.PriceOut.ReadOnly = true;
            // 
            // Picture
            // 
            this.Picture.DataPropertyName = "Image";
            this.Picture.HeaderText = "Hình Ảnh";
            this.Picture.Name = "Picture";
            this.Picture.ReadOnly = true;
            // 
            // Mau
            // 
            this.Mau.DataPropertyName = "Color";
            this.Mau.HeaderText = "Màu";
            this.Mau.Name = "Mau";
            this.Mau.ReadOnly = true;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Size";
            this.Size.HeaderText = "Kích Thước";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ImageDetail";
            this.Column2.HeaderText = "Hình Chi Tiết";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
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
            // Column3
            // 
            this.Column3.DataPropertyName = "CustomerType";
            this.Column3.HeaderText = "Loại Khách Hàng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // IDBill
            // 
            this.IDBill.DataPropertyName = "IDBill";
            this.IDBill.HeaderText = "Mã Hoá Đơn";
            this.IDBill.Name = "IDBill";
            this.IDBill.ReadOnly = true;
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
            // Column4
            // 
            this.Column4.DataPropertyName = "TotalPrice";
            this.Column4.HeaderText = "Tổng Tiền";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
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
            this.IDPro.DataPropertyName = "IDProductDetail";
            this.IDPro.HeaderText = "Mã Chi Tiết Sản Phẩm";
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
            // Column5
            // 
            this.Column5.DataPropertyName = "TotalPrice";
            this.Column5.HeaderText = "Tổng Tiền";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // fHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 603);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tHome);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "fHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePages";
            this.Load += new System.EventHandler(this.fHomePages_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetail)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.tStatistical.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetail)).EndInit();
            this.tTypeProduct.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductType)).EndInit();
            this.tProduct.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.tHome.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartquy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonth)).EndInit();
            this.ResumeLayout(false);

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
        private ToolStripMenuItem mtsLogOut;
        private ToolStripMenuItem thốngKêXuấtKhoToolStripMenuItem1;
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
        private TabPage tabPage3;
        private GroupBox groupBox7;
        private DataGridView dgvBillDetail;
        private TabPage tabPage2;
        private GroupBox groupBox8;
        private DataGridView dgvBill;
        private TabPage tabPage1;
        private GroupBox groupBox3;
        private DataGridView dgvCustomer;
        private TabPage tStatistical;
        private GroupBox groupBox6;
        private DataGridView dgvProductDetail;
        private TabPage tTypeProduct;
        private GroupBox groupBox2;
        private DataGridView dgvProductType;
        private DataGridViewTextBoxColumn IDProductType;
        private DataGridViewTextBoxColumn ProductTypeName;
        private TabPage tProduct;
        private GroupBox groupBox1;
        private DataGridView dgvProduct;
        private TabControl tHome;
        private ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private TabPage tabPage5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMonth;
        private Guna.UI2.WinForms.Guna2RadioButton cquy;
        private Guna.UI2.WinForms.Guna2RadioButton cMonth;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartquy;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalPrice;
        private Timer timer1;
        private Label label16;
        private TabPage tabPage6;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private DataGridViewTextBoxColumn IDProductDetail;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn PriceOut;
        private DataGridViewTextBoxColumn Picture;
        private DataGridViewTextBoxColumn Mau;
        private DataGridViewTextBoxColumn Size;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn IDTypeProduct;
        private DataGridViewTextBoxColumn IDProvider;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn PhoneNum;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn IDCard;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn IDB;
        private DataGridViewTextBoxColumn IDPro;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Discount;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn IDBill;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn IDCustomer;
        private DataGridViewTextBoxColumn IDNV;
        private DataGridViewTextBoxColumn TypeBill;
        private DataGridViewTextBoxColumn TT;
        private DataGridViewTextBoxColumn Column4;
    }
}