namespace ShopManagementSystem.SellsManagement.AddNewSale
{
    partial class frmSearchOnStock
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
            this.blShape = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.lbStockName = new System.Windows.Forms.Label();
            this.tbStockName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btClose = new Guna.UI2.WinForms.Guna2Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnResult = new Guna.UI2.WinForms.Guna2Panel();
            this.lbSearchResult = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.tbAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // blShape
            // 
            this.blShape.BorderRadius = 20;
            this.blShape.ContainerControl = this;
            this.blShape.DockIndicatorTransparencyValue = 0.6D;
            this.blShape.TransparentWhileDrag = true;
            // 
            // lbStockName
            // 
            this.lbStockName.AutoSize = true;
            this.lbStockName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStockName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.lbStockName.Location = new System.Drawing.Point(12, 136);
            this.lbStockName.Name = "lbStockName";
            this.lbStockName.Size = new System.Drawing.Size(126, 27);
            this.lbStockName.TabIndex = 7;
            this.lbStockName.Text = "Stock Name";
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
            this.tbStockName.Location = new System.Drawing.Point(17, 169);
            this.tbStockName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbStockName.MaxLength = 30;
            this.tbStockName.Name = "tbStockName";
            this.tbStockName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbStockName.PlaceholderText = "Enter The Stock Name";
            this.tbStockName.SelectedText = "";
            this.tbStockName.Size = new System.Drawing.Size(410, 44);
            this.tbStockName.TabIndex = 6;
            this.tbStockName.TextChanged += new System.EventHandler(this.tbStockName_TextChanged);
            this.tbStockName.MouseEnter += new System.EventHandler(this.TextBox_MouseEnter);
            // 
            // btSearch
            // 
            this.btSearch.BorderRadius = 10;
            this.btSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btSearch.FillColor = System.Drawing.Color.Blue;
            this.btSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btSearch.ForeColor = System.Drawing.Color.White;
            this.btSearch.Location = new System.Drawing.Point(253, 347);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(174, 49);
            this.btSearch.TabIndex = 28;
            this.btSearch.Text = "Search";
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
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
            this.btClose.Location = new System.Drawing.Point(12, 347);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(173, 49);
            this.btClose.TabIndex = 29;
            this.btClose.Text = "Close";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(83)))));
            this.lbTitle.Location = new System.Drawing.Point(10, 24);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(265, 38);
            this.lbTitle.TabIndex = 30;
            this.lbTitle.Text = "Search On Stock";
            // 
            // pnResult
            // 
            this.pnResult.BackColor = System.Drawing.Color.White;
            this.pnResult.BorderColor = System.Drawing.Color.White;
            this.pnResult.BorderRadius = 15;
            this.pnResult.BorderThickness = 1;
            this.pnResult.Controls.Add(this.lbSearchResult);
            this.pnResult.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnResult.Location = new System.Drawing.Point(17, 77);
            this.pnResult.Name = "pnResult";
            this.pnResult.Size = new System.Drawing.Size(411, 41);
            this.pnResult.TabIndex = 31;
            this.pnResult.Visible = false;
            // 
            // lbSearchResult
            // 
            this.lbSearchResult.AutoSize = true;
            this.lbSearchResult.BackColor = System.Drawing.Color.Transparent;
            this.lbSearchResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearchResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(83)))));
            this.lbSearchResult.Location = new System.Drawing.Point(70, 12);
            this.lbSearchResult.Name = "lbSearchResult";
            this.lbSearchResult.Size = new System.Drawing.Size(268, 20);
            this.lbSearchResult.TabIndex = 0;
            this.lbSearchResult.Text = "Invalid UserName or Password";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.lbAmount.Location = new System.Drawing.Point(12, 238);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(88, 27);
            this.lbAmount.TabIndex = 33;
            this.lbAmount.Text = "Amount";
            // 
            // tbAmount
            // 
            this.tbAmount.BackColor = System.Drawing.Color.Transparent;
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
            this.tbAmount.Location = new System.Drawing.Point(17, 271);
            this.tbAmount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbAmount.MaxLength = 30;
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbAmount.PlaceholderText = "Enter The Amount\r\n";
            this.tbAmount.SelectedText = "";
            this.tbAmount.Size = new System.Drawing.Size(410, 44);
            this.tbAmount.TabIndex = 32;
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmount_KeyPress);
            this.tbAmount.MouseEnter += new System.EventHandler(this.TextBox_MouseEnter);
            // 
            // frmSearchOnStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(440, 415);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.pnResult);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.lbStockName);
            this.Controls.Add(this.tbStockName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(440, 415);
            this.MinimumSize = new System.Drawing.Size(440, 415);
            this.Name = "frmSearchOnStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSearchOnStock";
            this.pnResult.ResumeLayout(false);
            this.pnResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm blShape;
        private System.Windows.Forms.Label lbStockName;
        private Guna.UI2.WinForms.Guna2TextBox tbStockName;
        private Guna.UI2.WinForms.Guna2Button btSearch;
        private Guna.UI2.WinForms.Guna2Button btClose;
        private System.Windows.Forms.Label lbTitle;
        private Guna.UI2.WinForms.Guna2Panel pnResult;
        private System.Windows.Forms.Label lbSearchResult;
        private System.Windows.Forms.Label lbAmount;
        private Guna.UI2.WinForms.Guna2TextBox tbAmount;
    }
}