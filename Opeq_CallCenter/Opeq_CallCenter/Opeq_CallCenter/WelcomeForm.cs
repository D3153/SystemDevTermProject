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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void addButton_CheckedChanged(object sender, EventArgs e)
        {
            AddForm addFormInstance = new AddForm();
            addFormInstance.ShowDialog();
            this.Close();
        }

        private void modifyRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            ModifyForm modifyFormInstance = new ModifyForm();
        }

        private void viewRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            ViewForm viewFormInstance = new ViewForm();
        }
    }
}
