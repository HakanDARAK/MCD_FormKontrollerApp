using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCD_FormKontrollerApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            CleanPage();
        }

        private void CleanPage()
        {
            txtName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtEmail.Text = String.Empty;
        }

        private void addCustomer(Customer customer)
        {
            VirtualDatabase.Customers.Add(customer);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != string.Empty && txtName.Text != string.Empty && txtLastName.Text != string.Empty && txtPhone.Text != string.Empty)
            {


                Preview previewRecord = new Preview();
                ((TextBox)previewRecord.Controls["txtName1"]).Text = txtName.Text;
                ((TextBox)previewRecord.Controls["txtLastName"]).Text = txtLastName.Text;
                ((TextBox)previewRecord.Controls["txtEmail"]).Text = txtEmail.Text;
                ((TextBox)previewRecord.Controls["txtPhone"]).Text = txtPhone.Text;

                previewRecord.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please fill all blanks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            addCustomer(new Customer()
            {
                name = txtName.Text,
                lastName = txtLastName.Text,
                phone = txtPhone.Text,
                emailAdress = txtEmail.Text

            });
            MessageBox.Show("Successfully saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SavedCustomer Sc = new SavedCustomer();

            foreach (Customer item in VirtualDatabase.Customers)
            {
                Sc.lstSavedInfırmation.Items.Add(item.name + " " + item.lastName + " " + item.emailAdress + " " + item.phone);
            }
            Sc.ShowDialog();


        }
    }
}
