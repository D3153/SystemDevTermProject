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
        }

        public MainHub(string empName)
        {
            InitializeComponent();
        }

        private void addButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            String empName = empNameTextView.Text;
            AddForm addFormInstance = new AddForm(empName);
            addFormInstance.ShowDialog();
            this.Close();
        }

        private void modifyRadioBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            String empName = empNameTextView.Text;
            ModifyForm modifyFormInstance = new ModifyForm(empName);
            modifyFormInstance.ShowDialog();
            this.Close();
        }

        private void viewRadioBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            String empName = empNameTextView.Text;
            ViewForm viewFormInstance = new ViewForm(empName);
            viewFormInstance.ShowDialog();
            this.Close();
        }
    }
}
