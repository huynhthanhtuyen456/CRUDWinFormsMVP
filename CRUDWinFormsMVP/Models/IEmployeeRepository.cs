using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWinFormsMVP.Models
{
    public interface IEmployeeRepository
    {
        void Add(EmployeeModel employeeModel);
        void Edit(EmployeeModel employeeModel);
        void Delete(int id);
        Task<IEnumerable<DataGridViewEmployeeModel>> GetAll();
        Task<IEnumerable<DataGridViewEmployeeModel>> GetByValue(string value);//Searchs
    }
}
