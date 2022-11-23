
namespace ResaurantReservationSYS
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuItemCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.registerCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelRegistraionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemReservation = new System.Windows.Forms.ToolStripMenuItem();
            this.makeReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelReseravtionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordArrivalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemTables = new System.Windows.Forms.ToolStripMenuItem();
            this.addTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyRevenueAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyTableAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picBoxRestaurantInside = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRestaurantInside)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemCustomers,
            this.mnuItemReservation,
            this.mnuItemTables,
            this.managementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(708, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuItemCustomers
            // 
            this.mnuItemCustomers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerCustomerToolStripMenuItem,
            this.updateCustomersToolStripMenuItem,
            this.cancelRegistraionToolStripMenuItem});
            this.mnuItemCustomers.Name = "mnuItemCustomers";
            this.mnuItemCustomers.Size = new System.Drawing.Size(69, 20);
            this.mnuItemCustomers.Text = "Accounts";
            // 
            // registerCustomerToolStripMenuItem
            // 
            this.registerCustomerToolStripMenuItem.Name = "registerCustomerToolStripMenuItem";
            this.registerCustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registerCustomerToolStripMenuItem.Text = "Create Account";
            this.registerCustomerToolStripMenuItem.Click += new System.EventHandler(this.registerCustomerToolStripMenuItem_Click);
            // 
            // updateCustomersToolStripMenuItem
            // 
            this.updateCustomersToolStripMenuItem.Name = "updateCustomersToolStripMenuItem";
            this.updateCustomersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateCustomersToolStripMenuItem.Text = "Update Account";
            this.updateCustomersToolStripMenuItem.Click += new System.EventHandler(this.updateCustomersToolStripMenuItem_Click);
            // 
            // cancelRegistraionToolStripMenuItem
            // 
            this.cancelRegistraionToolStripMenuItem.Name = "cancelRegistraionToolStripMenuItem";
            this.cancelRegistraionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cancelRegistraionToolStripMenuItem.Text = "Dlete Acccount";
            this.cancelRegistraionToolStripMenuItem.Click += new System.EventHandler(this.cancelRegistraionToolStripMenuItem_Click);
            // 
            // mnuItemReservation
            // 
            this.mnuItemReservation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeReservationToolStripMenuItem,
            this.cancelReseravtionToolStripMenuItem,
            this.recordArrivalToolStripMenuItem,
            this.recordToolStripMenuItem});
            this.mnuItemReservation.Name = "mnuItemReservation";
            this.mnuItemReservation.Size = new System.Drawing.Size(85, 20);
            this.mnuItemReservation.Text = "Reservations";
            // 
            // makeReservationToolStripMenuItem
            // 
            this.makeReservationToolStripMenuItem.Name = "makeReservationToolStripMenuItem";
            this.makeReservationToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.makeReservationToolStripMenuItem.Text = "Make Reservation";
            // 
            // cancelReseravtionToolStripMenuItem
            // 
            this.cancelReseravtionToolStripMenuItem.Name = "cancelReseravtionToolStripMenuItem";
            this.cancelReseravtionToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cancelReseravtionToolStripMenuItem.Text = "Cancel Reseravtion";
            // 
            // recordArrivalToolStripMenuItem
            // 
            this.recordArrivalToolStripMenuItem.Name = "recordArrivalToolStripMenuItem";
            this.recordArrivalToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.recordArrivalToolStripMenuItem.Text = "Record Arrival";
            // 
            // recordToolStripMenuItem
            // 
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.recordToolStripMenuItem.Text = "Record Bill Paid";
            // 
            // mnuItemTables
            // 
            this.mnuItemTables.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTableToolStripMenuItem,
            this.updateTableToolStripMenuItem,
            this.removeTableToolStripMenuItem});
            this.mnuItemTables.Name = "mnuItemTables";
            this.mnuItemTables.Size = new System.Drawing.Size(51, 20);
            this.mnuItemTables.Text = "Tables";
            // 
            // addTableToolStripMenuItem
            // 
            this.addTableToolStripMenuItem.Name = "addTableToolStripMenuItem";
            this.addTableToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.addTableToolStripMenuItem.Text = "Add Table";
            // 
            // updateTableToolStripMenuItem
            // 
            this.updateTableToolStripMenuItem.Name = "updateTableToolStripMenuItem";
            this.updateTableToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.updateTableToolStripMenuItem.Text = "Update Table";
            // 
            // removeTableToolStripMenuItem
            // 
            this.removeTableToolStripMenuItem.Name = "removeTableToolStripMenuItem";
            this.removeTableToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.removeTableToolStripMenuItem.Text = "Remove Table";
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yearlyRevenueAnalysisToolStripMenuItem,
            this.yearlyTableAnalysisToolStripMenuItem});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.managementToolStripMenuItem.Text = "Management";
            // 
            // yearlyRevenueAnalysisToolStripMenuItem
            // 
            this.yearlyRevenueAnalysisToolStripMenuItem.Name = "yearlyRevenueAnalysisToolStripMenuItem";
            this.yearlyRevenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.yearlyRevenueAnalysisToolStripMenuItem.Text = "Yearly Revenue Analysis";
            // 
            // yearlyTableAnalysisToolStripMenuItem
            // 
            this.yearlyTableAnalysisToolStripMenuItem.Name = "yearlyTableAnalysisToolStripMenuItem";
            this.yearlyTableAnalysisToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.yearlyTableAnalysisToolStripMenuItem.Text = "Yearly Table Analysis";
            // 
            // picBoxRestaurantInside
            // 
            this.picBoxRestaurantInside.Image = ((System.Drawing.Image)(resources.GetObject("picBoxRestaurantInside.Image")));
            this.picBoxRestaurantInside.Location = new System.Drawing.Point(0, 27);
            this.picBoxRestaurantInside.Name = "picBoxRestaurantInside";
            this.picBoxRestaurantInside.Size = new System.Drawing.Size(708, 400);
            this.picBoxRestaurantInside.TabIndex = 1;
            this.picBoxRestaurantInside.TabStop = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 427);
            this.Controls.Add(this.picBoxRestaurantInside);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMenu";
            this.Text = "Restaurant Reservations Main Page";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRestaurantInside)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuItemCustomers;
        private System.Windows.Forms.ToolStripMenuItem registerCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelRegistraionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItemReservation;
        private System.Windows.Forms.ToolStripMenuItem makeReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelReseravtionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordArrivalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItemTables;
        private System.Windows.Forms.ToolStripMenuItem addTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearlyRevenueAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearlyTableAnalysisToolStripMenuItem;
        private System.Windows.Forms.PictureBox picBoxRestaurantInside;
    }
}

