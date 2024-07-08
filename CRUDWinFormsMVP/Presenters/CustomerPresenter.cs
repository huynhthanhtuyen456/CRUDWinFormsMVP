using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUDWinFormsMVP.Models;
using CRUDWinFormsMVP.Views;
using ElectricCalculator.Enums;

namespace CRUDWinFormsMVP.Presenters
{
    public class CustomerPresenter
    {
        //Fields
        private ICustomerView view;
        private ICustomerRepository repository;
        private BindingSource customersBindingSource;
        private IEnumerable<DataGridViewCustomerModel> customerList;

        //Constructor
        public CustomerPresenter(ICustomerView view, ICustomerRepository repository)
        {
            this.customersBindingSource = new BindingSource();
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
            this.view.SetCustomerListBindingSource(customersBindingSource);
            //Load customer list view
            LoadAllCustomerList();
            //Show view
            this.view.Show();
        }

        //Methods
        private async void LoadAllCustomerList()
        {
            customerList = await repository.GetAll();
            customersBindingSource.DataSource = customerList;//Set data source.
        }
        private async void SearchCustomer(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                customerList = repository.GetByValue(this.view.SearchValue);
            else customerList = await repository.GetAll();
            customersBindingSource.DataSource = customerList;
        }
        private void AddNewPet(object sender, EventArgs e)
        {
            view.IsEdit = false;          
        }
        private void LoadSelectedPetToEdit(object sender, EventArgs e)
        {
            var customer = (DataGridViewCustomerModel)customersBindingSource.Current;
            view.CustomerId = customer.Id.ToString();
            view.CustomerName = customer.Name;
            view.CustomerDateOfBirth = customer.DateOfBirth;
            byte genderVal = (byte)Enum.Parse(typeof(GenderEnum), customer.Gender);
            view.CustomerGender = genderVal;
            byte occupationVal = (byte)Enum.Parse(typeof(OccupationEnum), customer.Occupation);
            view.CustomerOccupation = occupationVal;
            view.IsEdit = true;
        }
        private void SavePet(object sender, EventArgs e)
        {
            var model = new CustomerModel();
            model.Id = Convert.ToInt32(view.CustomerId);
            model.Name = view.CustomerName;
            model.DateOfBirth = view.CustomerDateOfBirth;
            model.Gender = (byte)view.CustomerGender;
            model.Occupation = (byte)view.CustomerOccupation;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if(view.IsEdit)//Edit model
                {
                    repository.Edit(model);
                    view.Message = "Customer edited successfuly";
                }
                else //Add new model
                {
                    repository.Add(model);
                    view.Message = "Customer added sucessfully";
                }
                view.IsSuccessful = true;
                LoadAllCustomerList();
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
            view.CustomerId = "0";
            view.CustomerName = "";
            view.CustomerDateOfBirth = DateTime.Now;
            view.CustomerGender = 0;            
            view.CustomerOccupation = 0;            
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }
        private void DeleteSelectedCustomer(object sender, EventArgs e)
        {
            try
            {
                var customerModel = (DataGridViewCustomerModel)customersBindingSource.Current;
                repository.Delete(customerModel.Id);
                view.IsSuccessful = true;
                view.Message = "Customer deleted successfully";
                LoadAllCustomerList();
            }
            catch (Exception)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete pet";
            }
        }

    }
}
