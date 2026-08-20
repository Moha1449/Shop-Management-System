namespace ShopManagementSystem.UsersScreen
{
    partial class frmAddOrUpdateUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btAddOrUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.bdlShape = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.lbPermission = new System.Windows.Forms.Label();
            this.btClose = new Guna.UI2.WinForms.Guna2Button();
            this.cbRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbScreenTitle = new System.Windows.Forms.Label();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.pnResultOfOperation = new Guna.UI2.WinForms.Guna2Panel();
            this.lbOperationResult = new System.Windows.Forms.Label();
            this.pnResultOfOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAddOrUpdate
            // 
            this.btAddOrUpdate.BorderRadius = 10;
            this.btAddOrUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddOrUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAddOrUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btAddOrUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAddOrUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAddOrUpdate.FillColor = System.Drawing.Color.Blue;
            this.btAddOrUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btAddOrUpdate.ForeColor = System.Drawing.Color.White;
            this.btAddOrUpdate.Location = new System.Drawing.Point(199, 487);
            this.btAddOrUpdate.Name = "btAddOrUpdate";
            this.btAddOrUpdate.Size = new System.Drawing.Size(166, 49);
            this.btAddOrUpdate.TabIndex = 13;
            this.btAddOrUpdate.Text = "Add User";
            this.btAddOrUpdate.Click += new System.EventHandler(this.btAddOrUpdate_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.lbPassword.Location = new System.Drawing.Point(14, 232);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(101, 26);
            this.lbPassword.TabIndex = 12;
            this.lbPassword.Text = "Password";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.lbUserName.Location = new System.Drawing.Point(14, 134);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(116, 27);
            this.lbUserName.TabIndex = 11;
            this.lbUserName.Text = "User Name";
            // 
            // tbPassword
            // 
            this.tbPassword.BorderColor = System.Drawing.Color.Black;
            this.tbPassword.BorderRadius = 15;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.DefaultText = "";
            this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(83)))));
            this.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.Location = new System.Drawing.Point(13, 264);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbPassword.MaxLength = 64;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbPassword.PlaceholderText = "Enter The Password";
            this.tbPassword.SelectedText = "";
            this.tbPassword.Size = new System.Drawing.Size(345, 45);
            this.tbPassword.TabIndex = 10;
            this.tbPassword.MouseEnter += new System.EventHandler(this.frmAddOrUpdateUser_MouseEnter);
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.Color.Transparent;
            this.tbUserName.BorderColor = System.Drawing.Color.Black;
            this.tbUserName.BorderRadius = 15;
            this.tbUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserName.DefaultText = "";
            this.tbUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUserName.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(83)))));
            this.tbUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUserName.Location = new System.Drawing.Point(13, 167);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbUserName.MaxLength = 30;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbUserName.PlaceholderText = "Enter The User Name";
            this.tbUserName.SelectedText = "";
            this.tbUserName.Size = new System.Drawing.Size(345, 44);
            this.tbUserName.TabIndex = 9;
            this.tbUserName.MouseEnter += new System.EventHandler(this.frmAddOrUpdateUser_MouseEnter);
            // 
            // bdlShape
            // 
            this.bdlShape.BorderRadius = 15;
            this.bdlShape.ContainerControl = this;
            this.bdlShape.DockIndicatorTransparencyValue = 0.6D;
            this.bdlShape.TransparentWhileDrag = true;
            // 
            // lbPermission
            // 
            this.lbPermission.AutoSize = true;
            this.lbPermission.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPermission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.lbPermission.Location = new System.Drawing.Point(14, 339);
            this.lbPermission.Name = "lbPermission";
            this.lbPermission.Size = new System.Drawing.Size(115, 26);
            this.lbPermission.TabIndex = 15;
            this.lbPermission.Text = "Permission";
            // 
            // btClose
            // 
            this.btClose.BorderRadius = 10;
            this.btClose.BorderThickness = 1;
            this.btClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btClose.FillColor = System.Drawing.Color.White;
            this.btClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(68)))), ((int)(((byte)(124)))));
            this.btClose.Location = new System.Drawing.Point(12, 487);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(166, 49);
            this.btClose.TabIndex = 16;
            this.btClose.Text = "Close";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // cbRole
            // 
            this.cbRole.BackColor = System.Drawing.Color.Transparent;
            this.cbRole.BorderColor = System.Drawing.Color.Black;
            this.cbRole.BorderRadius = 15;
            this.cbRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cbRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(83)))));
            this.cbRole.ItemHeight = 30;
            this.cbRole.Location = new System.Drawing.Point(13, 368);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(345, 36);
            this.cbRole.TabIndex = 17;
            // 
            // lbScreenTitle
            // 
            this.lbScreenTitle.AutoSize = true;
            this.lbScreenTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScreenTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(83)))));
            this.lbScreenTitle.Location = new System.Drawing.Point(12, 29);
            this.lbScreenTitle.Name = "lbScreenTitle";
            this.lbScreenTitle.Size = new System.Drawing.Size(202, 35);
            this.lbScreenTitle.TabIndex = 18;
            this.lbScreenTitle.Text = "Add New User";
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(83)))));
            this.cbActive.Location = new System.Drawing.Point(19, 423);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(83, 24);
            this.cbActive.TabIndex = 19;
            this.cbActive.Text = "Active";
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // pnResultOfOperation
            // 
            this.pnResultOfOperation.BorderColor = System.Drawing.Color.Black;
            this.pnResultOfOperation.BorderRadius = 15;
            this.pnResultOfOperation.BorderThickness = 1;
            this.pnResultOfOperation.Controls.Add(this.lbOperationResult);
            this.pnResultOfOperation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnResultOfOperation.Location = new System.Drawing.Point(13, 79);
            this.pnResultOfOperation.Name = "pnResultOfOperation";
            this.pnResultOfOperation.Size = new System.Drawing.Size(340, 42);
            this.pnResultOfOperation.TabIndex = 20;
            this.pnResultOfOperation.Visible = false;
            // 
            // lbOperationResult
            // 
            this.lbOperationResult.AutoSize = true;
            this.lbOperationResult.BackColor = System.Drawing.Color.Transparent;
            this.lbOperationResult.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOperationResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(83)))));
            this.lbOperationResult.Location = new System.Drawing.Point(36, 9);
            this.lbOperationResult.Name = "lbOperationResult";
            this.lbOperationResult.Size = new System.Drawing.Size(259, 24);
            this.lbOperationResult.TabIndex = 0;
            this.lbOperationResult.Text = "User was Added Successfully.";
            // 
            // frmAddOrUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(377, 548);
            this.Controls.Add(this.pnResultOfOperation);
            this.Controls.Add(this.cbActive);
            this.Controls.Add(this.lbScreenTitle);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.lbPermission);
            this.Controls.Add(this.btAddOrUpdate);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(377, 548);
            this.MinimumSize = new System.Drawing.Size(377, 548);
            this.Name = "frmAddOrUpdateUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAddOrUpdateUser_Load);
            this.pnResultOfOperation.ResumeLayout(false);
            this.pnResultOfOperation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btAddOrUpdate;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUserName;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
        private Guna.UI2.WinForms.Guna2TextBox tbUserName;
        private Guna.UI2.WinForms.Guna2BorderlessForm bdlShape;
        private Guna.UI2.WinForms.Guna2Button btClose;
        private System.Windows.Forms.Label lbPermission;
        private System.Windows.Forms.Label lbScreenTitle;
        private Guna.UI2.WinForms.Guna2ComboBox cbRole;
        private System.Windows.Forms.CheckBox cbActive;
        private Guna.UI2.WinForms.Guna2Panel pnResultOfOperation;
        private System.Windows.Forms.Label lbOperationResult;
    }
}