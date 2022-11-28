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
    public partial class MainHub : Form
    {
        public MainHub()
        {
            InitializeComponent();
        }

        private void addButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            AddForm addFormInstance = new AddForm();
            addFormInstance.ShowDialog();
            this.Close();
        }

        private void modifyRadioBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            ModifyForm modifyFormInstance = new ModifyForm();
            modifyFormInstance.ShowDialog();
            this.Close();
        }

        private void viewRadioBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            ViewForm viewFormInstance = new ViewForm();
            viewFormInstance.ShowDialog();
            this.Close();
        }

    }
}
