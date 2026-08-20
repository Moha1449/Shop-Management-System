using ClientSideBusinessLayer;
using ClientSideBusinessLayer.DTOs;
using Guna.UI2.WinForms;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementSystem
{
    public partial class frmLoginScreen : Form
    {
        public frmLoginScreen()
        {
            InitializeComponent();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private static void _EmptyBoxesFormat(Guna2TextBox TextBox)
        {
            TextBox.PlaceholderForeColor = System.Drawing.Color.Red;
        }

        private bool _AreTheInputsValid()
        {
            bool IsUserNameEmpty = false, IsPasswordEmpty = false;

            if (tbPassword.Text == string.Empty)
            {
                IsPasswordEmpty = true;
                _EmptyBoxesFormat(tbPassword);
            }

            if (tbUserName.Text == string.Empty)
            {
                IsUserNameEmpty = true;
                _EmptyBoxesFormat(tbUserName);
            }


            return !(IsPasswordEmpty || IsUserNameEmpty);
        }

        private async void btLogin_Click(object sender, EventArgs e)
        {
            if (!_AreTheInputsValid())
                return;

            clsGlobal.CurrentUser = await clsUser.LoginUsingPasswordAndUserName(new clsLoginDTO(tbUserName.Text, tbPassword.Text));

            if (clsGlobal.CurrentUser.State == clsReturnResult.enReturnResult.Found)
            {
                this.Hide();

                frmMainScreen MainScreen = new frmMainScreen();

                MainScreen.OnLogout += UserLoggedOut_EventHandler;

                MainScreen.Show();


                return;
            }


            Func<string, Task> InvalidLoginDataOrErrorShowedUp = async (Details) =>
            {
                lbLoginResultValue.Text = Details;

                pnLoginResult.Visible = true;

                await Task.Delay(3000);

                pnLoginResult.Visible = false;
            };


            string Message = (clsGlobal.CurrentUser.State == clsReturnResult.enReturnResult.Exception) ? "Server Error" : "Invalid UserName or Password";


            await InvalidLoginDataOrErrorShowedUp(Message);
        }

        private void UserLoggedOut_EventHandler(object Sender, bool LogoutResult)
        {
            if (LogoutResult)
            {
                this.Show();

                frmMainScreen MainScreen = (frmMainScreen)Sender;

                MainScreen.Close();

                clsGlobal.CurrentUser = null;
            }
        }

        private void tbUserName_MouseEnter(object sender, EventArgs e)
        {
            ((Guna2TextBox)sender).PlaceholderForeColor = System.Drawing.Color.Gray;
        }
    }
}
