using System;
using System.Collections.Generic;
using System.Text;

namespace MGame.Entities
{
    public class Campaign:IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public double CampaignDiscount { get; set; }
        public DateTime CampaignDate { get; set; }

    }
}
