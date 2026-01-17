
namespace WinFormsAppDemo.Forms.Pages
{
    partial class DashboardPage
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
            pnlContainer = new Sunny.UI.UIPanel();
            lblSubTitle = new Sunny.UI.UILabel();
            lblTitle = new Sunny.UI.UILabel();
            uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            pnlContainer.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(lblSubTitle);
            pnlContainer.Controls.Add(lblTitle);
            pnlContainer.Controls.Add(uiSymbolLabel1);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.FillColor = Color.White;
            pnlContainer.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Margin = new Padding(4, 5, 4, 5);
            pnlContainer.MinimumSize = new Size(1, 1);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Radius = 0;
            pnlContainer.RectSides = ToolStripStatusLabelBorderSides.None;
            pnlContainer.Size = new Size(800, 450);
            pnlContainer.Style = Sunny.UI.UIStyle.Custom;
            pnlContainer.TabIndex = 0;
            pnlContainer.Text = null;
            pnlContainer.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblSubTitle
            // 
            lblSubTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblSubTitle.BackColor = Color.Transparent;
            lblSubTitle.Font = new Font("微软雅黑", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblSubTitle.ForeColor = Color.Gray;
            lblSubTitle.Location = new Point(0, 360);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(800, 40);
            lblSubTitle.Style = Sunny.UI.UIStyle.Custom;
            lblSubTitle.TabIndex = 2;
            lblSubTitle.Text = "基于 SunnyUI 框架 + WinForms 设计";
            lblSubTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("微软雅黑", 24F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblTitle.ForeColor = Color.FromArgb(48, 48, 48);
            lblTitle.Location = new Point(0, 300);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(800, 60);
            lblTitle.Style = Sunny.UI.UIStyle.Custom;
            lblTitle.TabIndex = 1;
            lblTitle.Text = "欢迎使用 WinForms 快速开发通用模板";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiSymbolLabel1
            // 
            uiSymbolLabel1.Anchor = AnchorStyles.None;
            uiSymbolLabel1.BackColor = Color.Transparent;
            uiSymbolLabel1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiSymbolLabel1.Location = new Point(300, 80);
            uiSymbolLabel1.MinimumSize = new Size(1, 1);
            uiSymbolLabel1.Name = "uiSymbolLabel1";
            uiSymbolLabel1.Padding = new Padding(28, 0, 0, 0);
            uiSymbolLabel1.Size = new Size(200, 200);
            uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            uiSymbolLabel1.Symbol = 362615;
            uiSymbolLabel1.SymbolColor = Color.Black;
            uiSymbolLabel1.SymbolSize = 128;
            uiSymbolLabel1.TabIndex = 0;
            // 
            // DashboardPage
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlContainer);
            Name = "DashboardPage";
            PageIndex = 1001;
            Text = "DashboardPage";
            pnlContainer.ResumeLayout(false);
            ResumeLayout(false);

        }

        private Sunny.UI.UIPanel pnlContainer;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UILabel lblSubTitle;
    }
}
