using System;
using System.Windows.Forms;

namespace ShopManagementSystem.Notification
{
    public partial class frmCustomMessageBox: Form
    {
        private string Message { get; set; }

        private string Title { get; set; }

        private int TimerSec { get; set; }

        private int TickCount { get; set; }
       


        public frmCustomMessageBox(string title,string message,int timerSec)
        {
            Title = title;
            Message = message;
            TimerSec = timerSec;
            TickCount = 0;

            InitializeComponent();
        }

        private void frmCustomNotification_Load(object sender, EventArgs e)
        {
            lbTitle.Text = Title;
            lbMessage.Text = Message;
            tmNotification.Enabled = true;
        }

        private void tmNotification_Tick(object sender, EventArgs e)
        {
            TickCount += 1;

            if(TimerSec == TickCount)
                this.Close();
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
