using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWinFormsMVP.Models
{
   public interface ICustomerRepository
    {
        void Add(CustomerModel customerModel);
        void Edit(CustomerModel customerModel);
        void Delete(int id);
        Task<IEnumerable<DataGridViewCustomerModel>> GetAll();
        IEnumerable<DataGridViewCustomerModel> GetByValue(string value);//Searchs

    }
}
