using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Hospital.Model;
using System.Globalization;

namespace Hospital.View
{
    public partial class FormBillDetail : Form
    {
        public Bill BillDetail { get; set; }
        public Staff StaffDetail { get; set; }
        public Patient PatientDetail { get; set; }
        public string UserAction { get; set; }

        private DataTable BillMedicineTable { get; set; }
        private DataTable BillServiceTable { get; set; }
        private DataTable BillMaterialTable { get; set; }

        private FormBillDetail()
        {
            InitializeComponent();
        }

        public FormBillDetail(string userAction, Bill bill)
        {
            InitializeComponent();

            // Set useraction and bill            
            this.BillDetail = bill;
            this.UserAction = userAction;
            this.StaffDetail = Staff.GetStaff(BillDetail.StaffID);
            this.PatientDetail = Patient.GetPatient(BillDetail.PatientID);

            reFreshForm();
        }

        public FormBillDetail(string userAction, Bill bill, Staff staff, Patient patient)
        {
            InitializeComponent();

            // Set useraction and bill
            this.BillDetail = bill;
            this.UserAction = userAction;
            this.StaffDetail = staff;
            this.PatientDetail = patient;

            reFreshForm();
        }

        // Set information to form
        private void reFreshForm()
        {
            try
            {
                // Set bill information
                textBoxPatientID.Text = PatientDetail.PatientID.ToString();
                textBoxPatientName.Text = PatientDetail.LastName + ' ' + PatientDetail.FirstName;
                textBoxStaffID.Text = StaffDetail.StaffID.ToString();
                textBoxStaffName.Text = StaffDetail.LastName + ' ' + StaffDetail.FirstName;

                // Set comboBoxDetail corresponding to bill's type
                switch (BillDetail.BillTypeID)
                {
                    case Bill.MEDICINEBILL:
                        labelDetail.Text = "Tên thuốc:";

                        // Get Medicine list and set it to comboBox
                        comboBoxDetail.DataSource = Medicine.GetListMedicine();
                        comboBoxDetail.ValueMember = "PRICE";
                        comboBoxDetail.DisplayMember = "MEDICINENAME";
                        break;
                    case Bill.SERVICEBILL:
                        labelDetail.Text = "Dịch vụ:";

                        // Get Service list and set it to comboBox
                        comboBoxDetail.DataSource = Service.GetListService();
                        comboBoxDetail.ValueMember = "PRICE";
                        comboBoxDetail.DisplayMember = "SERVICENAME";
                        break;
                    case Bill.MATERIALBILL:
                        labelDetail.Text = "Đồ dùng:";

                        // Get Material list and set it to comboBox
                        comboBoxDetail.DataSource = Material.GetListMaterial();
                        comboBoxDetail.ValueMember = "PRICE";
                        comboBoxDetail.DisplayMember = "SERVICENAME";
                        break;
                }

                // If bill was pay then do nothing
                if (BillDetail.State == Bill.PAY)
                {
                    buttonAdd.Enabled = false;
                    buttonDelete.Enabled = false;
                    buttonPay.Enabled = false;
                    buttonSave.Enabled = false;
                    dateTimeInputBill.Enabled = false;
                    labelTotalBillPrice.ForeColor = Color.Green;
                    labelBillState.ForeColor = Color.Green;
                    labelBillState.Text = "Đã thanh toán";
                }


                // Set information when user edit bill's detail
                if ("edit".Equals(UserAction))
                {
                    // Set billID
                    textBoxBillID.Text = BillDetail.BillID.ToString();
                    // When update bill, user can only update bill's state
                    buttonAdd.Enabled = false;
                    buttonDelete.Enabled = false;
                    buttonPay.Enabled = false;
                    buttonSave.Enabled = false;
                    dateTimeInputBill.Enabled = false;

                    //BillDetail = Bill.GetBill(BillDetail.BillID);

                    labelTotalBillPrice.Text = BillDetail.TotalPrice.ToString("C", CultureInfo.CreateSpecificCulture("vi"));

                    // Set dataViewBillDetail corresponding bill's type
                    switch (BillDetail.BillTypeID)
                    {
                        case Bill.MEDICINEBILL:
                            BillMedicineTable = MedicineBillDetail.GetListMedicineBillDetail(BillDetail.BillID);

                            BillMedicineTable.Columns.Add("Thuốc", typeof(string), "[MEDICINENAME]");
                            BillMedicineTable.Columns.Add("Số lượng", typeof(int), "[QUANTITY]");
                            BillMedicineTable.Columns.Add("Giá", typeof(decimal), "[PRICE]");

                            dataViewBillDetail.DataSource = BillMedicineTable;
                            break;
                        case Bill.SERVICEBILL:
                            BillServiceTable = ServiceBillDetail.GetListServiceBillDetail(BillDetail.BillID);

                            BillServiceTable.Columns.Add("Dịch vụ", typeof(string), "[SERVICENAME]");
                            BillServiceTable.Columns.Add("Số lượng", typeof(int), "[QUANTITY]");
                            BillServiceTable.Columns.Add("Giá", typeof(decimal), "[PRICE]");

                            dataViewBillDetail.DataSource = BillServiceTable;
                            break;
                        case Bill.MATERIALBILL:
                            BillMaterialTable = RentMaterialBillDetail.GetListRentMaterialBillDetail(BillDetail.BillID);

                            BillMaterialTable.Columns.Add("Đồ dùng", typeof(string), "[MATERIALNAME]");
                            BillMaterialTable.Columns.Add("Số lượng", typeof(int), "[QUANTITY]");
                            BillMaterialTable.Columns.Add("Giá", typeof(decimal), "[PRICE]");

                            dataViewBillDetail.DataSource = BillMaterialTable;
                            break;
                    }
                }
                else if ("insert".Equals(UserAction))       /// Set information when user insert bill's detail
                {
                    // Generate next billID
                    textBoxBillID.Text = Bill.GetNextBillID().ToString();
                    dateTimeInputBill.Value = DateTime.Now;

                    BillDetail.BillID = Bill.GetNextBillID();
                    BillDetail.Date = dateTimeInputBill.Value;
                    BillDetail.TotalPrice = 0;
                    BillDetail.State = 0;

                    switch (BillDetail.BillTypeID)
                    {
                        case Bill.MEDICINEBILL:
                            BillMedicineTable = new DataTable();

                            BillMedicineTable.Columns.Add("MEDICINEID", typeof(int));
                            BillMedicineTable.Columns.Add("Thuốc", typeof(string));
                            BillMedicineTable.Columns.Add("Số lượng", typeof(int));
                            BillMedicineTable.Columns.Add("Giá", typeof(decimal));

                            dataViewBillDetail.DataSource = BillMedicineTable;
                            dataViewBillDetail.Columns["MEDICINEID"].Visible = false;

                            break;

                        case Bill.SERVICEBILL:
                            break;
                        case Bill.MATERIALBILL:
                            break;
                    }

                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void comboBoxDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (BillDetail.BillTypeID)
            {
                case Bill.MEDICINEBILL:
                    decimal medicinePrice = Convert.ToDecimal(((DataRowView)comboBoxDetail.SelectedItem).Row["PRICE"]);
                    labelPriceDetail.Text = medicinePrice.ToString("C", CultureInfo.CreateSpecificCulture("vi"));
                    break;
                case Bill.SERVICEBILL:
                    decimal servicePrice = Convert.ToDecimal(((DataRowView)comboBoxDetail.SelectedItem).Row["PRICE"]);
                    labelPriceDetail.Text = servicePrice.ToString("C", CultureInfo.CreateSpecificCulture("vi"));
                    break;
                case Bill.MATERIALBILL:
                    decimal materialPrice = Convert.ToDecimal(((DataRowView)comboBoxDetail.SelectedItem).Row["PRICE"]);
                    labelPriceDetail.Text = materialPrice.ToString("C", CultureInfo.CreateSpecificCulture("vi"));
                    break;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            decimal totalPrice = new Decimal();
            // Check validate
            if (!superValidator1.Validate())
            {
                return;
            }

            // Add bill detail corresponding to bill's type
            switch (BillDetail.BillTypeID)
            {
                // Add medicine detail
                case Bill.MEDICINEBILL:
                    int medicineID = Convert.ToInt32(((DataRowView)comboBoxDetail.SelectedItem).Row["MEDICINEID"]);
                    string medicineName = ((DataRowView)comboBoxDetail.SelectedItem).Row["MEDICINENAME"].ToString();
                    int quantity = Convert.ToInt32(textBoxQuantity.Text);
                    decimal price = Convert.ToDecimal(((DataRowView)comboBoxDetail.SelectedItem).Row["PRICE"]) * quantity;


                    BillMedicineTable.Rows.Add(new object[] { medicineID, medicineName, quantity, price });

                    foreach (DataRow record in ((DataTable)dataViewBillDetail.DataSource).Rows)
                    {
                        totalPrice += Convert.ToDecimal(record["Giá"]);
                    }

                    BillDetail.TotalPrice = totalPrice;
                    labelTotalBillPrice.Text = totalPrice.ToString("C", CultureInfo.CreateSpecificCulture("vi"));

                    break;
                // Add service detail
                case Bill.SERVICEBILL:

                    break;
                case Bill.MATERIALBILL:

                    break;
            }
        }

        // Delete bill detail
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataViewBillDetail.SelectedRows.Count > 0)
            {
                dataViewBillDetail.Rows.Remove(dataViewBillDetail.SelectedRows[0]);
            }
        }

        // Accept payment
        private void buttonPay_Click(object sender, EventArgs e)
        {

            try
            {
                // Ask user to accpet payment
                if (MessageBox.Show("Xác nhận thanh toán?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                            == DialogResult.Yes)
                {
                    if ("insert".Equals(UserAction))
                    {
                        switch (BillDetail.BillTypeID)
                        {
                            case Bill.MEDICINEBILL:

                                MedicineBillDetail newMedicineBillDetail = new MedicineBillDetail();

                                if (dataViewBillDetail.Rows.Count <= 0)
                                {
                                    MessageBox.Show("Thêm chi tiết hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                BillDetail.State = Bill.PAY;
                                Bill.InsertBill(BillDetail);

                                foreach (DataRow record in ((DataTable)dataViewBillDetail.DataSource).Rows)
                                {
                                    newMedicineBillDetail.BillID = BillDetail.BillID;
                                    newMedicineBillDetail.MedicineID = Convert.ToInt32(record["MEDICINEID"]);
                                    newMedicineBillDetail.Quantity = Convert.ToInt32(record["Số lượng"]);
                                    newMedicineBillDetail.Price = Convert.ToDecimal(record["Giá"]);

                                    MedicineBillDetail.InsertMedicineBillDetail(newMedicineBillDetail);
                                }
                                break;
                            case Bill.SERVICEBILL:
                                break;
                            case Bill.MATERIALBILL:
                                break;
                        }
                    }
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        // Close this form when click buttonClose
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Bill.InsertBill(BillDetail);
        }
    }
}
