
namespace demo
{
    partial class fProvider
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
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnSearchProvider = new System.Windows.Forms.Button();
            this.btnUpdateProvider = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefreshText = new System.Windows.Forms.Button();
            this.btnAddProvider = new System.Windows.Forms.Button();
            this.btnDeleteProvider = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvProvider = new System.Windows.Forms.DataGridView();
            this.IDProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProviderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDCard = new System.Windows.Forms.TextBox();
            this.txtProviderName = new System.Windows.Forms.TextBox();
            this.txtIDProvider = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvider)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pButton
            // 
            this.pButton.Controls.Add(this.cbSearch);
            this.pButton.Controls.Add(this.btnReload);
            this.pButton.Controls.Add(this.btnSearchProvider);
            this.pButton.Controls.Add(this.btnUpdateProvider);
            this.pButton.Controls.Add(this.btnExit);
            this.pButton.Controls.Add(this.btnRefreshText);
            this.pButton.Controls.Add(this.btnAddProvider);
            this.pButton.Controls.Add(this.btnDeleteProvider);
            this.pButton.Controls.Add(this.txtSearch);
            this.pButton.Location = new System.Drawing.Point(615, 33);
            this.pButton.Name = "pButton";
            this.pButton.Size = new System.Drawing.Size(319, 156);
            this.pButton.TabIndex = 8;
            // 
            // cbSearch
            // 
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(18, 77);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(92, 21);
            this.cbSearch.TabIndex = 9;
            this.cbSearch.SelectedIndexChanged += new System.EventHandler(this.cbSearch_SelectedIndexChanged);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(108, 40);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Tải Lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnSearchProvider
            // 
            this.btnSearchProvider.Location = new System.Drawing.Point(18, 117);
            this.btnSearchProvider.Name = "btnSearchProvider";
            this.btnSearchProvider.Size = new System.Drawing.Size(258, 23);
            this.btnSearchProvider.TabIndex = 8;
            this.btnSearchProvider.Text = "Tìm Kiếm";
            this.btnSearchProvider.UseVisualStyleBackColor = true;
            this.btnSearchProvider.Click += new System.EventHandler(this.btnSearchProvider_Click);
            // 
            // btnUpdateProvider
            // 
            this.btnUpdateProvider.Location = new System.Drawing.Point(201, 11);
            this.btnUpdateProvider.Name = "btnUpdateProvider";
            this.btnUpdateProvider.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateProvider.TabIndex = 2;
            this.btnUpdateProvider.Text = "Cập Nhật";
            this.btnUpdateProvider.UseVisualStyleBackColor = true;
            this.btnUpdateProvider.Click += new System.EventHandler(this.btnUpdateProvider_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(201, 40);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRefreshText
            // 
            this.btnRefreshText.Location = new System.Drawing.Point(18, 39);
            this.btnRefreshText.Name = "btnRefreshText";
            this.btnRefreshText.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshText.TabIndex = 3;
            this.btnRefreshText.Text = "Nhập Lại";
            this.btnRefreshText.UseVisualStyleBackColor = true;
            this.btnRefreshText.Click += new System.EventHandler(this.btnRefreshText_Click);
            // 
            // btnAddProvider
            // 
            this.btnAddProvider.Location = new System.Drawing.Point(18, 11);
            this.btnAddProvider.Name = "btnAddProvider";
            this.btnAddProvider.Size = new System.Drawing.Size(75, 23);
            this.btnAddProvider.TabIndex = 0;
            this.btnAddProvider.Text = "Thêm";
            this.btnAddProvider.UseVisualStyleBackColor = true;
            this.btnAddProvider.Click += new System.EventHandler(this.btnAddProvider_Click);
            // 
            // btnDeleteProvider
            // 
            this.btnDeleteProvider.Location = new System.Drawing.Point(108, 11);
            this.btnDeleteProvider.Name = "btnDeleteProvider";
            this.btnDeleteProvider.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProvider.TabIndex = 1;
            this.btnDeleteProvider.Text = "Xoá";
            this.btnDeleteProvider.UseVisualStyleBackColor = true;
            this.btnDeleteProvider.Click += new System.EventHandler(this.btnDeleteProvider_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(140, 77);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(136, 20);
            this.txtSearch.TabIndex = 6;
            // 
            // dgvProvider
            // 
            this.dgvProvider.BackgroundColor = System.Drawing.Color.White;
            this.dgvProvider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvider.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProvider,
            this.ProviderName,
            this.IDCard,
            this.PhoneNum,
            this.Email,
            this.Address});
            this.dgvProvider.Location = new System.Drawing.Point(6, 21);
            this.dgvProvider.Name = "dgvProvider";
            this.dgvProvider.ReadOnly = true;
            this.dgvProvider.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProvider.Size = new System.Drawing.Size(928, 253);
            this.dgvProvider.TabIndex = 10;
            this.dgvProvider.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProvider_CellClick);
            // 
            // IDProvider
            // 
            this.IDProvider.DataPropertyName = "IDProvider";
            this.IDProvider.HeaderText = "Mã Nhà Cung Câp";
            this.IDProvider.Name = "IDProvider";
            this.IDProvider.ReadOnly = true;
            this.IDProvider.Width = 150;
            // 
            // ProviderName
            // 
            this.ProviderName.DataPropertyName = "ProviderName";
            this.ProviderName.HeaderText = "Tên Nhà Cung Cấp";
            this.ProviderName.Name = "ProviderName";
            this.ProviderName.ReadOnly = true;
            this.ProviderName.Width = 150;
            // 
            // IDCard
            // 
            this.IDCard.DataPropertyName = "IDCard";
            this.IDCard.HeaderText = "Mã Thẻ";
            this.IDCard.Name = "IDCard";
            this.IDCard.ReadOnly = true;
            this.IDCard.Width = 150;
            // 
            // PhoneNum
            // 
            this.PhoneNum.DataPropertyName = "PhoneNum";
            this.PhoneNum.HeaderText = "Số Điện Thoại";
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.ReadOnly = true;
            this.PhoneNum.Width = 150;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 150;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Địa Chỉ";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPhoneNum);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtIDCard);
            this.panel1.Controls.Add(this.txtProviderName);
            this.panel1.Controls.Add(this.txtIDProvider);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 175);
            this.panel1.TabIndex = 11;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(405, 42);
            this.txtPhoneNum.MaxLength = 10;
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(136, 20);
            this.txtPhoneNum.TabIndex = 5;
            this.txtPhoneNum.TextChanged += new System.EventHandler(this.txtIDCard_TextChanged);
            this.txtPhoneNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDCard_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(405, 111);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(136, 20);
            this.txtAddress.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(405, 78);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(136, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtIDCard_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(298, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(297, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Địa Chỉ:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(299, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Số Điện Thoại:";
            // 
            // txtIDCard
            // 
            this.txtIDCard.Location = new System.Drawing.Point(137, 114);
            this.txtIDCard.MaxLength = 12;
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.Size = new System.Drawing.Size(138, 20);
            this.txtIDCard.TabIndex = 2;
            this.txtIDCard.TextChanged += new System.EventHandler(this.txtIDCard_TextChanged);
            this.txtIDCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDCard_KeyPress);
            // 
            // txtProviderName
            // 
            this.txtProviderName.Location = new System.Drawing.Point(137, 78);
            this.txtProviderName.MaxLength = 20;
            this.txtProviderName.Name = "txtProviderName";
            this.txtProviderName.Size = new System.Drawing.Size(138, 20);
            this.txtProviderName.TabIndex = 1;
            this.txtProviderName.TextChanged += new System.EventHandler(this.txtIDCard_TextChanged);
            // 
            // txtIDProvider
            // 
            this.txtIDProvider.Location = new System.Drawing.Point(139, 45);
            this.txtIDProvider.MaxLength = 20;
            this.txtIDProvider.Name = "txtIDProvider";
            this.txtIDProvider.Size = new System.Drawing.Size(136, 20);
            this.txtIDProvider.TabIndex = 0;
            this.txtIDProvider.TextChanged += new System.EventHandler(this.txtIDProvider_TextChanged);
            this.txtIDProvider.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDProvider_KeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã Thẻ:";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(26, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tên Nhà Cung Cấp:";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(26, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Mã Nhà Cung Cấp:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProvider);
            this.groupBox1.Location = new System.Drawing.Point(12, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(940, 274);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Nhà Cung Cấp";
            // 
            // fProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 481);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fProvider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fProvider";
            this.Load += new System.EventHandler(this.fProvider_Load);
            this.pButton.ResumeLayout(false);
            this.pButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pButton;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnSearchProvider;
        private System.Windows.Forms.Button btnUpdateProvider;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefreshText;
        private System.Windows.Forms.Button btnAddProvider;
        private System.Windows.Forms.Button btnDeleteProvider;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvProvider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtProviderName;
        private System.Windows.Forms.TextBox txtIDProvider;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProviderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}