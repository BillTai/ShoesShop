
namespace demo
{
    partial class fProductType
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtIDProductType = new System.Windows.Forms.TextBox();
            this.txtProductTypeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvProductType = new System.Windows.Forms.DataGridView();
            this.IDProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProductType = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProductType)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 420);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnReload);
            this.panel6.Controls.Add(this.btnDelete);
            this.panel6.Controls.Add(this.btnAdd);
            this.panel6.Controls.Add(this.btnRefresh);
            this.panel6.Controls.Add(this.btnExit);
            this.panel6.Controls.Add(this.btnUpdate);
            this.panel6.Location = new System.Drawing.Point(6, 130);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(281, 185);
            this.panel6.TabIndex = 4;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(15, 122);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(105, 23);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Tải Lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(149, 24);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(149, 73);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(101, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Nhập Lại";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(149, 122);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(15, 73);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbSearch);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Location = new System.Drawing.Point(6, 321);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(279, 94);
            this.panel3.TabIndex = 4;
            // 
            // cbSearch
            // 
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(13, 11);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(103, 21);
            this.cbSearch.TabIndex = 2;
            this.cbSearch.SelectedIndexChanged += new System.EventHandler(this.cbSearch_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(122, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(127, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(13, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(236, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtIDProductType);
            this.panel5.Controls.Add(this.txtProductTypeName);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(6, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(282, 110);
            this.panel5.TabIndex = 1;
            // 
            // txtIDProductType
            // 
            this.txtIDProductType.Location = new System.Drawing.Point(107, 15);
            this.txtIDProductType.MaxLength = 20;
            this.txtIDProductType.Name = "txtIDProductType";
            this.txtIDProductType.Size = new System.Drawing.Size(144, 20);
            this.txtIDProductType.TabIndex = 0;
            this.txtIDProductType.TextChanged += new System.EventHandler(this.txtIDProductType_TextChanged);
            this.txtIDProductType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDProductType_KeyPress);
            // 
            // txtProductTypeName
            // 
            this.txtProductTypeName.Location = new System.Drawing.Point(107, 55);
            this.txtProductTypeName.MaxLength = 20;
            this.txtProductTypeName.Name = "txtProductTypeName";
            this.txtProductTypeName.Size = new System.Drawing.Size(144, 20);
            this.txtProductTypeName.TabIndex = 1;
            this.txtProductTypeName.TextChanged += new System.EventHandler(this.txtProductTypeName_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Loại Sản Phẩm:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Loại Sản Phẩm:";
            // 
            // dgvProductType
            // 
            this.dgvProductType.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProductType,
            this.ProductTypeName});
            this.dgvProductType.Location = new System.Drawing.Point(6, 18);
            this.dgvProductType.Name = "dgvProductType";
            this.dgvProductType.ReadOnly = true;
            this.dgvProductType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductType.Size = new System.Drawing.Size(321, 411);
            this.dgvProductType.TabIndex = 0;
            this.dgvProductType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductType_CellClick);
            // 
            // IDProductType
            // 
            this.IDProductType.DataPropertyName = "IDProductType";
            this.IDProductType.HeaderText = "Mã Loại Sản Phẩm";
            this.IDProductType.Name = "IDProductType";
            this.IDProductType.ReadOnly = true;
            this.IDProductType.Width = 120;
            // 
            // ProductTypeName
            // 
            this.ProductTypeName.DataPropertyName = "ProductTypeName";
            this.ProductTypeName.HeaderText = "Tên Loại Sản Phẩm";
            this.ProductTypeName.Name = "ProductTypeName";
            this.ProductTypeName.ReadOnly = true;
            this.ProductTypeName.Width = 150;
            // 
            // errorProductType
            // 
            this.errorProductType.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProductType);
            this.groupBox1.Location = new System.Drawing.Point(307, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 436);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Loại Sản Phẩm";
            // 
            // fEditProductType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fEditProductType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fProductType";
            this.Load += new System.EventHandler(this.fEditProductType_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProductType)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtProductTypeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtIDProductType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DataGridView dgvProductType;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.ErrorProvider errorProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTypeName;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}