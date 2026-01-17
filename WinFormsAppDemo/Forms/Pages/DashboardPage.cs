using Sunny.UI;
using WinFormsAppDemo.Common;

namespace WinFormsAppDemo.Forms.Pages
{
    public partial class DashboardPage : UIPage
    {
        private readonly LocalizationManager _localization;

        public DashboardPage(LocalizationManager localization)
        {
            InitializeComponent();
            _localization = localization;
            _localization.LanguageChanged += UpdateLanguage;
            UpdateLanguage();
        }

        private void UpdateLanguage()
        {
            if (lblTitle != null) lblTitle.Text = _localization.GetString("WelcomeTitle");
            if (lblSubTitle != null) lblSubTitle.Text = _localization.GetString("WelcomeSubTitle");
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