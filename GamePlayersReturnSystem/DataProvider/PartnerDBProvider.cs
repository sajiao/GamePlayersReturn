using Data;
using IData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider
{
   public class PartnerDBProvider
    {
        public IPartner DB;
        public PartnerDBProvider()
        {
            InitDB(DbType.Mysql);
        }
        public void InitDB(DbType dbType)
        {
            if (dbType == DbType.Mysql)
            {
                DB = new PartnerDB();
            }
        }
    }
}
