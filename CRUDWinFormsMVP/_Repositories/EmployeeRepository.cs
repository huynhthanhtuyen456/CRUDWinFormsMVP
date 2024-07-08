using CRUDWinFormsMVP.Models;
using ElectricCalculator.Enums;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDWinFormsMVP.Views.Common.Enums;

namespace CRUDWinFormsMVP._Repositories
{
    public class EmployeeRepository : BaseRepository, IEmployeeRepository
    {
        //Constructor
        public EmployeeRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        //Methods
        public async void Add(EmployeeModel employeeModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                await connection.OpenAsync();
                command.Connection = connection;
                command.CommandText = "insert into Employee(Name, DateOfBirth, Gender, Education) " +
                    "values (@name, @dateOfBirth, @gender, @education)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = employeeModel.Name;
                command.Parameters.Add("@dateOfBirth", SqlDbType.DateTime).Value = employeeModel.DateOfBirth;
                command.Parameters.Add("@gender", SqlDbType.SmallInt).Value = employeeModel.Gender;
                command.Parameters.Add("@education", SqlDbType.SmallInt).Value = employeeModel.Education;
                await command.ExecuteNonQueryAsync();
            }
        }
        public async void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                await connection.OpenAsync();
                command.Connection = connection;
                command.CommandText = "delete from Employee where Id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                await command.ExecuteNonQueryAsync();
            }
        }
        public async void Edit(EmployeeModel employeeModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                await connection.OpenAsync();
                command.Connection = connection;
                command.CommandText = @"update Employee 
                                        set Name=@name,DateOfBirth= @dateOfBirth,Gender= @gender,Education= @education 
                                        where Id=@id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = employeeModel.Name;
                command.Parameters.Add("@dateOfBirth", SqlDbType.DateTime).Value = employeeModel.DateOfBirth;
                command.Parameters.Add("@gender", SqlDbType.SmallInt).Value = employeeModel.Gender;
                command.Parameters.Add("@education", SqlDbType.SmallInt).Value = employeeModel.Education;
                command.Parameters.Add("@id", SqlDbType.Int).Value = employeeModel.Id;
                await command.ExecuteNonQueryAsync();
            }
        }

        public async Task<IEnumerable<DataGridViewEmployeeModel>> GetAll()
        {
            var employeeList = new List<DataGridViewEmployeeModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Employee order by Id desc";
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var employeeModel = new DataGridViewEmployeeModel();
                        employeeModel.Id = (int)reader["Id"];
                        employeeModel.Name = reader["Name"].ToString();
                        employeeModel.DateOfBirth = (DateTime)reader["DateOfBirth"];
                        /*employeeModel.Gender = (byte)reader["Gender"];
                        employeeModel.Education = (byte)reader["Education"];*/
                        GenderEnum genderVal = (GenderEnum)(byte)reader["Gender"];
                        string genderText = genderVal.ToString();
                        employeeModel.Gender = genderText;
                        EducationEnum educationVal = (EducationEnum)(byte)reader["Education"];
                        string educationText = educationVal.ToString();
                        employeeModel.Education = educationText;
                        employeeList.Add(employeeModel);
                    }
                }
            }
            return employeeList;
        }

        public async Task<IEnumerable<DataGridViewEmployeeModel>> GetByValue(string value)
        {
            var employeeList = new List<DataGridViewEmployeeModel>();
            int employeeId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string employeeName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                await connection.OpenAsync();
                command.Connection = connection;
                command.CommandText = @"Select * from Employee
                                        where Id=@id or Name like @name+'%' 
                                        order by Id desc";
                command.Parameters.Add("@id", SqlDbType.Int).Value = employeeId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = employeeName;

                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var employeeModel = new DataGridViewEmployeeModel();
                        employeeModel.Id = (int)reader["Id"];
                        employeeModel.Name = reader["Name"].ToString();
                        //employeeModel.Gender = (byte)reader["Gender"];
                        //employeeModel.Education = (byte)reader["Education"];
                        GenderEnum genderVal = (GenderEnum)(byte)reader["Gender"];
                        string genderText = genderVal.ToString();
                        employeeModel.Gender = genderText;
                        EducationEnum educationVal = (EducationEnum)(byte)reader["Education"];
                        string educationText = educationVal.ToString();
                        employeeModel.Education = educationText;
                        employeeModel.DateOfBirth = (DateTime)reader["DateOfBirth"];
                        employeeList.Add(employeeModel);
                    }
                }
            }
            return employeeList;
        }
    }
}
