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
        private TreeNode? _dashboardNode;
        private TreeNode? _userMgmtNode;

        public MainForm(LocalizationManager localization, UserService userService)
        {
            InitializeComponent();
            _localization = localization;
            _userService = userService;

            // 订阅语言变更事件
            _localization.LanguageChanged += UpdateLanguage;

            InitNavigation();
            InitHeader();
            UpdateLanguage(); // 初始化文本
        }

        private void InitHeader()
        {
            // 必须显式开启 ExtendBox 属性，否则图标不会显示
            this.ExtendBox = true; 
            this.ExtendSymbol = 61954; // 翻译图标
            this.ExtendSymbolSize = 30;
            
            // 订阅点击事件
            this.ExtendBoxClick += (s, e) => 
            {
                var newLang = _localization.CurrentLanguage == "zh-CN" ? "en-US" : "zh-CN";
                _localization.LoadLanguage(newLang);
            };
        }

        private void UpdateLanguage()
        {
            this.Text = _localization.GetString("AppTitle");
            if (_dashboardNode != null) _dashboardNode.Text = _localization.GetString("Dashboard");
            if (_userMgmtNode != null) _userMgmtNode.Text = _localization.GetString("UserManagement");
            
            // 更新页面标题（如果页面有标题属性）
            // 更新其他静态文本
        }

        private void InitNavigation()
        {
            // 设置 TabControl 为主页面容器
            pageContainer.TabVisible = false;

            // 关联菜单与 TabControl
            NavMenu.TabControl = pageContainer;

            // 添加页面
            DashboardPage dashboard = new DashboardPage(_localization);
            UserManagementPage userMgmt = new UserManagementPage(_userService, _localization);

            // 添加菜单与页面关联
            // 仪表盘
            _dashboardNode = NavMenu.CreateNode(_localization.GetString("Dashboard"), 61671, 24, 1001);
            pageContainer.AddPage(dashboard);

            // 用户管理
            _userMgmtNode = NavMenu.CreateNode(_localization.GetString("UserManagement"), 62004, 24, 1002);
            pageContainer.AddPage(userMgmt);

            // 默认选中仪表盘
            NavMenu.SelectPage(1001);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (UIMessageBox.Show(_localization.GetString("ConfirmLogout"), _localization.GetString("Tip"), UIStyle.Purple, UIMessageBoxButtons.OKCancel))
            {
                this.DialogResult = DialogResult.Retry; 
                this.Close();
            }
        }
    }
}
