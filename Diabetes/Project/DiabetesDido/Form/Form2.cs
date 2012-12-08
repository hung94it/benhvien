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
    public partial class Form2 : Form
    {
        //private DiabetesDataSetTableAdapters.DatasourceTableAdapter datasourceTableAdapter;

        public Form2()
        {
            InitializeComponent();

            //this.datasourceTableAdapter = new DiabetesDido.DiabetesDataSetTableAdapters.DatasourceTableAdapter();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diabetesDataSet.Datasource' table. You can move, or remove it, as needed.
            this.datasourceTableAdapter.Fill(this.diabetesDataSet.Datasource);


        }
    }
}
