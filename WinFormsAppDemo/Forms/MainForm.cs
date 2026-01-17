using Sunny.UI;
using WinFormsAppDemo.Common;
using WinFormsAppDemo.Forms.Pages;
using WinFormsAppDemo.Services;

namespace WinFormsAppDemo.Forms
{
    public partial class MainForm : UIForm
    {
        private readonly LocalizationManager _localization;
        private readonly UserService _userService;

        public MainForm(LocalizationManager localization, UserService userService)
        {
            InitializeComponent();
            _localization = localization;
            _userService = userService;
            InitNavigation();
        }

        private void InitNavigation()
        {
            // 设置 TabControl 为主页面容器
            pageContainer.TabVisible = false;

            // 关联菜单与 TabControl
            NavMenu.TabControl = pageContainer;

            // 添加页面
            DashboardPage dashboard = new DashboardPage();
            UserManagementPage userMgmt = new UserManagementPage(_userService);

            // 添加菜单与页面关联
            // 仪表盘
            TreeNode dashboardNode = NavMenu.CreateNode("仪表盘", 61671, 24, 1001);
            pageContainer.AddPage(dashboard);

            // 用户管理
            TreeNode userNode = NavMenu.CreateNode("用户管理", 62004, 24, 1002);
            pageContainer.AddPage(userMgmt);

            // 默认选中仪表盘
            NavMenu.SelectPage(1001);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (UIMessageBox.Show("确定要注销登录吗？", "提示", UIStyle.Purple, UIMessageBoxButtons.OKCancel))
            {
                this.DialogResult = DialogResult.Retry; // 返回 Retry 以告知 Program.cs 重新显示登录页 (如果逻辑支持)
                // 或者直接关闭，让 Program.cs 处理重新登录逻辑
                // 这里我们假设直接关闭窗体，由调用者决定
                this.Close();
            }
        }
    }
}
