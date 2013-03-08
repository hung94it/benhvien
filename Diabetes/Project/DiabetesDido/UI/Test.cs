using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiabetesDido.UI
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void continuousDataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.continuousDataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diabetesDataSetB);

        }

        private void Test_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diabetesDataSetB.ContinuousData' table. You can move, or remove it, as needed.
            this.continuousDataTableAdapter.Fill(this.diabetesDataSetB.ContinuousData);

        }

    }
}
