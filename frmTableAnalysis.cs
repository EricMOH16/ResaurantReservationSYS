﻿using System;
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
    public partial class frmTableAnalysis : Form
    {
        public frmTableAnalysis()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var choice = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);

            if (choice == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                return;
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            frmRevenueAnalysis revenueAnalysis = new frmRevenueAnalysis();
            this.Hide();
            revenueAnalysis.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var choice = MessageBox.Show("Are you sure you want to return to the main menu?", "Cancel", MessageBoxButtons.YesNo);

            if (choice == DialogResult.Yes)
            {
                frmMainMenu mainMenu = new frmMainMenu();
                this.Hide();
                mainMenu.Show();
            }
            else
                return;
        }
    }
}
