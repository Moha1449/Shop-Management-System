namespace ShopManagementSystem.SellsManagement.AddNewSale
{
    partial class frmAddNewSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewSale));
            this.lbScreenTitle = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.lbTotalCost = new System.Windows.Forms.Label();
            this.lbTotalProducts = new System.Windows.Forms.Label();
            this.lbSubtitle = new System.Windows.Forms.Label();
            this.pnBuyerListContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.flBuyerList = new System.Windows.Forms.FlowLayoutPanel();
            this.pbAdd = new Guna.UI2.WinForms.Guna2PictureBox();
            this.bdShape = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btSave = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.pnBuyerListContainer.SuspendLayout();
            this.flBuyerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // lbScreenTitle
            // 
            this.lbScreenTitle.AutoSize = true;
            this.lbScreenTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScreenTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(83)))));
            this.lbScreenTitle.Location = new System.Drawing.Point(12, 19);
            this.lbScreenTitle.Name = "lbScreenTitle";
            this.lbScreenTitle.Size = new System.Drawing.Size(224, 38);
            this.lbScreenTitle.TabIndex = 19;
            this.lbScreenTitle.Text = "Add New Sale";
            // 
            // pbClose
            // 
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(944, 19);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(44, 41);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 18;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // lbTotalCost
            // 
            this.lbTotalCost.AutoSize = true;
            this.lbTotalCost.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.lbTotalCost.Location = new System.Drawing.Point(463, 539);
            this.lbTotalCost.Name = "lbTotalCost";
            this.lbTotalCost.Size = new System.Drawing.Size(84, 27);
            this.lbTotalCost.TabIndex = 23;
            this.lbTotalCost.Text = "Total: $";
            // 
            // lbTotalProducts
            // 
            this.lbTotalProducts.AutoSize = true;
            this.lbTotalProducts.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.lbTotalProducts.Location = new System.Drawing.Point(37, 539);
            this.lbTotalProducts.Name = "lbTotalProducts";
            this.lbTotalProducts.Size = new System.Drawing.Size(125, 27);
            this.lbTotalProducts.TabIndex = 22;
            this.lbTotalProducts.Text = "sales shown";
            // 
            // lbSubtitle
            // 
            this.lbSubtitle.AutoSize = true;
            this.lbSubtitle.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.lbSubtitle.Location = new System.Drawing.Point(14, 73);
            this.lbSubtitle.Name = "lbSubtitle";
            this.lbSubtitle.Size = new System.Drawing.Size(127, 27);
            this.lbSubtitle.TabIndex = 21;
            this.lbSubtitle.Text = "All products";
            // 
            // pnBuyerListContainer
            // 
            this.pnBuyerListContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnBuyerListContainer.BorderColor = System.Drawing.Color.Blue;
            this.pnBuyerListContainer.BorderThickness = 2;
            this.pnBuyerListContainer.Controls.Add(this.flBuyerList);
            this.pnBuyerListContainer.Location = new System.Drawing.Point(12, 103);
            this.pnBuyerListContainer.Name = "pnBuyerListContainer";
            this.pnBuyerListContainer.Size = new System.Drawing.Size(976, 397);
            this.pnBuyerListContainer.TabIndex = 20;
            // 
            // flBuyerList
            // 
            this.flBuyerList.AutoScroll = true;
            this.flBuyerList.Controls.Add(this.pbAdd);
            this.flBuyerList.Location = new System.Drawing.Point(7, 7);
            this.flBuyerList.Margin = new System.Windows.Forms.Padding(10);
            this.flBuyerList.Name = "flBuyerList";
            this.flBuyerList.Padding = new System.Windows.Forms.Padding(20, 20, 50, 20);
            this.flBuyerList.Size = new System.Drawing.Size(959, 380);
            this.flBuyerList.TabIndex = 25;
            // 
            // pbAdd
            // 
            this.pbAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdd.Image = ((System.Drawing.Image)(resources.GetObject("pbAdd.Image")));
            this.pbAdd.ImageRotate = 0F;
            this.pbAdd.Location = new System.Drawing.Point(23, 23);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(386, 178);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdd.TabIndex = 0;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // bdShape
            // 
            this.bdShape.BorderRadius = 20;
            this.bdShape.ContainerControl = this;
            this.bdShape.DockIndicatorTransparencyValue = 0.6D;
            this.bdShape.TransparentWhileDrag = true;
            // 
            // btSave
            // 
            this.btSave.BorderRadius = 15;
            this.btSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btSave.FillColor = System.Drawing.Color.Blue;
            this.btSave.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btSave.ForeColor = System.Drawing.Color.White;
            this.btSave.Location = new System.Drawing.Point(788, 525);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(190, 59);
            this.btSave.TabIndex = 24;
            this.btSave.Text = "Save";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // frmAddNewSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 606);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.pnBuyerListContainer);
            this.Controls.Add(this.lbScreenTitle);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.lbTotalCost);
            this.Controls.Add(this.lbTotalProducts);
            this.Controls.Add(this.lbSubtitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1000, 606);
            this.MinimumSize = new System.Drawing.Size(1000, 606);
            this.Name = "frmAddNewSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNewSale";
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.pnBuyerListContainer.ResumeLayout(false);
            this.flBuyerList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbScreenTitle;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label lbTotalCost;
        private System.Windows.Forms.Label lbTotalProducts;
        private System.Windows.Forms.Label lbSubtitle;
        private Guna.UI2.WinForms.Guna2Panel pnBuyerListContainer;
        private System.Windows.Forms.FlowLayoutPanel flBuyerList;
        private Guna.UI2.WinForms.Guna2BorderlessForm bdShape;
        private Guna.UI2.WinForms.Guna2PictureBox pbAdd;
        private Guna.UI2.WinForms.Guna2Button btSave;
    }
}