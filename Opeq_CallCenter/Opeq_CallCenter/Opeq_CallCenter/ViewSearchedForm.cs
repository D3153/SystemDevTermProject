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
    public partial class ViewSearchedForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-KFOB4HEQ\DINAL;Initial Catalog=Opeq_CentreAppels;Integrated Security=True");

        public ViewSearchedForm(string input, string empName)
        {
            InitializeComponent();
            MATTextBox.Text = input;
            empNameTextView.Text = empName;

            if (empName == "Simon.P")
            {
                adminRadioBtn.Show();
            }
            else adminRadioBtn.Hide();
        }

        private void ViewSearchedForm_Load(object sender, EventArgs e)
        {
            MATTextBox.ReadOnly = true;
            nameTextBox.ReadOnly = true;
            problemDescriptionTextBox.ReadOnly = true;
            dateTextBox.ReadOnly = true;
            emailTextbox.ReadOnly = true;
            phoneTextBox.ReadOnly = true;
            streetTextBox.ReadOnly = true;
            aptNumTextBox.ReadOnly = true;
            cityTextBox.ReadOnly = true;
            postalCodeTextBox.ReadOnly = true;
            problemTextbox.ReadOnly = true;
            orderTypeTextbox.ReadOnly = true;
            orderNumTextbox.ReadOnly = true;
            howResolvedTextbox.ReadOnly = true;
            actionTookTextbox.ReadOnly = true;
            dateResolvedTextbox.ReadOnly = true;
            newOrderTextbox.ReadOnly = true;
            dateSentTextBox.ReadOnly = true;
            returnVoucherTextBox.ReadOnly = true;
            RMATextBox.ReadOnly = true;
            emailRadioBtn.Enabled = false;
            phoneRadioBtn.Enabled = false;
            inPersonRadioBtn.Enabled = false;
            isSolvedRadioBtn.Enabled = false;
            notSolvedRadioBtn.Enabled = false;
            onGoingRadioBtn.Enabled = false;
            addRadioBtn.Enabled = false;
            modifyRadioBtn.Enabled = false;
            viewRadioBtn.Enabled = false;
            adminRadioBtn.Enabled = false;

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
            String MAT = MATTextBox.Text;
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
            cmd13.CommandText = "SELECT Computer_Prob.computer_desc FROM Client JOIN Product ON Client.product_id = Product.product_id JOIN Computer_Prob ON Computer_Prob.computer_prob_id = Client.computer_prob_id WHERE Product.MAT = '" + MAT + "';";
            cmd14.CommandText = "SELECT Laptop_Prob.laptop_desc FROM Client JOIN Product ON Client.product_id = Product.product_id JOIN Laptop_Prob ON Laptop_Prob.laptop_prob_id = Client.laptop_prob_id WHERE Product.MAT = '" + MAT + "';";
            cmd15.CommandText = "SELECT Phone_Tablet_Prob.phone_tab_desc FROM Client JOIN Product ON Client.product_id = Product.product_id JOIN Phone_Tablet_Prob ON Phone_Tablet_Prob.phone_tablet_prob_id = Client.phone_tablet_prob_id WHERE Product.MAT = '" + MAT + "';";
            cmd16.CommandText = "SELECT Screen_Prob.screen_desc FROM Client JOIN Product ON Client.product_id = Product.product_id JOIN Screen_Prob ON Screen_Prob.screen_prob_id = Client.screen_prob_id WHERE Product.MAT = '" + MAT + "';";
            //modify load
            cmd18.CommandText = "SELECT Modify_Client.modify_id FROM Modify_Client FULL OUTER JOIN Client ON Modify_Client.client_id=Client.client_id LEFT JOIN PRODUCT ON Client.product_id=Product.product_id WHERE MAT = '" + MAT + "';";
            cmd19.CommandText = "SELECT Order_Type.order_name FROM Order_Type FULL JOIN Modify_Client ON Order_Type.order_type_id=Modify_Client.order_type_id LEFT JOIN Client ON Modify_Client.client_id=Client.client_id LEFT JOIN Product ON Client.product_id=Product.product_id WHERE MAT = '" + MAT + "';";
            cmd20.CommandText = "SELECT Modify_Client.order_num FROM Modify_Client FULL OUTER JOIN Client ON Modify_Client.client_id=Client.client_id LEFT JOIN PRODUCT ON Client.product_id=Product.product_id WHERE MAT = '" + MAT + "';";
            cmd21.CommandText = "SELECT Modify_Client.how_solved FROM Modify_Client FULL OUTER JOIN Client ON Modify_Client.client_id=Client.client_id LEFT JOIN PRODUCT ON Client.product_id=Product.product_id WHERE MAT = '" + MAT + "';";
            cmd22.CommandText = "SELECT Action_Took.action_took_name FROM Action_Took FULL JOIN Modify_Client ON Action_Took.action_took_id=Modify_Client.action_took_id LEFT JOIN Client ON Client.client_id=Modify_Client.client_id LEFT JOIN Product ON Product.product_id=Client.product_id WHERE MAT = '" + MAT + "';";
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
            dateTextBox.Text = Convert.ToString(cmd3.ExecuteScalar());

            if (Convert.ToInt64(cmd4.ExecuteScalar()) == 1)
            {
                emailRadioBtn.Checked = true;
            }
            else if(Convert.ToInt64(cmd5.ExecuteScalar()) == 1)
            {
                phoneRadioBtn.Checked = true;
            }
            else if(Convert.ToInt64(cmd6.ExecuteScalar()) == 1)
            {
                inPersonRadioBtn.Checked = true;
            }

            emailTextbox.Text = Convert.ToString(cmd7.ExecuteScalar());
            phoneTextBox.Text = Convert.ToString(cmd8.ExecuteScalar());
            streetTextBox.Text = Convert.ToString(cmd9.ExecuteScalar());
            aptNumTextBox.Text = Convert.ToString(cmd10.ExecuteScalar());
            cityTextBox.Text = Convert.ToString(cmd11.ExecuteScalar());
            postalCodeTextBox.Text = Convert.ToString(cmd12.ExecuteScalar());

            if(Convert.ToString(cmd13.ExecuteScalar()) != "")
            {
                string value = "Ordinateur: ";
                value += Convert.ToString(cmd13.ExecuteScalar());
                problemTextbox.Text = value;
            }
            else if (Convert.ToString(cmd14.ExecuteScalar()) != "")
            {
                string value = "Portable: ";
                value += Convert.ToString(cmd14.ExecuteScalar());
                problemTextbox.Text = value;
            }
            else if (Convert.ToString(cmd15.ExecuteScalar()) != "")
            {
                string value = "Cellulaire/Tablette: ";
                value += Convert.ToString(cmd15.ExecuteScalar());
                problemTextbox.Text = value;
            }
            else if (Convert.ToString(cmd16.ExecuteScalar()) != "") 
            {
                string value = "Écran: ";
                value += Convert.ToString(cmd16.ExecuteScalar());
                problemTextbox.Text = value;
            }


            if (Convert.ToString(cmd18.ExecuteScalar()) == "")
            {
                orderTypeTextbox.Text = "";
                orderNumTextbox.Text = "";
                howResolvedTextbox.Text = "";
                actionTookTextbox.Text = "";
                dateResolvedTextbox.Text = "";
                newOrderTextbox.Text = "";
                dateSentTextBox.Text = "";
                returnVoucherTextBox.Text = "";
                RMATextBox.Text = "";

                //orderTypeTextbox.ReadOnly = true;
                //orderNumTextbox.ReadOnly = true;
                //howResolvedTextbox.ReadOnly = true;
                //actionTookTextbox.ReadOnly = true;
                //dateResolvedTextbox.ReadOnly = true;
                //newOrderTextbox.ReadOnly = true;
                //dateSentTextBox.ReadOnly = true;
                //returnVoucherTextBox.ReadOnly = true;
                //RMATextBox.ReadOnly = true;

            }
            else
            {
                orderTypeTextbox.Text = Convert.ToString(cmd19.ExecuteScalar());
                orderNumTextbox.Text = Convert.ToString(cmd20.ExecuteScalar());
                howResolvedTextbox.Text = Convert.ToString(cmd21.ExecuteScalar());
                actionTookTextbox.Text = Convert.ToString(cmd22.ExecuteScalar());

                if (Convert.ToInt64(cmd23.ExecuteScalar()) == 1)
                {
                    isSolvedRadioBtn.Checked = true;
                }
                else if (Convert.ToInt64(cmd24.ExecuteScalar()) == 1)
                {
                    notSolvedRadioBtn.Checked = true;
                }
                else if (Convert.ToInt64(cmd25.ExecuteScalar()) == 1)
                {
                    onGoingRadioBtn.Checked = true;
                }

                dateResolvedTextbox.Text = Convert.ToString(cmd26.ExecuteScalar());

                if(Convert.ToInt64(cmd27.ExecuteScalar()) > 0)
                {
                    newOrderTextbox.Text = "Oui";
                }
                else
                {
                    newOrderTextbox.Text = "Non";
                }

                RMATextBox.Text = Convert.ToString(cmd28.ExecuteScalar());
                dateSentTextBox.Text = Convert.ToString(cmd29.ExecuteScalar());
                returnVoucherTextBox.Text = Convert.ToString(cmd30.ExecuteScalar());
            }

            con.Close();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            string empName = empNameTextView.Text;
            this.Hide();
            ViewForm viewFormInstance = new ViewForm(empName);
            viewFormInstance.ShowDialog();
            this.Close();
        }

    }
}
