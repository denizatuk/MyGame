using System;
using System.Collections.Generic;
using System.Text;

namespace MGame.Concrete
{
    public interface IUserService
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);
    }
}
