using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
   public static class Const
    {
        public const string ConnString = "Data Source=10.253.0.106;port=3306;Initial Catalog=yijun;user id=root;password=moqikaka3306;Charset=utf8";

        public const string UserInsertSql = "Insert into User(Id,Name,NickName, Email, Password,CreatedTime) values (@Id,@Name,@NickName, @Email, @Password,@CreatedTime)";

        public const string UserGetByIdSql = "Select Id,Name,NickName, Email, Password,CreatedTime,UpdatedTime from User where Id = @Id";

        public const string UserGetAllSql = "Select Id,Name,NickName, Email, Password,CreatedTime,UpdatedTime from User";

        public const string UserUpdateSql = "Update User Set Id =@Id,Name=@Name,NickName =@NickName, Email=@Email, Password=@Password,UpdatedTime=@UpdatedTime where Id =@Id";

        public const string UserDeleteSql = "Delete from User where Id =@Id";

        public const string UserLoginSql = "Select Id,Name,NickName, Email,CreatedTime,UpdatedTime from User where Name = @Name and Password=@Password";


        public const string AreaInsertSql = "Insert into Area(Id,AreaName,CreatedTime) values (@Id,@AreaName,@CreatedTime)";

        public const string AreaGetByIdSql = "Select Id,AreaName,CreatedTime from Area where Id = @Id";

        public const string AreaGetAllSql = "Select Id,AreaName,CreatedTime from Area";

        public const string AreaUpdateSql = "Update Area Set Id =@Id,AreaName=@AreaName where Id =@Id";

        public const string AreaDeleteSql = "Delete from Area where Id =@Id";


        public const string PartnerInsertSql = "Insert into Partner(Id,Name,Description, BeginTime, EndTime,ConditionJson,CreatedBy,CreatedTime,ServiceName) values (@Id,@Name,@Description, @BeginTime, @EndTime,@ConditionJson,@CreatedBy,@CreatedTime,@ServiceName)";

        public const string PartnerGetByIdSql = "Select Id,Name,Description, BeginTime, EndTime,ConditionJson,CreatedBy,CreatedTime,ServiceName from Partner where Id = @Id";

        public const string PartnerGetAllSql = "Select Id,Name,Description, BeginTime, EndTime,ConditionJson,CreatedBy,CreatedTime,ServiceName from Partner WHERE beginTime < NOW() AND EndTime > NOW()";

        public const string PartnerUpdateSql = "Update Partner Set Id =@Id,Name=@Name,Description =@Description, BeginTime=@BeginTime, EndTime=@EndTime,ConditionJson=@ConditionJson,ServiceName=@ServiceName where Id =@Id";

        public const string PartnerDeleteSql = "Delete from Partner where Id =@Id";


        public const string PlayerInsertSql = "Insert into Player(Id,UserId,AreaId, CreatedTime) values (@Id,@UserId,@AreaId, @CreatedTime)";

        public const string PlayerGetByIdSql = "Select Id,UserId,AreaId, CreatedTime from Player where UserId = @UserId and AreaId = @AreaId";

        public const string PlayerGetAllSql = "Select Id,UserId,AreaId, CreatedTime from Player";

        public const string PlayerUpdateSql = "Update Player Set Id =@Id,UserId=@UserId,AreaId =@AreaId where Id =@Id";

        public const string PlayerDeleteSql = "Delete from Player where Id =@Id";


        public const string PlayerActivityLogInsertSql = "Insert into PlayerActivityLog(Id,PlayerId,TakePartInTime,PartnerId) values (@Id,@PlayerId, @TakePartInTime,@PartnerId)";

        public const string PlayerActivityLogGetByIdSql = "Select Id,PlayerId,TakePartInTime,PartnerId from PlayerActivityLog where PlayerId = @PlayerId and PartnerId =@PartnerId";

        public const string PlayerActivityLogGetAllSql = "Select Id,PlayerId,TakePartInTime,PartnerId from PlayerActivityLog";


        public const string UserLoginHistoryInsertSql = "Insert into UserLoginHistory(Id,UserId,PlayerId,AreaId,LoginTime) values (@Id,@UserId,@PlayerId,@AreaId,@LoginTime)";

        public const string UserLoginHistoryGetByIdSql = "Select Id,UserId,PlayerId,AreaId,LoginTime from UserLoginHistory where PlayerId = @PlayerId ORDER BY LoginTime DESC  LIMIT 0,1";

        public const string UserLoginHistoryGetAllSql = "Select Id,UserId,PlayerId,AreaId,LoginTime from UserLoginHistory";
    }
}
