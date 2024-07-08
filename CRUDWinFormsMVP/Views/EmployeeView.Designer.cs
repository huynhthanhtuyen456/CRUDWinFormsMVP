
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
            this.TabPageEmployeeList = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.LblSearchEmployee = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.TabPageEmployeeDetail = new System.Windows.Forms.TabPage();
            this.LblNameMsgError = new System.Windows.Forms.Label();
            this.ComboBoxGender = new System.Windows.Forms.ComboBox();
            this.ComboBoxEducation = new System.Windows.Forms.ComboBox();
            this.LblEducation = new System.Windows.Forms.Label();
            this.DtpEmployeeDOB = new System.Windows.Forms.DateTimePicker();
            this.LblDateOfBirth = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.LblGender = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtEmployeeName = new System.Windows.Forms.TextBox();
            this.LblID = new System.Windows.Forms.Label();
            this.TxtEmployeeId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomerOccupation = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.EmployeeTabControl.SuspendLayout();
            this.TabPageEmployeeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.TabPageEmployeeDetail.SuspendLayout();
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
            this.EmployeeTabControl.Controls.Add(this.TabPageEmployeeList);
            this.EmployeeTabControl.Controls.Add(this.TabPageEmployeeDetail);
            this.EmployeeTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeTabControl.Location = new System.Drawing.Point(0, 56);
            this.EmployeeTabControl.Name = "EmployeeTabControl";
            this.EmployeeTabControl.SelectedIndex = 0;
            this.EmployeeTabControl.Size = new System.Drawing.Size(892, 411);
            this.EmployeeTabControl.TabIndex = 2;
            // 
            // TabPageEmployeeList
            // 
            this.TabPageEmployeeList.Controls.Add(this.dataGridView);
            this.TabPageEmployeeList.Controls.Add(this.LblSearchEmployee);
            this.TabPageEmployeeList.Controls.Add(this.btnDelete);
            this.TabPageEmployeeList.Controls.Add(this.btnEdit);
            this.TabPageEmployeeList.Controls.Add(this.btnAddNew);
            this.TabPageEmployeeList.Controls.Add(this.btnSearch);
            this.TabPageEmployeeList.Controls.Add(this.txtSearch);
            this.TabPageEmployeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPageEmployeeList.Location = new System.Drawing.Point(4, 29);
            this.TabPageEmployeeList.Name = "TabPageEmployeeList";
            this.TabPageEmployeeList.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageEmployeeList.Size = new System.Drawing.Size(884, 378);
            this.TabPageEmployeeList.TabIndex = 0;
            this.TabPageEmployeeList.Text = "Employee list";
            this.TabPageEmployeeList.UseVisualStyleBackColor = true;
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
            // TabPageEmployeeDetail
            // 
            this.TabPageEmployeeDetail.Controls.Add(this.LblNameMsgError);
            this.TabPageEmployeeDetail.Controls.Add(this.ComboBoxGender);
            this.TabPageEmployeeDetail.Controls.Add(this.ComboBoxEducation);
            this.TabPageEmployeeDetail.Controls.Add(this.LblEducation);
            this.TabPageEmployeeDetail.Controls.Add(this.DtpEmployeeDOB);
            this.TabPageEmployeeDetail.Controls.Add(this.LblDateOfBirth);
            this.TabPageEmployeeDetail.Controls.Add(this.BtnCancel);
            this.TabPageEmployeeDetail.Controls.Add(this.BtnSave);
            this.TabPageEmployeeDetail.Controls.Add(this.LblGender);
            this.TabPageEmployeeDetail.Controls.Add(this.LblName);
            this.TabPageEmployeeDetail.Controls.Add(this.TxtEmployeeName);
            this.TabPageEmployeeDetail.Controls.Add(this.LblID);
            this.TabPageEmployeeDetail.Controls.Add(this.TxtEmployeeId);
            this.TabPageEmployeeDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPageEmployeeDetail.Location = new System.Drawing.Point(4, 29);
            this.TabPageEmployeeDetail.Name = "TabPageEmployeeDetail";
            this.TabPageEmployeeDetail.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageEmployeeDetail.Size = new System.Drawing.Size(884, 378);
            this.TabPageEmployeeDetail.TabIndex = 1;
            this.TabPageEmployeeDetail.Text = "Employee detail";
            this.TabPageEmployeeDetail.UseVisualStyleBackColor = true;
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
            // ComboBoxGender
            // 
            this.ComboBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxGender.FormattingEnabled = true;
            this.ComboBoxGender.Location = new System.Drawing.Point(63, 199);
            this.ComboBoxGender.Name = "ComboBoxGender";
            this.ComboBoxGender.Size = new System.Drawing.Size(183, 28);
            this.ComboBoxGender.TabIndex = 20;
            // 
            // ComboBoxEducation
            // 
            this.ComboBoxEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxEducation.FormattingEnabled = true;
            this.ComboBoxEducation.Location = new System.Drawing.Point(260, 199);
            this.ComboBoxEducation.Name = "ComboBoxEducation";
            this.ComboBoxEducation.Size = new System.Drawing.Size(183, 28);
            this.ComboBoxEducation.TabIndex = 19;
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
            // DtpEmployeeDOB
            // 
            this.DtpEmployeeDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpEmployeeDOB.Location = new System.Drawing.Point(264, 54);
            this.DtpEmployeeDOB.Name = "DtpEmployeeDOB";
            this.DtpEmployeeDOB.Size = new System.Drawing.Size(286, 26);
            this.DtpEmployeeDOB.TabIndex = 17;
            // 
            // LblDateOfBirth
            // 
            this.LblDateOfBirth.AutoSize = true;
            this.LblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDateOfBirth.Location = new System.Drawing.Point(260, 31);
            this.LblDateOfBirth.Name = "LblDateOfBirth";
            this.LblDateOfBirth.Size = new System.Drawing.Size(106, 20);
            this.LblDateOfBirth.TabIndex = 16;
            this.LblDateOfBirth.Text = "Date Of Birth:";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(260, 247);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(183, 44);
            this.BtnCancel.TabIndex = 15;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(63, 247);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(183, 44);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGender.Location = new System.Drawing.Point(59, 175);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(67, 20);
            this.LblGender.TabIndex = 13;
            this.LblGender.Text = "Gender:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(59, 102);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(55, 20);
            this.LblName.TabIndex = 9;
            this.LblName.Text = "Name:";
            // 
            // TxtEmployeeName
            // 
            this.TxtEmployeeName.Location = new System.Drawing.Point(63, 125);
            this.TxtEmployeeName.Name = "TxtEmployeeName";
            this.TxtEmployeeName.Size = new System.Drawing.Size(183, 29);
            this.TxtEmployeeName.TabIndex = 8;
            this.TxtEmployeeName.TextChanged += new System.EventHandler(this.TxtEmployeeName_TextChanged);
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.Location = new System.Drawing.Point(59, 31);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(30, 20);
            this.LblID.TabIndex = 7;
            this.LblID.Text = "ID:";
            // 
            // TxtEmployeeId
            // 
            this.TxtEmployeeId.Location = new System.Drawing.Point(63, 54);
            this.TxtEmployeeId.Name = "TxtEmployeeId";
            this.TxtEmployeeId.ReadOnly = true;
            this.TxtEmployeeId.Size = new System.Drawing.Size(154, 29);
            this.TxtEmployeeId.TabIndex = 6;
            this.TxtEmployeeId.Text = "0";
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
            this.TabPageEmployeeList.ResumeLayout(false);
            this.TabPageEmployeeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.TabPageEmployeeDetail.ResumeLayout(false);
            this.TabPageEmployeeDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LbLEmployeesTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl EmployeeTabControl;
        private System.Windows.Forms.TabPage TabPageEmployeeList;
        private System.Windows.Forms.Label LblSearchEmployee;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabPage TabPageEmployeeDetail;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label lblCustomerOccupation;
        private System.Windows.Forms.TextBox txtCustomerOccupation;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtCustomerDateOfBirth;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtEmployeeName;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.TextBox TxtEmployeeId;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label LblDateOfBirth;
        private System.Windows.Forms.DateTimePicker DtpEmployeeDOB;
        private System.Windows.Forms.ComboBox ComboBoxEducation;
        private System.Windows.Forms.Label LblEducation;
        private System.Windows.Forms.ComboBox ComboBoxGender;
        private System.Windows.Forms.Label LblNameMsgError;
    }
}