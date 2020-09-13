using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Titanik.Service.Models;

namespace Titanik.Service.Interfaces
{
    public interface IUser 
    {
        //string getTest();
        void Add(UserModel model);
    }
}
