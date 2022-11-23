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
    public partial class frmUpdateTable : Form
    {
        public frmUpdateTable()
        {
            InitializeComponent();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Table has been updated", "Success", MessageBoxButtons.OK);
            
            
        }
    }
}
