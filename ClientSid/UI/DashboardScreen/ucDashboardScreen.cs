using ClientSideBusinessLayer.Businesses;
using ClientSideBusinessLayer.Businesses.Client;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementSystem.DashboardScreen
{
    public partial class ucDashboardScreen : UserControl
    {
        public ucDashboardScreen()
        {
            InitializeComponent();
        }

        private void _SetRightLocationsForLabelsOfStatesPannal()
        {
            //Location Equations

            int Y_axis_common = (pnUsersStates.Height / 2) - 3;
            int X_axis_common = (pnUsersStates.Width / 2);


            //Titles Locations 
            Point TitlesNewLocation = new Point(X_axis_common - 40, 14);

            lbTotalUsersTitle.Location = TitlesNewLocation;
            lbTotalServedTitle.Location = TitlesNewLocation;
            lbTotalStocksTitle.Location = TitlesNewLocation;


            //Values Locations
            int X_axis_shift = (lbTotalUsersValue.Width / 2);
            lbTotalUsersValue.Location = new Point(X_axis_common - X_axis_shift - 9, Y_axis_common);

            X_axis_shift = (lbTotalServedValue.Width / 2);
            lbTotalServedValue.Location = new Point(X_axis_common - X_axis_shift, Y_axis_common);

            X_axis_shift = (lbTotalStocksValue.Width / 2);
            lbTotalStocksValue.Location = new Point(X_axis_common - X_axis_shift, Y_axis_common);


        }

        private void pnUsersStates_Resize(object sender, EventArgs e)
        {
            //Set The Labels In Right Location
            _SetRightLocationsForLabelsOfStatesPannal();
        }

        private async Task _LoadStatesFromServerAsync()
        {
            clsStates States = await clsStates.GetStates();

            if (!(States.State == ClientSideBusinessLayer.clsReturnResult.enReturnResult.Success))
                return;

            lbTotalServedValue.Text = States.TotalServedCustomers.ToString();
            lbTotalStocksValue.Text = States.TotalStocks.ToString();
            lbTotalUsersValue.Text = States.TotalUsers.ToString();
            lbTotalSellsValue.Text = '$' + States.TotalSells.ToString();
        }

        private async Task _LoadRecantsActivatesAsync()
        {
            List<string> Activities = new List<string>();

            var LogResult = await clsRecentActivatesLogger.GetActivatesAsync(Activities);

            if (LogResult == clsRecentActivatesLogger.enFileState.FileNotFound||
                LogResult == clsRecentActivatesLogger.enFileState.ErrorDuringTheReading)
                return;

            dgvRectentActivities.Rows.Clear();

            foreach (string Activity in Activities)
            {
                dgvRectentActivities.Rows.Add(Activity);
            }
        }

        private async void ucDashboardScreen_Load(object sender, EventArgs e)
        {
            lbWelcomingMessage.Text += ' ' + clsGlobal.CurrentUser.UserName;

            Task LoadStatesTask =  _LoadStatesFromServerAsync();

            Task LoadActivatesTask = _LoadRecantsActivatesAsync();

            await Task.WhenAll(new Task[] { LoadActivatesTask,LoadStatesTask});

            pnUsersStates_Resize(sender, e);
        }
    }
}
