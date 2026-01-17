using SqlSugar;

namespace WinFormsAppDemo.Models
{
    /// <summary>
    /// 用户实体类
    /// </summary>
    [SugarTable("Users")]
    public class User
    {
        /// <summary>
        /// 用户ID(主键,自增)
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }

        /// <summary>
        /// 用户名(唯一)
        /// </summary>
        [SugarColumn(Length = 50, IsNullable = false, ColumnDescription = "用户名")]
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// 密码
        /// </summary>
        [SugarColumn(Length = 100, IsNullable = false, ColumnDescription = "密码")]
        public string Password { get; set; } = string.Empty;

        /// <summary>
        /// 邮箱
        /// </summary>
        [SugarColumn(Length = 100, IsNullable = true, ColumnDescription = "邮箱")]
        public string? Email { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        [SugarColumn(Length = 50, IsNullable = true, ColumnDescription = "真实姓名")]
        public string? RealName { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [SugarColumn(Length = 20, IsNullable = true, ColumnDescription = "电话")]
        public string? Phone { get; set; }

        /// <summary>
        /// 是否激活
        /// </summary>
        [SugarColumn(IsNullable = false, ColumnDescription = "是否激活")]
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// 创建时间
        /// </summary>
        [SugarColumn(IsNullable = false, ColumnDescription = "创建时间")]
        public DateTime CreateTime { get; set; } = DateTime.Now;

        /// <summary>
        /// 更新时间
        /// </summary>
        [SugarColumn(IsNullable = true, ColumnDescription = "更新时间")]
        public DateTime? UpdateTime { get; set; }
    }
}
