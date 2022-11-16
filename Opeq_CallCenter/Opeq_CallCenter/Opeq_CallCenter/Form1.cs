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
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-KFOB4HEQ\DINAL;Initial Catalog=Opeq_CallCenter;Integrated Security=True");
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(empNameTextBox.Text != string.Empty) 
            {
                //Uncomment to see if database works
                string empName = empNameTextBox.Text;
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO employee (employee_name) VALUES ('" + empName + "');";
                cmd.ExecuteNonQuery();
                con.Close();

                this.Hide();
                WelcomeForm welcomeForm = new WelcomeForm();
                welcomeForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Entrer un nom valide!");
            }

        }

        private void adminLoginLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLoginForm adminLogin = new AdminLoginForm();
            adminLogin.ShowDialog();
            this.Close();
        }

        private void empNameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (empNameTextBox.Text == "Entrer votre nom")
            {
                empNameTextBox.Text = "";
                empNameTextBox.ForeColor = Color.Black;
            }
        }

        //private void empNameTextBox_MouseEnter(object sender, EventArgs e)
        //{
        //if (empNameTextBox.Text == "Entrer votre nom")
        //{
        //empNameTextBox.Text = "";
        //empNameTextBox.ForeColor = Color.Black;
        //}
        //}

        //private void empNameTextBox_MouseLeave(object sender, EventArgs e)
        //{
        //if (empNameTextBox.Text != "Entrer votre nom")
        //{
        //empNameTextBox.Text = "Entrer votre nom";
        //empNameTextBox.ForeColor = Color.Gray;
        //}
        //}

    }
}
