using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        string text;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myDropDown.Items.Add(text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            myDropDown.Items.Remove(myDropDown.SelectedItem);
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            text = textBox1.Text;
    
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
