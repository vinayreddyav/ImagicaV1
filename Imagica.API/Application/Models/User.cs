using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tralive.API.Application.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public List<string> Roles { get; set; }
    }
}
