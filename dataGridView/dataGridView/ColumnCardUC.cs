using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataGridView
{
    public partial class ColumnCardUC : UserControl
    {
        public ColumnCardUC()
        {
            InitializeComponent();
        }

        public event EventHandler<ColStruct> OnAddColumnClick;

        private void button1_Click(object sender, EventArgs e)
        {
            if (colNameTB.Text != null && comboBox.Text!="Choose Type")
            {
                warnLbl.Text = "";
                string colName = colNameTB.Text;
                string colType = comboBox.Text;
                ColStruct obj = new ColStruct() {
                    ColName = colName,
                    ColType = colType
                };
                OnAddColumnClick?.Invoke(sender, obj);
            }
            else {
                if(colNameTB.Text == null)
                    warnLbl.Text ="Enter The Column Name";
                else if(comboBox.Text == "Choose Type")
                    warnLbl.Text = "Enter The Column Type";
                else
                    warnLbl.Text = "Enter The Column Name and Type";
            }
        }
    }
}
