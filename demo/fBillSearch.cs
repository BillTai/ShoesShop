using ClosedXML.Excel;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using Excel = Microsoft.Office.Interop.Excel;

namespace demo
{
    public partial class fBillSearch : Form
    {
        public fBillSearch()
        {
            InitializeComponent();
        }
        private void fBillDetail_Load(object sender, EventArgs e)
        {
            cboStatus.SelectedIndex = 0;
            ShowBill();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            cbBillType.SelectedIndex=0;
        }
        Connect ConnectSQL = new Connect();
        DataTable Bill = new DataTable(); DataTable BillDetail = new DataTable();

        void ConnectSql(string query, DataGridView dgv)
        {
            Bill = ConnectSQL.ExcuteQuery(query);
            dgv.DataSource = Bill;
        }
        // Danh sách sản phẩm
        void ShowBill()
        {
            String query = "select IDBill,Date,IDCustomer,IDStaff,TypeBill from Bill ";
            ConnectSql(query, dgvBill);

        }
        //tìm kiếm hóa đơn
        void SearhBillwithDay()
        {
            string temps = "";
            if (cboStatus.Text == "Đã Hủy")
                temps = "0";
            if (cboStatus.Text == "Đã Bán")
                temps = "1";
            String query = "";
            if(cboStatus.Text!= "Tất Cả")
            {
                if (cbBillType.Text== "Tất Cả")
                    query = "select IDBill,Date,IDCustomer,IDStaff,TypeBill from Bill where IDBill like '%" + txtSearch.Text + "%'and Date BETWEEN convert(date,'" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "',105) AND convert(date,'" + dateTimePicker2.Value.ToString("dd/MM/yyyy") + "',105) and Status="+ temps;
                else
                {
                    query = "select IDBill,Date,IDCustomer,IDStaff,TypeBill from Bill where IDBill like '%" + txtSearch.Text + "%'and TypeBill Like N'"+cbBillType.Text+"'and Date BETWEEN convert(date,'" + dateTimePicker1.Value.ToString("dd/MM/yyyy")+ "',105) AND convert(date,'"+dateTimePicker2.Value.ToString("dd/MM/yyyy")+ "',105) and Status=" + temps;
                }
            }
            else
            {
                if (cbBillType.Text == "Tất Cả")
                    query = "select IDBill,Date,IDCustomer,IDStaff,TypeBill from Bill where IDBill like '%" + txtSearch.Text + "%'and Date BETWEEN convert(date,'" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "',105) AND convert(date,'" + dateTimePicker2.Value.ToString("dd/MM/yyyy") + "',105) " ;
                else
                {
                    query = "select IDBill,Date,IDCustomer,IDStaff,TypeBill from Bill where IDBill like '%" + txtSearch.Text + "%'and TypeBill Like N'" + cbBillType.Text + "'and Date BETWEEN convert(date,'" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "',105) AND convert(date,'" + dateTimePicker2.Value.ToString("dd/MM/yyyy") + "',105)" ;
                }
            }

            Bill = ConnectSQL.ExcuteQuery(query);
            dgvBill.DataSource = Bill;
                      
        }

        string tempz = "";
        private void dgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string a = "";
            int vt = e.RowIndex;
            if (vt <= Bill.Rows.Count-1&& vt>=0)
            {
                a = Bill.Rows[vt][0].ToString();
                String query = @"select IDProductDetail,Number,Price,Discount,TotalPrice from BillDetail where IDBill =N'" + a + "'";
                BillDetail = ConnectSQL.ExcuteQuery(query);
                dgvBillDetail.DataSource = BillDetail;
                tempz= dgvBill.Rows[vt].Cells[0].Value.ToString(); ;
                txtTHD.Text = "Hóa Đơn Số : "+dgvBill.Rows[vt].Cells[0].Value.ToString();
                double tt = 0;
                for (int i = 0; i < dgvBillDetail.Rows.Count - 1; i++)
                {
                    tt +=Convert.ToDouble( this.dgvBillDetail.Rows[i].Cells[4].Value.ToString());
                    txtTotal.Text = tt.ToString();
                }
            }

        }
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            SearhBillwithDay();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Path.GetFullPath("Excel") + @"\";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (ExcelEngine excelEngine = new ExcelEngine())
                {
                    dgvBill.Sort(dgvBill.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
                    IApplication application = excelEngine.Excel;
                    IWorkbook workbook = application.Workbooks.Create(1);
                    IWorksheet worksheet = workbook.Worksheets[0];
                    worksheet.ImportDataGridView(dgvBill, 1, 1, isImportHeader: true, isImportStyle: true);
                    worksheet.UsedRange.AutofitColumns();
                    workbook.SaveAs(saveFileDialog1.FileName);
                    System.Diagnostics.Process.Start(saveFileDialog1.FileName);
                }
            }
            //using (SaveFileDialog excel = new SaveFileDialog { Filter = "Excel|*.xlsx" })
            //{
            //    if (excel.ShowDialog() == DialogResult.OK)
            //    {
            //        try
            //        {
            //            using (XLWorkbook workbook = new XLWorkbook())
            //            {

            //                    workbook.Worksheets.Add(Bill, "Product");

            //                workbook.SaveAs(excel.FileName);
            //            }
            //            MessageBox.Show("Xuất Thành Công.!");
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message);
            //        }
            //    }

            //}
        }
        DataTable Status1 = new DataTable();
        DataTable Status2 = new DataTable();
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (tempz != "")
            {
                string querytemp = "select Status from Bill where IDBill=N'" + tempz + "'";
                Status1 = ConnectSQL.ExcuteQuery(querytemp);
                int temp = Convert.ToInt32(Status1.Rows[0][0].ToString());
                if (temp == 1)
                {
                    string queryUpdate = "update Bill set Status=0 where IDBill=N'" + tempz + "'";
                    Status1 = ConnectSQL.ExcuteQuery(queryUpdate);
                    string querytest = "select Status from Bill where IDBill=N'" + tempz + "'";
                    Status2 = ConnectSQL.ExcuteQuery(querytest);
                    int temp2 = Convert.ToInt32(Status2.Rows[0][0].ToString());
                    if (temp2 == 0)
                    {
                        MessageBox.Show("xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        fBillSearch bills = new fBillSearch();
                        bills.Size = new Size(1000, 900);
                        bills.ShowDialog();
                        this.Close();
                    }
                }
                else MessageBox.Show("xóa không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }   
            else MessageBox.Show("Vui lòng chọn hóa đơn cần xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
