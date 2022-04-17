using MGame.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MGame.Concrete
{
    public class UserManager : IUserService
    {
        private IPersonCheckService _personCheckService;
        public UserManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }

        public void Add(User user)
        {
            if (_personCheckService.CheckIfRealPerson(user))
            {
                Console.WriteLine("kullanıcı kayıt edildi! " + user.FirstName);
            }
            else
            {
                throw new Exception("Not a valid Person");
            }

        }



        public void Delete(User user)
        {
            Console.WriteLine("kullanıcı Silindi! " + user.FirstName);
        }

        public void Update(User user)
        {
            Console.WriteLine("kullanıcı güncellendi! " + user.FirstName);
        }
    }
}
