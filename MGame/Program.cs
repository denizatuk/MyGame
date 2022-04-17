using MGame.Adapters;
using MGame.Concrete;
using MGame.Entities;
using System;

namespace MGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User 
            { 
                Id = 1,
                FirstName = "deniz",
                LastName = "atuk",
                UserName = "denizatuk",
                Password = "123456",
                DateOfBirth = new DateTime(1996,09,01),
                NationalityId = "1234523"
            };

            UserManager userManager = new UserManager(new MernisServiceAdapter());
            userManager.Add(user1);

            userManager.Update(user1);

            userManager.Delete(user1);

            Campaign campany1 = new Campaign
            {

                CampaignName = "Age of empires 2",
                CampaignDiscount = 20,
                CampaignDate = new DateTime(2022, 12, 31),
                Id = 1
                

            };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(user1, campany1);
            campaignManager.Update(user1, campany1);
            campaignManager.Delete(user1, campany1);
            Selling selling1 = new Selling
            {
                userId = user1.Id,
                CampaignId = campany1.Id,
                Id = 1,
                Price = 100
            };

            SellingManager sellingManager = new SellingManager();
            sellingManager.SatisYap(user1, campany1,selling1);






            Console.WriteLine("Hello World!");
        }
        
    }
}
