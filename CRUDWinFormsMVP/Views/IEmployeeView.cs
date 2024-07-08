using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDWinFormsMVP.Views
{
    public interface IEmployeeView
    {
        //Properties - Fields
        string EmployeeId { get; set; }
        string EmployeeName { get; set; }
        DateTime EmployeeDateOfBirth { get; set; }
        int EmployeeGender { get; set; }
        int EmployeeEducation { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
        void SetEmployeeListBindingSource(BindingSource employeeList);
        void Show();//Optional

    }
}
