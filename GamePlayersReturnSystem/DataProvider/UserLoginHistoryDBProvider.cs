using Data;
using IData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider
{
   public class UserLoginHistoryDBProvider
    {
        public IUserLoginHistory DB;
        public UserLoginHistoryDBProvider()
        {
            InitDB(DbType.Mysql);
        }
        public void InitDB(DbType dbType)
        {
            if (dbType == DbType.Mysql)
            {
                DB = new UserLoginHistoryDB();
            }
        }
    }
}
