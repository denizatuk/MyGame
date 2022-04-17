using MGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MGame.Abstract
{
    interface ICampaignService
    {
        void Add(User user,Campaign campaign);
        void Update(User user, Campaign campaign);
        void Delete(User user, Campaign campaign);
    }
}
