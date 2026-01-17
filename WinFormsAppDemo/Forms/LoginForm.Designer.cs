namespace WinFormsAppDemo.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlLeft = new Sunny.UI.UIPanel();
            uiLine1 = new Sunny.UI.UILine();
            lblAppSubTitle = new Sunny.UI.UILabel();
            uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            lblIntroDesc = new Sunny.UI.UILabel();
            lblAppTitle = new Sunny.UI.UILabel();
            pnlRight = new Sunny.UI.UIPanel();
            btnExit = new Sunny.UI.UILinkLabel();
            lblSubTitle = new Sunny.UI.UILabel();
            txtUsername = new Sunny.UI.UITextBox();
            txtPassword = new Sunny.UI.UITextBox();
            btnLogin = new Sunny.UI.UISymbolButton();
            pnlLeft.SuspendLayout();
            pnlRight.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.Controls.Add(uiLine1);
            pnlLeft.Controls.Add(lblAppSubTitle);
            pnlLeft.Controls.Add(uiSymbolLabel2);
            pnlLeft.Controls.Add(lblIntroDesc);
            pnlLeft.Controls.Add(lblAppTitle);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.FillColor = Color.FromArgb(126, 87, 194);
            pnlLeft.Font = new Font("微软雅黑", 12F);
            pnlLeft.Location = new Point(0, 60);
            pnlLeft.Margin = new Padding(4, 5, 4, 5);
            pnlLeft.MinimumSize = new Size(1, 1);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Radius = 0;
            pnlLeft.RectSides = ToolStripStatusLabelBorderSides.None;
            pnlLeft.Size = new Size(600, 840);
            pnlLeft.Style = Sunny.UI.UIStyle.Custom;
            pnlLeft.TabIndex = 0;
            pnlLeft.Text = null;
            pnlLeft.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiLine1
            // 
            uiLine1.BackColor = Color.Transparent;
            uiLine1.Font = new Font("微软雅黑", 12F);
            uiLine1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLine1.LineColor = Color.White;
            uiLine1.Location = new Point(80, 520);
            uiLine1.MinimumSize = new Size(2, 2);
            uiLine1.Name = "uiLine1";
            uiLine1.Size = new Size(150, 2);
            uiLine1.Style = Sunny.UI.UIStyle.Custom;
            uiLine1.TabIndex = 4;
            // 
            // lblAppSubTitle
            // 
            lblAppSubTitle.BackColor = Color.Transparent;
            lblAppSubTitle.Font = new Font("微软雅黑", 24F, FontStyle.Bold);
            lblAppSubTitle.ForeColor = Color.White;
            lblAppSubTitle.Location = new Point(80, 420);
            lblAppSubTitle.Name = "lblAppSubTitle";
            lblAppSubTitle.Size = new Size(480, 60);
            lblAppSubTitle.Style = Sunny.UI.UIStyle.Custom;
            lblAppSubTitle.TabIndex = 3;
            lblAppSubTitle.Text = "WinForms 快速开发通用模板";
            lblAppSubTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel2
            // 
            uiSymbolLabel2.BackColor = Color.Transparent;
            uiSymbolLabel2.Font = new Font("微软雅黑", 12F);
            uiSymbolLabel2.ForeColor = Color.White;
            uiSymbolLabel2.Location = new Point(80, 100);
            uiSymbolLabel2.MinimumSize = new Size(1, 1);
            uiSymbolLabel2.Name = "uiSymbolLabel2";
            uiSymbolLabel2.Size = new Size(150, 150);
            uiSymbolLabel2.Style = Sunny.UI.UIStyle.Custom;
            uiSymbolLabel2.Symbol = 61913;
            uiSymbolLabel2.SymbolColor = Color.White;
            uiSymbolLabel2.SymbolSize = 120;
            uiSymbolLabel2.TabIndex = 2;
            // 
            // lblIntroDesc
            // 
            lblIntroDesc.BackColor = Color.Transparent;
            lblIntroDesc.Font = new Font("微软雅黑", 16F);
            lblIntroDesc.ForeColor = Color.White;
            lblIntroDesc.Location = new Point(80, 560);
            lblIntroDesc.Name = "lblIntroDesc";
            lblIntroDesc.Size = new Size(480, 180);
            lblIntroDesc.Style = Sunny.UI.UIStyle.Custom;
            lblIntroDesc.TabIndex = 1;
            lblIntroDesc.Text = "体验 SunnyUI、SqlSugar 的完美融合。\r\n比以往更快速地构建企业级桌面应用。";
            // 
            // lblAppTitle
            // 
            lblAppTitle.BackColor = Color.Transparent;
            lblAppTitle.Font = new Font("微软雅黑", 62F, FontStyle.Bold);
            lblAppTitle.ForeColor = Color.White;
            lblAppTitle.Location = new Point(70, 260);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(480, 140);
            lblAppTitle.Style = Sunny.UI.UIStyle.Custom;
            lblAppTitle.TabIndex = 0;
            lblAppTitle.Text = "Demo";
            lblAppTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlRight
            // 
            pnlRight.Controls.Add(btnExit);
            pnlRight.Controls.Add(lblSubTitle);
            pnlRight.Controls.Add(txtUsername);
            pnlRight.Controls.Add(txtPassword);
            pnlRight.Controls.Add(btnLogin);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.FillColor = Color.FromArgb(242, 242, 242);
            pnlRight.Font = new Font("微软雅黑", 12F);
            pnlRight.Location = new Point(600, 60);
            pnlRight.Margin = new Padding(4, 5, 4, 5);
            pnlRight.MinimumSize = new Size(1, 1);
            pnlRight.Name = "pnlRight";
            pnlRight.Radius = 0;
            pnlRight.RectSides = ToolStripStatusLabelBorderSides.None;
            pnlRight.Size = new Size(900, 840);
            pnlRight.Style = Sunny.UI.UIStyle.Custom;
            pnlRight.TabIndex = 1;
            pnlRight.Text = null;
            pnlRight.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            btnExit.ActiveLinkColor = Color.FromArgb(126, 87, 194);
            btnExit.Font = new Font("微软雅黑", 16F);
            btnExit.ForeColor = Color.FromArgb(48, 48, 48);
            btnExit.LinkBehavior = LinkBehavior.NeverUnderline;
            btnExit.LinkColor = Color.FromArgb(126, 87, 194);
            btnExit.Location = new Point(150, 723);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(500, 45);
            btnExit.Style = Sunny.UI.UIStyle.Custom;
            btnExit.TabIndex = 7;
            btnExit.TabStop = true;
            btnExit.Text = "退出程序";
            btnExit.TextAlign = ContentAlignment.MiddleCenter;
            btnExit.VisitedLinkColor = Color.FromArgb(220, 155, 40);
            btnExit.Click += btnExit_Click;
            // 
            // lblSubTitle
            // 
            lblSubTitle.Font = new Font("微软雅黑", 42F);
            lblSubTitle.ForeColor = Color.FromArgb(48, 48, 48);
            lblSubTitle.Location = new Point(150, 150);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(600, 100);
            lblSubTitle.TabIndex = 6;
            lblSubTitle.Text = "登录系统";
            lblSubTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUsername
            // 
            txtUsername.Cursor = Cursors.IBeam;
            txtUsername.Font = new Font("微软雅黑", 18F);
            txtUsername.Location = new Point(150, 300);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.MinimumSize = new Size(1, 16);
            txtUsername.Name = "txtUsername";
            txtUsername.Padding = new Padding(5);
            txtUsername.RectColor = Color.Silver;
            txtUsername.ShowText = false;
            txtUsername.Size = new Size(500, 70);
            txtUsername.TabIndex = 1;
            txtUsername.Text = "admin";
            txtUsername.TextAlignment = ContentAlignment.MiddleLeft;
            txtUsername.Watermark = "用户名";
            // 
            // txtPassword
            // 
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.DoubleValue = 123456D;
            txtPassword.Font = new Font("微软雅黑", 18F);
            txtPassword.IntValue = 123456;
            txtPassword.Location = new Point(150, 420);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.MinimumSize = new Size(1, 16);
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(5);
            txtPassword.PasswordChar = '*';
            txtPassword.RectColor = Color.Silver;
            txtPassword.ShowText = false;
            txtPassword.Size = new Size(500, 70);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "123456";
            txtPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtPassword.Watermark = "密码";
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FillColor = Color.FromArgb(103, 58, 183);
            btnLogin.FillHoverColor = Color.FromArgb(126, 87, 194);
            btnLogin.FillPressColor = Color.FromArgb(81, 45, 168);
            btnLogin.FillSelectedColor = Color.FromArgb(81, 45, 168);
            btnLogin.Font = new Font("微软雅黑", 18F);
            btnLogin.Location = new Point(150, 580);
            btnLogin.MinimumSize = new Size(1, 1);
            btnLogin.Name = "btnLogin";
            btnLogin.Radius = 20;
            btnLogin.RectSides = ToolStripStatusLabelBorderSides.None;
            btnLogin.Size = new Size(500, 80);
            btnLogin.Style = Sunny.UI.UIStyle.Custom;
            btnLogin.TabIndex = 5;
            btnLogin.Text = "登录";
            btnLogin.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1500, 900);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            Padding = new Padding(0, 60, 0, 0);
            Text = "Login";
            TitleFont = new Font("微软雅黑", 16F);
            TitleHeight = 60;
            ZoomScaleRect = new Rectangle(15, 15, 1500, 900);
            pnlLeft.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            ResumeLayout(false);

        }

        private Sunny.UI.UIPanel pnlLeft;
        private Sunny.UI.UILabel lblAppTitle;
        private Sunny.UI.UILabel lblIntroDesc;
        private Sunny.UI.UIPanel pnlRight;
        private Sunny.UI.UILabel lblSubTitle;
        private Sunny.UI.UITextBox txtUsername;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UISymbolButton btnLogin;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UILabel lblAppSubTitle;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILinkLabel btnExit;
    }
}
