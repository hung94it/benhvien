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
    }
}
