using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Svg;

namespace svgEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string filePath;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar!=(char)Keys.Back) {
                e.Handled = true;
            }
        }

        private void addImage(string path) {
            try {
                var document = SvgDocument.Open(path);
                
            }
            catch (Exception ex) {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void addObjBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDirectory = new OpenFileDialog();
            fileDirectory.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif|All Files|*.*"; 
            fileDirectory.ShowDialog();
            filePath = fileDirectory.FileName;
        }
    }
}
