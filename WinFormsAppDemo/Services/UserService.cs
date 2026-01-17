using WinFormsAppDemo.Models;

namespace WinFormsAppDemo.Services
{
    /// <summary>
    /// 用户服务类,提供用户CRUD操作
    /// </summary>
    public class UserService
    {
        private readonly DatabaseService _dbService;

        public UserService(DatabaseService dbService)
        {
            _dbService = dbService;
        }

        /// <summary>
        /// 获取所有用户列表
        /// </summary>
        public List<User> GetAllUsers()
        {
            return _dbService.Db.Queryable<User>().ToList();
        }

        /// <summary>
        /// 根据ID获取用户
        /// </summary>
        public User? GetUserById(int id)
        {
            return _dbService.Db.Queryable<User>().InSingle(id);
        }

        /// <summary>
        /// 添加新用户
        /// </summary>
        public bool AddUser(User user)
        {
            user.CreateTime = DateTime.Now;
            return _dbService.Db.Insertable(user).ExecuteCommand() > 0;
        }

        /// <summary>
        /// 更新用户信息
        /// </summary>
        public bool UpdateUser(User user)
        {
            user.UpdateTime = DateTime.Now;
            return _dbService.Db.Updateable(user).ExecuteCommand() > 0;
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        public bool DeleteUser(int id)
        {
            return _dbService.Db.Deleteable<User>().In(id).ExecuteCommand() > 0;
        }

        /// <summary>
        /// 搜索用户(根据用户名、真实姓名、邮箱)
        /// </summary>
        public List<User> SearchUsers(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return GetAllUsers();
            }

            return _dbService.Db.Queryable<User>()
                .Where(u => u.Username.Contains(keyword) 
                         || (u.RealName != null && u.RealName.Contains(keyword))
                         || (u.Email != null && u.Email.Contains(keyword)))
                .ToList();
        }

        /// <summary>
        /// 检查用户名是否已存在
        /// </summary>
        public bool IsUsernameExists(string username, int? excludeId = null)
        {
            var query = _dbService.Db.Queryable<User>().Where(u => u.Username == username);
            
            if (excludeId.HasValue)
            {
                query = query.Where(u => u.Id != excludeId.Value);
            }

            return query.Any();
        }
    }
}
