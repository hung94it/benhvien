using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiabetesDido
{
    public partial class RoiRacHoaDuLieu : Form
    {
        public RoiRacHoaDuLieu()
        {
            InitializeComponent();
        }

        private void dataSetTempBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataSetTempBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diabetesDataSet);

        }

        private void RoiRacHoaDuLieucs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diabetesDataSet.DataSetTemp' table. You can move, or remove it, as needed.
            this.dataSetTempTableAdapter.Fill(this.diabetesDataSet.DataSetTemp);

        }

        private void RoiRacHoaDuLieu_FormClosed(object sender, FormClosedEventArgs e)
        {
            TienXuDuLieu tienXuDuLieu = new TienXuDuLieu();
            tienXuDuLieu.Show();
        }
    }
}
