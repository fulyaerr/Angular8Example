using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Titanik.Repository;
using Titanik.Repository.Interfaces;
using Titanik.Service.Interfaces;
using Titanik.Service.Models;

namespace Titanik.Service
{
    public class User : IUser
    {
        public User()
        {
        }
        public string getTest()
        {
            return "ok";
        }

        public void Add(UserModel model)
        {
            UserRepository repository = new UserRepository();
            repository.Add(new Repository.Entity.User
            {
                Email = model.Email,
                NameSurname = model.NameSurname,
                Password = model.Password,
                PhoneNumber = model.PhoneNumber,
                ProfilePhoto = model.ProfilePhoto,
                UserName = model.UserName
            });
        }
    }
}
