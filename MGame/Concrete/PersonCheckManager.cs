using MGame.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MGame.Concrete
{
    public class PersonCheckManager : IPersonCheckService
    {
        public bool CheckIfRealPerson(User user)
        {
            return true;
        }
    }
}
