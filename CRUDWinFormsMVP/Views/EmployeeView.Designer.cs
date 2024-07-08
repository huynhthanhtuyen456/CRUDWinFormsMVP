
namespace CRUDWinFormsMVP.Views
{
    partial class EmployeeView
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
            this.LbLEmployeesTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.EmployeeTabControl = new System.Windows.Forms.TabControl();
            this.tabPagePetList = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.LblSearchEmployee = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabPagePetDetail = new System.Windows.Forms.TabPage();
            this.LblNameMsgError = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboBoxEducation = new System.Windows.Forms.ComboBox();
            this.LblEducation = new System.Windows.Forms.Label();
            this.dtpCustomerDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblGender = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomerOccupation = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.EmployeeTabControl.SuspendLayout();
            this.tabPagePetList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabPagePetDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbLEmployeesTitle
            // 
            this.LbLEmployeesTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LbLEmployeesTitle.AutoSize = true;
            this.LbLEmployeesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLEmployeesTitle.Location = new System.Drawing.Point(363, 17);
            this.LbLEmployeesTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbLEmployeesTitle.Name = "LbLEmployeesTitle";
            this.LbLEmployeesTitle.Size = new System.Drawing.Size(135, 25);
            this.LbLEmployeesTitle.TabIndex = 0;
            this.LbLEmployeesTitle.Text = "EMPLOYEES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.LbLEmployeesTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 56);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(851, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 30);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // EmployeeTabControl
            // 
            this.EmployeeTabControl.Controls.Add(this.tabPagePetList);
            this.EmployeeTabControl.Controls.Add(this.tabPagePetDetail);
            this.EmployeeTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeTabControl.Location = new System.Drawing.Point(0, 56);
            this.EmployeeTabControl.Name = "EmployeeTabControl";
            this.EmployeeTabControl.SelectedIndex = 0;
            this.EmployeeTabControl.Size = new System.Drawing.Size(892, 411);
            this.EmployeeTabControl.TabIndex = 2;
            // 
            // tabPagePetList
            // 
            this.tabPagePetList.Controls.Add(this.dataGridView);
            this.tabPagePetList.Controls.Add(this.LblSearchEmployee);
            this.tabPagePetList.Controls.Add(this.btnDelete);
            this.tabPagePetList.Controls.Add(this.btnEdit);
            this.tabPagePetList.Controls.Add(this.btnAddNew);
            this.tabPagePetList.Controls.Add(this.btnSearch);
            this.tabPagePetList.Controls.Add(this.txtSearch);
            this.tabPagePetList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePetList.Location = new System.Drawing.Point(4, 29);
            this.tabPagePetList.Name = "tabPagePetList";
            this.tabPagePetList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePetList.Size = new System.Drawing.Size(884, 378);
            this.tabPagePetList.TabIndex = 0;
            this.tabPagePetList.Text = "Employee list";
            this.tabPagePetList.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(8, 62);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(737, 307);
            this.dataGridView.TabIndex = 7;
            // 
            // LblSearchEmployee
            // 
            this.LblSearchEmployee.AutoSize = true;
            this.LblSearchEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearchEmployee.Location = new System.Drawing.Point(3, 8);
            this.LblSearchEmployee.Name = "LblSearchEmployee";
            this.LblSearchEmployee.Size = new System.Drawing.Size(138, 20);
            this.LblSearchEmployee.TabIndex = 5;
            this.LblSearchEmployee.Text = "Search Employee:";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(767, 137);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(767, 101);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(99, 30);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.Location = new System.Drawing.Point(767, 65);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(99, 30);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "Add";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(767, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(8, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(737, 26);
            this.txtSearch.TabIndex = 0;
            // 
            // tabPagePetDetail
            // 
            this.tabPagePetDetail.Controls.Add(this.LblNameMsgError);
            this.tabPagePetDetail.Controls.Add(this.comboBoxGender);
            this.tabPagePetDetail.Controls.Add(this.comboBoxEducation);
            this.tabPagePetDetail.Controls.Add(this.LblEducation);
            this.tabPagePetDetail.Controls.Add(this.dtpCustomerDOB);
            this.tabPagePetDetail.Controls.Add(this.lblDateOfBirth);
            this.tabPagePetDetail.Controls.Add(this.btnCancel);
            this.tabPagePetDetail.Controls.Add(this.btnSave);
            this.tabPagePetDetail.Controls.Add(this.lblGender);
            this.tabPagePetDetail.Controls.Add(this.label4);
            this.tabPagePetDetail.Controls.Add(this.txtCustomerName);
            this.tabPagePetDetail.Controls.Add(this.label3);
            this.tabPagePetDetail.Controls.Add(this.txtCustomerId);
            this.tabPagePetDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePetDetail.Location = new System.Drawing.Point(4, 29);
            this.tabPagePetDetail.Name = "tabPagePetDetail";
            this.tabPagePetDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePetDetail.Size = new System.Drawing.Size(884, 378);
            this.tabPagePetDetail.TabIndex = 1;
            this.tabPagePetDetail.Text = "Employee detail";
            this.tabPagePetDetail.UseVisualStyleBackColor = true;
            // 
            // LblNameMsgError
            // 
            this.LblNameMsgError.AutoSize = true;
            this.LblNameMsgError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNameMsgError.Location = new System.Drawing.Point(260, 125);
            this.LblNameMsgError.Name = "LblNameMsgError";
            this.LblNameMsgError.Size = new System.Drawing.Size(0, 20);
            this.LblNameMsgError.TabIndex = 21;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(63, 199);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(183, 28);
            this.comboBoxGender.TabIndex = 20;
            // 
            // comboBoxEducation
            // 
            this.comboBoxEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEducation.FormattingEnabled = true;
            this.comboBoxEducation.Location = new System.Drawing.Point(260, 199);
            this.comboBoxEducation.Name = "comboBoxEducation";
            this.comboBoxEducation.Size = new System.Drawing.Size(183, 28);
            this.comboBoxEducation.TabIndex = 19;
            // 
            // LblEducation
            // 
            this.LblEducation.AutoSize = true;
            this.LblEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEducation.Location = new System.Drawing.Point(260, 175);
            this.LblEducation.Name = "LblEducation";
            this.LblEducation.Size = new System.Drawing.Size(85, 20);
            this.LblEducation.TabIndex = 18;
            this.LblEducation.Text = "Education:";
            // 
            // dtpCustomerDOB
            // 
            this.dtpCustomerDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCustomerDOB.Location = new System.Drawing.Point(264, 54);
            this.dtpCustomerDOB.Name = "dtpCustomerDOB";
            this.dtpCustomerDOB.Size = new System.Drawing.Size(286, 26);
            this.dtpCustomerDOB.TabIndex = 17;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(260, 31);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(106, 20);
            this.lblDateOfBirth.TabIndex = 16;
            this.lblDateOfBirth.Text = "Date Of Birth:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(260, 247);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(183, 44);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(63, 247);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(183, 44);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(59, 175);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(67, 20);
            this.lblGender.TabIndex = 13;
            this.lblGender.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(63, 125);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(183, 29);
            this.txtCustomerName.TabIndex = 8;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID:";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(63, 54);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.ReadOnly = true;
            this.txtCustomerId.Size = new System.Drawing.Size(154, 29);
            this.txtCustomerId.TabIndex = 6;
            this.txtCustomerId.Text = "0";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            // 
            // txtCustomerOccupation
            // 
            this.txtCustomerOccupation.Location = new System.Drawing.Point(0, 0);
            this.txtCustomerOccupation.Name = "txtCustomerOccupation";
            this.txtCustomerOccupation.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerOccupation.TabIndex = 0;
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 467);
            this.Controls.Add(this.EmployeeTabControl);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EmployeeView";
            this.Text = "Employee View";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.EmployeeTabControl.ResumeLayout(false);
            this.tabPagePetList.ResumeLayout(false);
            this.tabPagePetList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabPagePetDetail.ResumeLayout(false);
            this.tabPagePetDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LbLEmployeesTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl EmployeeTabControl;
        private System.Windows.Forms.TabPage tabPagePetList;
        private System.Windows.Forms.Label LblSearchEmployee;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabPage tabPagePetDetail;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCustomerOccupation;
        private System.Windows.Forms.TextBox txtCustomerOccupation;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtCustomerDateOfBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpCustomerDOB;
        private System.Windows.Forms.ComboBox comboBoxEducation;
        private System.Windows.Forms.Label LblEducation;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label LblNameMsgError;
    }
}