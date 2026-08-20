namespace ShopManagementSystem.SellsManagement.Sales_Details
{
    partial class frmSalesDetailsScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesDetailsScreen));
            this.blShape = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.lbScreenTitle = new System.Windows.Forms.Label();
            this.pnUsersListContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvSaleDetailsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQauntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEnteredBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmServices = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbSubtitle = new System.Windows.Forms.Label();
            this.lbTotalProducts = new System.Windows.Forms.Label();
            this.lbTotalCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.pnUsersListContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleDetailsList)).BeginInit();
            this.cmServices.SuspendLayout();
            this.SuspendLayout();
            // 
            // blShape
            // 
            this.blShape.BorderRadius = 20;
            this.blShape.ContainerControl = this;
            this.blShape.DockIndicatorTransparencyValue = 0.6D;
            this.blShape.TransparentWhileDrag = true;
            // 
            // pbClose
            // 
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(801, 12);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(44, 41);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 12;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // lbScreenTitle
            // 
            this.lbScreenTitle.AutoSize = true;
            this.lbScreenTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScreenTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(83)))));
            this.lbScreenTitle.Location = new System.Drawing.Point(12, 15);
            this.lbScreenTitle.Name = "lbScreenTitle";
            this.lbScreenTitle.Size = new System.Drawing.Size(207, 38);
            this.lbScreenTitle.TabIndex = 13;
            this.lbScreenTitle.Text = "Sale Details ";
            // 
            // pnUsersListContainer
            // 
            this.pnUsersListContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnUsersListContainer.BorderColor = System.Drawing.Color.Blue;
            this.pnUsersListContainer.BorderThickness = 2;
            this.pnUsersListContainer.Controls.Add(this.dgvSaleDetailsList);
            this.pnUsersListContainer.Location = new System.Drawing.Point(12, 132);
            this.pnUsersListContainer.Name = "pnUsersListContainer";
            this.pnUsersListContainer.Size = new System.Drawing.Size(833, 397);
            this.pnUsersListContainer.TabIndex = 14;
            // 
            // dgvSaleDetailsList
            // 
            this.dgvSaleDetailsList.AllowUserToAddRows = false;
            this.dgvSaleDetailsList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvSaleDetailsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSaleDetailsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSaleDetailsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSaleDetailsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSaleDetailsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSaleDetailsList.ColumnHeadersHeight = 27;
            this.dgvSaleDetailsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSaleDetailsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clDetailID,
            this.clStockName,
            this.clCost,
            this.clQauntity,
            this.clEnteredBy});
            this.dgvSaleDetailsList.ContextMenuStrip = this.cmServices;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSaleDetailsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSaleDetailsList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSaleDetailsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSaleDetailsList.Location = new System.Drawing.Point(3, 3);
            this.dgvSaleDetailsList.MultiSelect = false;
            this.dgvSaleDetailsList.Name = "dgvSaleDetailsList";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSaleDetailsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSaleDetailsList.RowHeadersVisible = false;
            this.dgvSaleDetailsList.RowHeadersWidth = 51;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.dgvSaleDetailsList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSaleDetailsList.RowTemplate.Height = 24;
            this.dgvSaleDetailsList.Size = new System.Drawing.Size(827, 391);
            this.dgvSaleDetailsList.TabIndex = 1;
            this.dgvSaleDetailsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSaleDetailsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Blue;
            this.dgvSaleDetailsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSaleDetailsList.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvSaleDetailsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvSaleDetailsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSaleDetailsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSaleDetailsList.ThemeStyle.RowsStyle.Height = 24;
            this.dgvSaleDetailsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvSaleDetailsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // clDetailID
            // 
            this.clDetailID.HeaderText = "ID";
            this.clDetailID.MinimumWidth = 6;
            this.clDetailID.Name = "clDetailID";
            // 
            // clStockName
            // 
            this.clStockName.HeaderText = "Stock";
            this.clStockName.MinimumWidth = 6;
            this.clStockName.Name = "clStockName";
            // 
            // clCost
            // 
            this.clCost.HeaderText = "Cost";
            this.clCost.MinimumWidth = 6;
            this.clCost.Name = "clCost";
            // 
            // clQauntity
            // 
            this.clQauntity.HeaderText = "Qauntity";
            this.clQauntity.MinimumWidth = 6;
            this.clQauntity.Name = "clQauntity";
            // 
            // clEnteredBy
            // 
            this.clEnteredBy.HeaderText = "EnteredBy";
            this.clEnteredBy.MinimumWidth = 6;
            this.clEnteredBy.Name = "clEnteredBy";
            // 
            // cmServices
            // 
            this.cmServices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmServices.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmServices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteItemToolStripMenuItem,
            this.addItemToolStripMenuItem});
            this.cmServices.Name = "cmServices";
            this.cmServices.Size = new System.Drawing.Size(235, 128);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateToolStripMenuItem.Image")));
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(234, 32);
            this.updateToolStripMenuItem.Text = "Update Qauntity";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteItemToolStripMenuItem
            // 
            this.deleteItemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteItemToolStripMenuItem.Image")));
            this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(234, 32);
            this.deleteItemToolStripMenuItem.Text = "Delete Item";
            this.deleteItemToolStripMenuItem.Click += new System.EventHandler(this.deleteItemToolStripMenuItem_Click);
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addItemToolStripMenuItem.Image")));
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(234, 32);
            this.addItemToolStripMenuItem.Text = "Add Item";
            this.addItemToolStripMenuItem.Click += new System.EventHandler(this.addItemToolStripMenuItem_Click);
            // 
            // lbSubtitle
            // 
            this.lbSubtitle.AutoSize = true;
            this.lbSubtitle.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.lbSubtitle.Location = new System.Drawing.Point(14, 69);
            this.lbSubtitle.Name = "lbSubtitle";
            this.lbSubtitle.Size = new System.Drawing.Size(127, 27);
            this.lbSubtitle.TabIndex = 15;
            this.lbSubtitle.Text = "All products";
            // 
            // lbTotalProducts
            // 
            this.lbTotalProducts.AutoSize = true;
            this.lbTotalProducts.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.lbTotalProducts.Location = new System.Drawing.Point(28, 558);
            this.lbTotalProducts.Name = "lbTotalProducts";
            this.lbTotalProducts.Size = new System.Drawing.Size(125, 27);
            this.lbTotalProducts.TabIndex = 16;
            this.lbTotalProducts.Text = "sales shown";
            // 
            // lbTotalCost
            // 
            this.lbTotalCost.AutoSize = true;
            this.lbTotalCost.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.lbTotalCost.Location = new System.Drawing.Point(658, 558);
            this.lbTotalCost.Name = "lbTotalCost";
            this.lbTotalCost.Size = new System.Drawing.Size(84, 27);
            this.lbTotalCost.TabIndex = 17;
            this.lbTotalCost.Text = "Total: $";
            // 
            // frmSalesDetailsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(857, 615);
            this.Controls.Add(this.lbTotalCost);
            this.Controls.Add(this.lbTotalProducts);
            this.Controls.Add(this.lbSubtitle);
            this.Controls.Add(this.pnUsersListContainer);
            this.Controls.Add(this.lbScreenTitle);
            this.Controls.Add(this.pbClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(857, 615);
            this.MinimumSize = new System.Drawing.Size(857, 615);
            this.Name = "frmSalesDetailsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSalesDetailsScreen";
            this.Load += new System.EventHandler(this.frmSalesDetailsScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.pnUsersListContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleDetailsList)).EndInit();
            this.cmServices.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm blShape;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label lbScreenTitle;
        private Guna.UI2.WinForms.Guna2Panel pnUsersListContainer;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSaleDetailsList;
        private System.Windows.Forms.Label lbSubtitle;
        private System.Windows.Forms.Label lbTotalProducts;
        private System.Windows.Forms.Label lbTotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQauntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEnteredBy;
        private System.Windows.Forms.ContextMenuStrip cmServices;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
    }
}