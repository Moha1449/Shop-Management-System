namespace ShopManagementSystem
{
    partial class frmMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainScreen));
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btLogout = new System.Windows.Forms.Button();
            this.pbMenu = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btStocks = new System.Windows.Forms.Button();
            this.lbWelcomingMessage = new System.Windows.Forms.Label();
            this.btSells = new System.Windows.Forms.Button();
            this.btDashboard = new System.Windows.Forms.Button();
            this.btUsers = new System.Windows.Forms.Button();
            this.scMainScreen = new System.Windows.Forms.SplitContainer();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scMainScreen)).BeginInit();
            this.scMainScreen.Panel1.SuspendLayout();
            this.scMainScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pnMenu.Controls.Add(this.btLogout);
            this.pnMenu.Controls.Add(this.pbMenu);
            this.pnMenu.Controls.Add(this.btStocks);
            this.pnMenu.Controls.Add(this.lbWelcomingMessage);
            this.pnMenu.Controls.Add(this.btSells);
            this.pnMenu.Controls.Add(this.btDashboard);
            this.pnMenu.Controls.Add(this.btUsers);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(214, 678);
            this.pnMenu.TabIndex = 0;
            // 
            // btLogout
            // 
            this.btLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogout.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.ForeColor = System.Drawing.Color.White;
            this.btLogout.Location = new System.Drawing.Point(-8, 621);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(223, 57);
            this.btLogout.TabIndex = 14;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // pbMenu
            // 
            this.pbMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbMenu.Image")));
            this.pbMenu.ImageRotate = 0F;
            this.pbMenu.Location = new System.Drawing.Point(70, 12);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbMenu.Size = new System.Drawing.Size(74, 64);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMenu.TabIndex = 8;
            this.pbMenu.TabStop = false;
            // 
            // btStocks
            // 
            this.btStocks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btStocks.BackColor = System.Drawing.Color.Transparent;
            this.btStocks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btStocks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStocks.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStocks.ForeColor = System.Drawing.Color.White;
            this.btStocks.Location = new System.Drawing.Point(3, 357);
            this.btStocks.Name = "btStocks";
            this.btStocks.Size = new System.Drawing.Size(208, 51);
            this.btStocks.TabIndex = 13;
            this.btStocks.Text = "Stocks";
            this.btStocks.UseVisualStyleBackColor = false;
            this.btStocks.Click += new System.EventHandler(this.ButtonClicked_EventHandler);
            // 
            // lbWelcomingMessage
            // 
            this.lbWelcomingMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbWelcomingMessage.AutoSize = true;
            this.lbWelcomingMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcomingMessage.ForeColor = System.Drawing.Color.White;
            this.lbWelcomingMessage.Location = new System.Drawing.Point(12, 104);
            this.lbWelcomingMessage.Name = "lbWelcomingMessage";
            this.lbWelcomingMessage.Size = new System.Drawing.Size(191, 29);
            this.lbWelcomingMessage.TabIndex = 9;
            this.lbWelcomingMessage.Text = "Welcome Back ";
            // 
            // btSells
            // 
            this.btSells.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSells.BackColor = System.Drawing.Color.Transparent;
            this.btSells.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSells.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btSells.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSells.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSells.ForeColor = System.Drawing.Color.White;
            this.btSells.Location = new System.Drawing.Point(3, 300);
            this.btSells.Name = "btSells";
            this.btSells.Size = new System.Drawing.Size(208, 51);
            this.btSells.TabIndex = 12;
            this.btSells.Text = "Sells";
            this.btSells.UseVisualStyleBackColor = false;
            this.btSells.Click += new System.EventHandler(this.ButtonClicked_EventHandler);
            // 
            // btDashboard
            // 
            this.btDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDashboard.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDashboard.ForeColor = System.Drawing.Color.White;
            this.btDashboard.Location = new System.Drawing.Point(3, 186);
            this.btDashboard.Name = "btDashboard";
            this.btDashboard.Size = new System.Drawing.Size(208, 51);
            this.btDashboard.TabIndex = 10;
            this.btDashboard.Text = "Dashboard";
            this.btDashboard.UseVisualStyleBackColor = false;
            this.btDashboard.Click += new System.EventHandler(this.ButtonClicked_EventHandler);
            // 
            // btUsers
            // 
            this.btUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btUsers.BackColor = System.Drawing.Color.Transparent;
            this.btUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUsers.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUsers.ForeColor = System.Drawing.Color.White;
            this.btUsers.Location = new System.Drawing.Point(3, 243);
            this.btUsers.Name = "btUsers";
            this.btUsers.Size = new System.Drawing.Size(208, 51);
            this.btUsers.TabIndex = 11;
            this.btUsers.Text = "Users";
            this.btUsers.UseVisualStyleBackColor = false;
            this.btUsers.Click += new System.EventHandler(this.ButtonClicked_EventHandler);
            // 
            // scMainScreen
            // 
            this.scMainScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMainScreen.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scMainScreen.IsSplitterFixed = true;
            this.scMainScreen.Location = new System.Drawing.Point(0, 0);
            this.scMainScreen.Name = "scMainScreen";
            // 
            // scMainScreen.Panel1
            // 
            this.scMainScreen.Panel1.BackColor = System.Drawing.Color.Navy;
            this.scMainScreen.Panel1.Controls.Add(this.pnMenu);
            this.scMainScreen.Size = new System.Drawing.Size(988, 678);
            this.scMainScreen.SplitterDistance = 214;
            this.scMainScreen.TabIndex = 0;
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 678);
            this.Controls.Add(this.scMainScreen);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "frmMainScreen";
            this.Text = "Shop Management System ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainScreen_FormClosed);
            this.Load += new System.EventHandler(this.frmMainScreen_Load);
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            this.scMainScreen.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMainScreen)).EndInit();
            this.scMainScreen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.SplitContainer scMainScreen;
        private System.Windows.Forms.Button btLogout;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbMenu;
        private System.Windows.Forms.Button btStocks;
        private System.Windows.Forms.Label lbWelcomingMessage;
        private System.Windows.Forms.Button btSells;
        private System.Windows.Forms.Button btDashboard;
        private System.Windows.Forms.Button btUsers;
    }
}

