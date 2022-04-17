using MGame.Abstract;
using MGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MGame.Concrete
{
    class SellingManager : ISelingService
    {
        public void SatisYap(User user, Campaign campaign, Selling selling)
        {
            Console.WriteLine(user.FirstName + " İsimli kullanıcı" + campaign.CampaignName + " Kampanya" + selling.Price + " fiyatından satış yaptı");
        }
    }
}
