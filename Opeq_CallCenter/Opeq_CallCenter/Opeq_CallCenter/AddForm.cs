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
            //IDK if this works and pls check the names of the tables, IDs and Descriptions
            //I will put a "*" on the ones that are needed to be checked
            //-> I changed them I did not test if the database works yet
            
            con.Open();

            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Computer_Prob"); 
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Laptop_Prob"); 
            SqlCommand cmd3 = new SqlCommand("SELECT * FROM Screen_Prob"); 
            SqlCommand cmd4 = new SqlCommand("SELECT * FROM Phone_Tablet_Prob"); 

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

            cmd1.ExecuteReader();
            cmd2.ExecuteReader();
            cmd3.ExecuteReader();
            cmd4.ExecuteReader();

            con.Close();

            computerProblemComboBox.DataSource = dataSet1.Tables[0];
            computerProblemComboBox.DisplayMember = "comp_desc"; 
            computerProblemComboBox.ValueMember = "computer_prob_id";

            laptopProblemComboBox.DataSource = dataSet2.Tables[0];
            laptopProblemComboBox.DisplayMember = "laptop_desc";
            laptopProblemComboBox.ValueMember = "laptop_prob_id";

            screenProblemComboBox.DataSource = dataSet3.Tables[0];
            screenProblemComboBox.DisplayMember = "screen_desc"; 
            screenProblemComboBox.ValueMember = "screen_prob_id"; 

            phoneOrTabletProblemComboBox.DataSource = dataSet4.Tables[0];
            phoneOrTabletProblemComboBox.DisplayMember = "phone_tab_desc"; 
            phoneOrTabletProblemComboBox.ValueMember = "phone_tablet_prob_id"; 
            
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

                /*
                string street = streetTextBox.Text;
                string aptNum = aptNumTextBox.Text;
                string city = cityTextBox.Text;
                string province = provinceTextBox.Text;
                string postalCode = postalCodeTextBox.Text;
                */

                string mat = MATTextBox.Text;

                //Same problem as addressID
                string computerProbID = computerProblemComboBox.SelectedItem.ToString();
                string laptopProbID = computerProblemComboBox.SelectedItem.ToString();
                string screenProbID = computerProblemComboBox.SelectedItem.ToString();
                string phoneTabProbID = computerProblemComboBox.SelectedItem.ToString();

                string byEmail;
                string byTelephone;
                string inPerson;

                //This could be changed to a Switch case, I think, but I forgot how to do it. Sorry :(
                if (emailRadioBtn.Checked)
                {
                    byEmail = "1";
                    byTelephone = "0";
                    inPerson = "0";
                }
                else if (phoneRadioBtn.Checked)
                {
                    byEmail = "0";
                    byTelephone = "1";
                    inPerson = "0";
                }
                else if (inPersonRadioBtn.Checked)
                {
                    byEmail = "0";
                    byTelephone = "0";
                    inPerson = "1";
                }
                else
                {
                    MessageBox.Show("La section 'Comment Contacter' ne peut pas être vide");
                }

                /*
                con.Open();
                SqlCommand cmd1 = con.CreateCommand();
                SqlCommand cmd2 = con.CreateCommand();
                SqlCommand cmd3 = con.CreateCommand();
                SqlCommand cmd4 = con.CreateCommand();

                cmd1.CommandType = CommandType.Text;
                cmd2.CommandType = CommandType.Text;
                cmd3.CommandType = CommandType.Text;
                cmd4.CommandType = CommandType.Text;

                cmd1.CommandText = "INSERT INTO address (street, apt_num, city, province, postal_code) VALUES ('" + street + "', '" +
                                                             aptNum + "', '" + city + "', '" + province + "', '" + postalCode + "');";

                cmd1.ExecuteNonQuery();

                cmd2.CommandText = "SELECT IDENT_CURRENT('Employee');";
                empID = Convert.ToString(cmd2.ExecuteScalar());

                cmd3.CommandText = "SELECT IDENT_CURRENT('Addresss');";
                addressID = Convert.ToString(cmd3.ExecuteScalar());

                cmd4.CommandText = "INSERT INTO client (employee_id, MAT, computer_prob_id, laptop_prob_id, screen_prob_id, phone_tablet_prob_id, 
                                                         address_id, client_name, client_desc, date, client_email, client_phone_num, by_email, by_telephone, in_person) 
                                     VALUES ('" + empID + "', '" + mat + "', '" + computerProbID + "', '" + laptopProbID + "', '" + screenProbID + "', '" + phoneTabProbID + "', '" + 
                                                 addressID + "', '" + clientName + "', '" + problemDesc + "', '" + date + "', '" + email + "', '" + phone + "', '" + byEmail + "', '" + 
                                                 byTelephone + "', '" + inPerson + "');";
                cmd4.ExecuteNonQuery();

                con.Close();
                */

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
