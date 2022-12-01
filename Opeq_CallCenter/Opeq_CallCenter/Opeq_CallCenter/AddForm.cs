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
        Boolean isModifyRadioBtnClicked;
        Boolean isViewRadioBtnClicked;

        public AddForm()
        {
            InitializeComponent();
            nameTextBox.Focus();

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

        private void nameTextBox_MouseClick(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "Entrer nom")
            {
                nameTextBox.Text = "";
            }
            nameTextBox.ForeColor = Color.Black;
        }
        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Tab)
            {
                if (nameTextBox.Text == "Entrer nom")
                {
                    nameTextBox.Text = "";
                }
                nameTextBox.ForeColor = Color.Black;
            }
        }

        private void problemDescriptionTextBox_MouseClick(object sender, EventArgs e)
        {
            if (problemDescriptionTextBox.Text == "Entrer problème")
            {
                problemDescriptionTextBox.Text = "";
            }
            problemDescriptionTextBox.ForeColor = Color.Black;
        }
        private void problemDescriptionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Tab)
            {
                if (problemDescriptionTextBox.Text == "Entrer problème")
                {
                    problemDescriptionTextBox.Text = "";
                }
                problemDescriptionTextBox.ForeColor = Color.Black;
            }
        }

        private void emailTextbox_MouseClick(object sender, EventArgs e)
        {
            if (emailTextbox.Text == "Courriel")
            {
                emailTextbox.Text = "";
            }
            emailTextbox.ForeColor = Color.Black;
        }
        private void emailTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Tab)
            {
                if (emailTextbox.Text == "Courriel")
                {
                    emailTextbox.Text = "";
                }
                emailTextbox.ForeColor = Color.Black;
            }
        }

        private void phoneTextBox_MouseClick(object sender, EventArgs e)
        {
            if (phoneTextBox.Text == "Téléphone")
            {
                phoneTextBox.Text = "";
            }
            phoneTextBox.ForeColor = Color.Black;
        }
        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Tab)
            {
                if (phoneTextBox.Text == "Téléphone")
                {
                    phoneTextBox.Text = "";
                }
                phoneTextBox.ForeColor = Color.Black;
            }
        }

        private void streetTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (streetTextBox.Text == "Adresse")
            {
                streetTextBox.Text = "";
            }
            streetTextBox.ForeColor = Color.Black;
        }
        private void streetTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Tab)
            {
                if (streetTextBox.Text == "Adresse")
                {
                    streetTextBox.Text = "";
                }
                streetTextBox.ForeColor = Color.Black;
            }
        }

        private void aptNumTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (aptNumTextBox.Text == "Appartement, suite, ect.")
            {
                aptNumTextBox.Text = "";
            }
            aptNumTextBox.ForeColor = Color.Black;
        }
        private void aptNumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Tab)
            {
                if (aptNumTextBox.Text == "Appartement, suite, ect.")
                {
                    aptNumTextBox.Text = "";
                }
                aptNumTextBox.ForeColor = Color.Black;
            }
        }

        private void cityTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (cityTextBox.Text == "Ville")
            {
                cityTextBox.Text = "";
            }
            cityTextBox.ForeColor = Color.Black;
        }
        private void cityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Tab)
            {
                if (cityTextBox.Text == "Ville")
                {
                    cityTextBox.Text = "";
                }
                cityTextBox.ForeColor = Color.Black;
            }
        }

        private void postalCodeTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (postalCodeTextBox.Text == "Code Postal")
            {
                postalCodeTextBox.Text = "";
            }
            postalCodeTextBox.ForeColor = Color.Black;
        }
        private void postalCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Tab)
            {
                if (postalCodeTextBox.Text == "Code Postal")
                {
                    postalCodeTextBox.Text = "";
                }
                postalCodeTextBox.ForeColor = Color.Black;
            }
        }

        private void MATTextBox_MouseClick(object sender, EventArgs e)
        {
            if (MATTextBox.Text == "MAT")
            {
                MATTextBox.Text = "MAT-";
            }
            MATTextBox.ForeColor = Color.Black;
        }
        private void MATTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Tab)
            {
                if (MATTextBox.Text == "MAT")
                {
                    MATTextBox.Text = "MAT-";
                }
                MATTextBox.ForeColor = Color.Black;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && nameTextBox.Text != "Entrer nom" && problemDescriptionTextBox.Text != "" && problemDescriptionTextBox.Text != "Entrer problème" && emailTextbox.Text != "" && emailTextbox.Text != "Courriel" &&
                streetTextBox.Text != "" && streetTextBox.Text != "Adresse" && aptNumTextBox.Text != "" && aptNumTextBox.Text != "Appartement, suite, ect." && cityTextBox.Text != "" && cityTextBox.Text != "Ville" &&
                postalCodeTextBox.Text != "" && postalCodeTextBox.Text != "Code Postal" && MATTextBox.Text != "" && MATTextBox.Text != "MAT" && MATTextBox.Text != "MAT-")
            {
                //IDK if this will work
                string empID;
                string clientName = nameTextBox.Text;
                string problemDesc = problemDescriptionTextBox.Text;
                string email = emailTextbox.Text;
                string phone = phoneTextBox.Text;
                string date = dateTimePicker.Value.ToString();

                //IDK how to get addressId from address table
                string addressID = " ";

                
                string street = streetTextBox.Text;
                string aptNum = aptNumTextBox.Text;
                string city = cityTextBox.Text;
                string postalCode = postalCodeTextBox.Text;

                string productName = " ";

                string productID = " ";
                string mat = MATTextBox.Text;

                string computerProbDesc = computerProblemComboBox.GetItemText(computerProblemComboBox.SelectedItem);
                string laptopProbDesc = laptopProblemComboBox.GetItemText(laptopProblemComboBox.SelectedItem);
                string screenProbDesc = screenProblemComboBox.GetItemText(screenProblemComboBox.SelectedItem);
                string phoneTabProbDesc = phoneOrTabletProblemComboBox.GetItemText(phoneOrTabletProblemComboBox.SelectedItem);

                string computerProbID = " ";
                string laptopProbID = " ";
                string screenProbID = " ";
                string phoneTabProbID = " ";

                string byEmail = "0";
                string byTelephone = "0";
                string inPerson = "0";

                    var contacts = contactGroupBox;
                foreach (var radioButton in contacts.Controls.OfType<RadioButton>())
                {
                    byEmail = emailRadioBtn.Checked ? "1" : "0";
                    byTelephone = phoneRadioBtn.Checked ? "1" : "0";
                    inPerson = inPersonRadioBtn.Checked ? "1" : "0";
                }

                con.Open();

                SqlCommand cmd1 = con.CreateCommand();
                SqlCommand cmd2 = con.CreateCommand();
                SqlCommand cmd3 = con.CreateCommand();
                SqlCommand cmd4 = con.CreateCommand();
                SqlCommand cmd5 = con.CreateCommand();
                SqlCommand cmd6 = con.CreateCommand();
                SqlCommand cmd7 = con.CreateCommand();
                SqlCommand cmd8 = con.CreateCommand();
                SqlCommand cmd9 = con.CreateCommand();
                SqlCommand cmd10 = con.CreateCommand();


                cmd1.CommandType = CommandType.Text;
                cmd2.CommandType = CommandType.Text;
                cmd3.CommandType = CommandType.Text;
                cmd4.CommandType = CommandType.Text;
                cmd5.CommandType = CommandType.Text;
                cmd6.CommandType = CommandType.Text;
                cmd7.CommandType = CommandType.Text;
                cmd8.CommandType = CommandType.Text;
                cmd9.CommandType = CommandType.Text;
                cmd10.CommandType = CommandType.Text;

                cmd1.CommandText = "INSERT INTO Client_Address (street, apt_num, city, postal_code) VALUES ('" + street + "', '" +
                                                             aptNum + "', '" + city + "','" + postalCode + "');";

                cmd1.ExecuteNonQuery();

                cmd2.CommandText = "SELECT IDENT_CURRENT('Employee');";
                empID = Convert.ToString(cmd2.ExecuteScalar());

                cmd3.CommandText = "SELECT IDENT_CURRENT('Client_Address');";
                addressID = Convert.ToString(cmd3.ExecuteScalar());

                cmd4.CommandText = "INSERT INTO Product (MAT, product_name) VALUES ('" + mat + "', '" + productName + "');";
                cmd4.ExecuteNonQuery();

                cmd5.CommandText = "SELECT IDENT_CURRENT('Product');";
                productID = Convert.ToString(cmd5.ExecuteScalar());

                if (computerProbDesc != "")
                {
                    cmd6.CommandText = "SELECT computer_prob_id FROM Computer_Prob WHERE computer_desc = '" + computerProbDesc + "';";
                    computerProbID = Convert.ToString(cmd6.ExecuteScalar());
                }
                else if (laptopProbDesc != "")
                {
                    cmd7.CommandText = "SELECT laptop_prob_id FROM Laptop_Prob WHERE laptop_desc = '" + laptopProbDesc + "';";
                    laptopProbID = Convert.ToString(cmd7.ExecuteScalar());
                }
                else if (screenProbDesc != "")
                {
                    cmd8.CommandText = "SELECT screen_prob_id FROM Screen_Prob WHERE screen_desc = '" + screenProbDesc + "';";
                    screenProbID = Convert.ToString(cmd8.ExecuteScalar()); ;
                }
                else if (phoneTabProbDesc != "")
                {
                    cmd9.CommandText = "SELECT phone_tablet_prob_id FROM Phone_tablet_Prob WHERE phone_tab_desc = '" + phoneTabProbDesc + "';";
                    phoneTabProbID = Convert.ToString(cmd9.ExecuteScalar());
                }

                cmd10.CommandText = "INSERT INTO Client (employee_id, product_id, computer_prob_id, laptop_prob_id, screen_prob_id, phone_tablet_prob_id, address_id, client_name, client_desc, date_added, client_email, client_phone_num, by_email, by_telephone, in_person) VALUES ('" +
                                       empID + "', '" + productID + "', '" + computerProbID + "', '" + laptopProbID + "', '" + screenProbID + "', '" + phoneTabProbID + "', '" + addressID + "', '" + clientName + "', '" + problemDesc + "', '" + date + "', '" + email + "', '" + phone + "', '" + byEmail + "', '" + byTelephone + "', '" + inPerson + "');";

                cmd10.ExecuteNonQuery();

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
                    this.Hide();
                    MainHub mainHub = new MainHub();
                    mainHub.ShowDialog();
                    this.Close();
                }
            }
            else if (isCancelBtnClicked == true)
            {
                DialogResult dialog = MessageBox.Show("Les donnés que vous avez rentrées ne vont pas être sauvegardés." +
                    "\nÊtes-vous sur d’annuler?", "Mise en garde", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    this.Hide();
                    MainHub mainHub = new MainHub();
                    mainHub.ShowDialog();
                    this.Close();
                }
                else if (dialog == DialogResult.No)
                {
                    isCancelBtnClicked = false;
                }
            }
            else if (isModifyRadioBtnClicked == true)
            {
                DialogResult dialog = MessageBox.Show("Les donnés que vous avez rentrées ne vont pas être sauvegardés." +
                    "\nÊtes-vous sur d’annuler?", "Mise en garde", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    this.Hide();
                    ModifyForm modifyForm = new ModifyForm();
                    modifyForm.ShowDialog();
                    this.Close();
                }
                else if (dialog == DialogResult.No)
                {
                    isModifyRadioBtnClicked = false;
                }
            }
            else if (isViewRadioBtnClicked == true)
            {
                DialogResult dialog = MessageBox.Show("Les donnés que vous avez rentrées ne vont pas être sauvegardés." +
                    "\nÊtes-vous sur d’annuler?", "Mise en garde", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    this.Hide();
                    ViewForm viewForm = new ViewForm();
                    viewForm.ShowDialog();
                    this.Close();
                }
                else if (dialog == DialogResult.No)
                {
                    isViewRadioBtnClicked = false;
                }
            }
        }
        private void modifyRadioBtn_MouseClick(object sender, MouseEventArgs e)
        {
            isModifyRadioBtnClicked = true;
            addRadioBtn.Checked = true;
            confirmation();
        }

        private void viewRadioBtn_MouseClick(object sender, MouseEventArgs e)
        {
            isViewRadioBtnClicked = true;
            addRadioBtn.Checked = true;
            confirmation();
        }

        private void computerProblemComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void screenProblemComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void laptopProblemComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void phoneOrTabletProblemComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

    }
}
