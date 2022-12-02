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
        public string Name { get; set; }


        public WelcomeForm(String name)
        {
            InitializeComponent();
            this.Name = name;
            nameLabel.Text = Name;

            if(name == "Simon.P")
            {
                adminRadioBtn.Show();
            }else adminRadioBtn.Hide();
        }

        private void addButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            String empName = nameLabel.Text;
            AddForm addFormInstance = new AddForm(empName);
            addFormInstance.ShowDialog();
            this.Close();
        }

        private void modifyRadioBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            String empName = nameLabel.Text;
            ModifyForm modifyFormInstance = new ModifyForm(empName);
            modifyFormInstance.ShowDialog();
            this.Close();
        }

        private void viewRadioBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            String empName = nameLabel.Text;
            ViewForm viewFormInstance = new ViewForm(empName);
            viewFormInstance.ShowDialog();
            this.Close();
        }

        private void adminRadioBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            AdminPage adminPage = new AdminPage();
            adminPage.ShowDialog();
            this.Close();
        }

    }
}
