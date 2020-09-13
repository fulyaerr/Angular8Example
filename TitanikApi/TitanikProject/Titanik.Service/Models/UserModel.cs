using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanik.Service.Models
{
    public class UserModel
    {
        public int id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ProfilePhoto { get; set; }
    }
}
