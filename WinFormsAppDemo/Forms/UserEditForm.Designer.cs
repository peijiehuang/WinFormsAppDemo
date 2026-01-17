
namespace WinFormsAppDemo.Forms
{
    partial class UserEditForm
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
            lblUsername = new Sunny.UI.UILabel();
            txtUsername = new Sunny.UI.UITextBox();
            lblPassword = new Sunny.UI.UILabel();
            txtPassword = new Sunny.UI.UITextBox();
            lblEmail = new Sunny.UI.UILabel();
            txtEmail = new Sunny.UI.UITextBox();
            lblRealName = new Sunny.UI.UILabel();
            txtRealName = new Sunny.UI.UITextBox();
            lblPhone = new Sunny.UI.UILabel();
            txtPhone = new Sunny.UI.UITextBox();
            chkIsActive = new Sunny.UI.UICheckBox();
            btnSave = new Sunny.UI.UIButton();
            btnCancel = new Sunny.UI.UIButton();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("微软雅黑", 12F);
            lblUsername.ForeColor = Color.FromArgb(48, 48, 48);
            lblUsername.Location = new Point(30, 60);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 29);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "用户名:";
            lblUsername.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("微软雅黑", 12F);
            txtUsername.Location = new Point(140, 60);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.MinimumSize = new Size(1, 16);
            txtUsername.Name = "txtUsername";
            txtUsername.Padding = new Padding(5);
            txtUsername.ShowText = false;
            txtUsername.Size = new Size(300, 29);
            txtUsername.TabIndex = 1;
            txtUsername.TextAlignment = ContentAlignment.MiddleLeft;
            txtUsername.Watermark = "请输入用户名";
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("微软雅黑", 12F);
            lblPassword.ForeColor = Color.FromArgb(48, 48, 48);
            lblPassword.Location = new Point(30, 110);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 29);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "密码:";
            lblPassword.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("微软雅黑", 12F);
            txtPassword.Location = new Point(140, 110);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.MinimumSize = new Size(1, 16);
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(5);
            txtPassword.PasswordChar = '*';
            txtPassword.ShowText = false;
            txtPassword.Size = new Size(300, 29);
            txtPassword.TabIndex = 3;
            txtPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtPassword.Watermark = "请输入密码(至少6位)";
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("微软雅黑", 12F);
            lblEmail.ForeColor = Color.FromArgb(48, 48, 48);
            lblEmail.Location = new Point(30, 160);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 29);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "邮箱:";
            lblEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("微软雅黑", 12F);
            txtEmail.Location = new Point(140, 160);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.MinimumSize = new Size(1, 16);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(5);
            txtEmail.ShowText = false;
            txtEmail.Size = new Size(300, 29);
            txtEmail.TabIndex = 5;
            txtEmail.TextAlignment = ContentAlignment.MiddleLeft;
            txtEmail.Watermark = "请输入邮箱(可选)";
            // 
            // lblRealName
            // 
            lblRealName.Font = new Font("微软雅黑", 12F);
            lblRealName.ForeColor = Color.FromArgb(48, 48, 48);
            lblRealName.Location = new Point(30, 210);
            lblRealName.Name = "lblRealName";
            lblRealName.Size = new Size(100, 29);
            lblRealName.TabIndex = 6;
            lblRealName.Text = "真实姓名:";
            lblRealName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtRealName
            // 
            txtRealName.Font = new Font("微软雅黑", 12F);
            txtRealName.Location = new Point(140, 210);
            txtRealName.Margin = new Padding(4, 5, 4, 5);
            txtRealName.MinimumSize = new Size(1, 16);
            txtRealName.Name = "txtRealName";
            txtRealName.Padding = new Padding(5);
            txtRealName.ShowText = false;
            txtRealName.Size = new Size(300, 29);
            txtRealName.TabIndex = 7;
            txtRealName.TextAlignment = ContentAlignment.MiddleLeft;
            txtRealName.Watermark = "请输入真实姓名(可选)";
            // 
            // lblPhone
            // 
            lblPhone.Font = new Font("微软雅黑", 12F);
            lblPhone.ForeColor = Color.FromArgb(48, 48, 48);
            lblPhone.Location = new Point(30, 260);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 29);
            lblPhone.TabIndex = 8;
            lblPhone.Text = "电话:";
            lblPhone.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("微软雅黑", 12F);
            txtPhone.Location = new Point(140, 260);
            txtPhone.Margin = new Padding(4, 5, 4, 5);
            txtPhone.MinimumSize = new Size(1, 16);
            txtPhone.Name = "txtPhone";
            txtPhone.Padding = new Padding(5);
            txtPhone.ShowText = false;
            txtPhone.Size = new Size(300, 29);
            txtPhone.TabIndex = 9;
            txtPhone.TextAlignment = ContentAlignment.MiddleLeft;
            txtPhone.Watermark = "请输入电话(可选)";
            // 
            // chkIsActive
            // 
            chkIsActive.Checked = true;
            chkIsActive.Font = new Font("微软雅黑", 12F);
            chkIsActive.ForeColor = Color.FromArgb(48, 48, 48);
            chkIsActive.Location = new Point(140, 310);
            chkIsActive.MinimumSize = new Size(1, 1);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(150, 29);
            chkIsActive.TabIndex = 10;
            chkIsActive.Text = "是否激活";
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.FillColor = Color.FromArgb(102, 58, 183);
            btnSave.FillColor2 = Color.FromArgb(102, 58, 183);
            btnSave.FillHoverColor = Color.FromArgb(133, 97, 198);
            btnSave.FillPressColor = Color.FromArgb(82, 46, 147);
            btnSave.FillSelectedColor = Color.FromArgb(82, 46, 147);
            btnSave.Font = new Font("微软雅黑", 12F);
            btnSave.LightColor = Color.FromArgb(244, 242, 251);
            btnSave.Location = new Point(140, 370);
            btnSave.MinimumSize = new Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.RectColor = Color.FromArgb(102, 58, 183);
            btnSave.RectHoverColor = Color.FromArgb(133, 97, 198);
            btnSave.RectPressColor = Color.FromArgb(82, 46, 147);
            btnSave.RectSelectedColor = Color.FromArgb(82, 46, 147);
            btnSave.Size = new Size(120, 40);
            btnSave.Style = Sunny.UI.UIStyle.Custom;
            btnSave.TabIndex = 11;
            btnSave.Text = "保存";
            btnSave.TipsFont = new Font("微软雅黑", 9F);
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FillColor = Color.FromArgb(230, 230, 230);
            btnCancel.FillHoverColor = Color.FromArgb(235, 243, 255);
            btnCancel.FillPressColor = Color.FromArgb(220, 220, 220);
            btnCancel.FillSelectedColor = Color.FromArgb(220, 220, 220);
            btnCancel.Font = new Font("微软雅黑", 12F);
            btnCancel.ForeColor = Color.FromArgb(48, 48, 48);
            btnCancel.Location = new Point(320, 370);
            btnCancel.MinimumSize = new Size(1, 1);
            btnCancel.Name = "btnCancel";
            btnCancel.RectColor = Color.FromArgb(216, 216, 216);
            btnCancel.RectHoverColor = Color.FromArgb(197, 197, 197);
            btnCancel.RectPressColor = Color.FromArgb(176, 176, 176);
            btnCancel.RectSelectedColor = Color.FromArgb(176, 176, 176);
            btnCancel.Size = new Size(120, 40);
            btnCancel.Style = Sunny.UI.UIStyle.Custom;
            btnCancel.TabIndex = 12;
            btnCancel.Text = "取消";
            btnCancel.TipsFont = new Font("微软雅黑", 9F);
            btnCancel.Click += btnCancel_Click;
            // 
            // UserEditForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(244, 242, 251);
            ClientSize = new Size(480, 450);
            ControlBoxFillHoverColor = Color.FromArgb(133, 97, 198);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(chkIsActive);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtRealName);
            Controls.Add(lblRealName);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserEditForm";
            RectColor = Color.FromArgb(102, 58, 183);
            StartPosition = FormStartPosition.CenterParent;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "用户编辑";
            TitleColor = Color.FromArgb(102, 58, 183);
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            ResumeLayout(false);

        }

        private Sunny.UI.UILabel lblUsername;
        private Sunny.UI.UITextBox txtUsername;
        private Sunny.UI.UILabel lblPassword;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UILabel lblEmail;
        private Sunny.UI.UITextBox txtEmail;
        private Sunny.UI.UILabel lblRealName;
        private Sunny.UI.UITextBox txtRealName;
        private Sunny.UI.UILabel lblPhone;
        private Sunny.UI.UITextBox txtPhone;
        private Sunny.UI.UICheckBox chkIsActive;
        private Sunny.UI.UIButton btnSave;
        private Sunny.UI.UIButton btnCancel;
    }
}
