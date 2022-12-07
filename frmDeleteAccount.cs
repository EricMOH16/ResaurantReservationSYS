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
    public partial class frmDeleteAccount : Form
    {
        public frmDeleteAccount()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancellation Successful", "Cancellation", MessageBoxButtons.OK);
            
        }

        private void txtAccountID_TextChanged(object sender, EventArgs e)
        {
        }

        private void cboBoxDeleteReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void rea(object sender, EventArgs e)
        {

        }

        private void frmDeleteAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
