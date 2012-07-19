using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hospital.Model;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hospital.View
{
    public partial class FormMain
    {
        private void buttonBillEdit_Click(object sender, EventArgs e)
        {
            if (dataViewBill.SelectedRows.Count > 0)
            {
                // Get bill for edit
                Bill billDetail = Bill.GetBill(Convert.ToInt32(dataViewBill.SelectedRows[0].Cells[0].Value.ToString()));

                // Open billdetail form for edit
                FormBillDetail billDetailForm = new FormBillDetail("edit", billDetail);
                billDetailForm.ShowDialog();

                // Refresh datagridview after edit
                refreshDataViewBill();
            }
        }

        private void buttonBillDeleteSearch_Click(object sender, EventArgs e)
        {
            textBoxBillSearch.Text = "";
        }

        private void refreshDataViewBill()
        {
            try
            {
                // Get Bill's datatable
                DataTable billTable = Bill.GetListBill();

                // Add Vietnamese column's name
                billTable.Columns.Add("Mã hóa đơn", typeof(string), "[BILLID]");
                billTable.Columns.Add("Loại hóa đơn", typeof(string), @"IIF([BILLTYPEID] = 100, 'Thuốc',
                                                                            IIF([BILLTYPEID] = 101, 'Dịch vụ', 'Đồ dùng'))");
                billTable.Columns.Add("Họ tên bệnh nhân", typeof(string), "[PATIENTLASTNAME] + ' ' + [PATIENTFIRSTNAME]");
                billTable.Columns.Add("Ngày lập", typeof(DateTime), "[DATE]");
                billTable.Columns.Add("Tổng tiền", typeof(decimal), "[TOTALPRICE]");
                billTable.Columns.Add("Trạng thái", typeof(string), "IIF([STATE] = 0, 'Chưa thanh toán', 'Đã thanh toán')");
                billTable.Columns.Add("Mã nhân viên", typeof(string), "[STAFFID]");
                billTable.Columns.Add("Họ tên nhân viên", typeof(string), "[STAFFLASTNAME] + ' ' + [STAFFFIRSTNAME]");
                billTable.Columns.Add("Mã bệnh nhân", typeof(string), "[PATIENTID]");

                // Set data source to dataview for searching
                dataViewBill.DataSource = billTable.DefaultView;

                //Hide English columns'name
                for (int i = 0; i < 12; i++)
                {
                    dataViewBill.Columns[i].Visible = false;
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxBillSearch_TextChanged(object sender, EventArgs e)
        {
            searchBill();
        }

        private void textBoxBillSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBill();
            }
        }

        private void searchBill()
        {
            // Not search it search string is empty
            if (textBoxBillSearch.Text != "")
            {
                // Search with RowFilter
                ((DataView)dataViewBill.DataSource).RowFilter = "[Họ tên bệnh nhân] LIKE '*" + textBoxBillSearch.Text.Trim() + "*'"
                                                                + "OR [Mã bệnh nhân] LIKE '*" + textBoxBillSearch.Text.Trim() + "*'"
                                                                + "OR [Họ tên nhân viên] LIKE '*" + textBoxBillSearch.Text.Trim() + "*'"
                                                                + "OR [Mã nhân viên] LIKE '*" + textBoxBillSearch.Text.Trim() + "*'";
            }
            else
            {
                ((DataView)dataViewBill.DataSource).RowFilter = "";
            }
        }

        private void buttonBILLPrint_Click(object sender, EventArgs e)
        {
            if (dataViewBill.SelectedRows.Count > 0)
            {
                // Get bill for print
                Bill billDetail = Bill.GetBill(Convert.ToInt32(dataViewBill.SelectedRows[0].Cells[0].Value.ToString()));

                FormReport reportForm = new FormReport();

                switch (billDetail.BillTypeID)
                {
                    case Bill.MEDICINEBILL:
                        reportForm.ReportType = "MEDICINEBILL";
                        reportForm.ObjectID = billDetail.BillID;
                        break;
                    case Bill.SERVICEBILL:
                        reportForm.ReportType = "SERVICEBILL";
                        reportForm.ObjectID = billDetail.BillID;
                        break;
                    case Bill.MATERIALBILL:
                        reportForm.ReportType = "MATERIALBILL";
                        reportForm.ObjectID = billDetail.BillID;
                        break;
                    default:
                        MessageBox.Show("Vui lòng chọn hóa đơn để in!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                reportForm.Show();

            }
        }
    }
}
