using System;
using System.Collections.Generic;
using System.Text;

namespace MGame.Abstract
{
    public interface IPersonCheckService
    {
        bool CheckIfRealPerson(User user);
       
    }
}
