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

        //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-KFOB4HEQ\DINAL;Initial Catalog=Opeq_CallCenter;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PJPEDDG;Initial Catalog=Opeq;Integrated Security=True");

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
            hintForName();
        }
        private void adminNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            hintForName();
            if (e.KeyChar == (char)Keys.Enter)
            {
                adminLogin();
            }
        }

        private void adminPassTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            hintForPassword();
        }
        private void adminPassTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            hintForPassword();
            if (e.KeyChar == (char)Keys.Enter)
            {
                adminLogin();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            adminLogin();
        }

        public void hintForName()
        {
            if (adminNameTextBox.Text == "Entrer votre nom")
            {
                adminNameTextBox.Text = "";
            }
            adminNameTextBox.ForeColor = Color.Black;
        }

        public void hintForPassword()
        {
            if (adminPassTextBox.Text == "Entrer votre Mot de Passe")
            {
                adminPassTextBox.Text = "";
            }
            adminPassTextBox.ForeColor = Color.Black;
            adminPassTextBox.PasswordChar = '*';
        }

        public void adminLogin()
        {
            con.Open();
            SqlCommand cmd1 = con.CreateCommand();
            SqlCommand cmd2 = con.CreateCommand();

            cmd1.CommandType = CommandType.Text;
            cmd2.CommandType = CommandType.Text;

            cmd1.CommandText = "SELECT admin_name FROM Admin_Account;";
            cmd2.CommandText = "SELECT password FROM Admin_Account;";

            string adminName = Convert.ToString(cmd1.ExecuteScalar());
            string adminPass = Convert.ToString(cmd2.ExecuteScalar());
            con.Close();

            if (adminNameTextBox.Text == adminName && adminPassTextBox.Text == adminPass)
            {
                this.Hide();
                WelcomeForm welcomeForm = new WelcomeForm();
                welcomeForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nom ou Mot de Passe non valide!");
            }
        }
    }
}
