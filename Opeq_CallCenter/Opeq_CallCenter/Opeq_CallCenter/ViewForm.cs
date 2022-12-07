using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opeq_CallCenter
{
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {

        }

        private void modifyRadioBtn_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewSearchedForm viewFormInstance = new ViewSearchedForm();
            viewFormInstance.ShowDialog();
            this.Close();
        }
    }
}
