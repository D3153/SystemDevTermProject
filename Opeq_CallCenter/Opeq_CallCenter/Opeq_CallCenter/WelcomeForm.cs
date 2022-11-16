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
            AddForm addFormInstance = new AddForm();
            ModifyForm modifyFormInstance = new ModifyForm();            
            ViewForm viewFormInstance = new ViewForm();
        }

        private void addButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void modifyRadioBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void viewRadioBtn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
