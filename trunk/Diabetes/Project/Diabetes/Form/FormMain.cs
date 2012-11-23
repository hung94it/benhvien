using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Diabetes.DAL;

namespace Diabetes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //DiabetesEntities entity = new DiabetesEntities();
            //xetNghiemBindingSource.DataSource = entity.XetNghiems;

            //xetNghiemBindingSource.DataSource = MedicalTestDAL.SelectAll();
            dataGridView1.DataSource = MedicalTestDAL.SelectAll();
        }
    }
}
