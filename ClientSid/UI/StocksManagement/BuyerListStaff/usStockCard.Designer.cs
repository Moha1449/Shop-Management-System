namespace ShopManagementSystem.SellsManagement.AddNewSale.BuyerListStaff
{
    partial class usStockCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usStockCard));
            this.lbStockName = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbStockName
            // 
            this.lbStockName.AutoSize = true;
            this.lbStockName.BackColor = System.Drawing.Color.Transparent;
            this.lbStockName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStockName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.lbStockName.Location = new System.Drawing.Point(3, 28);
            this.lbStockName.Name = "lbStockName";
            this.lbStockName.Size = new System.Drawing.Size(85, 27);
            this.lbStockName.TabIndex = 6;
            this.lbStockName.Text = "Name : ";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.BackColor = System.Drawing.Color.Transparent;
            this.lbAmount.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.lbAmount.Location = new System.Drawing.Point(3, 114);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(99, 27);
            this.lbAmount.TabIndex = 7;
            this.lbAmount.Text = "Amount :";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.lbPrice.Location = new System.Drawing.Point(3, 71);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(70, 27);
            this.lbPrice.TabIndex = 8;
            this.lbPrice.Text = "Price :";
            // 
            // usStockCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.lbStockName);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(388, 180);
            this.MinimumSize = new System.Drawing.Size(388, 180);
            this.Name = "usStockCard";
            this.Size = new System.Drawing.Size(386, 178);
            this.Load += new System.EventHandler(this.usStockCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStockName;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label lbPrice;
    }
}
