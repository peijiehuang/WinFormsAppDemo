using SqlSugar;
using Microsoft.Extensions.Configuration;
using WinFormsAppDemo.Models;

namespace WinFormsAppDemo.Services
{
    public class DatabaseService
    {
        public SqlSugarClient Db { get; private set; }

        public DatabaseService(IConfiguration configuration)
        {
            Db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = configuration.GetConnectionString("DefaultConnection"),
                DbType = DbType.Sqlite,
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.Attribute
            });

            // 初始化数据库 (CodeFirst)
            Db.CodeFirst.InitTables(typeof(User));
        }
    }
}
