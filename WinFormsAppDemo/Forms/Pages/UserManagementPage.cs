using Sunny.UI;
using WinFormsAppDemo.Common;
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
        private readonly LocalizationManager _localization;

        public UserManagementPage(UserService userService, LocalizationManager localization)
        {
            InitializeComponent();
            _userService = userService;
            _localization = localization;
            
            // 订阅语言变更事件
            _localization.LanguageChanged += UpdateLanguage;
            
            // 页面加载时加载用户列表
            this.Load += UserManagementPage_Load;
            
            UpdateLanguage();
        }

        private void UserManagementPage_Load(object? sender, EventArgs e)
        {
            LoadUsers();
        }

        private void UpdateLanguage()
        {
            btnAdd.Text = _localization.GetString("Add");
            btnRefresh.Text = _localization.GetString("Refresh");
            btnSearch.Text = _localization.GetString("Search");
            txtSearch.Watermark = _localization.GetString("SearchPlaceholder");

            // 更新列头
            if (dgvUsers.Columns.Contains("colId")) dgvUsers.Columns["colId"].HeaderText = _localization.GetString("ColId");
            if (dgvUsers.Columns.Contains("colUsername")) dgvUsers.Columns["colUsername"].HeaderText = _localization.GetString("ColUsername");
            if (dgvUsers.Columns.Contains("colEmail")) dgvUsers.Columns["colEmail"].HeaderText = _localization.GetString("ColEmail");
            if (dgvUsers.Columns.Contains("colRealName")) dgvUsers.Columns["colRealName"].HeaderText = _localization.GetString("ColRealName");
            if (dgvUsers.Columns.Contains("colPhone")) dgvUsers.Columns["colPhone"].HeaderText = _localization.GetString("ColPhone");
            if (dgvUsers.Columns.Contains("colStatus")) dgvUsers.Columns["colStatus"].HeaderText = _localization.GetString("ColStatus");
            if (dgvUsers.Columns.Contains("colCreateTime")) dgvUsers.Columns["colCreateTime"].HeaderText = _localization.GetString("ColCreateTime");
            
            // 操作列通常是按钮列，Header Text 也可以改
            if (dgvUsers.Columns.Contains("colEdit")) dgvUsers.Columns["colEdit"].HeaderText = _localization.GetString("Edit");
            if (dgvUsers.Columns.Contains("colDelete")) dgvUsers.Columns["colDelete"].HeaderText = _localization.GetString("Delete");

            // 重新绑定数据以刷新内容中的“激活/未激活”
            if (dgvUsers.Rows.Count > 0)
            {
                // 注意：如果正在编辑，这可能会中断，但切换语言通常不在编辑中进行
                // 简单起见，重新加载数据
                LoadUsers();
            }
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
                UIMessageBox.Show($"{_localization.GetString("LoadUserFailed")}: {ex.Message}", "Error", UIStyle.Purple, UIMessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// 绑定用户数据到表格
        /// </summary>
        private void BindUserData(List<User> users)
        {
            if (users == null) return;

            // 转换数据以便显示
            var displayData = users.Select(u => new
            {
                u.Id,
                u.Username,
                u.Email,
                u.RealName,
                u.Phone,
                IsActive = u.IsActive ? _localization.GetString("Active") : _localization.GetString("Inactive"),
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
                UIMessageBox.Show($"{_localization.GetString("Error")}: {ex.Message}", "Error", UIStyle.Purple, UIMessageBoxButtons.OK);
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
            // 注意：这里假设 DataSource 绑定的对象属性名与 DataPropertyName 对应
            // 实际上 DataGridView 通常通过 DataBoundItem 获取
            
            if (dgvUsers.Rows[e.RowIndex].DataBoundItem == null) return;
            
            // 使用反射或 dynamic 获取 ID，因为绑定的是匿名对象
            dynamic data = dgvUsers.Rows[e.RowIndex].DataBoundItem;
            int userId = data.Id;

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
                    UIMessageBox.Show(_localization.GetString("UserNotFound"), "Warning", UIStyle.Purple, UIMessageBoxButtons.OK);
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
                UIMessageBox.Show($"{_localization.GetString("Error")}: {ex.Message}", "Error", UIStyle.Purple, UIMessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        private void DeleteUser(int userId)
        {
            try
            {
                if (UIMessageBox.Show(_localization.GetString("ConfirmDeleteUser"), _localization.GetString("Warning"), UIStyle.Purple, UIMessageBoxButtons.OKCancel))
                {
                    if (_userService.DeleteUser(userId))
                    {
                        UIMessageBox.Show(_localization.GetString("UserDeleteSuccess"), "Success", UIStyle.Purple, UIMessageBoxButtons.OK);
                        LoadUsers(); // 刷新列表
                    }
                    else
                    {
                        UIMessageBox.Show(_localization.GetString("UserDeleteFailed"), "Error", UIStyle.Purple, UIMessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.Show($"{_localization.GetString("Error")}: {ex.Message}", "Error", UIStyle.Purple, UIMessageBoxButtons.OK);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_localization != null) _localization.LanguageChanged -= UpdateLanguage;
                if (components != null) components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}