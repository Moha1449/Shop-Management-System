using ClientSideBusinessLayer;
using ShopManagementSystem.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementSystem.UsersScreen
{
    public partial class usUsersScreen : UserControl
    {
        private List<clsUser> _users = new List<clsUser>();

        private bool _isDataReloaded;

        public usUsersScreen()
        {
            InitializeComponent();
        }

        private void _AddUserToGrid(clsUser user)
        {
            dgvUsersList.Rows.Add(
                user.UserID,
                user.UserName,
                user.IsActive,
                (user.CreatedBy == null)? "None":user.CreatedBy.ToString());
        }

        private void _LoadUsersIntoGrid(List<clsUser> users)
        {
            dgvUsersList.Rows.Clear();

            foreach (clsUser user in users)
            {
                _AddUserToGrid(user);
            }
        }

        private async Task _LoadUsersFromServerAsync()
        {
            var (loadResult, users) = await clsUser.GetAllUsers();

            if (loadResult != clsReturnResult.enReturnResult.Success)
                return;

            _users = users;

            if (_users.Count == 0)
                return;

            _LoadUsersIntoGrid(_users);
        }

        private void _UnenabledServices()
        {
            cmUsersManagmentServices.Enabled = false;   
        }

        private void _EnabledServices()
        {
            cmUsersManagmentServices.Enabled = true;
        }

        private async void usUsersScreen_Load(object sender, System.EventArgs e)
        {
            lbWelcomingMessage.Text += " " + clsGlobal.CurrentUser.UserName;

            await _LoadUsersFromServerAsync();

            //If list is empty disable the services
            if (_users.Count == 0)
                _UnenabledServices();
        }

        private void tbSearchOnUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (_users.Count == 0)
                return;

            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(tbSearchOnUser.Text))
            {
                clsUser user =
                    _users.FirstOrDefault(u => u.UserName == tbSearchOnUser.Text);

                dgvUsersList.Rows.Clear();

                if (user != null)
                    _AddUserToGrid(user);

                _isDataReloaded = false;
            }
            else if (string.IsNullOrWhiteSpace(tbSearchOnUser.Text) && !_isDataReloaded)
            {
                _LoadUsersIntoGrid(_users);
                _isDataReloaded = true;
            }
        }

        private void btAddNewUser_Click(object sender, System.EventArgs e)
        {
            if (!clsGlobal.CurrentUser.IsUserHasPermission(clsUser.enOperations.UpdateUsers))
            {
                frmCustomMessageBox NoPermission = new frmCustomMessageBox("Not Allowed", "You do not have permission.", 7);
                NoPermission.ShowDialog();
                return;
            }

            frmAddOrUpdateUser AddUserScreen = new frmAddOrUpdateUser();

            AddUserScreen.OnUserAdded += _AddUserEventHandler;

            AddUserScreen.ShowDialog();
        }

        private void _AddUserEventHandler(clsUser User)
        {
            if (User == null)
                return;

            _users.Add(User);
            _AddUserToGrid(User);

            //If list was empty then added new user Re-Enable the services
            _EnabledServices();
        }

        private clsUser _GetSelectedUserInGrid()
        {
            if (!(dgvUsersList.SelectedRows.Count == 1))
                return null;

            short SelectedID = Convert.ToInt16(dgvUsersList.SelectedRows[0].Cells[0].Value);

            return _users.FirstOrDefault
                (u => u.UserID == SelectedID);
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.IsUserHasPermission(clsUser.enOperations.UpdateUsers))
            {
                frmCustomMessageBox NoPermission = new frmCustomMessageBox("Not Allowed", "You do not have permission.", 7);
                NoPermission.ShowDialog();
                return;
            }

            frmAddOrUpdateUser UpdateUserScreen = new frmAddOrUpdateUser(_GetSelectedUserInGrid());

            UpdateUserScreen.OnUserUpdated += _UpdateUserEventHandler;

            UpdateUserScreen.ShowDialog();
        }

        private void _UpdateUserEventHandler(clsUser UpdatedUser)
        {
            if(UpdatedUser == null) return;

            dgvUsersList.SelectedRows[0].Cells[1].Value = UpdatedUser.UserName;
            dgvUsersList.SelectedRows[0].Cells[2].Value = UpdatedUser.IsActive;
        }

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.IsUserHasPermission(clsUser.enOperations.DeleteUsers))
            {
                frmCustomMessageBox NoPermission = new frmCustomMessageBox("Not Allowed", "You do not have permission.", 7);
                NoPermission.ShowDialog();
                return;
            }

            if (dgvUsersList.SelectedRows.Count > 0)
            {
                short UserID = Convert.ToInt16(dgvUsersList.SelectedRows[0].Cells[0].Value);

                var DeleteResult = await clsUser.DeleteUserByUserID(UserID);

                string ResultMessage = "User was deleted.";

                if(DeleteResult == clsReturnResult.enReturnResult.Success)
                {
                    dgvUsersList.Rows.RemoveAt(dgvUsersList.SelectedRows[0].Index);
                    _users.Remove(_users.FirstOrDefault(u =>u .UserID == UserID));

                    //If list is empty disable the services
                    if (_users.Count == 0)
                        _UnenabledServices();
                }
                else
                {
                    ResultMessage = "User was not deleted.";
                }

                frmCustomMessageBox DeleteMessageBox = new frmCustomMessageBox("User Delete",ResultMessage,10);
                DeleteMessageBox.ShowDialog();
            }
        }
    }
}