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
        public int PrescriptionID { get; set; }
        public int HICID { get; set; }

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

        public FormBillDetail(string userAction, Bill bill, int prescriptionID)
        {
            InitializeComponent();

            // Set useraction and bill            
            this.BillDetail = bill;
            this.UserAction = userAction;
            this.StaffDetail = Staff.GetStaff(BillDetail.StaffID);
            this.PatientDetail = Patient.GetPatient(BillDetail.PatientID);
            this.PrescriptionID = prescriptionID;

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

                //Check HIC
                if (HIC.CheckHIC(BillDetail.PatientID))
                {
                    HIC newHIC = HIC.GetPatientHIC(BillDetail.PatientID);
                    if (HIC.CheckHICExpiration(newHIC.HICID))
                    {
                        labelHICID.Text = "Đã hết hạn";
                        this.HICID = 0;
                    }
                    else
                    {
                        labelHICID.Text = "Còn hạn sử dụng";
                        this.HICID = newHIC.HICID;
                    }
                }
                else
                {
                    labelHICID.Text = "Không có";
                    this.HICID = 0;
                }

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
                        comboBoxDetail.DisplayMember = "MATERIALNAME";
                        labelHIC.Visible = false;
                        labelHICID.Visible = false;
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
                    dateTimeInputBill.Value = BillDetail.Date;
                    // When update bill, user can only update bill's state
                    buttonAdd.Enabled = false;
                    buttonDelete.Enabled = false;
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

                            for (int i = 0; i < 3; i++)
                            {
                                dataViewBillDetail.Columns[i].Visible = false;
                            }

                            break;
                        case Bill.SERVICEBILL:
                            BillServiceTable = ServiceBillDetail.GetListServiceBillDetail(BillDetail.BillID);

                            BillServiceTable.Columns.Add("Dịch vụ", typeof(string), "[SERVICENAME]");
                            BillServiceTable.Columns.Add("Số lượng", typeof(int), "[QUANTITY]");
                            BillServiceTable.Columns.Add("Giá", typeof(decimal), "[PRICE]");

                            dataViewBillDetail.DataSource = BillServiceTable;

                            for (int i = 0; i < 3; i++)
                            {
                                dataViewBillDetail.Columns[i].Visible = false;
                            }

                            break;
                        case Bill.MATERIALBILL:
                            BillMaterialTable = RentMaterialBillDetail.GetListRentMaterialBillDetail(BillDetail.BillID);

                            BillMaterialTable.Columns.Add("Đồ dùng", typeof(string), "[MATERIALNAME]");
                            BillMaterialTable.Columns.Add("Số lượng", typeof(int), "[QUANTITY]");
                            BillMaterialTable.Columns.Add("Giá", typeof(decimal), "[PRICE]");

                            dataViewBillDetail.DataSource = BillMaterialTable;

                            for (int i = 0; i < 3; i++)
                            {
                                dataViewBillDetail.Columns[i].Visible = false;
                            }

                            break;
                    }
                }
                else if ("insert".Equals(UserAction))       /// Set information when user insert bill's detail
                {
                    // Generate next billID
                    textBoxBillID.Text = Bill.GetNextBillID().ToString();
                    dateTimeInputBill.Value = DateTime.Today;
                    labelTotalBillPrice.Text = 0.ToString("C", CultureInfo.CreateSpecificCulture("vi"));

                    BillDetail.BillID = Bill.GetNextBillID();
                    BillDetail.Date = dateTimeInputBill.Value;
                    BillDetail.TotalPrice = 0;
                    BillDetail.State = 0;

                    switch (BillDetail.BillTypeID)
                    {
                        case Bill.MEDICINEBILL:
                            buttonAdd.Enabled = false;
                            buttonDelete.Enabled = false;
                            decimal totalPrice = new Decimal();

                            BillMedicineTable = PrescriptionDetail.GetListPrescriptionDetailWithMedicine(PrescriptionID);

                            BillMedicineTable.Columns.Add("Thuốc", typeof(string), "[MEDICINENAME]");
                            BillMedicineTable.Columns.Add("Số lượng", typeof(int), "[QUANTITY]");
                            BillMedicineTable.Columns.Add("Giá", typeof(decimal), "[PRICE]");

                            dataViewBillDetail.DataSource = BillMedicineTable;

                            for (int i = 0; i < 4; i++)
                            {
                                dataViewBillDetail.Columns[i].Visible = false;
                            }

                            foreach (DataRow row in BillMedicineTable.Rows)
                            {
                                totalPrice += (decimal)row["Giá"];
                            }
                            if (HICID != 0)
                            {
                                totalPrice = totalPrice/4;
                            }
                            BillDetail.TotalPrice = totalPrice;
                            labelTotalBillPrice.Text = totalPrice.ToString("C", CultureInfo.CreateSpecificCulture("vi"));

                            break;

                        case Bill.SERVICEBILL:
                            BillServiceTable = new DataTable();

                            BillServiceTable.Columns.Add("SERVICEID", typeof(int));
                            BillServiceTable.Columns.Add("Dịch vụ", typeof(string));
                            BillServiceTable.Columns.Add("Số lượng", typeof(int));
                            BillServiceTable.Columns.Add("Giá", typeof(decimal));

                            dataViewBillDetail.DataSource = BillServiceTable;
                            dataViewBillDetail.Columns["SERVICEID"].Visible = false;
                            break;
                        case Bill.MATERIALBILL:
                            BillMaterialTable = new DataTable();

                            BillMaterialTable.Columns.Add("MATERIALID", typeof(int));
                            BillMaterialTable.Columns.Add("Đồ dùng", typeof(string));
                            BillMaterialTable.Columns.Add("Số lượng", typeof(int));
                            BillMaterialTable.Columns.Add("Giá", typeof(decimal));

                            dataViewBillDetail.DataSource = BillMaterialTable;
                            dataViewBillDetail.Columns["MATERIALID"].Visible = false;
                            break;
                    }
                }
                else
                {
                    switch (UserAction)
                    {
                        case "insertExamination":
                            // Only save and pay when create examination
                            buttonAdd.Enabled = false;
                            buttonDelete.Enabled = false;
                            
                            // Set new bill detail for examination
                            BillDetail.BillID = Bill.GetNextBillID();
                            BillDetail.Date = DateTime.Now;
                            BillDetail.TotalPrice = 30000;
                            BillDetail.State = 0;

                            // Set form information
                            textBoxBillID.Text = Bill.GetNextBillID().ToString();
                            dateTimeInputBill.Value = BillDetail.Date;
                            labelTotalBillPrice.Text = BillDetail.TotalPrice.ToString("C", CultureInfo.CreateSpecificCulture("vi"));

                            // Create table for datagridview
                            BillServiceTable = new DataTable();

                            BillServiceTable.Columns.Add("SERVICEID", typeof(int));
                            BillServiceTable.Columns.Add("Dịch vụ", typeof(string));
                            BillServiceTable.Columns.Add("Số lượng", typeof(int));
                            BillServiceTable.Columns.Add("Giá", typeof(decimal));

                            dataViewBillDetail.DataSource = BillServiceTable;
                            dataViewBillDetail.Columns["SERVICEID"].Visible = false;

                            BillServiceTable.Rows.Add(new object[] { 100, "Khám bệnh", 1, 30000 });

                            break;
                        case "insertTest":
                            break;
                        case "insertSurgery":
                            break;
                    }

                    UserAction = "insert";
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
            bool isDulicate = false;
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
                    //int medicineID = Convert.ToInt32(((DataRowView)comboBoxDetail.SelectedItem).Row["MEDICINEID"]);
                    //string medicineName = ((DataRowView)comboBoxDetail.SelectedItem).Row["MEDICINENAME"].ToString();
                    //int quantityMedicine = Convert.ToInt32(textBoxQuantity.Text);
                    //decimal priceMedicine = Convert.ToDecimal(((DataRowView)comboBoxDetail.SelectedItem).Row["PRICE"]) * quantityMedicine;

                    //BillMedicineTable.Rows.Add(new object[] { medicineID, medicineName, quantityMedicine, priceMedicine });

                    break;

                // Add service detail
                case Bill.SERVICEBILL:

                    int serviceID = Convert.ToInt32(((DataRowView)comboBoxDetail.SelectedItem).Row["SERVICEID"]);
                    string serviceName = ((DataRowView)comboBoxDetail.SelectedItem).Row["SERVICENAME"].ToString();
                    int quantityService = Convert.ToInt32(textBoxQuantity.Text);
                    decimal priceService = Convert.ToDecimal(((DataRowView)comboBoxDetail.SelectedItem).Row["PRICE"]) * quantityService;

                    foreach (DataRow row in BillServiceTable.Rows)
                    {
                        if (row["SERVICEID"].ToString().Trim().Equals(
                            ((DataRowView)comboBoxDetail.SelectedItem).Row["SERVICEID"].ToString().Trim()))
                        {
                            isDulicate = true;
                            row["Số lượng"] = quantityService + (int)row["Số lượng"];
                            row["Giá"] = priceService + (decimal)row["Giá"];
                        }
                    }

                    if (!isDulicate)
                    {
                        BillServiceTable.Rows.Add(new object[] { serviceID, serviceName, quantityService, priceService });
                        isDulicate = false;
                    }

                    break;

                case Bill.MATERIALBILL:
                    int materialID = Convert.ToInt32(((DataRowView)comboBoxDetail.SelectedItem).Row["MATERIALID"]);
                    string materialName = ((DataRowView)comboBoxDetail.SelectedItem).Row["MATERIALNAME"].ToString();
                    int quantityMaterial = Convert.ToInt32(textBoxQuantity.Text);
                    decimal priceMaterial = Convert.ToDecimal(((DataRowView)comboBoxDetail.SelectedItem).Row["PRICE"]) * quantityMaterial;

                    foreach (DataRow row in BillMaterialTable.Rows)
                    {
                        if (row["MATERIALID"].ToString().Trim().Equals(
                            ((DataRowView)comboBoxDetail.SelectedItem).Row["MATERIALID"].ToString().Trim()))
                        {
                            isDulicate = true;
                            row["Số lượng"] = quantityMaterial + (int)row["Số lượng"];
                            row["Giá"] = priceMaterial + (decimal)row["Giá"];
                        }
                    }

                    if (!isDulicate)
                    {
                        BillMaterialTable.Rows.Add(new object[] { materialID, materialName, quantityMaterial, priceMaterial });
                        isDulicate = false;
                    }

                    break;
            }

            foreach (DataRow record in ((DataTable)dataViewBillDetail.DataSource).Rows)
            {
                totalPrice += Convert.ToDecimal(record["Giá"]);
            }
            if (HICID != 0)
            {
                totalPrice = totalPrice / 4;
            }
            BillDetail.TotalPrice = totalPrice;
            labelTotalBillPrice.Text = totalPrice.ToString("C", CultureInfo.CreateSpecificCulture("vi"));
        }

        // Delete bill detail
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            decimal totalPrice = new Decimal();

            if (dataViewBillDetail.SelectedRows.Count > 0)
            {
                dataViewBillDetail.Rows.Remove(dataViewBillDetail.SelectedRows[0]);

                switch (BillDetail.BillTypeID)
                {
                    case Bill.MEDICINEBILL:
                        foreach (DataRow row in BillMedicineTable.Rows)
                        {
                            totalPrice += (decimal)row["Giá"];
                        }
                        break;
                    case Bill.SERVICEBILL:
                        foreach (DataRow row in BillServiceTable.Rows)
                        {
                            totalPrice += (decimal)row["Giá"];
                        }
                        break;
                    case Bill.MATERIALBILL:
                        foreach (DataRow row in BillMaterialTable.Rows)
                        {
                            totalPrice += (decimal)row["Giá"];
                        }
                        break;
                }
                if (HICID != 0)
                {
                    totalPrice = totalPrice / 4;
                }
                labelTotalBillPrice.Text = totalPrice.ToString("C", CultureInfo.CreateSpecificCulture("vi"));
            }
        }

        // Accept payment
        private void buttonPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataViewBillDetail.Rows.Count <= 0)
                {
                    MessageBox.Show("Thêm chi tiết hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ask user to accpet payment
                if (MessageBox.Show("Xác nhận thanh toán?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
                            == DialogResult.Yes)
                {
                    if ("insert".Equals(UserAction))
                    {

                        BillDetail.State = Bill.PAY;
                        Bill.InsertBill(BillDetail);

                        insertBillDetail();

                    }
                    else if ("edit".Equals(UserAction))
                    {
                        BillDetail.State = Bill.PAY;
                        Bill.UpdateBill(BillDetail);
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

        // Save bill's information for payment
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataViewBillDetail.Rows.Count <= 0)
                {
                    MessageBox.Show("Thêm chi tiết hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Lưu hóa đơn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
                            == DialogResult.Yes)
                {
                    Bill.InsertBill(BillDetail);
                    insertBillDetail();
                    this.Close();
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Insert bill detail after insert bill
        private void insertBillDetail()
        {
            switch (BillDetail.BillTypeID)
            {
                case Bill.MEDICINEBILL:

                    MedicineBillDetail newMedicineBillDetail = new MedicineBillDetail();

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

                    ServiceBillDetail newServiceBillDetail = new ServiceBillDetail();

                    foreach (DataRow record in ((DataTable)dataViewBillDetail.DataSource).Rows)
                    {
                        newServiceBillDetail.BillID = BillDetail.BillID;
                        newServiceBillDetail.ServiceID = Convert.ToInt32(record["SERVICEID"]);
                        newServiceBillDetail.Quantity = Convert.ToInt32(record["Số lượng"]);
                        newServiceBillDetail.Price = Convert.ToDecimal(record["Giá"]);

                        ServiceBillDetail.InsertServiceBillDetail(newServiceBillDetail);
                    }
                    break;
                case Bill.MATERIALBILL:

                    RentMaterialBillDetail newRentMaterialBillDetail = new RentMaterialBillDetail();

                    foreach (DataRow record in ((DataTable)dataViewBillDetail.DataSource).Rows)
                    {
                        newRentMaterialBillDetail.BillID = BillDetail.BillID;
                        newRentMaterialBillDetail.MaterialID = Convert.ToInt32(record["MATERIALID"]);
                        newRentMaterialBillDetail.Quantity = Convert.ToInt32(record["Số lượng"]);
                        newRentMaterialBillDetail.Price = Convert.ToDecimal(record["Giá"]);

                        RentMaterialBillDetail.InsertRentMaterialBillDetail(newRentMaterialBillDetail);
                    }
                    break;
            }
        }


    }
}
