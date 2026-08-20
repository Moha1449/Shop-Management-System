namespace ShopManagementSystem
{
    partial class frmLoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginScreen));
            this.tbUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbWelcomingMessage = new System.Windows.Forms.Label();
            this.btLogin = new Guna.UI2.WinForms.Guna2Button();
            this.pbLock = new System.Windows.Forms.PictureBox();
            this.lbSubheader = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pnLoginResult = new Guna.UI2.WinForms.Guna2Panel();
            this.lbLoginResultValue = new System.Windows.Forms.Label();
            this.bdlFormStyle = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.pnLoginResult.SuspendLayout();
            this.SuspendLayout();
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
            this.tbUserName.Location = new System.Drawing.Point(40, 290);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbUserName.MaxLength = 30;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbUserName.PlaceholderText = "Enter The User Name ";
            this.tbUserName.SelectedText = "";
            this.tbUserName.Size = new System.Drawing.Size(345, 44);
            this.tbUserName.TabIndex = 3;
            this.tbUserName.MouseEnter += new System.EventHandler(this.tbUserName_MouseEnter);
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
            this.tbPassword.Location = new System.Drawing.Point(40, 402);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbPassword.MaxLength = 64;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbPassword.PlaceholderText = "Enter The Password";
            this.tbPassword.SelectedText = "";
            this.tbPassword.Size = new System.Drawing.Size(345, 45);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.MouseEnter += new System.EventHandler(this.tbUserName_MouseEnter);
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.lbUserName.Location = new System.Drawing.Point(57, 257);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(116, 27);
            this.lbUserName.TabIndex = 5;
            this.lbUserName.Text = "User Name";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.lbPassword.Location = new System.Drawing.Point(57, 370);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(101, 26);
            this.lbPassword.TabIndex = 6;
            this.lbPassword.Text = "Password";
            // 
            // lbWelcomingMessage
            // 
            this.lbWelcomingMessage.AutoSize = true;
            this.lbWelcomingMessage.Font = new System.Drawing.Font("Franklin Gothic Medium", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcomingMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(83)))));
            this.lbWelcomingMessage.Location = new System.Drawing.Point(80, 113);
            this.lbWelcomingMessage.Name = "lbWelcomingMessage";
            this.lbWelcomingMessage.Size = new System.Drawing.Size(249, 38);
            this.lbWelcomingMessage.TabIndex = 7;
            this.lbWelcomingMessage.Text = "Welcome Back ";
            // 
            // btLogin
            // 
            this.btLogin.BorderRadius = 15;
            this.btLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btLogin.FillColor = System.Drawing.Color.Blue;
            this.btLogin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btLogin.ForeColor = System.Drawing.Color.White;
            this.btLogin.Location = new System.Drawing.Point(71, 507);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(276, 59);
            this.btLogin.TabIndex = 8;
            this.btLogin.Text = "Login";
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // pbLock
            // 
            this.pbLock.Image = ((System.Drawing.Image)(resources.GetObject("pbLock.Image")));
            this.pbLock.Location = new System.Drawing.Point(165, 24);
            this.pbLock.Name = "pbLock";
            this.pbLock.Size = new System.Drawing.Size(81, 72);
            this.pbLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLock.TabIndex = 9;
            this.pbLock.TabStop = false;
            // 
            // lbSubheader
            // 
            this.lbSubheader.AutoSize = true;
            this.lbSubheader.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubheader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(83)))));
            this.lbSubheader.Location = new System.Drawing.Point(120, 167);
            this.lbSubheader.Name = "lbSubheader";
            this.lbSubheader.Size = new System.Drawing.Size(167, 24);
            this.lbSubheader.TabIndex = 10;
            this.lbSubheader.Text = "Login To Continue";
            // 
            // pbClose
            // 
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(369, 3);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(44, 41);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 11;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pnLoginResult
            // 
            this.pnLoginResult.BackColor = System.Drawing.Color.White;
            this.pnLoginResult.BorderColor = System.Drawing.Color.White;
            this.pnLoginResult.BorderRadius = 15;
            this.pnLoginResult.BorderThickness = 1;
            this.pnLoginResult.Controls.Add(this.lbLoginResultValue);
            this.pnLoginResult.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnLoginResult.Location = new System.Drawing.Point(40, 204);
            this.pnLoginResult.Name = "pnLoginResult";
            this.pnLoginResult.Size = new System.Drawing.Size(342, 41);
            this.pnLoginResult.TabIndex = 12;
            this.pnLoginResult.Visible = false;
            // 
            // lbLoginResultValue
            // 
            this.lbLoginResultValue.AutoSize = true;
            this.lbLoginResultValue.BackColor = System.Drawing.Color.Transparent;
            this.lbLoginResultValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginResultValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(83)))));
            this.lbLoginResultValue.Location = new System.Drawing.Point(18, 11);
            this.lbLoginResultValue.Name = "lbLoginResultValue";
            this.lbLoginResultValue.Size = new System.Drawing.Size(268, 20);
            this.lbLoginResultValue.TabIndex = 0;
            this.lbLoginResultValue.Text = "Invalid UserName or Password";
            // 
            // bdlFormStyle
            // 
            this.bdlFormStyle.BorderRadius = 15;
            this.bdlFormStyle.ContainerControl = this;
            this.bdlFormStyle.DockIndicatorTransparencyValue = 0.6D;
            this.bdlFormStyle.TransparentWhileDrag = true;
            // 
            // frmLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(416, 587);
            this.Controls.Add(this.pnLoginResult);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.lbSubheader);
            this.Controls.Add(this.pbLock);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.lbWelcomingMessage);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoginScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pbLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.pnLoginResult.ResumeLayout(false);
            this.pnLoginResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox tbUserName;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbWelcomingMessage;
        private Guna.UI2.WinForms.Guna2Button btLogin;
        private System.Windows.Forms.PictureBox pbLock;
        private System.Windows.Forms.Label lbSubheader;
        private System.Windows.Forms.PictureBox pbClose;
        private Guna.UI2.WinForms.Guna2Panel pnLoginResult;
        private System.Windows.Forms.Label lbLoginResultValue;
        private Guna.UI2.WinForms.Guna2BorderlessForm bdlFormStyle;
    }
}