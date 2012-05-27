﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Hospital.Model;

namespace Hospital.View
{
    public partial class FormSurgicalDetail : Form
    {
        public Surgical surgicalDetail { get; set; }
        public String UserAction { get; set; }
        private static List<Staff> listStaff = new List<Staff>();
        private static List<SurgicalDetail> listSD = new List<SurgicalDetail>();
        public FormSurgicalDetail()
        {
            InitializeComponent();
        }
        public FormSurgicalDetail(int patientID)
        {
            InitializeComponent();
            SetSDForInsert(patientID);
        }
        private void SetSDForInsert(int patientID)
        {
            textBoxPatientID.Text = patientID.ToString();
            dateCreate.Value = DateTime.Today;
            comboBoxState.SelectedIndex = 0;
            comboBoxState.Enabled = false;

            DataTable dtStaff = Staff.GetListStaff();
            for (int i = 0; i < dtStaff.Rows.Count; i++)
            {
                String staffName = dtStaff.Rows[i][6].ToString() + " " + dtStaff.Rows[i][5].ToString();
                Staff newStaff = Staff.GetStaff(Convert.ToInt32(dtStaff.Rows[i][0]));
                listStaff.Add(newStaff);
                listBoxSystemStaff.Items.Add(staffName);
            }
            listBoxSystemStaff.SelectedIndex = 0;
        }

        private void buttonRemoveFunction_Click(object sender, EventArgs e)
        {
            if (listBoxCurrentStaff.SelectedIndex != -1)
            {
                int selectedStaff = listBoxCurrentStaff.SelectedIndex;
                listSD.RemoveAt(selectedStaff);
                listBoxCurrentStaff.Items.RemoveAt(selectedStaff);
                listBoxCurrentStaff.SelectedIndex = listBoxCurrentStaff.Items.Count - 1;
            }
        }

        private void buttonInsertFunction_Click(object sender, EventArgs e)
        {
            int selectedStaff = listBoxSystemStaff.SelectedIndex;
            if (CheckStaffInSurgical(listStaff[selectedStaff].StaffID))
            {
                MessageBox.Show("Nhân viên đã có trong danh sách tham gia ca phẩu thuật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SurgicalDetail newSD = new SurgicalDetail(0, listStaff[selectedStaff].StaffID);
                listSD.Add(newSD);
                listBoxCurrentStaff.Items.Add(listBoxSystemStaff.Items[selectedStaff].ToString());
                listBoxCurrentStaff.SelectedIndex = 0;
            }
        }
        private Boolean CheckStaffInSurgical(int staffID)
        {
            for (int i = 0; i < listSD.Count; i++)
            {
                if (staffID == listSD[i].StaffID)
                    return true;
            }
            return false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (!superValidator1.Validate())
                return;
            if (listBoxCurrentStaff.Items.Count > 0)
            {
                try
                {
                    if (this.UserAction == "edit")
                    {

                    }
                    else
                    {
                        Surgical newSurgical = new Surgical();
                        newSurgical.PatientID = Convert.ToInt32(textBoxPatientID.Text);
                        newSurgical.Date = dateCreate.Value;
                        newSurgical.State = comboBoxState.SelectedIndex;
                        newSurgical.Description = textBoxDescription.Text;
                        if (Surgical.InsertSurgical(newSurgical) > 0)
                        {
                            int curSurgicalID = Surgical.GetCurrentIdentity();
                            for (int i = 0; i < listSD.Count; i++)
                            {
                                listSD[i].SurgicalID = curSurgicalID;
                                SurgicalDetail.InsertSurgicalDetail(listSD[i]);
                            }
                            MessageBox.Show("Thêm ca phẩu thuật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                    }
                }
                catch (SqlException exception)
                {
                    MessageBox.Show(exception.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                listBoxCurrentStaff.Items.Clear();
                listBoxSystemStaff.Items.Clear();
                listSD.Clear();
                listStaff.Clear();
                this.Close();
            }
            else
            {
                MessageBox.Show("Chưa có nhân viên nào tham gia ca phẩu thuật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }

    }
}