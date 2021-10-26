using MernisProjectTry.Concrete;
using MernisProjectTry.Entities;
using System;
using MernisProjectTry.Adapters;
using MernisProjectTry.Abstract;

namespace MernisProjectTry
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerService kahvedunyasi = new KahveDunyasiManager();
            BaseCustomerService starbucks = new StarbucksManager(new MernisCheckCustomer());
            //starbucks için gerekli müşteri bilgileri gönderiliyor
            starbucks.AddCustomer(new Customer { FirstName = "Emir", LastName = "Gürbüz", DateOfBirth = new DateTime(2003, 9, 8), NationalId = "" });
            
        }
    }
}
