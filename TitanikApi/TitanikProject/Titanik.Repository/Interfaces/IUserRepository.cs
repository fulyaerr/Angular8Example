using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Titanik.Repository.Entity;

namespace Titanik.Repository.Interfaces
{
    public interface IUserRepository
    {
        void Add(User req);
    }
}
