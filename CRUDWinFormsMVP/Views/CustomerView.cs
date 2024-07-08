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
    public partial class CustomerView : Form, ICustomerView
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        private readonly string NameRgxPattern = @"^[A-Za-z\s]+$";

        //Constructor
        public CustomerView()
        {
            InitializeComponent();
            this.comboBoxOccupation.DataSource = Enum.GetValues(typeof(OccupationEnum));
            this.comboBoxGender.DataSource = Enum.GetValues(typeof(GenderEnum));
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPagePetDetail);
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
                tabControl1.TabPages.Remove(tabPagePetList);
                tabControl1.TabPages.Add(tabPagePetDetail);
                tabPagePetDetail.Text = "Add customer";
            };
            //Edit
            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPagePetList);
                tabControl1.TabPages.Add(tabPagePetDetail);
                tabPagePetDetail.Text = "Edit customer";
            };
            //Save changes
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPagePetDetail);
                    tabControl1.TabPages.Add(tabPagePetList);
                }
                MessageBox.Show(Message);
            };
            //Cancel
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPagePetDetail);
                tabControl1.TabPages.Add(tabPagePetList);
            };
            //Delete
            btnDelete.Click += delegate
            {               
                var result = MessageBox.Show("Are you sure you want to delete the selected customer?", "Warning",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        //Properties
        public string CustomerId
        {
            get { return txtCustomerId.Text; }
            set { txtCustomerId.Text = value; }
        }

        public string CustomerName
        {
            get { return txtCustomerName.Text; }
            set { txtCustomerName.Text = value; }
        }

        public DateTime CustomerDateOfBirth
        {
            get { return dtpCustomerDOB.Value; }
            set { dtpCustomerDOB.Value = value; }
        }

        public int CustomerGender
        {
            get { return comboBoxGender.SelectedIndex; }
            set { comboBoxGender.SelectedIndex = value; }
        }

        public int CustomerOccupation
        {
            get { return comboBoxOccupation.SelectedIndex; }
            set { comboBoxOccupation.SelectedIndex = value; }
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
        public void SetCustomerListBindingSource(BindingSource customerList)
        {
            dataGridView.DataSource = customerList;
        }

        //Singleton pattern (Open a single form instance)
        private static CustomerView instance;
        public static CustomerView GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CustomerView();
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

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            this.LblNameMsgError.Text = string.Empty;
            if (!this.IsValidName(this.txtCustomerName.Text))
            {
                this.LblNameMsgError.Text = "Only accepting alphabet!";
                this.LblNameMsgError.ForeColor = Color.Red;
                this.btnSave.Enabled = false;
                return;
            }
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            this.txtCustomerName.Text = textInfo.ToTitleCase(this.txtCustomerName.Text);
            this.txtCustomerName.Select(this.txtCustomerName.Text.Length, this.txtCustomerName.Text.Length - 1);
            this.btnSave.Enabled = true;
        }
    }
}
