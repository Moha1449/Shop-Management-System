namespace ShopManagementSystem.UsersScreen
{
    partial class usUsersScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usUsersScreen));
            this.pnUpperFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.lbWelcomingMessage = new System.Windows.Forms.Label();
            this.lbScreenTitle = new System.Windows.Forms.Label();
            this.pnUsersListControllers = new Guna.UI2.WinForms.Guna2Panel();
            this.tbSearchOnUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.btAddNewUser = new Guna.UI2.WinForms.Guna2Button();
            this.pnUsersListContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvUsersList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clRecentsActitvities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clisActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmUsersManagmentServices = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnUpperFooter.SuspendLayout();
            this.pnUsersListControllers.SuspendLayout();
            this.pnUsersListContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).BeginInit();
            this.cmUsersManagmentServices.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnUpperFooter
            // 
            this.pnUpperFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnUpperFooter.BorderColor = System.Drawing.Color.Blue;
            this.pnUpperFooter.BorderRadius = 15;
            this.pnUpperFooter.BorderThickness = 2;
            this.pnUpperFooter.Controls.Add(this.lbWelcomingMessage);
            this.pnUpperFooter.Controls.Add(this.lbScreenTitle);
            this.pnUpperFooter.Location = new System.Drawing.Point(3, 12);
            this.pnUpperFooter.Name = "pnUpperFooter";
            this.pnUpperFooter.Size = new System.Drawing.Size(1048, 71);
            this.pnUpperFooter.TabIndex = 1;
            // 
            // lbWelcomingMessage
            // 
            this.lbWelcomingMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbWelcomingMessage.AutoSize = true;
            this.lbWelcomingMessage.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcomingMessage.Location = new System.Drawing.Point(735, 20);
            this.lbWelcomingMessage.Name = "lbWelcomingMessage";
            this.lbWelcomingMessage.Size = new System.Drawing.Size(183, 30);
            this.lbWelcomingMessage.TabIndex = 1;
            this.lbWelcomingMessage.Text = "Welcome back,";
            // 
            // lbScreenTitle
            // 
            this.lbScreenTitle.AutoSize = true;
            this.lbScreenTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScreenTitle.Location = new System.Drawing.Point(30, 20);
            this.lbScreenTitle.Name = "lbScreenTitle";
            this.lbScreenTitle.Size = new System.Drawing.Size(229, 30);
            this.lbScreenTitle.TabIndex = 0;
            this.lbScreenTitle.Text = "Users Management";
            // 
            // pnUsersListControllers
            // 
            this.pnUsersListControllers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnUsersListControllers.BorderColor = System.Drawing.Color.Blue;
            this.pnUsersListControllers.BorderRadius = 15;
            this.pnUsersListControllers.BorderThickness = 2;
            this.pnUsersListControllers.Controls.Add(this.tbSearchOnUser);
            this.pnUsersListControllers.Controls.Add(this.btAddNewUser);
            this.pnUsersListControllers.Location = new System.Drawing.Point(3, 109);
            this.pnUsersListControllers.Name = "pnUsersListControllers";
            this.pnUsersListControllers.Size = new System.Drawing.Size(1048, 80);
            this.pnUsersListControllers.TabIndex = 2;
            // 
            // tbSearchOnUser
            // 
            this.tbSearchOnUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.tbSearchOnUser.BorderRadius = 15;
            this.tbSearchOnUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchOnUser.DefaultText = "";
            this.tbSearchOnUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearchOnUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearchOnUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchOnUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchOnUser.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbSearchOnUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchOnUser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.tbSearchOnUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(83)))));
            this.tbSearchOnUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchOnUser.Location = new System.Drawing.Point(18, 16);
            this.tbSearchOnUser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbSearchOnUser.Name = "tbSearchOnUser";
            this.tbSearchOnUser.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSearchOnUser.PlaceholderText = "Search";
            this.tbSearchOnUser.SelectedText = "";
            this.tbSearchOnUser.Size = new System.Drawing.Size(489, 45);
            this.tbSearchOnUser.TabIndex = 1;
            this.tbSearchOnUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearchOnUser_KeyDown);
            // 
            // btAddNewUser
            // 
            this.btAddNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddNewUser.BackColor = System.Drawing.Color.White;
            this.btAddNewUser.BorderColor = System.Drawing.Color.Blue;
            this.btAddNewUser.BorderRadius = 15;
            this.btAddNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddNewUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAddNewUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btAddNewUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAddNewUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAddNewUser.FillColor = System.Drawing.Color.Blue;
            this.btAddNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddNewUser.ForeColor = System.Drawing.Color.White;
            this.btAddNewUser.Location = new System.Drawing.Point(819, 16);
            this.btAddNewUser.Name = "btAddNewUser";
            this.btAddNewUser.Size = new System.Drawing.Size(210, 45);
            this.btAddNewUser.TabIndex = 0;
            this.btAddNewUser.Text = "+ Add User";
            this.btAddNewUser.Click += new System.EventHandler(this.btAddNewUser_Click);
            // 
            // pnUsersListContainer
            // 
            this.pnUsersListContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnUsersListContainer.BorderColor = System.Drawing.Color.Blue;
            this.pnUsersListContainer.BorderThickness = 2;
            this.pnUsersListContainer.Controls.Add(this.dgvUsersList);
            this.pnUsersListContainer.Location = new System.Drawing.Point(3, 205);
            this.pnUsersListContainer.Name = "pnUsersListContainer";
            this.pnUsersListContainer.Size = new System.Drawing.Size(1048, 464);
            this.pnUsersListContainer.TabIndex = 3;
            // 
            // dgvUsersList
            // 
            this.dgvUsersList.AllowUserToAddRows = false;
            this.dgvUsersList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvUsersList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsersList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsersList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsersList.ColumnHeadersHeight = 27;
            this.dgvUsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUsersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clRecentsActitvities,
            this.clUserName,
            this.clisActive,
            this.clCreatedBy});
            this.dgvUsersList.ContextMenuStrip = this.cmUsersManagmentServices;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsersList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsersList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUsersList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsersList.Location = new System.Drawing.Point(3, 3);
            this.dgvUsersList.MultiSelect = false;
            this.dgvUsersList.Name = "dgvUsersList";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsersList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsersList.RowHeadersVisible = false;
            this.dgvUsersList.RowHeadersWidth = 51;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.dgvUsersList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUsersList.RowTemplate.Height = 24;
            this.dgvUsersList.Size = new System.Drawing.Size(1042, 458);
            this.dgvUsersList.TabIndex = 1;
            this.dgvUsersList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsersList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Blue;
            this.dgvUsersList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsersList.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvUsersList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvUsersList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsersList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvUsersList.ThemeStyle.RowsStyle.Height = 24;
            this.dgvUsersList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvUsersList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // clRecentsActitvities
            // 
            this.clRecentsActitvities.HeaderText = "ID";
            this.clRecentsActitvities.MinimumWidth = 6;
            this.clRecentsActitvities.Name = "clRecentsActitvities";
            // 
            // clUserName
            // 
            this.clUserName.HeaderText = "User Name";
            this.clUserName.MinimumWidth = 6;
            this.clUserName.Name = "clUserName";
            // 
            // clisActive
            // 
            this.clisActive.HeaderText = "Is Active";
            this.clisActive.MinimumWidth = 6;
            this.clisActive.Name = "clisActive";
            // 
            // clCreatedBy
            // 
            this.clCreatedBy.HeaderText = "Created By";
            this.clCreatedBy.MinimumWidth = 6;
            this.clCreatedBy.Name = "clCreatedBy";
            // 
            // cmUsersManagmentServices
            // 
            this.cmUsersManagmentServices.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmUsersManagmentServices.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmUsersManagmentServices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateUserToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmUsersManagmentServices.Name = "cmUsersManagmentServices";
            this.cmUsersManagmentServices.Size = new System.Drawing.Size(208, 68);
            // 
            // updateUserToolStripMenuItem
            // 
            this.updateUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateUserToolStripMenuItem.Image")));
            this.updateUserToolStripMenuItem.Name = "updateUserToolStripMenuItem";
            this.updateUserToolStripMenuItem.Size = new System.Drawing.Size(207, 32);
            this.updateUserToolStripMenuItem.Text = "Update User";
            this.updateUserToolStripMenuItem.Click += new System.EventHandler(this.updateUserToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(207, 32);
            this.deleteToolStripMenuItem.Text = "Delete User";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // usUsersScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnUsersListContainer);
            this.Controls.Add(this.pnUsersListControllers);
            this.Controls.Add(this.pnUpperFooter);
            this.Name = "usUsersScreen";
            this.Size = new System.Drawing.Size(1054, 672);
            this.Load += new System.EventHandler(this.usUsersScreen_Load);
            this.pnUpperFooter.ResumeLayout(false);
            this.pnUpperFooter.PerformLayout();
            this.pnUsersListControllers.ResumeLayout(false);
            this.pnUsersListContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).EndInit();
            this.cmUsersManagmentServices.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnUpperFooter;
        private System.Windows.Forms.Label lbWelcomingMessage;
        private System.Windows.Forms.Label lbScreenTitle;
        private Guna.UI2.WinForms.Guna2Panel pnUsersListControllers;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchOnUser;
        private Guna.UI2.WinForms.Guna2Button btAddNewUser;
        private Guna.UI2.WinForms.Guna2Panel pnUsersListContainer;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUsersList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRecentsActitvities;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clisActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCreatedBy;
        private System.Windows.Forms.ContextMenuStrip cmUsersManagmentServices;
        private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
