using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class UserLoginHistory
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public string PlayerId { get; set; }

        public int AreaId { get; set; }

        public DateTime LoginTime { get; set; }
    }
}
