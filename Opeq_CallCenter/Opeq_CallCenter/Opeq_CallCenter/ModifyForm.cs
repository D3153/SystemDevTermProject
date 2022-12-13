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
    public partial class ModifyForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-KFOB4HEQ\DINAL;Initial Catalog=Opeq_CallCenter;Integrated Security=True");

        string orderTypeDesc;
        string orderNum;
        string howResolved;
        string actionTookDesc;

        string resolved;
        string notResolved;
        string onGoing;

        string resolvedDate;
        string yes;
        string no;

        string deliveryDate;
        string return_voucher;
        string rma;

        string clientId;
        string actionTookId;
        string orderTypeId;
        string newOrderId;

        public ModifyForm(string empName)
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

        //loading up client dropdown information
        private void ModifyForm_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

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

            //hide eveything before accessing the client
            nameTextBox.Hide();
            label1.Hide();
            label2.Hide();
            problemDescriptionTextBox.Hide();
            label4.Hide();
            dateTimePickerEntered.Hide();
            label3.Hide();
            contactGroupBox.Hide();
            emailTextbox.Hide();
            phoneTextBox.Hide();
            streetTextBox.Hide();
            aptNumTextBox.Hide();
            cityTextBox.Hide();
            postalCodeTextBox.Hide();
            problemGroupBox.Hide();
            label13.Hide();
            orderTypeComboBox.Hide();
            label12.Hide();
            textBox1.Hide();
            label14.Hide();
            textBox2.Hide();
            label15.Hide();
            actionTookComboBox.Hide();
            problemStatusFroupBox.Hide();
            label17.Hide();
            dateTimePicker1.Hide();

            //new order hidden
            orderGroupBox.Hide();
            label19.Hide();
            dateTimePicker2.Hide();
            label20.Hide();
            textBox3.Hide();
            label21.Hide();
            RMATextBox.Hide();

        }

        private void loadData()
        {
            string MAT = MATTextBox.Text;
            con.Open();
            SqlCommand cmd33 = con.CreateCommand();
            cmd33.CommandText = "SELECT MAT FROM Product WHERE MAT= '" + MAT + "';";
            try
            {
                cmd33.ExecuteNonQuery();
                resolved = "0";
                notResolved = "0";
                onGoing = "0";

                resolvedDate = dateTimePicker1.Value.ToString();
                yes = "0";
                no = "0";

                deliveryDate = dateTimePicker2.Value.ToString();
                return_voucher = textBox3.Text;
                rma = RMATextBox.Text;

                clientId = "";
                actionTookId = "";
                orderTypeId = "";
                newOrderId = "";

                //Show everything
                nameTextBox.Show();
                label1.Show();
                label2.Show();
                problemDescriptionTextBox.Show();
                label4.Show();
                dateTimePickerEntered.Show();
                label3.Show();
                contactGroupBox.Show();
                emailTextbox.Show();
                phoneTextBox.Show();
                streetTextBox.Show();
                aptNumTextBox.Show();
                cityTextBox.Show();
                postalCodeTextBox.Show();
                problemGroupBox.Show();
                label13.Show();
                orderTypeComboBox.Show();
                label12.Show();
                textBox1.Show();
                label14.Show();
                textBox2.Show();
                label15.Show();
                actionTookComboBox.Show();
                problemStatusFroupBox.Show();
                label17.Show();
                dateTimePicker1.Show();
                orderGroupBox.Show();

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
                SqlCommand cmd11 = con.CreateCommand();
                SqlCommand cmd12 = con.CreateCommand();
                SqlCommand cmd13 = con.CreateCommand();
                SqlCommand cmd14 = con.CreateCommand();
                SqlCommand cmd15 = con.CreateCommand();
                SqlCommand cmd16 = con.CreateCommand();

                //to load modify table
                SqlCommand cmd18 = con.CreateCommand();
                SqlCommand cmd19 = con.CreateCommand();
                SqlCommand cmd20 = con.CreateCommand();
                SqlCommand cmd21 = con.CreateCommand();
                SqlCommand cmd22 = con.CreateCommand();
                SqlCommand cmd23 = con.CreateCommand();
                SqlCommand cmd24 = con.CreateCommand();
                SqlCommand cmd25 = con.CreateCommand();
                SqlCommand cmd26 = con.CreateCommand();
                SqlCommand cmd27 = con.CreateCommand();
                SqlCommand cmd29 = con.CreateCommand();
                SqlCommand cmd28 = con.CreateCommand();
                SqlCommand cmd30 = con.CreateCommand();


                //SqlDataAdapter adapter5 = new SqlDataAdapter(cmd5);
                //SqlDataAdapter adapter6 = new SqlDataAdapter(cmd6);

                //Commands to run to get client information
                cmd1.CommandText = "SELECT client_name FROM Client FULL OUTER JOIN Product ON Client.product_id=Product.product_id WHERE Product.MAT= '" + MAT + "';";
                cmd2.CommandText = "SELECT client_desc FROM Client FULL OUTER JOIN Product ON Client.product_id=Product.product_id WHERE Product.MAT= '" + MAT + "';";
                cmd3.CommandText = "SELECT date_added FROM Client FULL OUTER JOIN Product ON Client.product_id=Product.product_id WHERE Product.MAT= '" + MAT + "';";
                cmd4.CommandText = "SELECT by_email FROM Client FULL OUTER JOIN Product ON Client.product_id=Product.product_id WHERE Product.MAT= '" + MAT + "';";
                cmd5.CommandText = "SELECT by_telephone FROM Client FULL OUTER JOIN Product ON Client.product_id=Product.product_id WHERE Product.MAT= '" + MAT + "';";
                cmd6.CommandText = "SELECT in_person FROM Client FULL OUTER JOIN Product ON Client.product_id=Product.product_id WHERE Product.MAT= '" + MAT + "';";
                cmd7.CommandText = "SELECT client_email FROM Client FULL OUTER JOIN Product ON Client.product_id=Product.product_id WHERE Product.MAT= '" + MAT + "';";
                cmd8.CommandText = "SELECT client_phone_num FROM Client FULL OUTER JOIN Product ON Client.product_id=Product.product_id WHERE Product.MAT= '" + MAT + "';";
                cmd9.CommandText = "SELECT Client_Address.street FROM Client JOIN Product ON Client.product_id = Product.product_id JOIN Client_Address ON Client_Address.address_id = Client.address_id WHERE Product.MAT = '" + MAT + "';";
                cmd10.CommandText = "SELECT Client_Address.apt_num FROM Client JOIN Product ON Client.product_id = Product.product_id JOIN Client_Address ON Client_Address.address_id = Client.address_id WHERE Product.MAT = '" + MAT + "';";
                cmd11.CommandText = "SELECT Client_Address.city FROM Client JOIN Product ON Client.product_id = Product.product_id JOIN Client_Address ON Client_Address.address_id = Client.address_id WHERE Product.MAT = '" + MAT + "';";
                cmd12.CommandText = "SELECT Client_Address.postal_code FROM Client JOIN Product ON Client.product_id = Product.product_id JOIN Client_Address ON Client_Address.address_id = Client.address_id WHERE Product.MAT = '" + MAT + "';";
                cmd13.CommandText = "SELECT Computer_Prob.computer_prob_id FROM Client JOIN Product ON Client.product_id = Product.product_id JOIN Computer_Prob ON Computer_Prob.computer_prob_id = Client.computer_prob_id WHERE Product.MAT = '" + MAT + "';";
                cmd14.CommandText = "SELECT Laptop_Prob.laptop_prob_id FROM Client JOIN Product ON Client.product_id = Product.product_id JOIN Laptop_Prob ON Laptop_Prob.laptop_prob_id = Client.laptop_prob_id WHERE Product.MAT = '" + MAT + "';";
                cmd15.CommandText = "SELECT Phone_Tablet_Prob.phone_tablet_prob_id FROM Client JOIN Product ON Client.product_id = Product.product_id JOIN Phone_Tablet_Prob ON Phone_Tablet_Prob.phone_tablet_prob_id = Client.phone_tablet_prob_id WHERE Product.MAT = '" + MAT + "';";
                cmd16.CommandText = "SELECT Screen_Prob.screen_prob_id FROM Client JOIN Product ON Client.product_id = Product.product_id JOIN Screen_Prob ON Screen_Prob.screen_prob_id = Client.screen_prob_id WHERE Product.MAT = '" + MAT + "';";
                //modify load
                cmd18.CommandText = "SELECT Modify_Client.modify_id FROM Modify_Client FULL OUTER JOIN Client ON Modify_Client.client_id=Client.client_id LEFT JOIN PRODUCT ON Client.product_id=Product.product_id WHERE MAT = '" + MAT + "';";
                cmd19.CommandText = "SELECT Order_Type.order_type_id FROM Order_Type JOIN Modify_Client ON Order_Type.order_type_id =Modify_Client.order_type_id JOIN Client ON Client.client_id=Modify_Client.client_id JOIN Product ON Product.product_id=Client.product_id WHERE MAT = '" + MAT + "';";
                cmd20.CommandText = "SELECT Modify_Client.order_num FROM Modify_Client FULL OUTER JOIN Client ON Modify_Client.client_id=Client.client_id LEFT JOIN PRODUCT ON Client.product_id=Product.product_id WHERE MAT = '" + MAT + "';";
                cmd21.CommandText = "SELECT Modify_Client.how_solved FROM Modify_Client FULL OUTER JOIN Client ON Modify_Client.client_id=Client.client_id LEFT JOIN PRODUCT ON Client.product_id=Product.product_id WHERE MAT = '" + MAT + "';";
                cmd22.CommandText = "SELECT Action_Took.action_took_id FROM Action_Took JOIN Modify_Client ON Action_Took.action_took_id=Modify_Client.order_type_id JOIN Client ON Client.client_id=Modify_Client.client_id JOIN Product ON Product.product_id=Client.product_id WHERE MAT = '" + MAT + "';";
                cmd23.CommandText = "SELECT Modify_Client.is_solved FROM Modify_Client FULL OUTER JOIN Client ON Modify_Client.client_id=Client.client_id LEFT JOIN PRODUCT ON Client.product_id=Product.product_id WHERE MAT = '" + MAT + "';";
                cmd24.CommandText = "SELECT Modify_Client.is_unsolved FROM Modify_Client FULL OUTER JOIN Client ON Modify_Client.client_id=Client.client_id LEFT JOIN PRODUCT ON Client.product_id=Product.product_id WHERE MAT = '" + MAT + "';";
                cmd25.CommandText = "SELECT Modify_Client.is_ongoing FROM Modify_Client FULL OUTER JOIN Client ON Modify_Client.client_id=Client.client_id LEFT JOIN PRODUCT ON Client.product_id=Product.product_id WHERE MAT = '" + MAT + "';";
                cmd26.CommandText = "SELECT Modify_Client.date_solved FROM Modify_Client FULL OUTER JOIN Client ON Modify_Client.client_id=Client.client_id LEFT JOIN PRODUCT ON Client.product_id=Product.product_id WHERE MAT = '" + MAT + "';";
                cmd27.CommandText = "SELECT Modify_Client.order_id FROM Modify_Client FULL OUTER JOIN Client ON Modify_Client.client_id=Client.client_id LEFT JOIN PRODUCT ON Client.product_id=Product.product_id WHERE MAT = '" + MAT + "';";
                cmd28.CommandText = "SELECT New_Order.RMA FROM New_Order JOIN Modify_Client ON New_Order.order_id=Modify_Client.order_id JOIN Client ON Client.client_id=Modify_Client.client_id JOIN Product ON Product.product_id=Client.product_id WHERE MAT = '" + MAT + "';";
                cmd29.CommandText = "SELECT New_Order.send_date FROM New_Order JOIN Modify_Client ON New_Order.order_id=Modify_Client.order_id JOIN Client ON Client.client_id=Modify_Client.client_id JOIN Product ON Product.product_id=Client.product_id WHERE MAT = '" + MAT + "';";
                cmd30.CommandText = "SELECT New_Order.return_voucher FROM New_Order JOIN Modify_Client ON New_Order.order_id=Modify_Client.order_id JOIN Client ON Client.client_id=Modify_Client.client_id JOIN Product ON Product.product_id=Client.product_id WHERE MAT = '" + MAT + "';";


                //Commands to populate dropdowns
                SqlCommand cmd17 = con.CreateCommand();
                SqlCommand cmd31 = con.CreateCommand();
                SqlCommand cmd32 = con.CreateCommand();

                cmd17.CommandType = CommandType.Text;
                cmd31.CommandType = CommandType.Text;
                cmd32.CommandType = CommandType.Text;

                //Setting texts for the client
                nameTextBox.Text = Convert.ToString(cmd1.ExecuteScalar());
                problemDescriptionTextBox.Text = Convert.ToString(cmd2.ExecuteScalar());
                dateTimePickerEntered.Value = Convert.ToDateTime(cmd3.ExecuteScalar());

                if (Convert.ToInt64(cmd4.ExecuteScalar()) == 1)
                {
                    emailRadioBtn.Checked = true;
                }
                else if (Convert.ToInt64(cmd5.ExecuteScalar()) == 1)
                {
                    phoneRadioBtn.Checked = true;
                }
                else if (Convert.ToInt64(cmd6.ExecuteScalar()) == 1)
                {
                    inPersonRadioBtn.Checked = true;
                }

                emailTextbox.Text = Convert.ToString(cmd7.ExecuteScalar());
                phoneTextBox.Text = Convert.ToString(cmd8.ExecuteScalar());
                streetTextBox.Text = Convert.ToString(cmd9.ExecuteScalar());
                aptNumTextBox.Text = Convert.ToString(cmd10.ExecuteScalar());
                cityTextBox.Text = Convert.ToString(cmd11.ExecuteScalar());
                postalCodeTextBox.Text = Convert.ToString(cmd12.ExecuteScalar());

                if (Convert.ToInt64(cmd13.ExecuteScalar()) > 0)
                {
                    cmd17.CommandText = "SELECT computer_desc FROM Computer_Prob WHERE computer_prob_id = '" + Convert.ToInt64(cmd13.ExecuteScalar()) + "';";
                    computerProblemComboBox.SelectedIndex = computerProblemComboBox.FindString(cmd17.ExecuteScalar().ToString());
                }
                else if (Convert.ToInt64(cmd14.ExecuteScalar()) > 0)
                {
                    cmd17.CommandText = "SELECT laptop_desc FROM Laptop_Prob WHERE laptop_prob_id = '" + Convert.ToInt64(cmd14.ExecuteScalar()) + "';";
                    laptopProblemComboBox.SelectedIndex = laptopProblemComboBox.FindString(cmd17.ExecuteScalar().ToString());
                }
                else if (Convert.ToInt64(cmd15.ExecuteScalar()) > 0)
                {
                    cmd17.CommandText = "SELECT phone_tab_desc FROM Phone_Tablet_Prob WHERE phone_tablet_prob_id = '" + Convert.ToInt64(cmd15.ExecuteScalar()) + "';";
                    phoneOrTabletProblemComboBox.SelectedIndex = phoneOrTabletProblemComboBox.FindString(cmd17.ExecuteScalar().ToString());
                }
                else if (Convert.ToInt64(cmd16.ExecuteScalar()) > 0)
                {
                    cmd17.CommandText = "SELECT screen_desc FROM Screen_Prob WHERE screen_prob_id = '" + Convert.ToInt64(cmd16.ExecuteScalar()) + "';";
                    screenProblemComboBox.SelectedIndex = screenProblemComboBox.FindString(cmd17.ExecuteScalar().ToString());
                }

                if (Convert.ToString(cmd18.ExecuteScalar()) == "")
                {
                    textBox1.Text = "Numero de Commande";
                    textBox2.Text = "Comment Résolu";
                    textBox3.Text = "Bon D'envoi";
                    RMATextBox.Text = "RMA";
                }
                else
                {
                    if (Convert.ToInt64(cmd19.ExecuteScalar()) != 0)
                    {
                        cmd31.CommandText = "SELECT order_name FROM Order_Type WHERE order_type_id = '" + Convert.ToInt64(cmd19.ExecuteScalar()) + "';";
                        orderTypeComboBox.SelectedIndex = orderTypeComboBox.FindString(cmd31.ExecuteScalar().ToString());
                    }

                    textBox1.Text = Convert.ToString(cmd20.ExecuteScalar());
                    textBox1.ForeColor = Color.Black;
                    textBox2.Text = Convert.ToString(cmd21.ExecuteScalar());
                    textBox2.ForeColor = Color.Black;

                    if (Convert.ToInt64(cmd22.ExecuteScalar()) != 0)
                    {
                        cmd32.CommandText = "SELECT action_took_name FROM Action_Took WHERE action_took_id = '" + Convert.ToInt64(cmd22.ExecuteScalar()) + "';";
                        orderTypeComboBox.SelectedIndex = orderTypeComboBox.FindString(cmd32.ExecuteScalar().ToString());
                    }

                    if (Convert.ToInt64(cmd23.ExecuteScalar()) == 1)
                    {
                        radioButton3.Checked = true;
                    }
                    else if (Convert.ToInt64(cmd24.ExecuteScalar()) == 1)
                    {
                        radioButton2.Checked = true;
                    }
                    else if (Convert.ToInt64(cmd25.ExecuteScalar()) == 1)
                    {
                        radioButton1.Checked = true;
                    }

                    dateTimePicker1.Value = Convert.ToDateTime(cmd26.ExecuteScalar());

                    if (Convert.ToInt64(cmd27.ExecuteScalar()) > 1)
                    {
                        radioButton5.Checked = true;
                        dateTimePicker2.Value = Convert.ToDateTime(cmd28.ExecuteScalar());
                        textBox3.Text = Convert.ToString(cmd29.ExecuteScalar());
                        textBox3.ForeColor = Color.Black;
                        RMATextBox.Text = Convert.ToString(cmd30.ExecuteScalar());
                        RMATextBox.ForeColor = Color.Black;

                    }
                    else
                    {
                        radioButton4.Checked = true;
                    }
                }

            }
            catch (ArgumentOutOfRangeException a)
            {

                DialogResult dialog = MessageBox.Show("MAT n'existe pas", "Mise en garde", MessageBoxButtons.OK);

            }

            con.Close();
        }

        private void MATTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            MATTextBox.ForeColor = Color.Black;
        }
        private void MATTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MATTextBox.Text = "MAT-";
            //MATTextBox.ForeColor = Color.Black;
            if (e.KeyChar == (char)Keys.Enter)
            {
                loadData();
            }
        }


        private void loadBtn_Click(object sender, EventArgs e)
        {
            loadData();
        }

        //placeholder clearing
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "Numero de Commande")
            {
                textBox1.Text = "";
            }
            textBox1.ForeColor = Color.Black;
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == "Comment Résolu")
            {
                textBox2.Text = "";
            }
            textBox2.ForeColor = Color.Black;
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox3.Text == "Bon D'envoi")
            {
                textBox3.Text = "";
            }
            textBox3.ForeColor = Color.Black;
        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            if (RMATextBox.Text == "RMA")
            {
                RMATextBox.Text = "";
            }
            RMATextBox.ForeColor = Color.Black;
        }

        //inserting into modify table
        private void addBtn_Click(object sender, EventArgs e)
        {
            //Update Client Table
            string empID;
            string clientName = nameTextBox.Text;
            string problemDesc = problemDescriptionTextBox.Text;
            string email = emailTextbox.Text;
            string phone = phoneTextBox.Text;
            string date = dateTimePickerEntered.Value.ToString();

            string street = streetTextBox.Text;
            string aptNum = aptNumTextBox.Text;
            string city = cityTextBox.Text;
            string postalCode = postalCodeTextBox.Text;

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

            cmd1.CommandText = "UPDATE Client_Address SET street = '" + street + "', apt_num = '" + aptNum + "', city = '" + city + "', postal_code = '" + postalCode + "' FROM Client_Address JOIN Client ON Client_Address.address_id = Client.address_id JOIN Product ON Product.product_id = Client.product_id WHERE MAT = '" + mat + "';";

            cmd1.ExecuteNonQuery();

            cmd2.CommandText = "SELECT IDENT_CURRENT('Employee');";
            empID = Convert.ToString(cmd2.ExecuteScalar());

            cmd5.CommandText = "SELECT product_id FROM Product WHERE MAT='" + mat + "';";
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
                screenProbID = Convert.ToString(cmd8.ExecuteScalar());
            }
            else if (phoneTabProbDesc != "")
            {
                cmd9.CommandText = "SELECT phone_tablet_prob_id FROM Phone_tablet_Prob WHERE phone_tab_desc = '" + phoneTabProbDesc + "';";
                phoneTabProbID = Convert.ToString(cmd9.ExecuteScalar());
            }

            cmd10.CommandText = "UPDATE Client SET computer_prob_id = '" + computerProbID + "', laptop_prob_id = '" + laptopProbID + "', screen_prob_id = '" + screenProbID + "', phone_tablet_prob_id = '" + phoneTabProbID + "', client_name = '" + clientName + "', client_desc = '" + problemDesc + "', date_added = '" + date + "', client_email = '" + email + "', client_phone_num = '" + phone + "', by_email = '" + byEmail + "', by_telephone = '" + byTelephone + "', in_person = '" + inPerson + "' FROM Client JOIN Product ON Client.product_id = Product.product_id WHERE MAT = '" + mat + "';";
            cmd10.ExecuteNonQuery();
            con.Close();

            var problemStatus = problemStatusFroupBox;
            foreach (var radioButton in problemStatus.Controls.OfType<RadioButton>())
            {
                resolved = radioButton3.Checked ? "1" : "0";
                notResolved = radioButton2.Checked ? "1" : "0";
                onGoing = radioButton1.Checked ? "1" : "0";
            }

            var yesNo = orderGroupBox;
            foreach (var radioButton in orderGroupBox.Controls.OfType<RadioButton>())
            {
                yes = radioButton5.Checked ? "1" : "0";
                no = radioButton4.Checked ? "1" : "0";
            }

            orderTypeDesc = orderTypeComboBox.GetItemText(orderTypeComboBox.SelectedItem);
            orderNum = textBox1.Text;
            howResolved = textBox2.Text;
            actionTookDesc = actionTookComboBox.GetItemText(actionTookComboBox.SelectedItem);

            con.Open();
            SqlCommand cmd18 = con.CreateCommand();
            SqlCommand cmd19 = con.CreateCommand();
            SqlCommand cmd20 = con.CreateCommand();
            SqlCommand cmd21 = con.CreateCommand();
            SqlCommand cmd22 = con.CreateCommand();
            SqlCommand cmd23 = con.CreateCommand();
            SqlCommand cmd24 = con.CreateCommand();
            SqlCommand cmd25 = con.CreateCommand();
            SqlCommand cmd26 = con.CreateCommand();
            SqlCommand cmd27 = con.CreateCommand();


            cmd18.CommandType = CommandType.Text;
            cmd19.CommandType = CommandType.Text;
            cmd20.CommandType = CommandType.Text;
            cmd21.CommandType = CommandType.Text;
            cmd22.CommandType = CommandType.Text;
            cmd23.CommandType = CommandType.Text;
            cmd24.CommandType = CommandType.Text;
            cmd25.CommandType = CommandType.Text;
            cmd26.CommandType = CommandType.Text;
            cmd27.CommandType = CommandType.Text;


            //access clientId
            cmd19.CommandText = "SELECT client_id FROM CLIENT WHERE CONVERT(VARCHAR, product_id) = '" + productID + "';";
            clientId = Convert.ToString(cmd19.ExecuteScalar());

            cmd21.CommandText = "SELECT action_took_id FROM Action_Took WHERE CONVERT(VARCHAR, action_took_name) = '" + actionTookDesc + "';";
            actionTookId = Convert.ToString(cmd21.ExecuteScalar());

            cmd23.CommandText = "SELECT order_type_id FROM Order_Type WHERE CONVERT(VARCHAR, order_name) = '" + orderTypeDesc + "';";
            orderTypeId = Convert.ToString(cmd23.ExecuteScalar());

            //create new orderId, by inputting it and insert into NewOrder table and access the id later
            if (yes == "1")
            {
                cmd24.CommandText = "INSERT INTO New_Order (RMA, send_date, return_voucher) VALUES ('" + rma + "', '" + deliveryDate + "', '" + return_voucher + "')";
                cmd24.ExecuteNonQuery();
                cmd25.CommandText = "SELECT client_id FROM CLIENT WHERE CONVERT(VARCHAR, RMA) = '" + rma + "';";
                newOrderId = Convert.ToString(cmd25.ExecuteScalar());
            }
            else if (no == "1")
            {
                newOrderId = " ";
            }

            cmd26.CommandText = "SELECT Modify_Client.client_id FROM Modify_Client JOIN Client ON Modify_Client.client_id=Client.client_id JOIN Product ON Client.product_id=Product.product_id WHERE MAT='" + empID + "';";

            if (Convert.ToString(cmd26.ExecuteScalar()) != "")
            {
                cmd27.CommandText = "UPDATE Modify_Client SET action_took_id= '" + actionTookId + "', order_type_id= '" + orderTypeId + "', how_solved= '" + howResolved + "', order_num= '" + orderNum + "', is_solved= '" + resolved + "', is_unsolved= '" + notResolved + "', is_ongoing= '" + onGoing + "', date_solved= '" + resolvedDate + "', order_id= '" + newOrderId + "' WHERE client_id = '" + clientId + "';";
                cmd27.ExecuteNonQuery();
            }
            else
            {
                cmd18.CommandText = "INSERT INTO Modify_Client (employee_id, client_id, action_took_id, order_type_id, how_solved, order_num, is_solved, is_unsolved, is_ongoing, date_solved, order_id) VALUES ('" + empID + "', '" + clientId + "', '" + actionTookId + "','" + orderTypeId + "', '" + howResolved + "', '" + orderNum + "', '" + resolved + "', '" + notResolved + "', '" + onGoing + "', '" + resolvedDate + "', '" + newOrderId + "');";
                cmd18.ExecuteNonQuery();
            }

            con.Close();

            isAddBtnClicked = true;
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

        private void orderTypeComboBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void actionTookComboBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }


        Boolean isAddBtnClicked;
        Boolean isCancelBtnClicked;
        Boolean isAddRadioBtnClicked;
        Boolean isViewRadioBtnClicked;
        Boolean isAdminRadioBtnClicked;

        private void confirmation()
        {
            if (isAddBtnClicked == true)
            {
                DialogResult dialog = MessageBox.Show("Les donnés que vous avez rentrées vont être sauvegardés." +
                    "\nModifier un autre client?", "Mise en garde", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    this.Hide();
                    String empName = empNameTextView.Text;
                    ModifyForm addForm = new ModifyForm(empName);
                    addForm.ShowDialog();
                    this.Close();
                    //Alternate solution: create a Form for the confirmation 
                }
                else if (dialog == DialogResult.No)
                {
                    this.Hide();
                    string empName = empNameTextView.Text;
                    MainHub mainHub = new MainHub(empName);
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
                    String empName = empNameTextView.Text;
                    MainHub mainHub = new MainHub(empName);
                    mainHub.ShowDialog();
                    this.Close();
                }
                else if (dialog == DialogResult.No)
                {
                    isCancelBtnClicked = false;
                }
            }
            else if (isAddRadioBtnClicked == true)
            {
                DialogResult dialog = MessageBox.Show("Les donnés que vous avez rentrées ne vont pas être sauvegardés." +
                    "\nÊtes-vous sur d’annuler?", "Mise en garde", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    this.Hide();
                    String empName = empNameTextView.Text;
                    AddForm modifyForm = new AddForm(empName);
                    modifyForm.ShowDialog();
                    this.Close();
                }
                else if (dialog == DialogResult.No)
                {
                    isAddRadioBtnClicked = false;
                }
            }
            else if (isViewRadioBtnClicked == true)
            {
                DialogResult dialog = MessageBox.Show("Les donnés que vous avez rentrées ne vont pas être sauvegardés." +
                    "\nÊtes-vous sur d’annuler?", "Mise en garde", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    this.Hide();
                    String empName = empNameTextView.Text;
                    ViewForm viewForm = new ViewForm(empName);
                    viewForm.ShowDialog();
                    this.Close();
                }
                else if (dialog == DialogResult.No)
                {
                    isViewRadioBtnClicked = false;
                }
            }
            else if (isAdminRadioBtnClicked == true)
            {
                DialogResult dialog = MessageBox.Show("Les donnés que vous avez rentrées ne vont pas être sauvegardés." +
                    "\nÊtes-vous sur d’annuler?", "Mise en garde", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    this.Hide();
                    String empName = empNameTextView.Text;
                    AdminPage adminForm = new AdminPage();
                    adminForm.ShowDialog();
                    this.Close();
                }
                else if (dialog == DialogResult.No)
                {
                    isAdminRadioBtnClicked = false;
                }
                //else if (isAdminRadioBtnClicked == true)
                //{
                //    DialogResult dialog1 = MessageBox.Show("Les donnés que vous avez rentrées ne vont pas être sauvegardés." +
                //        "\nÊtes-vous sur d’annuler?", "Mise en garde", MessageBoxButtons.YesNo);
                //    if (dialog1 == DialogResult.Yes)
                //    {
                //        this.Hide();
                //        String empName = empNameTextView.Text;
                //        AdminPage adminForm = new AdminPage();
                //        adminForm.ShowDialog();
                //        this.Close();
                //    }
                //    else if (dialog1 == DialogResult.No)
                //    {
                //        isAdminRadioBtnClicked = false;
                //    }
                //}
            }

        }
        private void addButton_MouseClick(object sender, MouseEventArgs e)
        {
            isAddRadioBtnClicked = true;
            confirmation();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            isCancelBtnClicked = true;
            confirmation();
        }

        private void viewRadioBtn_MouseClick(object sender, MouseEventArgs e)
        {
            isViewRadioBtnClicked = true;
            addRadioBtn.Checked = true;
            confirmation();
        }

        private void orderGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton5_MouseClick(object sender, MouseEventArgs e)
        {
            label19.Show();
            dateTimePicker2.Show();
            label20.Show();
            textBox3.Show();
            label21.Show();
            RMATextBox.Show();
        }

        private void radioButton4_MouseClick(object sender, MouseEventArgs e)
        {
            label19.Hide();
            dateTimePicker2.Hide();
            label20.Hide();
            textBox3.Hide();
            label21.Hide();
            RMATextBox.Hide();
        }

        private void adminRadioBtn_MouseClick(object sender, MouseEventArgs e)
        {
            isViewRadioBtnClicked = true;
            addRadioBtn.Checked = true;
            confirmation();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }

}
