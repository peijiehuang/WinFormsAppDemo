using Sunny.UI;
using WinFormsAppDemo.Models;
using WinFormsAppDemo.Services;

namespace WinFormsAppDemo.Forms.Pages
{
    /// <summary>
    /// 用户管理页面
    /// </summary>
    public partial class UserManagementPage : UIPage
    {
        private readonly UserService _userService;

        public UserManagementPage(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
            
            // 页面加载时加载用户列表
            this.Load += UserManagementPage_Load;
        }

        private void UserManagementPage_Load(object? sender, EventArgs e)
        {
            LoadUsers();
        }

        /// <summary>
        /// 加载用户列表
        /// </summary>
        private void LoadUsers()
        {
            try
            {
                var users = _userService.GetAllUsers();
                BindUserData(users);
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError($"加载用户列表失败: {ex.Message}");
            }
        }

        /// <summary>
        /// 绑定用户数据到表格
        /// </summary>
        private void BindUserData(List<User> users)
        {
            // 转换数据以便显示
            var displayData = users.Select(u => new
            {
                u.Id,
                u.Username,
                u.Email,
                u.RealName,
                u.Phone,
                IsActive = u.IsActive ? "激活" : "未激活",
                CreateTime = u.CreateTime.ToString("yyyy-MM-dd HH:mm:ss")
            }).ToList();

            dgvUsers.DataSource = displayData;
        }

        /// <summary>
        /// 添加用户按钮点击事件
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var editForm = new UserEditForm(_userService);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsers(); // 刷新列表
            }
        }

        /// <summary>
        /// 刷新按钮点击事件
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            LoadUsers();
        }

        /// <summary>
        /// 搜索按钮点击事件
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var keyword = txtSearch.Text.Trim();
                var users = _userService.SearchUsers(keyword);
                BindUserData(users);
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError($"搜索失败: {ex.Message}");
            }
        }

        /// <summary>
        /// 数据表格单元格点击事件(处理编辑和删除按钮)
        /// </summary>
        private void dgvUsers_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            // 确保点击的是有效行
            if (e.RowIndex < 0) return;

            // 获取用户ID
            var userId = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells["colId"].Value);

            // 判断点击的是哪一列
            if (dgvUsers.Columns[e.ColumnIndex].Name == "colEdit")
            {
                // 编辑用户
                EditUser(userId);
            }
            else if (dgvUsers.Columns[e.ColumnIndex].Name == "colDelete")
            {
                // 删除用户
                DeleteUser(userId);
            }
        }

        /// <summary>
        /// 编辑用户
        /// </summary>
        private void EditUser(int userId)
        {
            try
            {
                var user = _userService.GetUserById(userId);
                if (user == null)
                {
                    UIMessageBox.ShowWarning("用户不存在!");
                    return;
                }

                var editForm = new UserEditForm(_userService, user);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadUsers(); // 刷新列表
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError($"编辑用户失败: {ex.Message}");
            }
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        private void DeleteUser(int userId)
        {
            try
            {
                if (UIMessageBox.Show("确定要删除该用户吗?", "确认删除", UIStyle.Purple, UIMessageBoxButtons.OKCancel))
                {
                    if (_userService.DeleteUser(userId))
                    {
                        UIMessageBox.ShowSuccess("用户删除成功!");
                        LoadUsers(); // 刷新列表
                    }
                    else
                    {
                        UIMessageBox.ShowError("用户删除失败!");
                    }
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError($"删除用户失败: {ex.Message}");
            }
        }
    }
}
