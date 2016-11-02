using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxItemSelect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "ABC")
            {
                MessageBox.Show("Hi");
                comboBox1.SelectedItem = 1;
            }

            if (comboBox1.SelectedItem == "DEF")
            {
                MessageBox.Show("Hello");
                comboBox1.SelectedItem = 0;

            }
        }
    }
}
