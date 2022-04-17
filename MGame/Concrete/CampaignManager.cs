using MGame.Abstract;
using MGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MGame.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(User user, Campaign campaign)
        {
            Console.WriteLine(user.UserName + " adlı kullanıcı " + campaign.CampaignName + "kampanyası oluşturdu!" );
        }

        public void Delete(User user, Campaign campaign)
        {
            Console.WriteLine(user.UserName + " adlı kullanıcı " + campaign.CampaignName + "kampanyası sildi!");
        }

        public void Update(User user, Campaign campaign)
        {
            Console.WriteLine(user.UserName + " adlı kullanıcı " + campaign.CampaignName + "kampanyası düzenledi!");
        }
    }
}
