namespace BankSystem
{
    partial class BankManagment
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankManagment));
            this.navigatoionPanel = new System.Windows.Forms.Panel();
            this.withdraw = new System.Windows.Forms.Button();
            this.deposit = new System.Windows.Forms.Button();
            this.transactionLog = new System.Windows.Forms.Button();
            this.accountInfo = new System.Windows.Forms.Button();
            this.bankInfo = new System.Windows.Forms.Button();
            this.showPanel = new System.Windows.Forms.Panel();
            this.login1 = new BankSystem.Login();
            this.navigatoionPanel.SuspendLayout();
            this.showPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigatoionPanel
            // 
            this.navigatoionPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.navigatoionPanel.Controls.Add(this.withdraw);
            this.navigatoionPanel.Controls.Add(this.deposit);
            this.navigatoionPanel.Controls.Add(this.transactionLog);
            this.navigatoionPanel.Controls.Add(this.accountInfo);
            this.navigatoionPanel.Controls.Add(this.bankInfo);
            this.navigatoionPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigatoionPanel.Location = new System.Drawing.Point(0, 0);
            this.navigatoionPanel.Name = "navigatoionPanel";
            this.navigatoionPanel.Size = new System.Drawing.Size(226, 655);
            this.navigatoionPanel.TabIndex = 0;
            // 
            // withdraw
            // 
            this.withdraw.AutoSize = true;
            this.withdraw.BackColor = System.Drawing.Color.DarkSlateGray;
            this.withdraw.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.withdraw.FlatAppearance.BorderSize = 0;
            this.withdraw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.withdraw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.withdraw.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.withdraw.ForeColor = System.Drawing.Color.LimeGreen;
            this.withdraw.Image = ((System.Drawing.Image)(resources.GetObject("withdraw.Image")));
            this.withdraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.withdraw.Location = new System.Drawing.Point(0, 469);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(225, 95);
            this.withdraw.TabIndex = 5;
            this.withdraw.Text = "            Withdraw";
            this.withdraw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.withdraw.UseCompatibleTextRendering = true;
            this.withdraw.UseVisualStyleBackColor = false;
            this.withdraw.Click += new System.EventHandler(this.withdraw_Click);
            // 
            // deposit
            // 
            this.deposit.AutoSize = true;
            this.deposit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.deposit.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.deposit.FlatAppearance.BorderSize = 0;
            this.deposit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.deposit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.deposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deposit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deposit.ForeColor = System.Drawing.Color.LimeGreen;
            this.deposit.Image = ((System.Drawing.Image)(resources.GetObject("deposit.Image")));
            this.deposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deposit.Location = new System.Drawing.Point(0, 375);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(225, 95);
            this.deposit.TabIndex = 4;
            this.deposit.Text = "            Deposit";
            this.deposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deposit.UseCompatibleTextRendering = true;
            this.deposit.UseVisualStyleBackColor = false;
            this.deposit.Click += new System.EventHandler(this.deposit_Click);
            // 
            // transactionLog
            // 
            this.transactionLog.AutoSize = true;
            this.transactionLog.BackColor = System.Drawing.Color.DarkSlateGray;
            this.transactionLog.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.transactionLog.FlatAppearance.BorderSize = 0;
            this.transactionLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.transactionLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.transactionLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactionLog.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.transactionLog.ForeColor = System.Drawing.Color.LimeGreen;
            this.transactionLog.Image = ((System.Drawing.Image)(resources.GetObject("transactionLog.Image")));
            this.transactionLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transactionLog.Location = new System.Drawing.Point(0, 280);
            this.transactionLog.Name = "transactionLog";
            this.transactionLog.Size = new System.Drawing.Size(225, 95);
            this.transactionLog.TabIndex = 3;
            this.transactionLog.Text = "            Transaction Log";
            this.transactionLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transactionLog.UseCompatibleTextRendering = true;
            this.transactionLog.UseVisualStyleBackColor = false;
            this.transactionLog.Click += new System.EventHandler(this.transactionLog_Click);
            // 
            // accountInfo
            // 
            this.accountInfo.AutoSize = true;
            this.accountInfo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.accountInfo.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.accountInfo.FlatAppearance.BorderSize = 0;
            this.accountInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.accountInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.accountInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountInfo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accountInfo.ForeColor = System.Drawing.Color.LimeGreen;
            this.accountInfo.Image = ((System.Drawing.Image)(resources.GetObject("accountInfo.Image")));
            this.accountInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountInfo.Location = new System.Drawing.Point(0, 188);
            this.accountInfo.Name = "accountInfo";
            this.accountInfo.Size = new System.Drawing.Size(225, 95);
            this.accountInfo.TabIndex = 1;
            this.accountInfo.Text = "            Account Info";
            this.accountInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountInfo.UseCompatibleTextRendering = true;
            this.accountInfo.UseVisualStyleBackColor = false;
            this.accountInfo.Click += new System.EventHandler(this.accountInfo_Click);
            // 
            // bankInfo
            // 
            this.bankInfo.AutoSize = true;
            this.bankInfo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bankInfo.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.bankInfo.FlatAppearance.BorderSize = 0;
            this.bankInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.bankInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.bankInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bankInfo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bankInfo.ForeColor = System.Drawing.Color.LimeGreen;
            this.bankInfo.Image = ((System.Drawing.Image)(resources.GetObject("bankInfo.Image")));
            this.bankInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bankInfo.Location = new System.Drawing.Point(0, 93);
            this.bankInfo.Name = "bankInfo";
            this.bankInfo.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.bankInfo.Size = new System.Drawing.Size(225, 95);
            this.bankInfo.TabIndex = 0;
            this.bankInfo.Text = "            Bank Info";
            this.bankInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bankInfo.UseCompatibleTextRendering = true;
            this.bankInfo.UseVisualStyleBackColor = false;
            this.bankInfo.Click += new System.EventHandler(this.bankInfo_Click);
            // 
            // showPanel
            // 
            this.showPanel.BackColor = System.Drawing.Color.Lavender;
            this.showPanel.Controls.Add(this.login1);
            this.showPanel.Location = new System.Drawing.Point(226, 0);
            this.showPanel.Name = "showPanel";
            this.showPanel.Size = new System.Drawing.Size(876, 655);
            this.showPanel.TabIndex = 1;
            // 
            // login1
            // 
            this.login1.AutoSize = true;
            this.login1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.login1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login1.Location = new System.Drawing.Point(0, 0);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(876, 655);
            this.login1.TabIndex = 2;
            // 
            // BankManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 655);
            this.Controls.Add(this.showPanel);
            this.Controls.Add(this.navigatoionPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1120, 702);
            this.MinimumSize = new System.Drawing.Size(1120, 702);
            this.Name = "BankManagment";
            this.Text = "Bank Managment";
            this.Load += new System.EventHandler(this.BankManagment_Load);
            this.navigatoionPanel.ResumeLayout(false);
            this.navigatoionPanel.PerformLayout();
            this.showPanel.ResumeLayout(false);
            this.showPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel navigatoionPanel;
        private Button bankInfo;
        private Button accountInfo;
        private Button withdraw;
        private Button deposit;
        private Button transactionLog;
        private Panel showPanel;
        private Login login1;
    }
}