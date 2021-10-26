using MernisProjectTry.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MernisProjectTry.Abstract
{
    //tüm kahve şirktleri ortak metodu kullandığı için abstract base sınfımızı oluşturduk
    public abstract class BaseCustomerService : ICustomerService
    {
        //sanal metodumuzu yazıyoruz özel kontroller için override etmek için
        public virtual void AddCustomer(Customer customer)
        {
            Console.WriteLine("Adding to database : "+customer.FirstName);
        }
    }
}
