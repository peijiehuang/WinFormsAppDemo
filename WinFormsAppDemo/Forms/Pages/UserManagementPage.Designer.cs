
namespace WinFormsAppDemo.Forms.Pages
{
    partial class UserManagementPage
    {
        private System.ComponentModel.IContainer components = null;



        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panelTop = new Sunny.UI.UIPanel();
            txtSearch = new Sunny.UI.UITextBox();
            btnSearch = new Sunny.UI.UISymbolButton();
            btnRefresh = new Sunny.UI.UISymbolButton();
            btnAdd = new Sunny.UI.UISymbolButton();
            dgvUsers = new Sunny.UI.UIDataGridView();
            colId = new DataGridViewTextBoxColumn();
            colUsername = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colRealName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colIsActive = new DataGridViewTextBoxColumn();
            colCreateTime = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(txtSearch);
            panelTop.Controls.Add(btnSearch);
            panelTop.Controls.Add(btnRefresh);
            panelTop.Controls.Add(btnAdd);
            panelTop.Dock = DockStyle.Top;
            panelTop.Font = new Font("微软雅黑", 12F);
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(4, 5, 4, 5);
            panelTop.MinimumSize = new Size(1, 1);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1000, 60);
            panelTop.TabIndex = 0;
            panelTop.Text = null;
            panelTop.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Font = new Font("微软雅黑", 12F);
            txtSearch.Location = new Point(550, 15);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.MinimumSize = new Size(1, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Padding = new Padding(5);
            txtSearch.ShowText = false;
            txtSearch.Size = new Size(250, 30);
            txtSearch.TabIndex = 3;
            txtSearch.TextAlignment = ContentAlignment.MiddleLeft;
            txtSearch.Watermark = "搜索用户名/姓名/邮箱";
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FillColor = Color.FromArgb(102, 58, 183);
            btnSearch.FillColor2 = Color.FromArgb(102, 58, 183);
            btnSearch.FillHoverColor = Color.FromArgb(133, 97, 198);
            btnSearch.FillPressColor = Color.FromArgb(82, 46, 147);
            btnSearch.FillSelectedColor = Color.FromArgb(82, 46, 147);
            btnSearch.Font = new Font("微软雅黑", 12F);
            btnSearch.LightColor = Color.FromArgb(244, 242, 251);
            btnSearch.Location = new Point(810, 15);
            btnSearch.MinimumSize = new Size(1, 1);
            btnSearch.Name = "btnSearch";
            btnSearch.RectColor = Color.FromArgb(102, 58, 183);
            btnSearch.RectHoverColor = Color.FromArgb(133, 97, 198);
            btnSearch.RectPressColor = Color.FromArgb(82, 46, 147);
            btnSearch.RectSelectedColor = Color.FromArgb(82, 46, 147);
            btnSearch.Size = new Size(80, 30);
            btnSearch.Style = Sunny.UI.UIStyle.Custom;
            btnSearch.Symbol = 61442;
            btnSearch.TabIndex = 2;
            btnSearch.Text = "搜索";
            btnSearch.TipsFont = new Font("微软雅黑", 9F);
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FillColor = Color.FromArgb(102, 58, 183);
            btnRefresh.FillColor2 = Color.FromArgb(102, 58, 183);
            btnRefresh.FillHoverColor = Color.FromArgb(133, 97, 198);
            btnRefresh.FillPressColor = Color.FromArgb(82, 46, 147);
            btnRefresh.FillSelectedColor = Color.FromArgb(82, 46, 147);
            btnRefresh.Font = new Font("微软雅黑", 12F);
            btnRefresh.LightColor = Color.FromArgb(244, 242, 251);
            btnRefresh.Location = new Point(120, 15);
            btnRefresh.MinimumSize = new Size(1, 1);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.RectColor = Color.FromArgb(102, 58, 183);
            btnRefresh.RectHoverColor = Color.FromArgb(133, 97, 198);
            btnRefresh.RectPressColor = Color.FromArgb(82, 46, 147);
            btnRefresh.RectSelectedColor = Color.FromArgb(82, 46, 147);
            btnRefresh.Size = new Size(100, 30);
            btnRefresh.Style = Sunny.UI.UIStyle.Custom;
            btnRefresh.Symbol = 61473;
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "刷新";
            btnRefresh.TipsFont = new Font("微软雅黑", 9F);
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FillColor = Color.FromArgb(102, 58, 183);
            btnAdd.FillColor2 = Color.FromArgb(102, 58, 183);
            btnAdd.FillHoverColor = Color.FromArgb(133, 97, 198);
            btnAdd.FillPressColor = Color.FromArgb(82, 46, 147);
            btnAdd.FillSelectedColor = Color.FromArgb(82, 46, 147);
            btnAdd.Font = new Font("微软雅黑", 12F);
            btnAdd.LightColor = Color.FromArgb(244, 242, 251);
            btnAdd.Location = new Point(10, 15);
            btnAdd.MinimumSize = new Size(1, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.RectColor = Color.FromArgb(102, 58, 183);
            btnAdd.RectHoverColor = Color.FromArgb(133, 97, 198);
            btnAdd.RectPressColor = Color.FromArgb(82, 46, 147);
            btnAdd.RectSelectedColor = Color.FromArgb(82, 46, 147);
            btnAdd.Size = new Size(100, 30);
            btnAdd.Style = Sunny.UI.UIStyle.Custom;
            btnAdd.Symbol = 61543;
            btnAdd.TabIndex = 0;
            btnAdd.Text = "添加";
            btnAdd.TipsFont = new Font("微软雅黑", 9F);
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(103, 58, 183);
            dataGridViewCellStyle2.Font = new Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.ColumnHeadersHeight = 32;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { colId, colUsername, colEmail, colRealName, colPhone, colIsActive, colCreateTime, colEdit, colDelete });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.Font = new Font("微软雅黑", 12F);
            dgvUsers.GridColor = Color.FromArgb(80, 160, 255);
            dgvUsers.Location = new Point(0, 60);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(103, 58, 183);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvUsers.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("微软雅黑", 12F);
            dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvUsers.RowTemplate.Height = 29;
            dgvUsers.SelectedIndex = -1;
            dgvUsers.Size = new Size(1000, 540);
            dgvUsers.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgvUsers.TabIndex = 1;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colUsername
            // 
            colUsername.DataPropertyName = "Username";
            colUsername.HeaderText = "用户名";
            colUsername.MinimumWidth = 6;
            colUsername.Name = "colUsername";
            colUsername.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "邮箱";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colRealName
            // 
            colRealName.DataPropertyName = "RealName";
            colRealName.HeaderText = "真实姓名";
            colRealName.MinimumWidth = 6;
            colRealName.Name = "colRealName";
            colRealName.ReadOnly = true;
            // 
            // colPhone
            // 
            colPhone.DataPropertyName = "Phone";
            colPhone.HeaderText = "电话";
            colPhone.MinimumWidth = 6;
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            // 
            // colIsActive
            // 
            colIsActive.DataPropertyName = "IsActive";
            colIsActive.HeaderText = "状态";
            colIsActive.MinimumWidth = 6;
            colIsActive.Name = "colIsActive";
            colIsActive.ReadOnly = true;
            // 
            // colCreateTime
            // 
            colCreateTime.DataPropertyName = "CreateTime";
            colCreateTime.HeaderText = "创建时间";
            colCreateTime.MinimumWidth = 6;
            colCreateTime.Name = "colCreateTime";
            colCreateTime.ReadOnly = true;
            // 
            // colEdit
            // 
            colEdit.HeaderText = "编辑";
            colEdit.MinimumWidth = 6;
            colEdit.Name = "colEdit";
            colEdit.ReadOnly = true;
            colEdit.Text = "编辑";
            colEdit.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            colDelete.HeaderText = "删除";
            colDelete.MinimumWidth = 6;
            colDelete.Name = "colDelete";
            colDelete.ReadOnly = true;
            colDelete.Text = "删除";
            colDelete.UseColumnTextForButtonValue = true;
            // 
            // UserManagementPage
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(244, 242, 251);
            ClientSize = new Size(1000, 600);
            ControlBoxFillHoverColor = Color.FromArgb(133, 97, 198);
            Controls.Add(dgvUsers);
            Controls.Add(panelTop);
            Name = "UserManagementPage";
            PageIndex = 1002;
            RectColor = Color.FromArgb(102, 58, 183);
            Style = Sunny.UI.UIStyle.Custom;
            Text = "用户管理";
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);

        }

        private Sunny.UI.UIPanel panelTop;
        private Sunny.UI.UISymbolButton btnAdd;
        private Sunny.UI.UISymbolButton btnRefresh;
        private Sunny.UI.UISymbolButton btnSearch;
        private Sunny.UI.UITextBox txtSearch;
        private Sunny.UI.UIDataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRealName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateTime;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}
