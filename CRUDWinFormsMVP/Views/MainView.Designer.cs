
namespace CRUDWinFormsMVP.Views
{
    partial class MainView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCustomers = new System.Windows.Forms.Button();
            this.BtnEmployees = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnEmployees);
            this.panel1.Controls.Add(this.BtnCustomers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 565);
            this.panel1.TabIndex = 0;
            // 
            // BtnCustomers
            // 
            this.BtnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomers.Location = new System.Drawing.Point(3, 54);
            this.BtnCustomers.Name = "BtnCustomers";
            this.BtnCustomers.Size = new System.Drawing.Size(197, 37);
            this.BtnCustomers.TabIndex = 0;
            this.BtnCustomers.Text = "Customers";
            this.BtnCustomers.UseVisualStyleBackColor = true;
            // 
            // BtnEmployees
            // 
            this.BtnEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmployees.Location = new System.Drawing.Point(3, 97);
            this.BtnEmployees.Name = "BtnEmployees";
            this.BtnEmployees.Size = new System.Drawing.Size(197, 37);
            this.BtnEmployees.TabIndex = 1;
            this.BtnEmployees.Text = "Employees";
            this.BtnEmployees.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 565);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electricity Calculator";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCustomers;
        private System.Windows.Forms.Button BtnEmployees;
    }
}