using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opeq_CallCenter
{
    public partial class AdminPage : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-KFOB4HEQ\DINAL;Initial Catalog=Opeq_CallCenter;Integrated Security=True");
        public AdminPage(string empName)
        {
            InitializeComponent();
        }

        public AdminPage()
        {
            InitializeComponent();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd1 = con.CreateCommand();
            SqlCommand cmd2 = con.CreateCommand();
            SqlCommand cmd3 = con.CreateCommand();
            SqlCommand cmd4 = con.CreateCommand();
            SqlCommand cmd5 = con.CreateCommand();
            SqlCommand cmd6 = con.CreateCommand();

            cmd1.CommandType = CommandType.Text;
            cmd2.CommandType = CommandType.Text;
            cmd3.CommandType = CommandType.Text;
            cmd4.CommandType = CommandType.Text;

            cmd1.CommandText = "SELECT * FROM Computer_Prob;";
            cmd2.CommandText = "SELECT * FROM Laptop_Prob;";
            cmd3.CommandText = "SELECT * FROM Screen_Prob;";
            cmd4.CommandText = "SELECT * FROM Phone_Tablet_Prob;";

            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            cmd4.ExecuteNonQuery();

            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            SqlDataAdapter adapter3 = new SqlDataAdapter(cmd3);
            SqlDataAdapter adapter4 = new SqlDataAdapter(cmd4);

            DataSet dataSet1 = new DataSet();
            DataSet dataSet2 = new DataSet();
            DataSet dataSet3 = new DataSet();
            DataSet dataSet4 = new DataSet();

            adapter1.Fill(dataSet1);
            adapter2.Fill(dataSet2);
            adapter3.Fill(dataSet3);
            adapter4.Fill(dataSet4);

            con.Close();

            computerProblemComboBox.DataSource = dataSet1.Tables[0];
            computerProblemComboBox.DisplayMember = "computer_desc";
            computerProblemComboBox.ValueMember = "computer_prob_id";
            computerProblemComboBox.SelectedIndex = -1;

            laptopProblemComboBox.DataSource = dataSet2.Tables[0];
            laptopProblemComboBox.DisplayMember = "laptop_desc";
            laptopProblemComboBox.ValueMember = "laptop_prob_id";
            laptopProblemComboBox.SelectedIndex = -1;

            screenProblemComboBox.DataSource = dataSet3.Tables[0];
            screenProblemComboBox.DisplayMember = "screen_desc";
            screenProblemComboBox.ValueMember = "screen_prob_id";
            screenProblemComboBox.SelectedIndex = -1;

            phoneOrTabletProblemComboBox.DataSource = dataSet4.Tables[0];
            phoneOrTabletProblemComboBox.DisplayMember = "phone_tab_desc";
            phoneOrTabletProblemComboBox.ValueMember = "phone_tablet_prob_id";
            phoneOrTabletProblemComboBox.SelectedIndex = -1;
        }

        private void addButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            AddForm addFormInstance = new AddForm("Simon.P");
            addFormInstance.ShowDialog();
            this.Close();
        }

        private void modifyRadioBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            ModifyForm modifyFormInstance = new ModifyForm("Simon.P");
            modifyFormInstance.ShowDialog();
            this.Close();
        }

        private void viewRadioBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            ViewForm viewFormInstance = new ViewForm("Simon.P");
            viewFormInstance.ShowDialog();
            this.Close();
        }
    }
}
