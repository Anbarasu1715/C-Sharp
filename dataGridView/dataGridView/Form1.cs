using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DataGridViewColumn newColumn;
        private ColumnCardUC cardUC;
        private DataCardUC data;
        //private List<List<string>> TablDdata=new List<List<string>>();
        private Dictionary<string,string> TableDdata=new Dictionary<string, string>();
        private List<string> columnNames=new List<string>();

        private void addColumn(Object sender,ColStruct column) {


            switch (column.ColType) {
                case "string":
                    newColumn = new DataGridViewTextBoxColumn();
                    break;
                case "link":
                    newColumn = new DataGridViewLinkColumn();
                    break;
                case "checkBox":
                    newColumn = new DataGridViewCheckBoxColumn();
                    break;
                case "comboBox":
                    newColumn = new DataGridViewComboBoxColumn();
                    break;
                case "Button":
                    newColumn = new DataGridViewButtonColumn();
                    break;
                case "image":
                    newColumn = new DataGridViewImageColumn();
                    break;
                default:
                    return;
            }

            newColumn.HeaderText = column.ColName;
            newColumn.Name = "new Column";
            //column name added to the list
            columnNames.Add(column.ColName);
            newColumn.Width = 100;
            userDGV.Columns.Add(newColumn);
        }

        private void addColBtn_Click(object sender, EventArgs e)
        {
            cardUC?.Dispose();
            data?.Dispose();

            cardUC = new ColumnCardUC();
            cardUC.OnAddColumnClick += addColumn;
            cardUC.Location = new Point((Width/2)-cardUC.Size.Width/2, (Height / 2) - cardUC.Size.Height / 2);

            Controls.Add(cardUC);
            cardUC.BringToFront();
            
        }

        private void AddRow(Object sender, List<string> ColumnNames) {
            
        }

        private void addRowBtn_Click(object sender, EventArgs e)
        {
            cardUC?.Dispose();
            data?.Dispose();

            data = new DataCardUC();
            data.Width = 300;
            data.Height = (columnNames.Count * 100) + 50;
            data.OnDataSend +=DisplayTableData;
            data.OnDataReceive?.Invoke(sender, columnNames);
            Controls.Add(data);
            data.BringToFront();
            data.Location = new Point((Width / 2) - data.Size.Width / 2, (Height / 2) - data.Size.Height / 2);
        }

        private void DisplayTableData(object sender, Dictionary<string, string> e)
        {
            cardUC?.Dispose();
            data?.Dispose();
            foreach (KeyValuePair<string,string> kvp in e) {

                displayBox.Text += kvp.Key + " --- " + kvp.Value+Environment.NewLine;
            }
        }
    }
}
