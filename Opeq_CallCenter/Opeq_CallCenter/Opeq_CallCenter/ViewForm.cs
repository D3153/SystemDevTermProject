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
            con.Open();



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
            //take search results(mat, client name, or command number)
            //MAT from product 
            //client name from client
            //order number from 
            String data = searchbar.Text;
            String mat = "";
            String client_name = "";
            String orderNum = "";

            //make commands
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

            SqlCommand cmd31 = con.CreateCommand();
            SqlCommand cmd32 = con.CreateCommand();
            SqlCommand cmd33 = con.CreateCommand();
            SqlCommand cmd34 = con.CreateCommand();
            SqlCommand cmd35 = con.CreateCommand();

            cmd31.CommandType = CommandType.Text;
            cmd32.CommandType = CommandType.Text;
            cmd33.CommandType = CommandType.Text;
            cmd34.CommandType = CommandType.Text;
            cmd35.CommandType = CommandType.Text;

            //get the values for from the search bar
            cmd31.CommandText = "SELECT client_name FROM Product p JOIN Client c ON p.product_id=c.product_id JOIN Modify_Client m ON c.client_id=m.client_id " +
                "WHERE c.client_name = '" + data + "' OR MAT = '" + data + "' OR order_num = '" + data + "';";
            cmd32.CommandText = "SELECT MAT FROM Product p JOIN Client c ON p.product_id=c.product_id JOIN Modify_Client m ON c.client_id=m.client_id " +
                "WHERE c.client_name = '" + data + "' OR MAT = '" + data + "' OR order_num = '" + data + "';";
            cmd33.CommandText = "SELECT order_num FROM Product p JOIN Client c ON p.product_id=c.product_id JOIN Modify_Client m ON c.client_id=m.client_id " +
                "WHERE c.client_name = '" + data + "' OR MAT = '" + data + "' OR order_num = '" + data + "';";



            mat = Convert.ToString(cmd31.ExecuteScalar());
            client_name = Convert.ToString(cmd32.ExecuteScalar());
            // comNum = Convert.ToString(cmd3.ExecuteScalar());


            //if mat found, find all the client info based on product id
            if (mat != "")
            {
                // cmd34.CommandText = "SELECT * FROM Client INNER JOIN Product ON Client.product_id = Product.product_id WHERE Product.MAT = (SELECT MAT FROM Product WHERE CONVERT(VARCHAR, MAT) = '" + data + "'";
                //dont do anything, just take the mat that is stored in variable, and execute the methods after if statement
            }
            else if (client_name != "")
            {
                //change mat based on client name
                cmd34.CommandText = "SELECT MAT FROM Product INNER JOIN Client ON Client.product_id = Product.product_id WHERE Client.client_name = (SELECT client_name FROM Client WHERE CONVERT(VARCHAR, client_name) = '" + data + "')";
                mat = Convert.ToString(cmd34.ExecuteScalar());
            }
            else if (orderNum != "")
            {
                //change mat based on orderNum

            }
            else
            {
                //error
            }
            cmd1.CommandText = "SELECT client_name FROM Client FULL OUTER JOIN Product ON Client.product_id=Product.product_id WHERE Product.MAT= '" + mat + "';";

            cmd2.CommandText = "SELECT client_desc FROM Client FULL OUTER JOIN Product ON Client.product_id=Product.product_id WHERE Product.MAT= '" + mat + "';";

            cmd3.CommandText = "SELECT date_added FROM Client FULL OUTER JOIN Product ON Client.product_id=Product.product_id WHERE Product.MAT= '" + mat + "';";

            cmd4.CommandText = "SELECT by_email FROM Client FULL OUTER JOIN Product ON Client.product_id=Product.product_id WHERE Product.MAT= '" + mat + "';";

            cmd5.CommandText = "SELECT by_telephone FROM Client FULL OUTER JOIN Product ON Client.product_id=Product.product_id WHERE Product.MAT= '" + mat + "';";

            cmd6.CommandText = "SELECT in_person FROM Client FULL OUTER JOIN Product ON Client.product_id=Product.product_id WHERE Product.MAT= '" + mat + "';";

            cmd7.CommandText = "SELECT client_email FROM Client FULL OUTER JOIN Product ON Client.product_id=Product.product_id WHERE Product.MAT= '" + mat + "';";

            cmd8.CommandText = "SELECT client_phone_num FROM Client FULL OUTER JOIN Product ON Client.product_id=Product.product_id WHERE Product.MAT= '" + mat + "';";

            cmd9.CommandText = "SELECT Client_Address.street FROM Client JOIN Product ON Client.product_id = Product.product_id JOIN Client_Address ON Client_Address.address_id = Client.address_id WHERE Product.MAT = '" + mat + "';";

            cmd10.CommandText = "SELECT Client_Address.apt_num FROM Client JOIN Product ON Client.product_id = Product.product_id JOIN Client_Address ON Client_Address.address_id = Client.address_id WHERE Product.MAT = '" + mat + "';";

            cmd11.CommandText = "SELECT Client_Address.city FROM Client JOIN Product ON Client.product_id = Product.product_id JOIN Client_Address ON Client_Address.address_id = Client.address_id WHERE Product.MAT = '" + mat + "';";

            cmd12.CommandText = "SELECT Client_Address.postal_code FROM Client JOIN Product ON Client.product_id = Product.product_id JOIN Client_Address ON Client_Address.address_id = Client.address_id WHERE Product.MAT = '" + mat + "';";

            cmd13.CommandText = "SELECT Computer_Prob.computer_prob_id FROM Client JOIN Product ON Client.product_id = Product.product_id JOIN Computer_Prob ON Computer_Prob.computer_prob_id = Client.computer_prob_id WHERE Product.MAT = '" + mat + "';";

            cmd14.CommandText = "SELECT Laptop_Prob.laptop_prob_id FROM Client JOIN Product ON Client.product_id = Product.product_id JOIN Computer_Prob ON Laptop_Prob.laptop_prob_id = Client.laptop_prob_id WHERE Product.MAT = '" + mat + "';";

            cmd15.CommandText = "SELECT Phone_Tablet_Prob.phone_tablet_prob_id FROM Client JOIN Product ON Client.product_id = Product.product_id JOIN Phone_Tablet_Prob ON Phone_Tablet_Prob.phone_tablet_prob_id = Client.phone_tablet_prob_id WHERE Product.MAT = '" + mat + "';";

            cmd16.CommandText = "SELECT Screen_Prob.screen_prob_id FROM Client JOIN Product ON Client.product_id = Product.product_id JOIN Screen_Prob ON Screen_Prob.screen_prob_id = Client.screen_prob_id WHERE Product.MAT = '" + mat + "';";

            //modify load
            cmd18.CommandText = "SELECT Modify_Client.* FROM Modify_Client FULL OUTER JOIN Client ON Modify_Client.client_id=Client.client_id LEFT JOIN PRODUCT ON Client.product_id=Product.product_id WHERE MAT = '" + mat + "';";

            cmd19.CommandText = "SELECT Order_Type.order_type_id FROM Order_Type JOIN Modify_Client ON Order_Type.order_type_id =Modify_Client.order_type_id JOIN Client ON Client.client_id=Modify_Client.client_id JOIN Product ON Product.product_id=Client.product_id WHERE MAT = '" + mat + "';";

            cmd20.CommandText = "SELECT Modify_Client.order_num FROM Modify_Client FULL OUTER JOIN Client ON Modify_Client.client_id=Client.client_id LEFT JOIN PRODUCT ON Client.product_id=Product.product_id WHERE MAT = '" + mat + "';";

            cmd21.CommandText = "SELECT Modify_Client.how_solved FROM Modify_Client FULL OUTER JOIN Client ON Modify_Client.client_id=Client.client_id LEFT JOIN PRODUCT ON Client.product_id=Product.product_id WHERE MAT = '" + mat + "';";

            cmd22.CommandText = "SELECT Action_Took.action_took_id FROM Action_Took JOIN Modify_Client ON Action_Took.action_took_id=Modify_Client.order_type_id JOIN Client ON Client.client_id=Modify_Client.client_id JOIN Product ON Product.product_id=Client.product_id WHERE MAT = '" + mat + "';";

            cmd23.CommandText = "SELECT Modify_Client.is_solved FROM Modify_Client FULL OUTER JOIN Client ON Modify_Client.client_id=Client.client_id LEFT JOIN PRODUCT ON Client.product_id=Product.product_id WHERE MAT = '" + mat + "';";

            cmd24.CommandText = "SELECT Modify_Client.is_unsolved FROM Modify_Client FULL OUTER JOIN Client ON Modify_Client.client_id=Client.client_id LEFT JOIN PRODUCT ON Client.product_id=Product.product_id WHERE MAT = '" + mat + "';";

            cmd25.CommandText = "SELECT Modify_Client.is_ongoing FROM Modify_Client FULL OUTER JOIN Client ON Modify_Client.client_id=Client.client_id LEFT JOIN PRODUCT ON Client.product_id=Product.product_id WHERE MAT = '" + mat + "';";

            cmd26.CommandText = "SELECT Modify_Client.date_solved FROM Modify_Client FULL OUTER JOIN Client ON Modify_Client.client_id=Client.client_id LEFT JOIN PRODUCT ON Client.product_id=Product.product_id WHERE MAT = '" + mat + "';";

            cmd27.CommandText = "SELECT Modify_Client.order_id FROM Modify_Client FULL OUTER JOIN Client ON Modify_Client.client_id=Client.client_id LEFT JOIN PRODUCT ON Client.product_id=Product.product_id WHERE MAT = '" + mat + "';";

            cmd28.CommandText = "SELECT New_Order.RMA FROM New_Order JOIN Modify_Client ON New_Order.order_id=Modify_Client.order_id JOIN Client ON Client.client_id=Modify_Client.client_id JOIN Product ON Product.product_id=Client.product_id WHERE MAT = '" + mat + "';";

            cmd29.CommandText = "SELECT New_Order.send_date FROM New_Order JOIN Modify_Client ON New_Order.order_id=Modify_Client.order_id JOIN Client ON Client.client_id=Modify_Client.client_id JOIN Product ON Product.product_id=Client.product_id WHERE MAT = '" + mat + "';";

            cmd30.CommandText = "SELECT New_Order.return_voucher FROM New_Order JOIN Modify_Client ON New_Order.order_id=Modify_Client.order_id JOIN Client ON Client.client_id=Modify_Client.client_id JOIN Product ON Product.product_id=Client.product_id WHERE MAT = '" + mat + "';";

            //show values for found clients mat, client name, and order number

        }

        private void resolvedRBtn(object sender, MouseEventArgs e)
        {

        }

        private void processingRBtn(object sender, MouseEventArgs e)
        {

        }

        private void modifyRadioBtn_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void NotResolvedRBtn(object sender, MouseEventArgs e)
        {

        }

        //take client info, + modify client info
        private void viewBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewSearchedForm viewFormInstance = new ViewSearchedForm();
            viewFormInstance.ShowDialog();
            this.Close();
        }
            //resultBox.Text = $"Accounts with {accountType}{Environment.NewLine}";

            // traverse file until end of file
            /*while (true)
            {
                // get next Record available in file
                //string inputRecord = fileReader.ReadLine();

                // when at the end of file, exit method
                if (inputRecord == null)
                {
                    return;
                }

                // parse input
                //string[] inputFields = inputRecord.Split(',');

                // create Record from input
                var record =
                new ClientInfo(inputFields[0], inputFields[1],
                inputFields[2], inputFields[3], inputFields[4],
                inputFields[5], decimal.Parse(inputFields[6]));*/

            //resultBox.Text =

            // determine whether to display balance
            //if (ShouldDisplay(record.Balance, accountType))
            //{// display record
            //    displayTextBox.AppendText($"{record.Name}\t" +
            //     $"{record.Gender}\t{record.Age}\t" +
            //     $"{record.PhoneNumber}\t{record.Account}\t" +
            //     $"{record.Password}\t{record.Balance:C}");
            //}
        }

        //Navigation
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
                    String empName = empNameTextView.Text;
                    ModifyForm modifyForm = new ModifyForm(empName);
                    modifyForm.ShowDialog();
                    this.Close();
                }
                else if (dialog == DialogResult.No)
                {
                    isModifyRadioBtnClicked = false;
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
                    AddForm addForm = new AddForm(empName);
                    addForm.ShowDialog();
                    this.Close();
                }
                else if (dialog == DialogResult.No)
                {
                    isAddRadioBtnClicked = false;
                }
            }
        }


    }
}

