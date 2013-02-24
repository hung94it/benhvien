using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace DiabetesDido.UI
{
    public partial class FormMain : DevComponents.DotNetBar.Metro.MetroForm
    {        

        public FormMain()
        {
            InitializeComponent();
            InitializeTabPreprocessingData();
            InitializeTabCreateModel();
            InitializeTabDiagnosis();

        }

        private void superTabControlMain_SelectedTabChanged(object sender, SuperTabStripSelectedTabChangedEventArgs e)
        {
            switch ((sender as SuperTabControl).SelectedTabIndex)
            { 
                case 1:
                    refreshTabCreateModel();
                    break;
                default:
                    break;
            }
        }
    }
}