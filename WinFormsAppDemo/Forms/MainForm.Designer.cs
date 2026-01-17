namespace WinFormsAppDemo.Forms
{
    partial class MainForm
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
            Aside = new Sunny.UI.UIPanel();
            NavMenu = new Sunny.UI.UINavMenu();
            btnLogout = new Sunny.UI.UISymbolButton();
            lblLogo = new Sunny.UI.UILabel();
            uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            pageContainer = new Sunny.UI.UITabControl();
            Aside.SuspendLayout();
            SuspendLayout();
            // 
            // Aside
            // 
            Aside.Controls.Add(NavMenu);
            Aside.Controls.Add(btnLogout);
            Aside.Controls.Add(lblLogo);
            Aside.Controls.Add(uiSymbolLabel1);
            Aside.Dock = DockStyle.Left;

            Aside.Font = new Font("微软雅黑", 12F);
            Aside.Location = new Point(0, 60);
            Aside.Margin = new Padding(4, 5, 4, 5);
            Aside.MinimumSize = new Size(1, 1);
            Aside.Name = "Aside";
            Aside.Size = new Size(250, 940);
            Aside.TabIndex = 0;
            Aside.Text = null;
            Aside.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // NavMenu
            // 

            NavMenu.BorderStyle = BorderStyle.None;
            NavMenu.Dock = DockStyle.Fill;
            NavMenu.DrawMode = TreeViewDrawMode.OwnerDrawAll;
            NavMenu.Font = new Font("微软雅黑", 12F);
            NavMenu.FullRowSelect = true;
            NavMenu.HotTracking = true;
            NavMenu.ItemHeight = 50;
            NavMenu.Location = new Point(0, 110);
            NavMenu.MenuStyle = Sunny.UI.UIMenuStyle.White;
            NavMenu.Name = "NavMenu";
            NavMenu.ShowLines = false;
            NavMenu.ShowPlusMinus = false;
            NavMenu.ShowRootLines = false;
            NavMenu.Size = new Size(250, 775);
            NavMenu.Style = Sunny.UI.UIStyle.Purple;
            NavMenu.TabIndex = 3;
            NavMenu.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // btnLogout
            // 
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.Font = new Font("微软雅黑", 12F);
            btnLogout.Location = new Point(0, 885);
            btnLogout.MinimumSize = new Size(1, 1);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(20, 0, 0, 0);
            btnLogout.Size = new Size(250, 55);
            btnLogout.Style = Sunny.UI.UIStyle.Purple;
            btnLogout.Symbol = 61579;
            btnLogout.TabIndex = 2;
            btnLogout.Text = "注销";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnLogout.Click += btnLogout_Click;
            // 
            // lblLogo
            // 
            lblLogo.Dock = DockStyle.Top;
            lblLogo.Font = new Font("微软雅黑", 14F, FontStyle.Bold);
            lblLogo.ForeColor = Color.FromArgb(48, 48, 48);
            lblLogo.Location = new Point(0, 50);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(250, 60);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "Demo";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiSymbolLabel1
            // 
            uiSymbolLabel1.Dock = DockStyle.Top;
            uiSymbolLabel1.Font = new Font("微软雅黑", 12F);
            uiSymbolLabel1.Location = new Point(0, 0);
            uiSymbolLabel1.MinimumSize = new Size(1, 1);
            uiSymbolLabel1.Name = "uiSymbolLabel1";
            uiSymbolLabel1.Padding = new Padding(28, 0, 0, 0);
            uiSymbolLabel1.Size = new Size(250, 50);
            uiSymbolLabel1.Symbol = 361732;
            uiSymbolLabel1.SymbolSize = 48;
            uiSymbolLabel1.TabIndex = 0;
            // 
            // pageContainer
            // 
            pageContainer.Dock = DockStyle.Fill;
            pageContainer.DrawMode = TabDrawMode.OwnerDrawFixed;
            pageContainer.Font = new Font("微软雅黑", 12F);
            pageContainer.ItemSize = new Size(150, 40);
            pageContainer.Location = new Point(250, 60);
            pageContainer.MainPage = "";
            pageContainer.Name = "pageContainer";
            pageContainer.SelectedIndex = 0;
            pageContainer.Size = new Size(1350, 940);
            pageContainer.SizeMode = TabSizeMode.Fixed;
            pageContainer.Style = Sunny.UI.UIStyle.Custom;
            pageContainer.TabIndex = 1;
            pageContainer.TabUnSelectedForeColor = Color.FromArgb(240, 240, 240);
            pageContainer.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1600, 1000);
            Controls.Add(pageContainer);
            Controls.Add(Aside);
            Name = "MainForm";
            Padding = new Padding(0, 60, 0, 0);
            Text = "MainForm";
            TitleFont = new Font("微软雅黑", 16F);
            TitleHeight = 60;
            ZoomScaleRect = new Rectangle(22, 22, 1600, 1000);
            Aside.ResumeLayout(false);
            ResumeLayout(false);

        }

        private Sunny.UI.UIPanel Aside;
        private Sunny.UI.UINavMenu NavMenu;
        private Sunny.UI.UISymbolButton btnLogout;
        private Sunny.UI.UILabel lblLogo;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UITabControl pageContainer;
    }
}
