using MernisServiceReference1;
using MGame.Abstract;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MGame.Adapters
{
    public class MernisServiceAdapter : IPersonCheckService
    {
        public bool CheckIfRealPerson(User user)
        {
            ////Mernis Doğrulama
            //var locale = new CultureInfo("tr-TR", false);
            //var svc = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            //{
            //    var cmd = svc.TCKimlikNoDogrulaAsync(Convert.ToInt64(user.NationalityId), user.FirstName, user.LastName, user.DateOfBirth.Year);
            //    return cmd.Result.Body.TCKimlikNoDogrulaResult;
            //};
            return true;
        }
            
    }
}
