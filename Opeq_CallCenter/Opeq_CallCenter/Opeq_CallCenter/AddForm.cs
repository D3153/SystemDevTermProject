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
    public partial class AddForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-KFOB4HEQ\DINAL;Initial Catalog=Opeq_CallCenter;Integrated Security=True");

        Boolean isAddBtnClicked;
        Boolean isCancelBtnClicked;

        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd1 = con.CreateCommand();
            SqlCommand cmd2 = con.CreateCommand();
            SqlCommand cmd3 = con.CreateCommand();
            SqlCommand cmd4 = con.CreateCommand();

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
            computerProblemComboBox.DisplayMember = "comp_desc"; 
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

        private void nameTextBox_MouseClick(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "Entrer nom du client")
            {
                nameTextBox.Text = "";
            }
            nameTextBox.ForeColor = Color.Black;
        }

        private void problemDescriptionTextBox_MouseClick(object sender, EventArgs e)
        {
            if (problemDescriptionTextBox.Text == "Entrer problème")
            {
                problemDescriptionTextBox.Text = "";
            }
            problemDescriptionTextBox.ForeColor = Color.Black;
        }

        private void emailTextbox_MouseClick(object sender, EventArgs e)
        {
            if (emailTextbox.Text == "Courriel")
            {
                emailTextbox.Text = "";
            }
            emailTextbox.ForeColor = Color.Black;
        }

        private void phoneTextBox_MouseClick(object sender, EventArgs e)
        {
            if (phoneTextBox.Text == "Téléphone")
            {
                phoneTextBox.Text = "";
            }
            phoneTextBox.ForeColor = Color.Black;
        }

        private void streetTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (streetTextBox.Text == "Adresse")
            {
                streetTextBox.Text = "";
            }
            streetTextBox.ForeColor = Color.Black;
        }

        private void aptNumTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (aptNumTextBox.Text == "Appartement, suite, ect.")
            {
                aptNumTextBox.Text = "";
            }
            aptNumTextBox.ForeColor = Color.Black;
        }

        private void cityTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (cityTextBox.Text == "Ville")
            {
                cityTextBox.Text = "";
            }
            cityTextBox.ForeColor = Color.Black;
        }

        private void postalCodeTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (postalCodeTextBox.Text == "Code Postal")
            {
                postalCodeTextBox.Text = "";
            }
            postalCodeTextBox.ForeColor = Color.Black;
        }

        private void MATTextBox_MouseClick(object sender, EventArgs e)
        {
            if (MATTextBox.Text == "MAT")
            {
                MATTextBox.Text = "";
            }
            MATTextBox.ForeColor = Color.Black;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != " " && problemDescriptionTextBox.Text != " " && emailTextbox.Text != " " && MATTextBox.Text != " ")
            {
                //IDK if this will work
                string empID;
                string clientName = nameTextBox.Text;
                string problemDesc = problemDescriptionTextBox.Text;
                string email = emailTextbox.Text;
                string phone = phoneTextBox.Text;
                string date = dateTimePicker.Value.ToString();

                //IDK how to get addressId from address table
                string addressID;

                
                string street = streetTextBox.Text;
                string aptNum = aptNumTextBox.Text;
                string city = cityTextBox.Text;
                string postalCode = postalCodeTextBox.Text;

                string productName = " ";

                string mat = MATTextBox.Text;

                //Same problem as addressID
                int computerProbID = computerProblemComboBox.SelectedIndex;
                int laptopProbID = laptopProblemComboBox.SelectedIndex;
                int screenProbID = screenProblemComboBox.SelectedIndex;
                int phoneTabProbID = phoneOrTabletProblemComboBox.SelectedIndex;

                string byEmail = "0";
                string byTelephone = "0";
                string inPerson = "0";

                if(computerProbID > 0)
                {
                    productName = "Computer";
                }
                else if(laptopProbID > 0)
                {
                    productName = "Laptop";
                }
                else if (screenProbID > 0)
                {
                    productName = "Screen";
                }
                else if (phoneTabProbID > 0)
                {
                    productName = "Phone and Tablet";
                }
                else if (computerProbID == 0 && laptopProbID == 0 && screenProbID == 0 && phoneTabProbID == 0)
                {
                    MessageBox.Show("Fuck you and fill it out");
                }

                    //var problems = problemGroupBox;
                    //foreach (var comboBox in problems.Controls))
                    //{
                    //    computerProbID = computerProblemComboBox.Select ? "1" : "0";
                    //    laptopProbID = phoneRadioBtn.Checked ? "1" : "0";
                    //    screenProbID = inPersonRadioBtn.Checked ? "1" : "0";
                    //    phoneTabProbID = inPersonRadioBtn.Checked ? "1" : "0";
                    //}

                    var contacts = contactGroupBox;
                foreach (var radioButton in contacts.Controls.OfType<RadioButton>())
                {
                    byEmail = emailRadioBtn.Checked ? "1" : "0";
                    byTelephone = phoneRadioBtn.Checked ? "1" : "0";
                    inPerson = inPersonRadioBtn.Checked ? "1" : "0";
                }

                /*
                var ctrl3 = containerGroupBox;
                foreach (var radioButton in ctrl3.Controls.OfType<RadioButton>())
                {
                    Total = radioButton.Checked ? (Total + Convert.ToDouble(radioButton.Tag)) : Total;
                }*/


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

                cmd1.CommandText = "INSERT INTO address (street, apt_num, city, postal_code) VALUES ('" + street + "', '" +
                                                             aptNum + "', '" + city + "','" + postalCode + "');";

                cmd1.ExecuteNonQuery();

                cmd2.CommandText = "SELECT IDENT_CURRENT('Employee');";
                empID = Convert.ToString(cmd2.ExecuteScalar());

                cmd3.CommandText = "SELECT IDENT_CURRENT('Addresss');";
                addressID = Convert.ToString(cmd3.ExecuteScalar());

                cmd4.CommandText = "INSERT INTO product VALUES ('" + productName + "');";
                cmd4.ExecuteNonQuery();

                cmd5.CommandText = "SELECT IDENT_CURRENT('Product');";
                 mat = Convert.ToString(cmd5.ExecuteScalar());

                cmd6.CommandText = "INSERT INTO client (employee_id, MAT, computer_prob_id, laptop_prob_id, screen_prob_id, phone_tablet_prob_id, address_id, client_name, client_desc, date, client_email, client_phone_num, by_email, by_telephone, in_person) VALUES ('" +
                                   empID + "', '" + mat + "', '" + computerProbID + "', '" + laptopProbID + "', '" + screenProbID + "', '" + phoneTabProbID + "', '" + addressID + "', '" + clientName + "', '" + problemDesc + "', '" + date + "', '" + email + "', '" + phone + "', '" + byEmail + "', '" + byTelephone + "', '" + inPerson + "');";

                cmd4.ExecuteNonQuery();

                con.Close();

                isAddBtnClicked = true;
                confirmation();
                
            }
            else
            {
                MessageBox.Show("Les champs de texte ne peuvent pas être vides");
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            isCancelBtnClicked = true;
            confirmation();
        }

        private void confirmation()
        {
            if (isAddBtnClicked == true)
            {
                DialogResult dialog = MessageBox.Show("Les donnés que vous avez rentrées vont être sauvegardés." +
                    "\nModifier un autre client?", "Mise en garde", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    //This might break the app or not so test with caution
                    this.Hide();
                    AddForm addForm = new AddForm();
                    addForm.ShowDialog();
                    this.Close();
                    //Alternate solution: create a Form for the confirmation 
                }
                else if (dialog == DialogResult.No)
                {
                    //Redirect to Main hub but it does not exist XD
                }
            }
            else if (isCancelBtnClicked == true)
            {
                DialogResult dialog = MessageBox.Show("Les donnés que vous avez rentrées ne vont pas être sauvegardés." +
                    "\nÊtes-vous sur d’annuler?", "Mise en garde", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    //Also redirect to Main hub
                }
                else if (dialog == DialogResult.No)
                {
                    //IDK how to go back to the page that still has the values in the textBox
                    //Alternate solution: create a Form for the confirmation 
                }
            }
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
