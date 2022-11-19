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

        
        
        

        private void addButton_MouseClick(object sender, MouseEventArgs e)
        {
            AddForm addFormInstance = new AddForm();
            addFormInstance.ShowDialog();
            this.Close();
        }

        private void modifyRadioBtn_MouseClick(object sender, MouseEventArgs e)
        {
            ModifyForm modifyFormInstance = new ModifyForm();
            modifyFormInstance.ShowDialog();
            this.Close();
        }

        private void viewRadioBtn_MouseClick(object sender, MouseEventArgs e)
        {
            ViewForm viewFormInstance = new ViewForm();
            viewFormInstance.ShowDialog();
            this.Close();
        }
    }
}
