using IData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
  public  class UserLoginHistoryDB : IUserLoginHistory
    {
        public UserLoginHistory Add<UserLoginHistory>(UserLoginHistory req)
        {

            var result = SqlHelper.Exucute(Const.UserLoginHistoryInsertSql, req);
            
            return req;
        }


        public UserLoginHistory GetById<UserLoginHistory>(UserLoginHistory req)
        {
            return SqlHelper.QueryFirst<UserLoginHistory>(Const.UserLoginHistoryGetByIdSql, req);
        }

        public IEnumerable<UserLoginHistory> GetAll<UserLoginHistory>(UserLoginHistory req)
        {
            return SqlHelper.Query<UserLoginHistory>(Const.UserLoginHistoryGetAllSql, req);
        }
    }
}
