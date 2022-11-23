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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void registerCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateAccount CreateAccount = new frmCreateAccount();
            this.Hide();
            CreateAccount.Show();


        }

        private void updateCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateAccount UpdateAccount = new frmUpdateAccount();
            this.Hide();
            UpdateAccount.Show();

        }

        private void cancelRegistraionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteAccount DeleteAccount = new frmDeleteAccount();
            this.Hide();
            DeleteAccount.Show();

        }
    }
}
