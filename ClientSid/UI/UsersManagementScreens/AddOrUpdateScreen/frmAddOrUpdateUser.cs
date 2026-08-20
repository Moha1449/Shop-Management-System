using ClientSideBusinessLayer;
using ClientSideBusinessLayer.Businesses.Server;
using Guna.UI2.WinForms;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ShopManagementSystem.clsGlobal;

namespace ShopManagementSystem.UsersScreen
{
    public partial class frmAddOrUpdateUser : Form
    {
        private enScreenMode _Operation { get; set; }


        public event Action<clsUser> OnUserAdded;

        public event Action<clsUser> OnUserUpdated;

        private clsUser _UpdateUser = null;


        public frmAddOrUpdateUser()
        {
            _Operation = enScreenMode.Add;
            InitializeComponent();
        }

        public frmAddOrUpdateUser(clsUser user)
        {
            _Operation = enScreenMode.Update;
            _UpdateUser = user;
            InitializeComponent();
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

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _SetRightTileAndButtonName()
        {
            if (_Operation == enScreenMode.Update)
            {
                lbScreenTitle.Text = "Update User";
                btAddOrUpdate.Text = lbScreenTitle.Text;
            }
        }

        private void _LoadUserDataOnControllers()
        {
            if (_Operation == enScreenMode.Update && _UpdateUser != null)
            {
                tbUserName.Text = _UpdateUser.UserName;
                tbPassword.Text = _UpdateUser.Password;
                cbActive.Checked = _UpdateUser.IsActive;
                cbRole.Text = _UpdateUser.Role.ToString();
            }
        }

        private void _LoadRolesOnComboBox()
        {
            cbRole.Items.Add(clsRoles.enRole.None.ToString());
            cbRole.Items.Add(clsRoles.enRole.Admin.ToString());
            cbRole.Items.Add(clsRoles.enRole.Employee.ToString());

            if (clsGlobal.CurrentUser.Role == clsRoles.enRole.Owner)
                cbRole.Items.Add(clsRoles.enRole.Owner.ToString());
        }

        private void frmAddOrUpdateUser_Load(object sender, EventArgs e)
        {
            _LoadRolesOnComboBox();

            if (_Operation == enScreenMode.Update)
            {
                _SetRightTileAndButtonName();
                _LoadUserDataOnControllers();
            }
        }

        private async Task _ShowOperationResult(clsReturnResult OperationResult)
        {
            if (_Operation == enScreenMode.Add)
            {
                lbOperationResult.Text = (OperationResult.State == clsReturnResult.enReturnResult.Success) ? "User was added successfully." :
                   (OperationResult.State == clsReturnResult.enReturnResult.ServerError)?OperationResult.Error:"User was not added.";

                pnResultOfOperation.FillColor = (OperationResult.State == clsReturnResult.enReturnResult.Success)
                    ? System.Drawing.Color.FromArgb(192, 255, 192) : System.Drawing.Color.FromArgb(255, 192, 192);
            }
            else
            {
                lbOperationResult.Text = (OperationResult.State == clsReturnResult.enReturnResult.Success) ? "User was updated." :
                  (OperationResult.State == clsReturnResult.enReturnResult.ServerError) ? OperationResult.Error: "User was not updated.";

                pnResultOfOperation.FillColor = (OperationResult.State == clsReturnResult.enReturnResult.Success)
                    ? System.Drawing.Color.FromArgb(192, 255, 192) : System.Drawing.Color.FromArgb(255, 192, 192);
            }

            pnResultOfOperation.Visible = true;

            await Task.Delay(3000);

            pnResultOfOperation.Visible = false;
        }

        private async Task _AddNewUserOperation()
        {
            if (_Operation != enScreenMode.Add)
                return;


            clsUser NewUser = new clsUser();

            NewUser.UserName = tbUserName.Text;
            NewUser.Password = tbPassword.Text;
            NewUser.CreatedBy = clsGlobal.CurrentUser.UserID;
            NewUser.IsActive = cbActive.Checked;
            NewUser.Permissions = clsUser.ConvertRoleFromStringToByte(cbRole.Text);

            var Result = await NewUser.Save();

            if (Result.State == clsReturnResult.enReturnResult.Success)
            {
                OnUserAdded?.Invoke(NewUser);
            }

            await _ShowOperationResult(Result);

        }

        private async Task _UpdateUserOperation()
        {
            if (_Operation != enScreenMode.Update || _UpdateUser == null)
                return;

            _UpdateUser.UserName = tbUserName.Text;
            _UpdateUser.Password = tbPassword.Text;
            _UpdateUser.CreatedBy = clsGlobal.CurrentUser.UserID;
            _UpdateUser.IsActive = cbActive.Checked;
            _UpdateUser.Permissions = clsUser.ConvertRoleFromStringToByte(cbRole.Text);

            var Result = await _UpdateUser.Save();

            if (Result.State == clsReturnResult.enReturnResult.Success)
            {
                OnUserUpdated?.Invoke(_UpdateUser);
            }

            await _ShowOperationResult(Result);
        }

        private async void btAddOrUpdate_Click(object sender, EventArgs e)
        {
            if (!_AreTheInputsValid())
                return;

            if (_Operation == enScreenMode.Add)
            {
                await _AddNewUserOperation();
            }
            else
            {
                await _UpdateUserOperation();
            }
        }

        private void frmAddOrUpdateUser_MouseEnter(object sender, EventArgs e)
        {
            ((Guna2TextBox)sender).PlaceholderForeColor = System.Drawing.Color.Gray;
        }


        ~frmAddOrUpdateUser()
        {
            if (_Operation == enScreenMode.Add)
                OnUserAdded = null;
            else
                OnUserUpdated = null;
        }
    }
}
