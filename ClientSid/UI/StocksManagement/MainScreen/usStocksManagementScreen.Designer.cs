namespace ShopManagementSystem.StocksManagement.MainScreen
{
    partial class usStocksManagementScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usStocksManagementScreen));
            this.pnUpperFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.lbWelcomingMessage = new System.Windows.Forms.Label();
            this.lbScreenTitle = new System.Windows.Forms.Label();
            this.pnStocksListControllers = new Guna.UI2.WinForms.Guna2Panel();
            this.tbSearchOnStock = new Guna.UI2.WinForms.Guna2TextBox();
            this.btAddNewUser = new Guna.UI2.WinForms.Guna2Button();
            this.pnUsersListContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvStocksList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clRecentsActitvities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAddedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmStocksManagmentServices = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnUpperFooter.SuspendLayout();
            this.pnStocksListControllers.SuspendLayout();
            this.pnUsersListContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocksList)).BeginInit();
            this.cmStocksManagmentServices.SuspendLayout();
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
            this.pnUpperFooter.Location = new System.Drawing.Point(3, 8);
            this.pnUpperFooter.Name = "pnUpperFooter";
            this.pnUpperFooter.Size = new System.Drawing.Size(1048, 71);
            this.pnUpperFooter.TabIndex = 4;
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
            this.lbScreenTitle.Size = new System.Drawing.Size(241, 30);
            this.lbScreenTitle.TabIndex = 0;
            this.lbScreenTitle.Text = "Stocks Management";
            // 
            // pnStocksListControllers
            // 
            this.pnStocksListControllers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnStocksListControllers.BorderColor = System.Drawing.Color.Blue;
            this.pnStocksListControllers.BorderRadius = 15;
            this.pnStocksListControllers.BorderThickness = 2;
            this.pnStocksListControllers.Controls.Add(this.tbSearchOnStock);
            this.pnStocksListControllers.Controls.Add(this.btAddNewUser);
            this.pnStocksListControllers.Location = new System.Drawing.Point(3, 105);
            this.pnStocksListControllers.Name = "pnStocksListControllers";
            this.pnStocksListControllers.Size = new System.Drawing.Size(1048, 80);
            this.pnStocksListControllers.TabIndex = 5;
            // 
            // tbSearchOnStock
            // 
            this.tbSearchOnStock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.tbSearchOnStock.BorderRadius = 15;
            this.tbSearchOnStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchOnStock.DefaultText = "";
            this.tbSearchOnStock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearchOnStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearchOnStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchOnStock.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchOnStock.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbSearchOnStock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchOnStock.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.tbSearchOnStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(83)))));
            this.tbSearchOnStock.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchOnStock.Location = new System.Drawing.Point(18, 16);
            this.tbSearchOnStock.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbSearchOnStock.Name = "tbSearchOnStock";
            this.tbSearchOnStock.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSearchOnStock.PlaceholderText = "Search";
            this.tbSearchOnStock.SelectedText = "";
            this.tbSearchOnStock.Size = new System.Drawing.Size(489, 45);
            this.tbSearchOnStock.TabIndex = 1;
            this.tbSearchOnStock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearchOnStock_KeyDown);
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
            this.btAddNewUser.Text = "+ Add Stock";
            this.btAddNewUser.Click += new System.EventHandler(this.btAddNewUser_Click);
            // 
            // pnUsersListContainer
            // 
            this.pnUsersListContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnUsersListContainer.BorderColor = System.Drawing.Color.Blue;
            this.pnUsersListContainer.BorderThickness = 2;
            this.pnUsersListContainer.Controls.Add(this.dgvStocksList);
            this.pnUsersListContainer.Location = new System.Drawing.Point(3, 201);
            this.pnUsersListContainer.Name = "pnUsersListContainer";
            this.pnUsersListContainer.Size = new System.Drawing.Size(1048, 464);
            this.pnUsersListContainer.TabIndex = 6;
            // 
            // dgvStocksList
            // 
            this.dgvStocksList.AllowUserToAddRows = false;
            this.dgvStocksList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvStocksList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStocksList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStocksList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStocksList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStocksList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStocksList.ColumnHeadersHeight = 27;
            this.dgvStocksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvStocksList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clRecentsActitvities,
            this.clName,
            this.clAmount,
            this.clAddedBy});
            this.dgvStocksList.ContextMenuStrip = this.cmStocksManagmentServices;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStocksList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStocksList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStocksList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvStocksList.Location = new System.Drawing.Point(3, 3);
            this.dgvStocksList.MultiSelect = false;
            this.dgvStocksList.Name = "dgvStocksList";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStocksList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStocksList.RowHeadersVisible = false;
            this.dgvStocksList.RowHeadersWidth = 51;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.dgvStocksList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStocksList.RowTemplate.Height = 24;
            this.dgvStocksList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStocksList.Size = new System.Drawing.Size(1042, 458);
            this.dgvStocksList.TabIndex = 1;
            this.dgvStocksList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStocksList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Blue;
            this.dgvStocksList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStocksList.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvStocksList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvStocksList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStocksList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvStocksList.ThemeStyle.RowsStyle.Height = 24;
            this.dgvStocksList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvStocksList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvStocksList.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvStocksList_Scroll);
            // 
            // clRecentsActitvities
            // 
            this.clRecentsActitvities.HeaderText = "ID";
            this.clRecentsActitvities.MinimumWidth = 6;
            this.clRecentsActitvities.Name = "clRecentsActitvities";
            // 
            // clName
            // 
            this.clName.HeaderText = "Name";
            this.clName.MinimumWidth = 6;
            this.clName.Name = "clName";
            // 
            // clAmount
            // 
            this.clAmount.HeaderText = "Amount";
            this.clAmount.MinimumWidth = 6;
            this.clAmount.Name = "clAmount";
            // 
            // clAddedBy
            // 
            this.clAddedBy.HeaderText = "Added By";
            this.clAddedBy.MinimumWidth = 6;
            this.clAddedBy.Name = "clAddedBy";
            // 
            // cmStocksManagmentServices
            // 
            this.cmStocksManagmentServices.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmStocksManagmentServices.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmStocksManagmentServices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateUserToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmStocksManagmentServices.Name = "cmUsersManagmentServices";
            this.cmStocksManagmentServices.Size = new System.Drawing.Size(218, 96);
            // 
            // updateUserToolStripMenuItem
            // 
            this.updateUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateUserToolStripMenuItem.Image")));
            this.updateUserToolStripMenuItem.Name = "updateUserToolStripMenuItem";
            this.updateUserToolStripMenuItem.Size = new System.Drawing.Size(217, 32);
            this.updateUserToolStripMenuItem.Text = "Update Stock";
            this.updateUserToolStripMenuItem.Click += new System.EventHandler(this.updateStockToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(217, 32);
            this.deleteToolStripMenuItem.Text = "Delete Stock";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // usStocksManagementScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnUpperFooter);
            this.Controls.Add(this.pnStocksListControllers);
            this.Controls.Add(this.pnUsersListContainer);
            this.Name = "usStocksManagementScreen";
            this.Size = new System.Drawing.Size(1054, 672);
            this.Load += new System.EventHandler(this.usStocksManagementScreen_Load);
            this.pnUpperFooter.ResumeLayout(false);
            this.pnUpperFooter.PerformLayout();
            this.pnStocksListControllers.ResumeLayout(false);
            this.pnUsersListContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocksList)).EndInit();
            this.cmStocksManagmentServices.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnUpperFooter;
        private System.Windows.Forms.Label lbWelcomingMessage;
        private System.Windows.Forms.Label lbScreenTitle;
        private Guna.UI2.WinForms.Guna2Panel pnStocksListControllers;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchOnStock;
        private Guna.UI2.WinForms.Guna2Button btAddNewUser;
        private Guna.UI2.WinForms.Guna2Panel pnUsersListContainer;
        private Guna.UI2.WinForms.Guna2DataGridView dgvStocksList;
        private System.Windows.Forms.ContextMenuStrip cmStocksManagmentServices;
        private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRecentsActitvities;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAddedBy;
    }
}
