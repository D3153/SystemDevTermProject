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
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void employeeLoginLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

        private void adminNameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (adminNameTextBox.Text == "Entrer votre Nom")
            {
                adminNameTextBox.Text = "";
                adminNameTextBox.ForeColor = Color.Black;
            }
        }

        private void adminPassTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (adminPassTextBox.Text == "Entrer votre Mot de Passe")
            {
                adminPassTextBox.Text = "";
                adminPassTextBox.ForeColor = Color.Black;
            }
        }
    }
}
