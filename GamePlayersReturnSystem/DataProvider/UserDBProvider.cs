using Data;
using IData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider
{
  public  class UserDBProvider
    {
        public IUser DB;
        public UserDBProvider() {
            InitDB(DbType.Mysql);
        }
        public void InitDB(DbType dbType) {
            if (dbType == DbType.Mysql) {
                DB = new UserDB();
            }
        }
    }
}
