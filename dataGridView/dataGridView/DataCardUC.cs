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
    public partial class DataCardUC : UserControl
    {
        public DataCardUC()
        {
            InitializeComponent();
            OnDataReceive += GenerateUI;
        }

        public EventHandler<List<string>> OnDataReceive;
        public EventHandler<Dictionary<string, string>> OnDataSend;
        private int LocY = 0;
        private Dictionary<string, string> RowData=new Dictionary<string, string>();

        private void sendRowData(object sender,EventArgs e) {
            foreach (Control panel in Controls) {
                string colName=null;
                if (panel is Panel)
                {
                    foreach (Control c in panel.Controls)
                    {
                        if (c is Label)
                        {
                            colName = c.Text;
                        }
                        else if (c is RichTextBox)
                        {
                            if (colName != null)
                            {
                                RowData.Add(colName, (c as RichTextBox).Text);
                            }
                        }
                    }
                }
            }

            OnDataSend?.Invoke(sender,RowData);
        }

        private void GenerateUI(Object sender, List<string> columnNames) {
            foreach (string colName in columnNames) {
                Panel newPanel = new Panel() {
                    Width = 300,
                    Height=100,
                    Location=new Point(0,LocY)
                };
                Label newLabel = new Label() {
                    AutoSize = false,
                    Width = 300,
                    Height = 50,
                    Font = new Font("Microsoft Sans Serif",10,FontStyle.Bold),
                    TextAlign=ContentAlignment.MiddleCenter,
                    Location=new Point(0,0),
                    Text=colName
                };
                RichTextBox richTextBox = new RichTextBox() {
                    Width=300,
                    Height=50,
                    Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold),
                    Location = new Point(0, 50)
                };
                newPanel.Controls.Add(newLabel);
                newPanel.Controls.Add(richTextBox);
                Controls.Add(newPanel);
                LocY += 100;
            }
            Button newButton = new Button()
            {
                Width = 300,
                Height = 50,
                Text = "Submit",
                Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold),
                Location = new Point(0,Height-50)
            };
            Controls.Add(newButton);
            newButton.Click += sendRowData;
        }

    }
}
