using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResaurantReservationSYS
{
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void labelFirstName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Validation
            if (txtFirstName.Text.Equals("") && txtPhoneNumber.Text.Equals("") && txtSurname.Text.Equals("") && txtEmail.Text.Equals(""))
            {
                MessageBox.Show("All fields must be entered", "Invalid Input", MessageBoxButtons.OK);
                txtFirstName.Focus();
                return;
            }

            if (txtFirstName.Text.Equals(""))
            {
                MessageBox.Show("First Name must be entered", "Invalid Input", MessageBoxButtons.OK);
                txtFirstName.Focus();
                return;
            }
            if (txtSurname.Text.Equals(""))
            {
                MessageBox.Show("Surname must be entered", "Invalid Input", MessageBoxButtons.OK);
                txtSurname.Focus();
                return;
            }
            if (txtPhoneNumber.Text.Equals(""))
            {
                MessageBox.Show("Phone number must be entered", "Invalid Input", MessageBoxButtons.OK);
                txtPhoneNumber.Focus();
                return;
            }
            if (txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Email must be entered", "Invalid Input", MessageBoxButtons.OK);
                txtEmail.Focus();
                return;
            }


            MessageBox.Show("Customer Registered", "Success", MessageBoxButtons.OK);

            //Resets the UI
            txtFirstName.Clear();
            txtSurname.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
