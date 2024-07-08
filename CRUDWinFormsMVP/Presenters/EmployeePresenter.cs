using CRUDWinFormsMVP.Models;
using CRUDWinFormsMVP.Views;
using CRUDWinFormsMVP.Views.Common.Enums;
using ElectricCalculator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDWinFormsMVP.Presenters
{
    public class EmployeePresenter
    {
        //Fields
        private IEmployeeView view;
        private IEmployeeRepository repository;
        private BindingSource employeesBindingSource;
        private IEnumerable<DataGridViewEmployeeModel> employeeList;

        //Constructor
        public EmployeePresenter(IEmployeeView view, IEmployeeRepository repository)
        {
            this.employeesBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchCustomer;
            this.view.AddNewEvent += AddNewPet;
            this.view.EditEvent += LoadSelectedPetToEdit;
            this.view.DeleteEvent += DeleteSelectedCustomer;
            this.view.SaveEvent += SavePet;
            this.view.CancelEvent += CancelAction;
            //Set customers bindind source
            this.view.SetEmployeeListBindingSource(employeesBindingSource);
            //Load customer list view
            LoadAllEmployeeList();
            //Show view
            this.view.Show();
        }

        //Methods
        private async void LoadAllEmployeeList()
        {
            employeeList = await repository.GetAll();
            employeesBindingSource.DataSource = employeeList;//Set data source.
        }
        private async void SearchCustomer(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                employeeList = await repository.GetByValue(this.view.SearchValue);
            else employeeList = await repository.GetAll();
            employeesBindingSource.DataSource = employeeList;
        }
        private void AddNewPet(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void LoadSelectedPetToEdit(object sender, EventArgs e)
        {
            DataGridViewEmployeeModel employee = (DataGridViewEmployeeModel)employeesBindingSource.Current;
            view.EmployeeId = employee.Id.ToString();
            view.EmployeeName = employee.Name;
            view.EmployeeDateOfBirth = employee.DateOfBirth;
            byte genderVal = (byte)Enum.Parse(typeof(GenderEnum), employee.Gender);
            view.EmployeeGender = genderVal;
            byte educationVal = (byte)Enum.Parse(typeof(EducationEnum), employee.Education);
            view.EmployeeEducation = educationVal;
            view.IsEdit = true;
        }
        private void SavePet(object sender, EventArgs e)
        {
            var model = new EmployeeModel();
            model.Id = Convert.ToInt32(view.EmployeeId);
            model.Name = view.EmployeeName;
            model.DateOfBirth = view.EmployeeDateOfBirth;
            model.Gender = (byte)view.EmployeeGender;
            model.Education = (byte)view.EmployeeEducation;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)//Edit model
                {
                    repository.Edit(model);
                    view.Message = "Employee edited successfuly";
                }
                else //Add new model
                {
                    repository.Add(model);
                    view.Message = "Employee added sucessfully";
                }
                view.IsSuccessful = true;
                LoadAllEmployeeList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            view.EmployeeId = "0";
            view.EmployeeName = "";
            view.EmployeeDateOfBirth = DateTime.Now;
            view.EmployeeGender = 0;
            view.EmployeeEducation = 0;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }
        private void DeleteSelectedCustomer(object sender, EventArgs e)
        {
            try
            {
                var employeeModel = (DataGridViewEmployeeModel)employeesBindingSource.Current;
                repository.Delete(employeeModel.Id);
                view.IsSuccessful = true;
                view.Message = "Employee deleted successfully";
                LoadAllEmployeeList();
            }
            catch (Exception)
            {
                view.IsSuccessful = false;
                view.Message = "An error occurred, could not delete pet";
            }
        }
    }
}
