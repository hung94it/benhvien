using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hospital.Model;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Hospital.View
{
    public partial class FormMain
    {
        private void buttonAccount_Click(object sender, EventArgs e)
        {
            FormStaffDetail formSD = new FormStaffDetail("personalEdit", loginStaff);
            formSD.ShowDialog();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            refreshDataViewPatient();
            GrantRole();
        }
        private void GrantRole()
        {
            DataTable dtRoleDetail = RoleDetail.GetListStaffFunction(loginStaff.RoleID);
            for (int i = 0; i < dtRoleDetail.Rows.Count; i++)
            {
                String tabName = dtRoleDetail.Rows[i][2].ToString();
                for (int j = 0; j < tabMain.Tabs.Count; j++)
                    if (tabMain.Tabs[j].Name == tabName)
                    {
                        tabMain.Tabs[j].Visible = true;
                        break;
                    }
            }
        }
        private void tabMain_SelectedTabChanged(object sender, DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs e)
        {
            switch (tabMain.SelectedTab.Name)
            {
                case "tabItemDisease":
                    refreshDataViewDisease();
                    break;
                case "tabItemHealthFile":
                    refreshDataViewHeathFile();
                    break;
                case "tabItemBed":
                    refreshDataViewBed();
                    break;
                case "tabItemService":
                    refreshDataViewService();
                    break;
                case "tabItemMaterial":
                    refreshDataViewMaterial();
                    break;
                case "tabItemHospitalization":
                    refreshDataViewService();
                    break;
                case "tabItemDischarged":
                    refreshDataViewDC();
                    break;
                case "tabItemFunction":
                    refreshDataViewFunction();
                    break;
                case "tabItemPatient":
                    refreshDataViewPatient();
                    break;
                case "tabItemBill":
                    refreshDataViewBill();
                    break;
                case "tabItemExamination":
                    refreshDataViewExamination();
                    break;
                case "tabItemTest":
                    refreshDataViewTest();
                    break;
                case "tabItemSurgery":
                    refreshDataViewSurgical();
                    break;
                case "tabItemAssignment":
                    refreshDataViewAssignment();
                    break;
                case "tabItemDeptMajor":
                    refreshDataViewDepartment();
                    break;
                case "tabItemStaff":
                    refreshDataViewStaff();
                    break;
                case "tabItemRole":
                    refreshDataViewRole();
                    break;
                case "tabItemMedicine":
                    refreshDataViewMedicine();
                    break;
                case "tabItemPrescpition":
                    refreshDataViewPrescription();
                    break;
                case "tabItemMonitor":
                    refreshDataViewHeathNote();
                    break;
            }
        }
    }
}
