using MernisProjectTry.Abstract;
using MernisProjectTry.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MernisProjectTry.Concrete
{
    public class StarbucksManager:BaseCustomerService
    {
        //depency injection ile müşteri doğrulama classı alınacak
        ICheckCustomerService _checkCustomerService;
        public StarbucksManager(ICheckCustomerService checkCustomerService)
        {
            _checkCustomerService = checkCustomerService;
        }
        //virtual yaptığımız ekleme metodunu override edip eziyoruz ve kontrol işlemlerini yapıp base sınıfımıza gönderiyoruz
        public override void AddCustomer(Customer customer)
        {
            //eğer true gelirse kişi doğrulanmıştır
            //false ise hata gönderiyoruz
            if (_checkCustomerService.CheckCustomer(customer))
            {
                base.AddCustomer(customer);
            }
            else
            {
                throw new Exception("invalid customer");
            }
            
        }
    }
}
