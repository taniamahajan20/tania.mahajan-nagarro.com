using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService
{
    public class User
    {
        private UserContext userContext;
        public string Name { get; set; }
        public int Age { get; set; }
        public int userId { get; set; }
        public string Email { get; set; }
    }
}
