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
        Boolean isViewRadioBtnClicked;

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-KFOB4HEQ\DINAL;Initial Catalog=Opeq_CallCenter;Integrated Security=True");
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

            SqlCommand cmd1 = con.CreateCommand();
            SqlCommand cmd2 = con.CreateCommand();
            SqlCommand cmd3 = con.CreateCommand();
            SqlCommand cmd4 = con.CreateCommand();
        }

        private void addButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            String empName = empNameTextView.Text;
            AddForm addFormInstance = new AddForm(empName);
            addFormInstance.ShowDialog();
            this.Close();
        }

        private void modifyRadioBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            String empName = empNameTextView.Text;
            ModifyForm modifyFormInstance = new ModifyForm(empName);
            modifyFormInstance.ShowDialog();
            this.Close();
        }

        private void viewRadioBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            String empName = empNameTextView.Text;
            ViewForm viewFormInstance = new ViewForm(empName);
            viewFormInstance.ShowDialog();
            this.Close();
        }

        private void view(object sender, MouseEventArgs e)
        {
            isViewRadioBtnClicked = true;
            addRadioBtn.Checked = true;
            confirmation();
        }

        private void modify(object sender, MouseEventArgs e)
        {
            isModifyRadioBtnClicked = true;
            addRadioBtn.Checked = true;
            confirmation();
        }

        private void adminRadioBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            AdminPage adminFormInstance = new AdminPage();
            adminFormInstance.ShowDialog();
            this.Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            String data = searchbar.Text;
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
                    MainHub mainHub = new MainHub(empNameTextView.Text);
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
                    MainHub mainHub = new MainHub(empNameTextView.Text);
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
                    //ModifyForm modifyForm = new ModifyForm();
                    //modifyForm.ShowDialog();
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


    }
}

