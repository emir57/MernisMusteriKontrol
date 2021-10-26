using MernisProjectTry.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MernisProjectTry.Abstract
{
    public interface ICustomerService
    {
        void AddCustomer(Customer customer);
    }
}
