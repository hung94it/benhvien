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

namespace Hospital.View
{
    public partial class FormRoleDetail : Form
    {
        public Role roleDetail { get; set; }
        public String UserAction { get; set; }

        public FormRoleDetail()
        {
            InitializeComponent();
        }
        public FormRoleDetail(Role roledetail, String usertAction)
        {
            InitializeComponent();
            this.roleDetail = roledetail;
            this.UserAction = usertAction;
            if (usertAction.Equals("edit"))
                SetRoleDetail(roleDetail);
        }
        public void SetRoleDetail(Role roledetail)
        {
            this.roleDetail = roledetail;

            textBoxRoleID.Text = roleDetail.RoleID.ToString();
            textBoxRoleName.Text = roleDetail.RoleName;

            listBoxCurrentFunction.Enabled = true;
            listBoxSystemFunction.Enabled = true;
            buttonRemoveFunction.Enabled = true;
            buttonInsertFunction.Enabled = true;

            DataTable dtCurrentFunction = RoleDetail.GetListStaffFunction(roledetail.RoleID);
            for (int i = 0; i < dtCurrentFunction.Rows.Count; i++)
            { 
                RoleFunction tempRF=new RoleFunction(int.Parse(dtCurrentFunction.Rows[i][0].ToString()),dtCurrentFunction.Rows[i][1].ToString(),"");
                listBoxCurrentFunction.Items.Add(tempRF.FucntionName);
                listBoxCurrentFunctionID.Items.Add(tempRF.FunctionID);
            }
            DataTable dtSystemFunction = RoleFunction.GetListFunction();
            for (int i = 0; i < dtSystemFunction.Rows.Count; i++)
            {
                RoleFunction tempRF = new RoleFunction(int.Parse(dtSystemFunction.Rows[i][0].ToString()), dtSystemFunction.Rows[i][1].ToString(), dtSystemFunction.Rows[i][2].ToString());
                listBoxSystemFunction.Items.Add(tempRF.FucntionName);
                listBoxSystemFunctionID.Items.Add(tempRF.FunctionID);
            }
            ListBox lstTemp = new ListBox();
            for (int i = 0; i < listBoxCurrentFunctionID.Items.Count; i++)
            {
                for (int j = 0; j < listBoxSystemFunctionID.Items.Count; j++)
                {
                    if (listBoxCurrentFunctionID.Items[i].ToString() == listBoxSystemFunctionID.Items[j].ToString())
                    {
                        listBoxSystemFunctionID.Items.RemoveAt(j);
                        listBoxSystemFunction.Items.RemoveAt(j);
                        break;
                    }
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxRoleName.Text != "")
            {
                try
                {
                    if ("edit".Equals(this.UserAction))
                    {
                        Role editRole = new Role(int.Parse(textBoxRoleID.Text), textBoxRoleName.Text);

                        if (Role.UpdateRole(editRole) > 0)
                        {
                            RoleDetail.DeleteRoleDetail(roleDetail.RoleID);
                            for (int i = 0; i < listBoxCurrentFunctionID.Items.Count; i++) 
                            {
                                RoleDetail newRD = new RoleDetail(roleDetail.RoleID, int.Parse(listBoxCurrentFunctionID.Items[i].ToString()));
                                RoleDetail.InsertRoleDetail(newRD);
                            }
                            MessageBox.Show("Cập nhập phân quyền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                    }
                    else
                    {
                        Role newRole = new Role(0, textBoxRoleName.Text);
                        if (Role.InsertRole(newRole) > 0)
                            MessageBox.Show("Thêm phân quyền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
                catch (SqlException exception)
                {
                    MessageBox.Show(exception.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thiếu thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Close();
        }

        private void buttonRemoveFunction_Click(object sender, EventArgs e)
        {
            if (listBoxCurrentFunction.Items.Count > 0)
            {
                int selectedItem = listBoxCurrentFunction.SelectedIndex;
                if (selectedItem >= 0)
                {
                    listBoxSystemFunction.Items.Add(listBoxCurrentFunction.Items[selectedItem].ToString());
                    listBoxSystemFunctionID.Items.Add(listBoxCurrentFunctionID.Items[selectedItem].ToString());
                    listBoxCurrentFunction.Items.RemoveAt(selectedItem);
                    listBoxCurrentFunctionID.Items.RemoveAt(selectedItem);
                }
            }
        }

        private void buttonInsertFunction_Click(object sender, EventArgs e)
        {
            if (listBoxSystemFunction.Items.Count > 0)
            {
                int selectedItem = listBoxSystemFunction.SelectedIndex;
                if (selectedItem >= 0)
                {
                    listBoxCurrentFunction.Items.Add(listBoxSystemFunction.Items[selectedItem].ToString());
                    listBoxCurrentFunctionID.Items.Add(listBoxSystemFunctionID.Items[selectedItem].ToString());
                    listBoxSystemFunction.Items.RemoveAt(selectedItem);
                    listBoxSystemFunctionID.Items.RemoveAt(selectedItem);
                }
            }
        }
    }
}
