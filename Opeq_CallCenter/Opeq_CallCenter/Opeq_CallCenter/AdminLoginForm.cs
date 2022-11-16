using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Opeq_CallCenter
{
    public partial class AdminLoginForm : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-KFOB4HEQ\DINAL;Initial Catalog=Opeq_CallCenter;Integrated Security=True");

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

        private void loginButton_Click(object sender, EventArgs e)
        {
            /*con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string adminName = cmd.CommandText = "SELECT admin_name FROM Admin;";
            string adminPass = cmd.CommandText = "SELECT password FROM Admin;";
            cmd.ExecuteNonQuery();
            con.Close();*/

            if (adminNameTextBox.Text == "Ollo" && adminPassTextBox.Text == "Ollo")
            {
                this.Hide();
                WelcomeForm welcomeForm = new WelcomeForm();
                welcomeForm.ShowDialog();
                this.Close();
            }
        }
    }
}
