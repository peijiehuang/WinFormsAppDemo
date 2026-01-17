using Sunny.UI;
using WinFormsAppDemo.Common;

namespace WinFormsAppDemo.Forms
{
    public partial class LoginForm : UIForm
    {
        private readonly LocalizationManager _localization;

        public LoginForm(LocalizationManager localization)
        {
            InitializeComponent();
            _localization = localization;
            UpdateLanguage();
        }

        private void UpdateLanguage()
        {
            this.Text = _localization.GetString("Login");
            lblAppTitle.Text = _localization.GetString("AppTitle");
            lblAppSubTitle.Text = _localization.GetString("AppSubTitle");
            lblIntroDesc.Text = _localization.GetString("AppIntro");
            lblSubTitle.Text = _localization.GetString("LoginSystem");
            txtUsername.Watermark = _localization.GetString("Username");
            txtPassword.Watermark = _localization.GetString("Password");
            btnLogin.Text = _localization.GetString("Login");
            btnExit.Text = _localization.GetString("ExitApp");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 简单登录逻辑
            if (txtUsername.Text == "admin" && txtPassword.Text == "123456")
            {
                UIMessageBox.Show(_localization.GetString("LoginSuccess"), "Success", UIStyle.Purple, UIMessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                UIMessageBox.Show(_localization.GetString("LoginFailed"), "Error", UIStyle.Purple, UIMessageBoxButtons.OK);
            }
        }
    }
}
