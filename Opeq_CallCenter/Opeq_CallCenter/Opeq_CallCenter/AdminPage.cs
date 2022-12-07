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
            loadComboBox();
        }

        public void loadComboBox()
        {
            this.Refresh();

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
            cmd5.CommandType = CommandType.Text;
            cmd6.CommandType = CommandType.Text;

            cmd1.CommandText = "SELECT * FROM Computer_Prob;";
            cmd2.CommandText = "SELECT * FROM Laptop_Prob;";
            cmd3.CommandText = "SELECT * FROM Screen_Prob;";
            cmd4.CommandText = "SELECT * FROM Phone_Tablet_Prob;";
            cmd5.CommandText = "SELECT * FROM Order_Type;";
            cmd6.CommandText = "SELECT * FROM Action_Took;";

            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            cmd4.ExecuteNonQuery();
            cmd5.ExecuteNonQuery();
            cmd6.ExecuteNonQuery();

            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            SqlDataAdapter adapter3 = new SqlDataAdapter(cmd3);
            SqlDataAdapter adapter4 = new SqlDataAdapter(cmd4);
            SqlDataAdapter adapter5 = new SqlDataAdapter(cmd5);
            SqlDataAdapter adapter6 = new SqlDataAdapter(cmd6);

            DataSet dataSet1 = new DataSet();
            DataSet dataSet2 = new DataSet();
            DataSet dataSet3 = new DataSet();
            DataSet dataSet4 = new DataSet();
            DataSet dataSet5 = new DataSet();
            DataSet dataSet6 = new DataSet();

            adapter1.Fill(dataSet1);
            adapter2.Fill(dataSet2);
            adapter3.Fill(dataSet3);
            adapter4.Fill(dataSet4);
            adapter5.Fill(dataSet5);
            adapter6.Fill(dataSet6);

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

            orderTypeComboBox.DataSource = dataSet5.Tables[0];
            orderTypeComboBox.DisplayMember = "order_name";
            orderTypeComboBox.ValueMember = "order_type_id";
            orderTypeComboBox.SelectedIndex = -1;

            actionTookComboBox.DataSource = dataSet6.Tables[0];
            actionTookComboBox.DisplayMember = "action_took_name";
            actionTookComboBox.ValueMember = "action_took_id";
            actionTookComboBox.SelectedIndex = -1;
        }

        public void reloadComboBox()
        {
            computerProblemComboBox.Refresh();
            orderTypeComboBox.Refresh();
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

        private void emptyTextBox(TextBox textBox)
        {
            if(textBox.Text == "Ajouter")
            {
                textBox.Text = "";
            }
            textBox.ForeColor = Color.Black;
        }

        private void computerProbTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            emptyTextBox(computerProbTextBox);
        }

        private void laptopProbTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            emptyTextBox(laptopProbTextBox);
        }

        private void screenProbTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            emptyTextBox(screenProbTextBox);
        }
       
        private void phoneOrTabTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            emptyTextBox(phoneOrTabTextBox);
        }
        
        private void orderTypeTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            emptyTextBox(orderTypeTextBox);
        }

        private void actionTookTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            emptyTextBox(actionTookTextBox);
        }

        private void computerProbAddBtn_Click(object sender, EventArgs e)
        {
            string computerProbDesc = computerProbTextBox.Text;

            if(computerProbDesc != "")
            {
                con.Open();

                SqlCommand cmd1 = con.CreateCommand();

                cmd1.CommandType = CommandType.Text;

                cmd1.CommandText = "INSERT INTO Computer_Prob (computer_desc) VALUES ('" + computerProbDesc + "');";

                cmd1.ExecuteNonQuery();


                con.Close();
            }
            computerProbTextBox.Text = "";
            loadComboBox();
        }

        private void screenProbAddBtn_Click(object sender, EventArgs e)
        {
            string screenProbDesc = screenProbTextBox.Text;

            if (screenProbDesc != "")
            {
                con.Open();

                SqlCommand cmd1 = con.CreateCommand();

                cmd1.CommandType = CommandType.Text;

                cmd1.CommandText = "INSERT INTO Screen_Prob (screen_desc) VALUES ('" + screenProbDesc + "');";

                cmd1.ExecuteNonQuery();

                con.Close();
            }
            screenProbTextBox.Text = "";
            loadComboBox();
        }

        private void laptopProbAddBtn_Click(object sender, EventArgs e)
        {
            string laptopProbDesc = laptopProbTextBox.Text;

            if (laptopProbDesc != "")
            {
                con.Open();

                SqlCommand cmd1 = con.CreateCommand();

                cmd1.CommandType = CommandType.Text;

                cmd1.CommandText = "INSERT INTO Laptop_Prob (laptop_desc) VALUES ('" + laptopProbDesc + "');";

                cmd1.ExecuteNonQuery();

                con.Close();
            }
            laptopProbTextBox.Text = "";
            loadComboBox();
        }

        private void phoneOrTabProbAddBtn_Click(object sender, EventArgs e)
        {
            string phoneOrTabProbDesc = phoneOrTabTextBox.Text;

            if (phoneOrTabProbDesc != "")
            {
                con.Open();

                SqlCommand cmd1 = con.CreateCommand();

                cmd1.CommandType = CommandType.Text;

                cmd1.CommandText = "INSERT INTO Phone_Tablet_Prob (phone_tab_desc) VALUES ('" + phoneOrTabProbDesc + "');";

                cmd1.ExecuteNonQuery();

                con.Close();
            }
            phoneOrTabTextBox.Text = "";
            loadComboBox();
        }

        private void orderTypeAddBtn_Click(object sender, EventArgs e)
        {
            string orderTypeName = orderTypeTextBox.Text;

            if (orderTypeName != "")
            {
                con.Open();

                SqlCommand cmd1 = con.CreateCommand();

                cmd1.CommandType = CommandType.Text;

                cmd1.CommandText = "INSERT INTO Order_Type (order_name) VALUES ('" + orderTypeName + "');";

                cmd1.ExecuteNonQuery();

                con.Close();
            }
            orderTypeTextBox.Text = "";
            loadComboBox();
        }

        private void actionTookAddBtn_Click(object sender, EventArgs e)
        {
            string actionTookName = actionTookTextBox.Text;

            if (actionTookName != "")
            {
                con.Open();

                SqlCommand cmd1 = con.CreateCommand();

                cmd1.CommandType = CommandType.Text;

                cmd1.CommandText = "INSERT INTO Action_Took (action_took_name) VALUES ('" + actionTookName + "');";

                cmd1.ExecuteNonQuery();

                con.Close();
            }
            actionTookTextBox.Text = "";
            loadComboBox();
        }

        private void computerProbRemoveBtn_Click(object sender, EventArgs e)
        {
            string computerProbDesc = computerProbTextBox.Text;

            if (computerProbDesc != "")
            {
                con.Open();

                SqlCommand cmd1 = con.CreateCommand();

                cmd1.CommandType = CommandType.Text;

                cmd1.CommandText = "DELETE FROM Computer_Prob WHERE CONVERT(VARCHAR, computer_desc) = '" + computerProbDesc + "';";

                cmd1.ExecuteNonQuery();

                con.Close();
            }
            loadComboBox();
        }

        private void screenProbRemoveBtn_Click(object sender, EventArgs e)
        {
            string screenProbDesc = screenProbTextBox.Text;

            if (screenProbDesc != "")
            {
                con.Open();

                SqlCommand cmd1 = con.CreateCommand();

                cmd1.CommandType = CommandType.Text;

                cmd1.CommandText = "DELETE FROM Screen_Prob WHERE CONVERT(VARCHAR, screen_desc) = '" + screenProbDesc + "';";

                cmd1.ExecuteNonQuery();

                con.Close();
            }
            loadComboBox();
        }

        private void laptopProbRemoveBtn_Click(object sender, EventArgs e)
        {
            string laptopProbDesc = laptopProbTextBox.Text;

            if (laptopProbDesc != "")
            {
                con.Open();

                SqlCommand cmd1 = con.CreateCommand();

                cmd1.CommandType = CommandType.Text;

                cmd1.CommandText = "DELETE FROM Laptop_Prob WHERE CONVERT(VARCHAR, laptop_desc) = '" + laptopProbDesc + "';";

                cmd1.ExecuteNonQuery();

                con.Close();
            }
            loadComboBox();
        }

        private void phoneOrTabProbRemoveBtn_Click(object sender, EventArgs e)
        {
            string phoneOrTabProbDesc = phoneOrTabTextBox.Text;

            if (phoneOrTabProbDesc != "")
            {
                con.Open();

                SqlCommand cmd1 = con.CreateCommand();

                cmd1.CommandType = CommandType.Text;

                cmd1.CommandText = "DELETE FROM Phone_Tablet_Prob WHERE CONVERT(VARCHAR, phone_tab_desc) = '" + phoneOrTabProbDesc + "';";

                cmd1.ExecuteNonQuery();

                con.Close();
            }
            loadComboBox();
        }

        private void orderTypeRemoveBtn_Click(object sender, EventArgs e)
        {
            string orderTypeName = orderTypeComboBox.GetItemText(orderTypeComboBox.SelectedItem);

            if (orderTypeName != "")
            {
                con.Open();

                SqlCommand cmd1 = con.CreateCommand();

                cmd1.CommandType = CommandType.Text;

                cmd1.CommandText = "DELETE FROM Order_Type WHERE CONVERT(VARCHAR, order_name) = '" + orderTypeName + "';";

                cmd1.ExecuteNonQuery();

                con.Close();
            }
            loadComboBox();
        }

        private void actionTookRemoveBtn_Click(object sender, EventArgs e)
        {
            string actionTookName = actionTookTextBox.Text;

            if (actionTookName != "")
            {
                con.Open();

                SqlCommand cmd1 = con.CreateCommand();

                cmd1.CommandType = CommandType.Text;

                cmd1.CommandText = "DELETE FROM Action_Took WHERE CONVERT(VARCHAR, action_took_name) = '" + actionTookName + "';";

                cmd1.ExecuteNonQuery();

                con.Close();
            }
            loadComboBox();
        }

    }
}
