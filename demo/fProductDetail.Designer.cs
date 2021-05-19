
namespace demo
{
    partial class fProductDetail
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
            this.button1 = new System.Windows.Forms.Button();
            this.cbIDProductDetail = new System.Windows.Forms.ComboBox();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.txtImageName = new System.Windows.Forms.TextBox();
            this.txtPriceOut = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pProduct = new System.Windows.Forms.PictureBox();
            this.txtPriceIn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProduct = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.IDProductDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.pButton.SuspendLayout();
            this.pValues.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // 
            // cbIDProductDetail
            // 
            this.cbIDProductDetail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIDProductDetail.FormattingEnabled = true;
            this.cbIDProductDetail.Location = new System.Drawing.Point(128, 15);
            this.cbIDProductDetail.Name = "cbIDProductDetail";
            this.cbIDProductDetail.Size = new System.Drawing.Size(135, 21);
            this.cbIDProductDetail.TabIndex = 8;
            // 
            // nudNumber
            // 
            this.nudNumber.Location = new System.Drawing.Point(394, 83);
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(84, 20);
            this.nudNumber.TabIndex = 2;
            // 
            // txtImageName
            // 
            this.txtImageName.Location = new System.Drawing.Point(128, 88);
            this.txtImageName.Name = "txtImageName";
            this.txtImageName.Size = new System.Drawing.Size(136, 20);
            this.txtImageName.TabIndex = 4;
            // 
            // txtPriceOut
            // 
            this.txtPriceOut.Location = new System.Drawing.Point(394, 51);
            this.txtPriceOut.Name = "txtPriceOut";
            this.txtPriceOut.Size = new System.Drawing.Size(84, 20);
            this.txtPriceOut.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pProduct);
            this.panel1.Controls.Add(this.cbIDProductDetail);
            this.panel1.Controls.Add(this.nudNumber);
            this.panel1.Controls.Add(this.txtImageName);
            this.panel1.Controls.Add(this.txtPriceOut);
            this.panel1.Controls.Add(this.txtPriceIn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 175);
            this.panel1.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(394, 123);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(84, 21);
            this.comboBox2.TabIndex = 30;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(128, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 21);
            this.comboBox1.TabIndex = 30;
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
            // txtPriceIn
            // 
            this.txtPriceIn.Location = new System.Drawing.Point(394, 19);
            this.txtPriceIn.Name = "txtPriceIn";
            this.txtPriceIn.Size = new System.Drawing.Size(84, 20);
            this.txtPriceIn.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(286, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Kích Thước:";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(129, 51);
            this.txtProductName.MaxLength = 20;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(135, 20);
            this.txtProductName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Màu:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(20, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mã Chi Tiết  Sản Phẩm:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(289, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Giá Nhập:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(20, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 23);
            this.label8.TabIndex = 25;
            this.label8.Text = "Tên Hình";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(21, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tên Sản Phẩm:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(288, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Giá Xuất:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(289, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Số Lượng:";
            // 
            // errorProduct
            // 
            this.errorProduct.ContainerControl = this;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProductDetail,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn3,
            this.PriceOut,
            this.Picture,
            this.Mau,
            this.Size});
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvProduct.Location = new System.Drawing.Point(3, 16);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(1111, 296);
            this.dgvProduct.TabIndex = 0;
            // 
            // IDProductDetail
            // 
            this.IDProductDetail.DataPropertyName = "IDProductDetail";
            this.IDProductDetail.HeaderText = "Mã Chi Tiết Sản Phẩm";
            this.IDProductDetail.Name = "IDProductDetail";
            this.IDProductDetail.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDProduct";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Sản Phẩm";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            this.pButton.Location = new System.Drawing.Point(762, 12);
            this.pButton.Name = "pButton";
            this.pButton.Size = new System.Drawing.Size(322, 179);
            this.pButton.TabIndex = 8;
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
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(127, 41);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(82, 23);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Tải Lại";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(39, 143);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(263, 23);
            this.btnSearchProduct.TabIndex = 8;
            this.btnSearchProduct.Text = "Tìm Kiếm";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(220, 12);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(82, 23);
            this.btnUpdateProduct.TabIndex = 3;
            this.btnUpdateProduct.Text = "Cập Nhật";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
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
            // 
            // btnRefreshText
            // 
            this.btnRefreshText.Location = new System.Drawing.Point(37, 40);
            this.btnRefreshText.Name = "btnRefreshText";
            this.btnRefreshText.Size = new System.Drawing.Size(82, 23);
            this.btnRefreshText.TabIndex = 1;
            this.btnRefreshText.Text = "Nhập Lại";
            this.btnRefreshText.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(37, 12);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(82, 23);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Thêm";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(127, 12);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(82, 23);
            this.btnDeleteProduct.TabIndex = 2;
            this.btnDeleteProduct.Text = "Xoá";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
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
            this.groupBox1.Location = new System.Drawing.Point(9, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1120, 315);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // fProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 587);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "fProductDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "fProductDetail";
            this.Load += new System.EventHandler(this.fProductDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.pButton.ResumeLayout(false);
            this.pButton.PerformLayout();
            this.pValues.ResumeLayout(false);
            this.pValues.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbIDProductDetail;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.TextBox txtImageName;
        private System.Windows.Forms.TextBox txtPriceOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pProduct;
        private System.Windows.Forms.TextBox txtPriceIn;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProduct;
        private System.Windows.Forms.Panel pButton;
        private System.Windows.Forms.Panel pValues;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefreshText;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProductDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
    }
}