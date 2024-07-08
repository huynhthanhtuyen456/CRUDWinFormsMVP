using CRUDWinFormsMVP.Views.Common.Enums;
using ElectricCalculator.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDWinFormsMVP.Views
{
    public partial class EmployeeView : Form, IEmployeeView
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        private readonly string NameRgxPattern = @"^[A-Za-z\s]+$";

        //Constructor
        public EmployeeView()
        {
            InitializeComponent();
            this.ComboBoxEducation.DataSource = Enum.GetValues(typeof(EducationEnum));
            this.ComboBoxGender.DataSource = Enum.GetValues(typeof(GenderEnum));
            AssociateAndRaiseViewEvents();
            EmployeeTabControl.TabPages.Remove(TabPageEmployeeDetail);
            btnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            //Search
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
              {
                  if (e.KeyCode == Keys.Enter)
                      SearchEvent?.Invoke(this, EventArgs.Empty);
              };
            //Add new
            btnAddNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                EmployeeTabControl.TabPages.Remove(TabPageEmployeeList);
                EmployeeTabControl.TabPages.Add(TabPageEmployeeDetail);
                TabPageEmployeeDetail.Text = "Add Employee";
            };
            //Edit
            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                EmployeeTabControl.TabPages.Remove(TabPageEmployeeList);
                EmployeeTabControl.TabPages.Add(TabPageEmployeeDetail);
                TabPageEmployeeDetail.Text = "Edit Employee";
            };
            //Save changes
            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    EmployeeTabControl.TabPages.Remove(TabPageEmployeeDetail);
                    EmployeeTabControl.TabPages.Add(TabPageEmployeeList);
                }
                MessageBox.Show(Message);
            };
            //Cancel
            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                EmployeeTabControl.TabPages.Remove(TabPageEmployeeDetail);
                EmployeeTabControl.TabPages.Add(TabPageEmployeeList);
            };
            //Delete
            btnDelete.Click += delegate
            {               
                var result = MessageBox.Show("Are you sure you want to delete the selected employee?", "Warning",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        //Properties
        public string EmployeeId
        {
            get { return TxtEmployeeId.Text; }
            set { TxtEmployeeId.Text = value; }
        }

        public string EmployeeName
        {
            get { return TxtEmployeeName.Text; }
            set { TxtEmployeeName.Text = value; }
        }

        public DateTime EmployeeDateOfBirth
        {
            get { return DtpEmployeeDOB.Value; }
            set { DtpEmployeeDOB.Value = value; }
        }

        public int EmployeeGender
        {
            get { return ComboBoxGender.SelectedIndex; }
            set { ComboBoxGender.SelectedIndex = value; }
        }

        public int EmployeeEducation
        {
            get { return ComboBoxEducation.SelectedIndex; }
            set { ComboBoxEducation.SelectedIndex = value; }
        }

        public string SearchValue
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }

        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }

        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //Methods
        public void SetEmployeeListBindingSource(BindingSource employeeList)
        {
            dataGridView.DataSource = employeeList;
        }

        //Singleton pattern (Open a single form instance)
        private static EmployeeView instance;
        public static EmployeeView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new EmployeeView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

        /// <summary>
        /// Return true if name field is only text; otherwise, False
        /// </summary>
        /// <param name="name"></param>
        /// <returns>True if name is text else False</returns>
        private bool IsValidName(string name)
        {
            Regex nameRegex = new Regex(this.NameRgxPattern);
            return true && nameRegex.IsMatch(name);
        }

        private void TxtEmployeeName_TextChanged(object sender, EventArgs e)
        {
            this.LblNameMsgError.Text = string.Empty;
            if (!this.IsValidName(this.TxtEmployeeName.Text))
            {
                this.LblNameMsgError.Text = "Only accepting alphabet!";
                this.LblNameMsgError.ForeColor = Color.Red;
                this.BtnSave.Enabled = false;
                return;
            }
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            this.TxtEmployeeName.Text = textInfo.ToTitleCase(this.TxtEmployeeName.Text);
            this.TxtEmployeeName.Select(this.TxtEmployeeName.Text.Length, this.TxtEmployeeName.Text.Length - 1);
            this.BtnSave.Enabled = true;
        }
    }
}
