namespace BankSystem
{
    partial class Logs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.deposited = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.withdrawn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel1.Controls.Add(this.deposited);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 655);
            this.panel1.TabIndex = 0;
            // 
            // deposited
            // 
            this.deposited.BackColor = System.Drawing.Color.Aquamarine;
            this.deposited.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deposited.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deposited.Location = new System.Drawing.Point(0, 78);
            this.deposited.Multiline = true;
            this.deposited.Name = "deposited";
            this.deposited.ReadOnly = true;
            this.deposited.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.deposited.Size = new System.Drawing.Size(438, 577);
            this.deposited.TabIndex = 1;
            this.deposited.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deposited";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Controls.Add(this.withdrawn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(438, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 655);
            this.panel2.TabIndex = 1;
            // 
            // withdrawn
            // 
            this.withdrawn.BackColor = System.Drawing.Color.LightSalmon;
            this.withdrawn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.withdrawn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.withdrawn.Location = new System.Drawing.Point(0, 78);
            this.withdrawn.Multiline = true;
            this.withdrawn.Name = "withdrawn";
            this.withdrawn.ReadOnly = true;
            this.withdrawn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.withdrawn.Size = new System.Drawing.Size(438, 577);
            this.withdrawn.TabIndex = 2;
            this.withdrawn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(438, 75);
            this.label2.TabIndex = 1;
            this.label2.Text = "Withdrawn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Logs";
            this.Size = new System.Drawing.Size(876, 655);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox deposited;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private TextBox withdrawn;
    }
}
