using ClientSideBusinessLayer;
using ShopManagementSystem.DashboardScreen;
using ShopManagementSystem.Notification;
using ShopManagementSystem.SellsManagement.Main_Screen;
using ShopManagementSystem.StocksManagement.MainScreen;
using ShopManagementSystem.UI;
using ShopManagementSystem.UsersScreen;
using System;
using System.Windows.Forms;

namespace ShopManagementSystem
{
    public partial class frmMainScreen : Form
    {
        public event EventHandler<bool> OnLogout;

        private bool _FormClosedByCloseButton { get; set; }

        private Button _CurrentClickedButton { get; set; }

        public frmMainScreen()
        {
            _FormClosedByCloseButton = true;
            InitializeComponent();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            _FormClosedByCloseButton = false;
            OnLogout?.Invoke(this, true);
        }

        private void frmMainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CloseReason.UserClosing == e.CloseReason && _FormClosedByCloseButton)
            {
                Application.Exit();
            }
        }


        private void _ScreenCleaner()
        {
            if (scMainScreen.Panel2.Controls.Count > 0)
                scMainScreen.Panel2.Controls.RemoveAt(0);
        }


        private bool _IsAllowed(string ButtonName)
        {
            switch (ButtonName)
            {
                //Everyone can see dashboard but not all has permissions to see other
                //screens so if screen is not dashboard checks the permissions of user
                case "btDashboard":
                    return true;

                case "btUsers":
                    return clsGlobal.CurrentUser.IsUserHasPermission(
                        clsUser.enOperations.ShowUsers);

                case "btStocks":
                    return clsGlobal.CurrentUser.IsUserHasPermission(
                        clsUser.enOperations.ShowStocks);

                case "btSells":
                    return clsGlobal.CurrentUser.IsUserHasPermission(
                        clsUser.enOperations.ShowSales);

                default:
                    return false;
            }
        }



        private void _ScreensRunner()
        {
            _ScreenCleaner();

            switch (_CurrentClickedButton.Name)
            {
                case "btDashboard":
                    {
                        ucDashboardScreen Dashboard = new ucDashboardScreen();
                        Dashboard.Dock = DockStyle.Fill;
                        scMainScreen.Panel2.Controls.Add(Dashboard);
                        break;
                    }
                case "btUsers":
                    {


                        usUsersScreen UsersManagement = new usUsersScreen();
                        UsersManagement.Dock = DockStyle.Fill;
                        scMainScreen.Panel2.Controls.Add(UsersManagement);
                        break;
                    }
                case "btStocks":
                    {

                        usStocksManagementScreen StockManagement = new usStocksManagementScreen();
                        StockManagement.Dock = DockStyle.Fill;
                        scMainScreen.Panel2.Controls.Add(StockManagement);
                        break;
                    }
                case "btSells":
                    {

                        usSellsManagementScreen SellManagement = new usSellsManagementScreen();
                        SellManagement.Dock = DockStyle.Fill;
                        scMainScreen.Panel2.Controls.Add(SellManagement);
                        break;
                    }

            }


        }

        private void ButtonClicked_EventHandler(object sender, EventArgs e)
        {
            Button clicked = sender as Button;

            if (!_IsAllowed(clicked.Name    ))
            {
                frmCustomMessageBox NoPermission = new frmCustomMessageBox("Not Allowed", "You do not have permission.", 7);
                NoPermission.ShowDialog();
                return;
            }

            //If the _CurrentClickedButtonName is the same of the new clicked button that means user is trying to run the same screen so do not do any thing
            if (_CurrentClickedButton.Text == clicked.Text)
                return;

            clsUIFormatter.ChangeActivateStateTo(_CurrentClickedButton, (Button)sender);
            _CurrentClickedButton = (Button)sender;
            _ScreensRunner();
        }

        private void frmMainScreen_Load(object sender, EventArgs e)
        {
            _CurrentClickedButton = btDashboard;
            clsUIFormatter.ActiveButton(_CurrentClickedButton);
            _ScreensRunner();
        }

        ~frmMainScreen()
        {
            OnLogout = null;
        }

    }
}
