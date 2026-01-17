using Sunny.UI;
using WinFormsAppDemo.Models;
using WinFormsAppDemo.Services;

namespace WinFormsAppDemo.Forms
{
    /// <summary>
    /// 用户编辑表单(用于添加和编辑用户)
    /// </summary>
    public partial class UserEditForm : UIForm
    {
        private readonly UserService _userService;
        private User? _currentUser;

        /// <summary>
        /// 是否为编辑模式
        /// </summary>
        public bool IsEditMode => _currentUser != null;

        public UserEditForm(UserService userService, User? user = null)
        {
            InitializeComponent();
            _userService = userService;
            _currentUser = user;

            InitForm();
        }

        private void InitForm()
        {
            // 设置窗体标题
            this.Text = IsEditMode ? "编辑用户" : "添加用户";

            // 如果是编辑模式,填充数据
            if (IsEditMode && _currentUser != null)
            {
                txtUsername.Text = _currentUser.Username;
                txtPassword.Text = _currentUser.Password;
                txtEmail.Text = _currentUser.Email ?? string.Empty;
                txtRealName.Text = _currentUser.RealName ?? string.Empty;
                txtPhone.Text = _currentUser.Phone ?? string.Empty;
                chkIsActive.Checked = _currentUser.IsActive;

                // 编辑模式下用户名不可修改
                txtUsername.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 验证输入
            if (!ValidateInput())
            {
                return;
            }

            try
            {
                if (IsEditMode && _currentUser != null)
                {
                    // 更新用户
                    _currentUser.Password = txtPassword.Text.Trim();
                    _currentUser.Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim();
                    _currentUser.RealName = string.IsNullOrWhiteSpace(txtRealName.Text) ? null : txtRealName.Text.Trim();
                    _currentUser.Phone = string.IsNullOrWhiteSpace(txtPhone.Text) ? null : txtPhone.Text.Trim();
                    _currentUser.IsActive = chkIsActive.Checked;

                    if (_userService.UpdateUser(_currentUser))
                    {
                        UIMessageBox.Show("用户更新成功!", "提示", UIStyle.Purple, UIMessageBoxButtons.OK);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        UIMessageBox.Show("用户更新失败!", "提示", UIStyle.Purple, UIMessageBoxButtons.OK);
                    }
                }
                else
                {
                    // 添加新用户
                    var newUser = new User
                    {
                        Username = txtUsername.Text.Trim(),
                        Password = txtPassword.Text.Trim(),
                        Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim(),
                        RealName = string.IsNullOrWhiteSpace(txtRealName.Text) ? null : txtRealName.Text.Trim(),
                        Phone = string.IsNullOrWhiteSpace(txtPhone.Text) ? null : txtPhone.Text.Trim(),
                        IsActive = chkIsActive.Checked
                    };

                    if (_userService.AddUser(newUser))
                    {
                        UIMessageBox.Show("用户添加成功!", "提示", UIStyle.Purple, UIMessageBoxButtons.OK);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        UIMessageBox.Show("用户添加失败!", "提示", UIStyle.Purple, UIMessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.Show($"操作失败: {ex.Message}", "错误", UIStyle.Purple, UIMessageBoxButtons.OK);
            }
        }

        private bool ValidateInput()
        {
            // 验证用户名
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                UIMessageBox.Show("请输入用户名!", "警告", UIStyle.Purple, UIMessageBoxButtons.OK);
                txtUsername.Focus();
                return false;
            }

            // 验证用户名唯一性(仅在添加模式下)
            if (!IsEditMode && _userService.IsUsernameExists(txtUsername.Text.Trim()))
            {
                UIMessageBox.Show("用户名已存在!", "警告", UIStyle.Purple, UIMessageBoxButtons.OK);
                txtUsername.Focus();
                return false;
            }

            // 验证密码
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                UIMessageBox.Show("请输入密码!", "警告", UIStyle.Purple, UIMessageBoxButtons.OK);
                txtPassword.Focus();
                return false;
            }

            if (txtPassword.Text.Length < 6)
            {
                UIMessageBox.Show("密码长度不能少于6位!", "警告", UIStyle.Purple, UIMessageBoxButtons.OK);
                txtPassword.Focus();
                return false;
            }

            // 验证邮箱格式(如果填写了)
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (!IsValidEmail(txtEmail.Text.Trim()))
                {
                    UIMessageBox.Show("邮箱格式不正确!", "警告", UIStyle.Purple, UIMessageBoxButtons.OK);
                    txtEmail.Focus();
                    return false;
                }
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
