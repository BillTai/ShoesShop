
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
            this.dgvProvider = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.cbIDProductType = new System.Windows.Forms.ComboBox();
            this.cbIDProvider = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.txtPriceOut = new System.Windows.Forms.TextBox();
            this.txtPriceIn = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtIDProductDetail = new System.Windows.Forms.TextBox();
            this.txtIDProduct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pButton = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefreshText = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvider)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.pButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProvider
            // 
            this.dgvProvider.BackgroundColor = System.Drawing.Color.White;
            this.dgvProvider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvider.Location = new System.Drawing.Point(7, 216);
            this.dgvProvider.Name = "dgvProvider";
            this.dgvProvider.Size = new System.Drawing.Size(945, 253);
            this.dgvProvider.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nudNumber);
            this.panel1.Controls.Add(this.cbIDProductType);
            this.panel1.Controls.Add(this.cbIDProvider);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.txtPriceOut);
            this.panel1.Controls.Add(this.txtPriceIn);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.txtIDProductDetail);
            this.panel1.Controls.Add(this.txtIDProduct);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(7, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 175);
            this.panel1.TabIndex = 12;
            // 
            // nudNumber
            // 
            this.nudNumber.Location = new System.Drawing.Point(124, 78);
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(59, 20);
            this.nudNumber.TabIndex = 37;
            // 
            // cbIDProductType
            // 
            this.cbIDProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIDProductType.FormattingEnabled = true;
            this.cbIDProductType.Location = new System.Drawing.Point(374, 12);
            this.cbIDProductType.Name = "cbIDProductType";
            this.cbIDProductType.Size = new System.Drawing.Size(136, 21);
            this.cbIDProductType.TabIndex = 36;
            // 
            // cbIDProvider
            // 
            this.cbIDProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIDProvider.FormattingEnabled = true;
            this.cbIDProvider.Location = new System.Drawing.Point(375, 45);
            this.cbIDProvider.Name = "cbIDProvider";
            this.cbIDProvider.Size = new System.Drawing.Size(136, 21);
            this.cbIDProvider.TabIndex = 36;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(375, 80);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(136, 21);
            this.cbStatus.TabIndex = 36;
            // 
            // txtPriceOut
            // 
            this.txtPriceOut.Location = new System.Drawing.Point(124, 139);
            this.txtPriceOut.Name = "txtPriceOut";
            this.txtPriceOut.Size = new System.Drawing.Size(84, 20);
            this.txtPriceOut.TabIndex = 28;
            // 
            // txtPriceIn
            // 
            this.txtPriceIn.Location = new System.Drawing.Point(124, 113);
            this.txtPriceIn.Name = "txtPriceIn";
            this.txtPriceIn.Size = new System.Drawing.Size(84, 20);
            this.txtPriceIn.TabIndex = 30;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(124, 45);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(138, 20);
            this.txtProductName.TabIndex = 31;
            // 
            // txtIDProductDetail
            // 
            this.txtIDProductDetail.Location = new System.Drawing.Point(375, 108);
            this.txtIDProductDetail.Name = "txtIDProductDetail";
            this.txtIDProductDetail.Size = new System.Drawing.Size(136, 20);
            this.txtIDProductDetail.TabIndex = 33;
            // 
            // txtIDProduct
            // 
            this.txtIDProduct.Location = new System.Drawing.Point(126, 12);
            this.txtIDProduct.Name = "txtIDProduct";
            this.txtIDProduct.Size = new System.Drawing.Size(136, 20);
            this.txtIDProduct.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(269, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "IDProductDetail:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(268, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "ID ProductType:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(269, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Status";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "PriceIN:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(267, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "IDProvider:";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(19, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "ProductName:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(18, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "PriceOut:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Number:";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(19, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 24;
            this.label10.Text = "IDProduct:";
            // 
            // pButton
            // 
            this.pButton.Controls.Add(this.btnReload);
            this.pButton.Controls.Add(this.btnSearchProduct);
            this.pButton.Controls.Add(this.btnUpdateProduct);
            this.pButton.Controls.Add(this.btnExit);
            this.pButton.Controls.Add(this.btnRefreshText);
            this.pButton.Controls.Add(this.btnAddProduct);
            this.pButton.Controls.Add(this.btnDeleteProduct);
            this.pButton.Controls.Add(this.txtID);
            this.pButton.Controls.Add(this.label8);
            this.pButton.Location = new System.Drawing.Point(610, 33);
            this.pButton.Name = "pButton";
            this.pButton.Size = new System.Drawing.Size(319, 156);
            this.pButton.TabIndex = 11;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(108, 40);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 33;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(32, 107);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(263, 23);
            this.btnSearchProduct.TabIndex = 14;
            this.btnSearchProduct.Text = "Search";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(201, 11);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateProduct.TabIndex = 15;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(201, 40);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnRefreshText
            // 
            this.btnRefreshText.Location = new System.Drawing.Point(18, 39);
            this.btnRefreshText.Name = "btnRefreshText";
            this.btnRefreshText.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshText.TabIndex = 16;
            this.btnRefreshText.Text = "Refresh";
            this.btnRefreshText.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(18, 11);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 16;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(108, 11);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProduct.TabIndex = 17;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(140, 77);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(136, 20);
            this.txtID.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(33, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 24;
            this.label8.Text = "Value:";
            // 
            // fBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 481);
            this.Controls.Add(this.dgvProvider);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pButton);
            this.Name = "fBill";
            this.Text = "fBill";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.pButton.ResumeLayout(false);
            this.pButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProvider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.ComboBox cbIDProductType;
        private System.Windows.Forms.ComboBox cbIDProvider;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox txtPriceOut;
        private System.Windows.Forms.TextBox txtPriceIn;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtIDProductDetail;
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
        private System.Windows.Forms.Panel pButton;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefreshText;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
    }
}