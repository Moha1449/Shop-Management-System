namespace ShopManagementSystem.StocksManagement.AddOrUpdateScreen
{
    partial class frmAddOrUpdateStock
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
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbStockName = new System.Windows.Forms.Label();
            this.tbAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbStockName = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnResultOfOperation = new Guna.UI2.WinForms.Guna2Panel();
            this.lbOperationResult = new System.Windows.Forms.Label();
            this.lbScreenTitle = new System.Windows.Forms.Label();
            this.btClose = new Guna.UI2.WinForms.Guna2Button();
            this.lbCost = new System.Windows.Forms.Label();
            this.bdShape = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.tbCost = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
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
            this.btAddOrUpdate.Location = new System.Drawing.Point(202, 557);
            this.btAddOrUpdate.Name = "btAddOrUpdate";
            this.btAddOrUpdate.Size = new System.Drawing.Size(174, 49);
            this.btAddOrUpdate.TabIndex = 25;
            this.btAddOrUpdate.Text = "Update Stock";
            this.btAddOrUpdate.Click += new System.EventHandler(this.btAddOrUpdate_Click);
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.lbAmount.Location = new System.Drawing.Point(13, 228);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(88, 26);
            this.lbAmount.TabIndex = 24;
            this.lbAmount.Text = "Amount";
            // 
            // lbStockName
            // 
            this.lbStockName.AutoSize = true;
            this.lbStockName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStockName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.lbStockName.Location = new System.Drawing.Point(13, 130);
            this.lbStockName.Name = "lbStockName";
            this.lbStockName.Size = new System.Drawing.Size(126, 27);
            this.lbStockName.TabIndex = 23;
            this.lbStockName.Text = "Stock Name\r\n";
            // 
            // tbAmount
            // 
            this.tbAmount.BorderColor = System.Drawing.Color.Black;
            this.tbAmount.BorderRadius = 15;
            this.tbAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAmount.DefaultText = "";
            this.tbAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAmount.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tbAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(83)))));
            this.tbAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAmount.Location = new System.Drawing.Point(12, 260);
            this.tbAmount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbAmount.MaxLength = 64;
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbAmount.PlaceholderText = "Enter The Amount";
            this.tbAmount.SelectedText = "";
            this.tbAmount.Size = new System.Drawing.Size(363, 45);
            this.tbAmount.TabIndex = 22;
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.tbAmount.MouseEnter += new System.EventHandler(this.MouseEnterTextBoxesEventHandler);
            // 
            // tbStockName
            // 
            this.tbStockName.BackColor = System.Drawing.Color.Transparent;
            this.tbStockName.BorderColor = System.Drawing.Color.Black;
            this.tbStockName.BorderRadius = 15;
            this.tbStockName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbStockName.DefaultText = "";
            this.tbStockName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbStockName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbStockName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbStockName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbStockName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbStockName.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tbStockName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(83)))));
            this.tbStockName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbStockName.Location = new System.Drawing.Point(12, 163);
            this.tbStockName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbStockName.MaxLength = 30;
            this.tbStockName.Name = "tbStockName";
            this.tbStockName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbStockName.PlaceholderText = "Enter The Stock Name";
            this.tbStockName.SelectedText = "";
            this.tbStockName.Size = new System.Drawing.Size(363, 44);
            this.tbStockName.TabIndex = 21;
            this.tbStockName.MouseEnter += new System.EventHandler(this.MouseEnterTextBoxesEventHandler);
            // 
            // pnResultOfOperation
            // 
            this.pnResultOfOperation.BorderColor = System.Drawing.Color.Black;
            this.pnResultOfOperation.BorderRadius = 15;
            this.pnResultOfOperation.BorderThickness = 1;
            this.pnResultOfOperation.Controls.Add(this.lbOperationResult);
            this.pnResultOfOperation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnResultOfOperation.Location = new System.Drawing.Point(12, 75);
            this.pnResultOfOperation.Name = "pnResultOfOperation";
            this.pnResultOfOperation.Size = new System.Drawing.Size(363, 42);
            this.pnResultOfOperation.TabIndex = 31;
            this.pnResultOfOperation.Visible = false;
            // 
            // lbOperationResult
            // 
            this.lbOperationResult.AutoSize = true;
            this.lbOperationResult.BackColor = System.Drawing.Color.Transparent;
            this.lbOperationResult.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOperationResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(83)))));
            this.lbOperationResult.Location = new System.Drawing.Point(45, 9);
            this.lbOperationResult.Name = "lbOperationResult";
            this.lbOperationResult.Size = new System.Drawing.Size(268, 24);
            this.lbOperationResult.TabIndex = 0;
            this.lbOperationResult.Text = "Stock was Added Successfully.";
            // 
            // lbScreenTitle
            // 
            this.lbScreenTitle.AutoSize = true;
            this.lbScreenTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScreenTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(83)))));
            this.lbScreenTitle.Location = new System.Drawing.Point(12, 18);
            this.lbScreenTitle.Name = "lbScreenTitle";
            this.lbScreenTitle.Size = new System.Drawing.Size(191, 35);
            this.lbScreenTitle.TabIndex = 29;
            this.lbScreenTitle.Text = "Update Stock";
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
            this.btClose.Location = new System.Drawing.Point(12, 557);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(173, 49);
            this.btClose.TabIndex = 27;
            this.btClose.Text = "Close";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // lbCost
            // 
            this.lbCost.AutoSize = true;
            this.lbCost.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.lbCost.Location = new System.Drawing.Point(13, 332);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(53, 26);
            this.lbCost.TabIndex = 26;
            this.lbCost.Text = "Cost";
            // 
            // bdShape
            // 
            this.bdShape.BorderRadius = 20;
            this.bdShape.ContainerControl = this;
            this.bdShape.DockIndicatorTransparencyValue = 0.6D;
            this.bdShape.TransparentWhileDrag = true;
            // 
            // tbCost
            // 
            this.tbCost.BorderColor = System.Drawing.Color.Black;
            this.tbCost.BorderRadius = 15;
            this.tbCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCost.DefaultText = "";
            this.tbCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCost.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tbCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(83)))));
            this.tbCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCost.Location = new System.Drawing.Point(12, 362);
            this.tbCost.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbCost.MaxLength = 64;
            this.tbCost.Name = "tbCost";
            this.tbCost.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbCost.PlaceholderText = "Enter The Cost";
            this.tbCost.SelectedText = "";
            this.tbCost.Size = new System.Drawing.Size(363, 45);
            this.tbCost.TabIndex = 32;
            this.tbCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.tbCost.MouseEnter += new System.EventHandler(this.MouseEnterTextBoxesEventHandler);
            // 
            // tbPrice
            // 
            this.tbPrice.BorderColor = System.Drawing.Color.Black;
            this.tbPrice.BorderRadius = 15;
            this.tbPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPrice.DefaultText = "";
            this.tbPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrice.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(83)))));
            this.tbPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrice.Location = new System.Drawing.Point(12, 466);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbPrice.MaxLength = 64;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbPrice.PlaceholderText = "Enter The Price";
            this.tbPrice.SelectedText = "";
            this.tbPrice.Size = new System.Drawing.Size(363, 45);
            this.tbPrice.TabIndex = 34;
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.tbPrice.MouseEnter += new System.EventHandler(this.MouseEnterTextBoxesEventHandler);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.lbPrice.Location = new System.Drawing.Point(13, 436);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(59, 26);
            this.lbPrice.TabIndex = 33;
            this.lbPrice.Text = "Price";
            // 
            // frmAddOrUpdateStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(388, 629);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.btAddOrUpdate);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.lbStockName);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.tbStockName);
            this.Controls.Add(this.pnResultOfOperation);
            this.Controls.Add(this.lbScreenTitle);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.lbCost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(388, 629);
            this.MinimumSize = new System.Drawing.Size(388, 629);
            this.Name = "frmAddOrUpdateStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddOrUpdateStock";
            this.Load += new System.EventHandler(this.frmAddOrUpdateStock_Load);
            this.pnResultOfOperation.ResumeLayout(false);
            this.pnResultOfOperation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btAddOrUpdate;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label lbStockName;
        private Guna.UI2.WinForms.Guna2TextBox tbAmount;
        private Guna.UI2.WinForms.Guna2TextBox tbStockName;
        private Guna.UI2.WinForms.Guna2Panel pnResultOfOperation;
        private System.Windows.Forms.Label lbOperationResult;
        private System.Windows.Forms.Label lbScreenTitle;
        private Guna.UI2.WinForms.Guna2Button btClose;
        private System.Windows.Forms.Label lbCost;
        private Guna.UI2.WinForms.Guna2BorderlessForm bdShape;
        private Guna.UI2.WinForms.Guna2TextBox tbCost;
        private Guna.UI2.WinForms.Guna2TextBox tbPrice;
        private System.Windows.Forms.Label lbPrice;
    }
}