namespace ShopManagementSystem.Notification
{
    partial class frmCustomMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomMessageBox));
            this.bdlShape = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pcImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.tmNotification = new System.Windows.Forms.Timer(this.components);
            this.pcClose = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bdlShape
            // 
            this.bdlShape.BorderRadius = 25;
            this.bdlShape.ContainerControl = this;
            this.bdlShape.DockIndicatorTransparencyValue = 0.6D;
            this.bdlShape.ResizeForm = false;
            this.bdlShape.TransparentWhileDrag = true;
            // 
            // pcImage
            // 
            this.pcImage.Image = ((System.Drawing.Image)(resources.GetObject("pcImage.Image")));
            this.pcImage.ImageRotate = 0F;
            this.pcImage.Location = new System.Drawing.Point(22, 33);
            this.pcImage.Name = "pcImage";
            this.pcImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pcImage.Size = new System.Drawing.Size(54, 53);
            this.pcImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcImage.TabIndex = 0;
            this.pcImage.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(83)))));
            this.lbTitle.Location = new System.Drawing.Point(100, 18);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(141, 30);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "User added";
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.lbMessage.Location = new System.Drawing.Point(102, 61);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(269, 25);
            this.lbMessage.TabIndex = 2;
            this.lbMessage.Text = "User was added successfully.";
            // 
            // tmNotification
            // 
            this.tmNotification.Interval = 1000;
            this.tmNotification.Tick += new System.EventHandler(this.tmNotification_Tick);
            // 
            // pcClose
            // 
            this.pcClose.Image = ((System.Drawing.Image)(resources.GetObject("pcClose.Image")));
            this.pcClose.ImageRotate = 0F;
            this.pcClose.Location = new System.Drawing.Point(386, 3);
            this.pcClose.Name = "pcClose";
            this.pcClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pcClose.Size = new System.Drawing.Size(41, 36);
            this.pcClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcClose.TabIndex = 3;
            this.pcClose.TabStop = false;
            this.pcClose.Click += new System.EventHandler(this.pcClose_Click);
            // 
            // frmCustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 114);
            this.Controls.Add(this.pcClose);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pcImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(439, 114);
            this.MinimumSize = new System.Drawing.Size(439, 114);
            this.Name = "frmCustomMessageBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCustomNotification";
            this.Load += new System.EventHandler(this.frmCustomNotification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm bdlShape;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pcImage;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Timer tmNotification;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pcClose;
    }
}