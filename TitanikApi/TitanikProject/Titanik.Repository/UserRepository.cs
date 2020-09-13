using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Titanik.Repository.Entity;
using Titanik.Repository.Interfaces;
using System.Data.SqlClient;

namespace Titanik.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly TitanikContext context;
        public UserRepository()
        {
            this.context = new TitanikContext();
        }

        public void Add(User req)
        {
            context.Users.Add(req);
            context.SaveChanges();
        }
    }
}
