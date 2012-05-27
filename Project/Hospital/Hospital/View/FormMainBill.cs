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
        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void refreshDataViewBill()
        {
            try
            {
                // Get Staff's datatable
                DataTable billTable = Bill.GetListBill();

                // Add Vietnamese column's name
                billTable.Columns.Add("Mã hóa đơn", typeof(string), "[BILLID]");
                billTable.Columns.Add("Loại hóa đơn", typeof(string), "[BILLTYPEID]");
                billTable.Columns.Add("Bệnh nhân", typeof(string), "[PATIENTID]");
                billTable.Columns.Add("Nhân viên", typeof(string), "[STAFFID]");
                billTable.Columns.Add("Ngày lập", typeof(DateTime), "[DATE]");
                billTable.Columns.Add("Tỏng tiền", typeof(decimal), "[TOTALPRICE]");
                billTable.Columns.Add("Trạng thái", typeof(string), "IIF([STATE] = 0, 'Chưa thanh toán', 'Đã thanh toán')");

                // Set data source to dataview for searching
                dataViewBill.DataSource = billTable.DefaultView;

                //Hide English columns'name
                for (int i = 0; i < 7; i++)
                {
                    dataViewBill.Columns[i].Visible = false;
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
