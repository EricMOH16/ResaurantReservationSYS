
namespace ResaurantReservationSYS
{
    partial class frmDeleteAccount
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
            this.txtAccountID = new System.Windows.Forms.TextBox();
            this.lblAccountId = new System.Windows.Forms.Label();
            this.cboBoxDeleteReason = new System.Windows.Forms.ComboBox();
            this.labelReason = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpboxReason = new System.Windows.Forms.GroupBox();
            this.txtBoxDeleteInfo = new System.Windows.Forms.RichTextBox();
            this.grpboxReason.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAccountID
            // 
            this.txtAccountID.Enabled = false;
            this.txtAccountID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(101)))));
            this.txtAccountID.Location = new System.Drawing.Point(163, 8);
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.Size = new System.Drawing.Size(100, 20);
            this.txtAccountID.TabIndex = 14;
            this.txtAccountID.TextChanged += new System.EventHandler(this.txtAccountID_TextChanged);
            // 
            // lblAccountId
            // 
            this.lblAccountId.AutoSize = true;
            this.lblAccountId.Location = new System.Drawing.Point(83, 11);
            this.lblAccountId.Name = "lblAccountId";
            this.lblAccountId.Size = new System.Drawing.Size(61, 13);
            this.lblAccountId.TabIndex = 13;
            this.lblAccountId.Text = "Account ID";
            // 
            // cboBoxDeleteReason
            // 
            this.cboBoxDeleteReason.FormattingEnabled = true;
            this.cboBoxDeleteReason.Location = new System.Drawing.Point(189, 61);
            this.cboBoxDeleteReason.Name = "cboBoxDeleteReason";
            this.cboBoxDeleteReason.Size = new System.Drawing.Size(121, 21);
            this.cboBoxDeleteReason.TabIndex = 15;
            this.cboBoxDeleteReason.SelectedIndexChanged += new System.EventHandler(this.cboBoxDeleteReason_SelectedIndexChanged);
            this.cboBoxDeleteReason.TextChanged += new System.EventHandler(this.rea);
            // 
            // labelReason
            // 
            this.labelReason.AutoSize = true;
            this.labelReason.Location = new System.Drawing.Point(5, 64);
            this.labelReason.Name = "labelReason";
            this.labelReason.Size = new System.Drawing.Size(178, 13);
            this.labelReason.TabIndex = 16;
            this.labelReason.Text = "Why are you deleting your account?";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(189, 255);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 20;
            this.btnRegister.Text = "Update";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(86, 255);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpboxReason
            // 
            this.grpboxReason.Controls.Add(this.txtBoxDeleteInfo);
            this.grpboxReason.Location = new System.Drawing.Point(73, 99);
            this.grpboxReason.Name = "grpboxReason";
            this.grpboxReason.Size = new System.Drawing.Size(206, 131);
            this.grpboxReason.TabIndex = 21;
            this.grpboxReason.TabStop = false;
            this.grpboxReason.Text = "Additonal Information";
            // 
            // txtBoxDeleteInfo
            // 
            this.txtBoxDeleteInfo.Location = new System.Drawing.Point(13, 29);
            this.txtBoxDeleteInfo.Name = "txtBoxDeleteInfo";
            this.txtBoxDeleteInfo.Size = new System.Drawing.Size(177, 96);
            this.txtBoxDeleteInfo.TabIndex = 22;
            this.txtBoxDeleteInfo.Text = "";
            // 
            // frmDeleteAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 320);
            this.Controls.Add(this.grpboxReason);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelReason);
            this.Controls.Add(this.cboBoxDeleteReason);
            this.Controls.Add(this.txtAccountID);
            this.Controls.Add(this.lblAccountId);
            this.Name = "frmDeleteAccount";
            this.Text = "frmDeleteAccount";
            this.grpboxReason.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccountID;
        private System.Windows.Forms.Label lblAccountId;
        private System.Windows.Forms.ComboBox cboBoxDeleteReason;
        private System.Windows.Forms.Label labelReason;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpboxReason;
        private System.Windows.Forms.RichTextBox txtBoxDeleteInfo;
    }
}