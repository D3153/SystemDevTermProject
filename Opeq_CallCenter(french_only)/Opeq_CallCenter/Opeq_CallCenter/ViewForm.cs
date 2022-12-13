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
    public partial class ViewForm : Form
    {

        Boolean isAddBtnClicked;
        Boolean isCancelBtnClicked;
        Boolean isModifyRadioBtnClicked;
        Boolean isAddRadioBtnClicked;
        Boolean isAdminRadioBtnClicked;
        Boolean isResolvedClicked;
        Boolean isOnGoingClicked;
        Boolean isUnresolvedClicked;

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-KFOB4HEQ\DINAL;Initial Catalog=Opeq_CallCenter;Integrated Security=True");
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PJPEDDG;Initial Catalog=Opeq;Integrated Security=True");
        public ViewForm()
        {
        }

        public ViewForm(string empName)
        {
            InitializeComponent();
            empNameTextView.Text = empName;

            if (empName == "Simon.P")
            {
                adminRadioBtn.Show();
            }
            else
            {
                adminRadioBtn.Hide();
            }
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            resultBox.ReadOnly = true;
            nameRichTextBox.ReadOnly = true;
            orderNumRichTextBox.ReadOnly = true;

            this.Refresh();
        }

        private void addButton_MouseClick(object sender, MouseEventArgs e)
        {
            isAddRadioBtnClicked = true;
            addRadioBtn.Checked = true;
            confirmation();
        }

        private void modifyRadioBtn_MouseClick(object sender, MouseEventArgs e)
        {
            isModifyRadioBtnClicked = true;
            modifyRadioBtn.Checked = true;
            confirmation();
        }

        private void adminRadioBtn_MouseClick(object sender, MouseEventArgs e)
        {
            isAdminRadioBtnClicked = true;
            adminRadioBtn.Checked = true;
            confirmation();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            String data = searchbar.Text;
            String mat = "";
            String client_name = "";
            String orderNum = "";


            con.Open();

            //make commands
            SqlCommand cmd1 = con.CreateCommand();
            SqlCommand cmd2 = con.CreateCommand();
            SqlCommand cmd3 = con.CreateCommand();
            SqlCommand cmd4 = con.CreateCommand();
            SqlCommand cmd5 = con.CreateCommand();

            cmd1.CommandType = CommandType.Text;
            cmd2.CommandType = CommandType.Text;
            cmd3.CommandType = CommandType.Text;
            cmd4.CommandType = CommandType.Text;
            cmd5.CommandType = CommandType.Text;

            //get the values for from the search bar
            //cmd1.CommandText = "SELECT MAT, client_name, order_num FROM Product p JOIN Client c ON p.product_id=c.product_id JOIN Modify_Client m ON c.client_id=m.client_id " +
            //    "WHERE c.client_name = '" + data + "' OR MAT = '" + data + "' OR order_num = '" + data + "';";
            cmd1.CommandText = "SELECT MAT FROM Product p JOIN Client c ON p.product_id=c.product_id JOIN Modify_Client m ON c.client_id=m.client_id " +
                "WHERE c.client_name = '" + data + "' OR MAT = '" + data + "' OR order_num = '" + data + "';";
            cmd2.CommandText = "SELECT client_name FROM Product p JOIN Client c ON p.product_id=c.product_id JOIN Modify_Client m ON c.client_id=m.client_id " +
                "WHERE c.client_name = '" + data + "' OR MAT = '" + data + "' OR order_num = '" + data + "';";
            cmd3.CommandText = "SELECT order_num FROM Product p JOIN Client c ON p.product_id=c.product_id JOIN Modify_Client m ON c.client_id=m.client_id " +
                "WHERE c.client_name = '" + data + "' OR MAT = '" + data + "' OR order_num = '" + data + "';";

            String output1 = "MAT\n";
            String output2 = "Nom du Client\n";
            String output3 = "Numero de Commande\n";

            if (Convert.ToString(cmd3.ExecuteScalar()) == "")
            {
                cmd4.CommandText = "SELECT MAT FROM Product p JOIN Client c ON p.product_id=c.product_id JOIN Modify_Client m ON c.client_id=m.client_id " +
                "WHERE c.client_name = '" + data + "' OR MAT = '" + data + "';";

                cmd5.CommandText = "SELECT client_name FROM Product p JOIN Client c ON p.product_id=c.product_id JOIN Modify_Client m ON c.client_id=m.client_id " +
                "WHERE c.client_name = '" + data + "' OR MAT = '" + data + "';";

                SqlDataReader dr1 = cmd4.ExecuteReader();
                if (dr1.HasRows)
                {
                    while (dr1.Read())
                    {
                        output1 += dr1.GetString(0) + "\n";
                    }
                }
                dr1.Close();

                SqlDataReader dr2 = cmd5.ExecuteReader();
                if (dr2.HasRows)
                {
                    while (dr2.Read())
                    {
                        output2 += dr2.GetString(0) + "\n";
                    }
                }
                dr2.Close();
            }
            else
            {
                SqlDataReader dr1 = cmd1.ExecuteReader();
                if (dr1.HasRows)
                {
                    while (dr1.Read())
                    {
                        output1 += dr1.GetString(0) + "\n";
                    }
                }
                dr1.Close();

                SqlDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.HasRows)
                {
                    while (dr2.Read())
                    {
                        output2 += dr2.GetString(0) + "\n";
                    }
                }
                dr2.Close();

                SqlDataReader dr3 = cmd3.ExecuteReader();
                if (dr3.HasRows)
                {
                    while (dr3.Read())
                    {
                        output3 += dr3.GetString(0) + "\n";
                    }
                }
                dr3.Close();
            }

            resultBox.Text = output1;
            nameRichTextBox.Text = output2;
            orderNumRichTextBox.Text = output3;

            con.Close();

            this.Refresh();
        }

        //take client info, + modify client info
        private void viewBtn_Click(object sender, EventArgs e)
        {
            String input = MATsearchBar.Text;
            con.Open();
            SqlCommand cmd4 = con.CreateCommand();
            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText = "SELECT Client.client_id FROM Client JOIN Product ON Client.product_id=Product.product_id WHERE MAT = '" + input + "';";

            if(Convert.ToString(cmd4.ExecuteScalar()) == "")
            {
                DialogResult dialog = MessageBox.Show("Le MAT rentrer n'est pas valide", "Mise en garde", MessageBoxButtons.OK);
            }
            else
            {
                string empName = empNameTextView.Text;
                this.Hide();
                ViewSearchedForm viewFormInstance = new ViewSearchedForm(input, empName);
                viewFormInstance.ShowDialog();
                this.Close();
            }

        }

        //Navigation
        private void confirmation()
        {
            if (isAddRadioBtnClicked == true)
            {
                    this.Hide();
                    String empName = empNameTextView.Text;
                    AddForm addForm = new AddForm(empName);
                    addForm.ShowDialog();
                    this.Close();
            }
            else if (isModifyRadioBtnClicked == true)
            {
                    this.Hide();
                    String empName = empNameTextView.Text;
                    ModifyForm modifyForm = new ModifyForm(empName);
                    modifyForm.ShowDialog();
                    this.Close();
            }
            else if (isAdminRadioBtnClicked == true)
            {
                    this.Hide();
                    String empName = empNameTextView.Text;
                    AdminPage adminForm = new AdminPage(empName);
                    adminForm.ShowDialog();
                    this.Close();
            }
        }

        private void resolveRadioBtn_Click(object sender, EventArgs e)
        {
            resolveRadioBtn.Checked = true;
            Filter();
        }

        private void ongoingRadioBtn_Click(object sender, EventArgs e)
        {
            ongoingRadioBtn.Checked = true;
            Filter();
        }

        private void unresolvedRadioBtn_Click(object sender, EventArgs e)
        {
            unresolvedRadioBtn.Checked = true;
            Filter();
        }

        public void Filter()
        {
            con.Open();

            //make commands
            SqlCommand cmd4 = con.CreateCommand();
            SqlCommand cmd5 = con.CreateCommand();
            SqlCommand cmd6 = con.CreateCommand();

            cmd4.CommandType = CommandType.Text;
            cmd5.CommandType = CommandType.Text;
            cmd6.CommandType = CommandType.Text;

            String output1 = "MAT\n";
            String output2 = "Nom du Client\n";
            String output3 = "Numero de Commande\n";

            if (resolveRadioBtn.Checked == true)
            {

                //get the values for from the search bar
                //cmd1.CommandText = "SELECT MAT, client_name, order_num FROM Product p JOIN Client c ON p.product_id=c.product_id JOIN Modify_Client m ON c.client_id=m.client_id " +
                //    "WHERE c.client_name = '" + data + "' OR MAT = '" + data + "' OR order_num = '" + data + "';";
                cmd4.CommandText = "SELECT MAT FROM Product p JOIN Client c ON p.product_id=c.product_id JOIN Modify_Client m ON c.client_id=m.client_id " +
                    "WHERE m.is_solved = 1;";
                cmd5.CommandText = "SELECT client_name FROM Product p JOIN Client c ON p.product_id=c.product_id JOIN Modify_Client m ON c.client_id=m.client_id " +
                    "WHERE m.is_solved = 1;";
                cmd6.CommandText = "SELECT order_num FROM Product p JOIN Client c ON p.product_id=c.product_id JOIN Modify_Client m ON c.client_id=m.client_id " +
                    "WHERE m.is_solved = 1;";

                SqlDataReader dr1 = cmd4.ExecuteReader();
                if (dr1.HasRows)
                {
                    while (dr1.Read())
                    {
                        output1 += dr1.GetString(0) + "\n";
                    }
                }
                dr1.Close();

                SqlDataReader dr2 = cmd5.ExecuteReader();
                if (dr2.HasRows)
                {
                    while (dr2.Read())
                    {
                        output2 += dr2.GetString(0) + "\n";
                    }
                }
                dr2.Close();

                SqlDataReader dr3 = cmd6.ExecuteReader();
                if (dr3.HasRows)
                {
                    while (dr3.Read())
                    {
                        output3 += dr3.GetString(0) + "\n";
                    }
                }
                dr3.Close();

                resultBox.Text = output1;
                nameRichTextBox.Text = output2;
                orderNumRichTextBox.Text = output3;

            }
            else if(ongoingRadioBtn.Checked == true)
            {

                //get the values for from the search bar
                //cmd1.CommandText = "SELECT MAT, client_name, order_num FROM Product p JOIN Client c ON p.product_id=c.product_id JOIN Modify_Client m ON c.client_id=m.client_id " +
                //    "WHERE c.client_name = '" + data + "' OR MAT = '" + data + "' OR order_num = '" + data + "';";
                cmd4.CommandText = "SELECT MAT FROM Product p JOIN Client c ON p.product_id=c.product_id JOIN Modify_Client m ON c.client_id=m.client_id " +
                    "WHERE m.is_ongoing = 1;";
                cmd5.CommandText = "SELECT client_name FROM Product p JOIN Client c ON p.product_id=c.product_id JOIN Modify_Client m ON c.client_id=m.client_id " +
                    "WHERE m.is_ongoing = 1;";
                cmd6.CommandText = "SELECT order_num FROM Product p JOIN Client c ON p.product_id=c.product_id JOIN Modify_Client m ON c.client_id=m.client_id " +
                    "WHERE m.is_ongoing = 1;";

                SqlDataReader dr1 = cmd4.ExecuteReader();
                if (dr1.HasRows)
                {
                    while (dr1.Read())
                    {
                        output1 += dr1.GetString(0) + "\n";
                    }
                }
                dr1.Close();

                SqlDataReader dr2 = cmd5.ExecuteReader();
                if (dr2.HasRows)
                {
                    while (dr2.Read())
                    {
                        output2 += dr2.GetString(0) + "\n";
                    }
                }
                dr2.Close();

                SqlDataReader dr3 = cmd6.ExecuteReader();
                if (dr3.HasRows)
                {
                    while (dr3.Read())
                    {
                        output3 += dr3.GetString(0) + "\n";
                    }
                }
                dr3.Close();

                resultBox.Text = output1;
                nameRichTextBox.Text = output2;
                orderNumRichTextBox.Text = output3;

            }
            else if(unresolvedRadioBtn.Checked == true)
            {

                //get the values for from the search bar
                //cmd1.CommandText = "SELECT MAT, client_name, order_num FROM Product p JOIN Client c ON p.product_id=c.product_id JOIN Modify_Client m ON c.client_id=m.client_id " +
                //    "WHERE c.client_name = '" + data + "' OR MAT = '" + data + "' OR order_num = '" + data + "';";
                cmd4.CommandText = "SELECT MAT FROM Product p JOIN Client c ON p.product_id=c.product_id JOIN Modify_Client m ON c.client_id=m.client_id " +
                    "WHERE m.is_unsolved = 1;";
                cmd5.CommandText = "SELECT client_name FROM Product p JOIN Client c ON p.product_id=c.product_id JOIN Modify_Client m ON c.client_id=m.client_id " +
                    "WHERE m.is_unsolved = 1;";
                cmd6.CommandText = "SELECT order_num FROM Product p JOIN Client c ON p.product_id=c.product_id JOIN Modify_Client m ON c.client_id=m.client_id " +
                    "WHERE m.is_unsolved = 1;";

                SqlDataReader dr1 = cmd4.ExecuteReader();
                if (dr1.HasRows)
                {
                    while (dr1.Read())
                    {
                        output1 += dr1.GetString(0) + "\n";
                    }
                }
                dr1.Close();

                SqlDataReader dr2 = cmd5.ExecuteReader();
                if (dr2.HasRows)
                {
                    while (dr2.Read())
                    {
                        output2 += dr2.GetString(0) + "\n";
                    }
                }
                dr2.Close();

                SqlDataReader dr3 = cmd6.ExecuteReader();
                if (dr3.HasRows)
                {
                    while (dr3.Read())
                    {
                        output3 += dr3.GetString(0) + "\n";
                    }
                }
                dr3.Close();

                resultBox.Text = output1;
                nameRichTextBox.Text = output2;
                orderNumRichTextBox.Text = output3;

            }
            con.Close();

            this.Refresh();
        }

        private void searchbar_MouseClick(object sender, MouseEventArgs e)
        {
            if (searchbar.Text == "Enter nom du cliente, MAT, ou nom du commande")
            {
                searchbar.Text = "";
            }
            searchbar.ForeColor = Color.Black;
        }

        private void MATsearchBar_MouseClick(object sender, MouseEventArgs e)
        {
            if (MATsearchBar.Text == "Enter MAT")
            {
                MATsearchBar.Text = "MAT-";
            }
            MATsearchBar.ForeColor = Color.Black;
        }

        private void MATsearchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (MATsearchBar.Text == "Enter MAT")
            {
                MATsearchBar.Text = "MAT-";
            }
            MATsearchBar.ForeColor = Color.Black;
        }

        private void searchbar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (searchbar.Text == "Enter nom du cliente, MAT, ou nom du commande")
            {
                searchbar.Text = "";
            }
            searchbar.ForeColor = Color.Black;
        }
    }
}

