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
        public ModifyForm()
        {
            InitializeComponent();
        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {
           

        }

        private void MATTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (MATTextBox.Text == "Entrer problème")
            {
                MATTextBox.Text = "";
            }
            MATTextBox.ForeColor = Color.Black;
        }



        private void loadBtn_Click(object sender, EventArgs e)
        {
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

            String MAT = MATTextBox.Text;
            cmd1.CommandText = "SELECT client_name FROM Client FULL OUTER JOIN Product ON Client.product_id=Product.product_id WHERE Product.MAT= '" + MAT + "';";
            cmd2.CommandText = "SELECT client_desc FROM Client FULL OUTER JOIN Product ON Client.product_id=Product.product_id WHERE Product.MAT= '" + MAT + "';";
            cmd3.CommandText = "SELECT date_added FROM Client FULL OUTER JOIN Product ON Client.product_id=Product.product_id WHERE Product.MAT= '" + MAT + "';";
            cmd4.CommandText = "SELECT by_email FROM Client FULL OUTER JOIN Product ON Client.product_id=Product.product_id WHERE Product.MAT= '" + MAT + "';";
            cmd5.CommandText = "SELECT by_phone FROM Client FULL OUTER JOIN Product ON Client.product_id=Product.product_id WHERE Product.MAT= '" + MAT + "';";
            cmd6.CommandText = "SELECT in_person FROM Client FULL OUTER JOIN Product ON Client.product_id=Product.product_id WHERE Product.MAT= '" + MAT + "';";
            cmd7.CommandText = "SELECT client_email FROM Client FULL OUTER JOIN Product ON Client.product_id=Product.product_id WHERE Product.MAT= '" + MAT + "';";
            cmd8.CommandText = "SELECT client_phone_num FROM Client FULL OUTER JOIN Product ON Client.product_id=Product.product_id WHERE Product.MAT= '" + MAT + "';";
            cmd9.CommandText = "SELECT Client_Address.street FROM Client JOIN Product ON Client.product_id = Product.product_id JOIN Client_Address ON Client_Address.address_id = Client.address_id WHERE Product.MAT = '" + MAT + "';";
            cmd10.CommandText = "SELECT Client_Address.apt_num FROM Client JOIN Product ON Client.product_id = Product.product_id JOIN Client_Address ON Client_Address.address_id = Client.address_id WHERE Product.MAT = '" + MAT + "';";
            cmd11.CommandText = "SELECT Client_Address.city FROM Client JOIN Product ON Client.product_id = Product.product_id JOIN Client_Address ON Client_Address.address_id = Client.address_id WHERE Product.MAT = '" + MAT + "';";
            cmd12.CommandText = "SELECT Client_Address.postal_code FROM Client JOIN Product ON Client.product_id = Product.product_id JOIN Client_Address ON Client_Address.address_id = Client.address_id WHERE Product.MAT = '" + MAT + "';";

            //cmd1.ExecuteNonQuery();
            //cmd2.ExecuteNonQuery();
            //cmd3.ExecuteNonQuery();
            //cmd4.ExecuteNonQuery();
            //cmd5.ExecuteNonQuery();
            //cmd6.ExecuteNonQuery();
            //cmd7.ExecuteNonQuery();
            //cmd8.ExecuteNonQuery();
            //cmd9.ExecuteNonQuery();
            //cmd10.ExecuteNonQuery();
            //cmd11.ExecuteNonQuery();
            //cmd12.ExecuteNonQuery();

            //string name;
            //name = Convert.ToString(cmd1.ExecuteScalar());
            nameTextBox.Text = Convert.ToString(cmd1.ExecuteScalar());



            con.Close();
        }
    }
}
