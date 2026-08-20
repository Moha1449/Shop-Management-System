namespace ShopManagementSystem.SellsManagement.Main_Screen
{
    partial class usSellsManagementScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usSellsManagementScreen));
            this.pnUpperFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.lbWelcomingMessage = new System.Windows.Forms.Label();
            this.lbScreenTitle = new System.Windows.Forms.Label();
            this.pnUsersListControllers = new Guna.UI2.WinForms.Guna2Panel();
            this.tbSearchOnSells = new Guna.UI2.WinForms.Guna2TextBox();
            this.btAddNewSells = new Guna.UI2.WinForms.Guna2Button();
            this.pnUsersListContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvSellsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clSellID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPayDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDoneBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmSellsManagmentServices = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showSaleDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnUpperFooter.SuspendLayout();
            this.pnUsersListControllers.SuspendLayout();
            this.pnUsersListContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellsList)).BeginInit();
            this.cmSellsManagmentServices.SuspendLayout();
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
            this.lbScreenTitle.Size = new System.Drawing.Size(217, 30);
            this.lbScreenTitle.TabIndex = 0;
            this.lbScreenTitle.Text = "Sells Management";
            // 
            // pnUsersListControllers
            // 
            this.pnUsersListControllers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnUsersListControllers.BorderColor = System.Drawing.Color.Blue;
            this.pnUsersListControllers.BorderRadius = 15;
            this.pnUsersListControllers.BorderThickness = 2;
            this.pnUsersListControllers.Controls.Add(this.tbSearchOnSells);
            this.pnUsersListControllers.Controls.Add(this.btAddNewSells);
            this.pnUsersListControllers.Location = new System.Drawing.Point(3, 105);
            this.pnUsersListControllers.Name = "pnUsersListControllers";
            this.pnUsersListControllers.Size = new System.Drawing.Size(1048, 80);
            this.pnUsersListControllers.TabIndex = 5;
            // 
            // tbSearchOnSells
            // 
            this.tbSearchOnSells.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.tbSearchOnSells.BorderRadius = 15;
            this.tbSearchOnSells.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchOnSells.DefaultText = "";
            this.tbSearchOnSells.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearchOnSells.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearchOnSells.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchOnSells.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchOnSells.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbSearchOnSells.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchOnSells.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.tbSearchOnSells.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(83)))));
            this.tbSearchOnSells.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchOnSells.Location = new System.Drawing.Point(18, 16);
            this.tbSearchOnSells.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbSearchOnSells.Name = "tbSearchOnSells";
            this.tbSearchOnSells.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSearchOnSells.PlaceholderText = "Search Using Sell ID";
            this.tbSearchOnSells.SelectedText = "";
            this.tbSearchOnSells.Size = new System.Drawing.Size(489, 45);
            this.tbSearchOnSells.TabIndex = 1;
            this.tbSearchOnSells.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearchOnSell_KeyDown);
            this.tbSearchOnSells.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // btAddNewSells
            // 
            this.btAddNewSells.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddNewSells.BackColor = System.Drawing.Color.White;
            this.btAddNewSells.BorderColor = System.Drawing.Color.Blue;
            this.btAddNewSells.BorderRadius = 15;
            this.btAddNewSells.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddNewSells.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAddNewSells.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btAddNewSells.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAddNewSells.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAddNewSells.FillColor = System.Drawing.Color.Blue;
            this.btAddNewSells.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddNewSells.ForeColor = System.Drawing.Color.White;
            this.btAddNewSells.Location = new System.Drawing.Point(819, 16);
            this.btAddNewSells.Name = "btAddNewSells";
            this.btAddNewSells.Size = new System.Drawing.Size(210, 45);
            this.btAddNewSells.TabIndex = 0;
            this.btAddNewSells.Text = "+ Add Sell";
            this.btAddNewSells.Click += new System.EventHandler(this.btAddNewSells_Click);
            // 
            // pnUsersListContainer
            // 
            this.pnUsersListContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnUsersListContainer.BorderColor = System.Drawing.Color.Blue;
            this.pnUsersListContainer.BorderThickness = 2;
            this.pnUsersListContainer.Controls.Add(this.dgvSellsList);
            this.pnUsersListContainer.Location = new System.Drawing.Point(3, 201);
            this.pnUsersListContainer.Name = "pnUsersListContainer";
            this.pnUsersListContainer.Size = new System.Drawing.Size(1048, 464);
            this.pnUsersListContainer.TabIndex = 6;
            // 
            // dgvSellsList
            // 
            this.dgvSellsList.AllowUserToAddRows = false;
            this.dgvSellsList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvSellsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSellsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSellsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSellsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSellsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSellsList.ColumnHeadersHeight = 27;
            this.dgvSellsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSellsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSellID,
            this.clTotalCost,
            this.clPayDate,
            this.clDoneBy});
            this.dgvSellsList.ContextMenuStrip = this.cmSellsManagmentServices;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSellsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSellsList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSellsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSellsList.Location = new System.Drawing.Point(3, 3);
            this.dgvSellsList.MultiSelect = false;
            this.dgvSellsList.Name = "dgvSellsList";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSellsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSellsList.RowHeadersVisible = false;
            this.dgvSellsList.RowHeadersWidth = 51;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.dgvSellsList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSellsList.RowTemplate.Height = 24;
            this.dgvSellsList.Size = new System.Drawing.Size(1042, 458);
            this.dgvSellsList.TabIndex = 1;
            this.dgvSellsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSellsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Blue;
            this.dgvSellsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSellsList.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvSellsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvSellsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSellsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSellsList.ThemeStyle.RowsStyle.Height = 24;
            this.dgvSellsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvSellsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSellsList.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvSellsList_Scroll);
            // 
            // clSellID
            // 
            this.clSellID.HeaderText = "ID";
            this.clSellID.MinimumWidth = 6;
            this.clSellID.Name = "clSellID";
            // 
            // clTotalCost
            // 
            this.clTotalCost.HeaderText = "Cost";
            this.clTotalCost.MinimumWidth = 6;
            this.clTotalCost.Name = "clTotalCost";
            // 
            // clPayDate
            // 
            this.clPayDate.HeaderText = "Date";
            this.clPayDate.MinimumWidth = 6;
            this.clPayDate.Name = "clPayDate";
            // 
            // clDoneBy
            // 
            this.clDoneBy.HeaderText = "Done By";
            this.clDoneBy.MinimumWidth = 6;
            this.clDoneBy.Name = "clDoneBy";
            // 
            // cmSellsManagmentServices
            // 
            this.cmSellsManagmentServices.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmSellsManagmentServices.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmSellsManagmentServices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showSaleDetailsToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmSellsManagmentServices.Name = "cmUsersManagmentServices";
            this.cmSellsManagmentServices.Size = new System.Drawing.Size(215, 96);
            // 
            // showSaleDetailsToolStripMenuItem
            // 
            this.showSaleDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showSaleDetailsToolStripMenuItem.Image")));
            this.showSaleDetailsToolStripMenuItem.Name = "showSaleDetailsToolStripMenuItem";
            this.showSaleDetailsToolStripMenuItem.Size = new System.Drawing.Size(214, 32);
            this.showSaleDetailsToolStripMenuItem.Text = "Show Details";
            this.showSaleDetailsToolStripMenuItem.Click += new System.EventHandler(this.showSaleDetailsToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(214, 32);
            this.deleteToolStripMenuItem.Text = "Delete Sale";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // usSellsManagementScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnUpperFooter);
            this.Controls.Add(this.pnUsersListControllers);
            this.Controls.Add(this.pnUsersListContainer);
            this.Name = "usSellsManagementScreen";
            this.Size = new System.Drawing.Size(1054, 672);
            this.Load += new System.EventHandler(this.usSellsManagementScreen_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvSellsList_Scroll);
            this.pnUpperFooter.ResumeLayout(false);
            this.pnUpperFooter.PerformLayout();
            this.pnUsersListControllers.ResumeLayout(false);
            this.pnUsersListContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellsList)).EndInit();
            this.cmSellsManagmentServices.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnUpperFooter;
        private System.Windows.Forms.Label lbWelcomingMessage;
        private System.Windows.Forms.Label lbScreenTitle;
        private Guna.UI2.WinForms.Guna2Panel pnUsersListControllers;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchOnSells;
        private Guna.UI2.WinForms.Guna2Button btAddNewSells;
        private Guna.UI2.WinForms.Guna2Panel pnUsersListContainer;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSellsList;
        private System.Windows.Forms.ContextMenuStrip cmSellsManagmentServices;
        private System.Windows.Forms.ToolStripMenuItem showSaleDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSellID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPayDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDoneBy;
    }
}
