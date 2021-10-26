using MernisProjectTry.Abstract;
using MernisProjectTry.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MernisProjectTry.Adapters
{
    public class MernisCheckCustomer : ICheckCustomerService
    {
        //mernis ile kişi doğrulaması yapılıyor
        //ad ve soyad büyük harf ile gönderilmek zorunda
        public bool CheckCustomer(Customer customer)
        {
            MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient(MernisServiceReference.KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalId),customer.FirstName.ToUpper(),customer.LastName.ToUpper(),customer.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
