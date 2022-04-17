using MGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MGame.Abstract
{
    public interface ISelingService
    {
        void SatisYap(User user, Campaign campaign, Selling selling);
       
    }
}
