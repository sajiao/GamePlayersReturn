using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Entity;
using IData;
using MySql.Data.MySqlClient;

namespace Data
{
  public  class UserDB : IUser
    {
        public User Add<User>(User req) {
    
            var result = SqlHelper.Exucute(Const.UserInsertSql, req);
            if (result > 0)
                return GetById(req);
            return req;
        }

        public User Update<User>(User req) {
            var result = SqlHelper.Exucute(Const.UserUpdateSql, req);
            if (result > 0)
                return GetById(req);
            return req;
        }

        public bool Delete<User>(User req) {
            var result = SqlHelper.Exucute(Const.UserDeleteSql, req);
            return result > 0;
        }

        public User GetById<User>(User req)
        {
            return SqlHelper.QueryFirst<User>(Const.UserGetByIdSql, req);
        }

        public IEnumerable<User> GetAll<User>(User req) {
            return SqlHelper.Query<User>(Const.UserGetAllSql, req);
        }

        public User Login(User req) {
            return SqlHelper.QueryFirst<User>(Const.UserLoginSql, req);
        }
    }
}
