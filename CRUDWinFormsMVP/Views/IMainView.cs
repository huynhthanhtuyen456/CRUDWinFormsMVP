using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWinFormsMVP.Views
{
    public interface IMainView
    {
        event EventHandler ShowCustomerView;
        event EventHandler ShowEmployeeView;
    }
}
