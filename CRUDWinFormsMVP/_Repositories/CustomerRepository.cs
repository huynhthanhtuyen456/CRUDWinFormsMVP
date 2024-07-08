using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CRUDWinFormsMVP.Models;
using ElectricCalculator.Enums;

namespace CRUDWinFormsMVP._Repositories
{
    public class CustomerRepository : BaseRepository, ICustomerRepository
    {
        //Constructor
        public CustomerRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        //Methods
        public void Add(CustomerModel customerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into Customer(Name, Gender, Occupation, DateOfBirth) " +
                    "values (@name, @gender, @occupation, @dateOfBirth)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = customerModel.Name;
                command.Parameters.Add("@occupation", SqlDbType.SmallInt).Value = customerModel.Occupation;
                command.Parameters.Add("@gender", SqlDbType.SmallInt).Value = customerModel.Gender;
                command.Parameters.Add("@dateOfBirth", SqlDbType.DateTime).Value = customerModel.DateOfBirth;
                command.ExecuteNonQuery();
            }
        }
        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from Customer where Id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;           
                command.ExecuteNonQuery();
            }
        }
        public void Edit(CustomerModel customerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update Customer 
                                        set Name=@name,DateOfBirth= @dateOfBirth,Occupation= @occupation,Gender= @gender 
                                        where Id=@id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = customerModel.Name;
                command.Parameters.Add("@dateOfBirth", SqlDbType.DateTime).Value = customerModel.DateOfBirth;
                command.Parameters.Add("@gender", SqlDbType.SmallInt).Value = customerModel.Gender;
                command.Parameters.Add("@occupation", SqlDbType.SmallInt).Value = customerModel.Occupation;
                command.Parameters.Add("@id", SqlDbType.Int).Value = customerModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public async Task<IEnumerable<DataGridViewCustomerModel>> GetAll()
        {
            var customerList = new List<DataGridViewCustomerModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Customer order by Id desc";
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var customerModel = new DataGridViewCustomerModel();
                        customerModel.Id = (int)reader["Id"];
                        customerModel.Name = reader["Name"].ToString();
                        customerModel.DateOfBirth = (DateTime)reader["DateOfBirth"];
                        GenderEnum genderVal = (GenderEnum)(byte)reader["Gender"];
                        string genderText = genderVal.ToString();
                        customerModel.Gender = genderText;
                        OccupationEnum occupationVal = (OccupationEnum)(byte)reader["Occupation"];
                        string occupationText = occupationVal.ToString();
                        customerModel.Occupation = occupationText;
                        customerList.Add(customerModel);
                    }
                }
            }
            return customerList;
        }

        public IEnumerable<DataGridViewCustomerModel> GetByValue(string value)
        {
            var customerList = new List<DataGridViewCustomerModel>();
            int customerId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string customerName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from Customer
                                        where Id=@id or Name like @name+'%' 
                                        order by Id desc";
                command.Parameters.Add("@id", SqlDbType.Int).Value = customerId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = customerName;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customerModel = new DataGridViewCustomerModel();
                        customerModel.Id = (int)reader["Id"];
                        customerModel.Name = reader["Name"].ToString();
                        GenderEnum genderVal = (GenderEnum)(byte)reader["Gender"];
                        string genderText = genderVal.ToString();
                        customerModel.Gender = genderText;
                        OccupationEnum occupationVal = (OccupationEnum)(byte)reader["Occupation"];
                        string occupationText = occupationVal.ToString();
                        customerModel.Occupation = occupationText;
                        customerModel.DateOfBirth = (DateTime)reader["DateOfBirth"];
                        customerList.Add(customerModel);
                    }
                }
            }
            return customerList;
        }
    }
}
