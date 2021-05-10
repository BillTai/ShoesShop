
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.pValues = new System.Windows.Forms.Panel();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.From = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProductDetail = new System.Windows.Forms.DataGridView();
            this.IDProductDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIDProductDetail = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.pValues.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetail)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(161, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(157, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbSearch);
            this.panel3.Controls.Add(this.pValues);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Location = new System.Drawing.Point(7, 309);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(334, 165);
            this.panel3.TabIndex = 4;
            // 
            // cbSearch
            // 
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(16, 25);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(118, 21);
            this.cbSearch.TabIndex = 37;
            this.cbSearch.SelectedIndexChanged += new System.EventHandler(this.cbSearch_SelectedIndexChanged);
            // 
            // pValues
            // 
            this.pValues.Controls.Add(this.txtTo);
            this.pValues.Controls.Add(this.label11);
            this.pValues.Controls.Add(this.txtFrom);
            this.pValues.Controls.Add(this.From);
            this.pValues.Location = new System.Drawing.Point(16, 72);
            this.pValues.Name = "pValues";
            this.pValues.Size = new System.Drawing.Size(302, 30);
            this.pValues.TabIndex = 36;
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
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(73, 126);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(176, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(355, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 492);
            this.panel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProductDetail);
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 484);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Chi Tiết Sản Phẩm";
            // 
            // dgvProductDetail
            // 
            this.dgvProductDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProductDetail,
            this.Size,
            this.Color});
            this.dgvProductDetail.GridColor = System.Drawing.Color.White;
            this.dgvProductDetail.Location = new System.Drawing.Point(6, 16);
            this.dgvProductDetail.Name = "dgvProductDetail";
            this.dgvProductDetail.ReadOnly = true;
            this.dgvProductDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductDetail.Size = new System.Drawing.Size(447, 458);
            this.dgvProductDetail.TabIndex = 0;
            this.dgvProductDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductDetail_CellClick);
            // 
            // IDProductDetail
            // 
            this.IDProductDetail.DataPropertyName = "IDProductDetail";
            this.IDProductDetail.HeaderText = "Mã Chi Tiết Sản Phẩm";
            this.IDProductDetail.Name = "IDProductDetail";
            this.IDProductDetail.ReadOnly = true;
            this.IDProductDetail.Width = 160;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Size";
            this.Size.HeaderText = "Kích Thước";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            this.Size.Width = 140;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Màu Sắc";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // txtIDProductDetail
            // 
            this.txtIDProductDetail.Location = new System.Drawing.Point(161, 13);
            this.txtIDProductDetail.Name = "txtIDProductDetail";
            this.txtIDProductDetail.Size = new System.Drawing.Size(144, 20);
            this.txtIDProductDetail.TabIndex = 1;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(161, 53);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(144, 20);
            this.txtSize.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kích Thước:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(14, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Chi Tiết Sản Phẩm:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtIDProductDetail);
            this.panel5.Controls.Add(this.txtColor);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtSize);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(7, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(334, 132);
            this.panel5.TabIndex = 1;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(162, 90);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(144, 20);
            this.txtColor.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(14, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Màu Sắc:";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(46, 120);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(118, 23);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(180, 22);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(46, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(180, 71);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(114, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(180, 120);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(46, 71);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Updete";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnReload);
            this.panel6.Controls.Add(this.btnDelete);
            this.panel6.Controls.Add(this.btnAdd);
            this.panel6.Controls.Add(this.btnRefresh);
            this.panel6.Controls.Add(this.btnExit);
            this.panel6.Controls.Add(this.btnUpdate);
            this.panel6.Location = new System.Drawing.Point(7, 141);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(334, 162);
            this.panel6.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(5, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 487);
            this.panel1.TabIndex = 2;
            // 
            // fProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fProductDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "fProductDetail";
            this.Load += new System.EventHandler(this.fProductDetail_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pValues.ResumeLayout(false);
            this.pValues.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetail)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtIDProductDetail;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProductDetail;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Panel pValues;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProductDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
    }
}