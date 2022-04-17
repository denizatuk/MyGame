using System;
using System.Collections.Generic;
using System.Text;

namespace MGame.Entities
{
    public class Selling:IEntity
    {
        public int Id { get; set; }
        public int userId { get; set; }
        public int CampaignId { get; set; }
        public double Price { get; set; }
    }
}
