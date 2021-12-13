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
    public partial class Preview : Form
    {
        public Preview()
        {
            InitializeComponent();
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != string.Empty && txtName1.Text != string.Empty && txtLastName.Text != string.Empty && txtPhone.Text != string.Empty)
            {


                VirtualDatabase.Customers.Add(new Customer()
                {
                    name = txtName1.Text,
                    lastName = txtLastName.Text,
                    phone = txtPhone.Text,
                    emailAdress = txtEmail.Text
                });
                MessageBox.Show("Successfully saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
                SavedCustomer Sc = new SavedCustomer();

                foreach (Customer item in VirtualDatabase.Customers)
                {
                    Sc.lstSavedInfırmation.Items.Add(item.name + " " + item.lastName + " " + item.emailAdress + " " + item.phone);
                }
                Sc.ShowDialog();

            }
            else
            {
                MessageBox.Show("Please fill all blanks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
