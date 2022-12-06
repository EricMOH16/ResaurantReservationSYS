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

        private void makeReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMakeReservation makeReservation = new frmMakeReservation();
            this.Hide();
            makeReservation.Show();
        }

        private void addTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddTable addTable = new frmAddTable();
            this.Hide();
            addTable.Show();
        }

        private void updateTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateTable updateTable = new frmUpdateTable();
            this.Hide();
            updateTable.Show();
        }

        private void removeTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteTable deleteTable = new frmDeleteTable();
            this.Hide();
            deleteTable.Show();
        }

        private void cancelReseravtionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCancelRes cancelRes = new frmCancelRes();
            this.Hide();
            cancelRes.Show();

        }
    }
}
