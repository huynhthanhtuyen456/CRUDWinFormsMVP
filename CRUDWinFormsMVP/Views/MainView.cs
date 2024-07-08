using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDWinFormsMVP.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            BtnCustomers.Click += delegate { ShowCustomerView?.Invoke(this, EventArgs.Empty); };
            BtnEmployees.Click += delegate { ShowEmployeeView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowCustomerView;
        public event EventHandler ShowEmployeeView;

        private void MainView_Load(object sender, EventArgs e)
        {
            ShowCustomerView?.Invoke(this, EventArgs.Empty);
        }
    }
}
