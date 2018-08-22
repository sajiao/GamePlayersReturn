using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class User
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string NickName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int AreaId { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime UpdatedTime { get; set; }
    }

    public class UserLoginResponse {
        public string Id { get; set; }

        public string Name { get; set; }

        public string NickName { get; set; }

        public int AreaId { get; set; }

        public Dictionary<string, bool> Partners { get; set; }

    }
}
