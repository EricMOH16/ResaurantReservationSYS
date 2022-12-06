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
    public partial class frmCancelRes : Form
    {
        public frmCancelRes()
        {
            InitializeComponent();
        }

        private void cboBoxReason_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmCancelRes_Load(object sender, EventArgs e)
        {
            cboBoxReason.Items.Add("Advice from others");
            cboBoxReason.Items.Add("Bad online review");
            cboBoxReason.Items.Add("Poor past Experience");
        }

        private void btnNewRes_Click(object sender, EventArgs e)
        {
            frmMakeReservation makeReservation = new frmMakeReservation();
            this.Hide();
            makeReservation.Show();

        }

        private void btnConfrim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to cancel this reservation?","Confrim",MessageBoxButtons.YesNo);
           if(Mess)
               

        }
    }
}
