using ClientSideBusinessLayer;
using ClientSideBusinessLayer.Businesses.Server;
using Guna.UI2.WinForms;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ShopManagementSystem.clsGlobal;

namespace ShopManagementSystem.StocksManagement.AddOrUpdateScreen
{
    public partial class frmAddOrUpdateStock: Form
    {
        private clsGlobal.enScreenMode _Operation {  get; set; }

        private clsStock _UpdateStock {  get; set; }

        public event Action<clsStock> OnStockAdded;

        public event Action<clsStock> OnStockUpdated;


        public frmAddOrUpdateStock()
        {
            _Operation = clsGlobal.enScreenMode.Add;
            _UpdateStock = null;
            InitializeComponent();
        }

        public frmAddOrUpdateStock(clsStock Stock)
        {
            _Operation = clsGlobal.enScreenMode.Update;
            _UpdateStock = Stock;
            InitializeComponent();
        }


        private static void _EmptyBoxesFormat(Guna2TextBox TextBox)
        {
            TextBox.PlaceholderForeColor = System.Drawing.Color.Red;
        }

        private bool _AreTheInputsValid()
        {
            bool IsDataValid = true;

            if (string.IsNullOrEmpty(tbStockName.Text))
            {
                IsDataValid = false;
                _EmptyBoxesFormat(tbStockName);
            }

            if (string.IsNullOrEmpty(tbAmount.Text))
            {
                IsDataValid = false;
                _EmptyBoxesFormat(tbAmount);
            }

            if(string.IsNullOrEmpty(tbCost.Text))
            {
                IsDataValid = false;
                _EmptyBoxesFormat(tbCost);
            }

            if (string.IsNullOrEmpty(tbPrice.Text))
            {
                IsDataValid = false;
                _EmptyBoxesFormat(tbPrice);
            }


            return IsDataValid;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _SetTheRightNames()
        {
            if(_Operation == clsGlobal.enScreenMode.Add)
            {
                btAddOrUpdate.Text = "Add Stock";
                lbScreenTitle.Text = "Add New Stock";
            }
            else
            {
                btAddOrUpdate.Text = "Update";
                lbScreenTitle.Text = "Update Stock";
            }
        }

        private void _LoadStockData()
        {
            tbStockName.Text = _UpdateStock.Name;
            tbAmount.Text = _UpdateStock.Amount.ToString();
            tbCost.Text = _UpdateStock.Cost.ToString();
            tbPrice.Text = _UpdateStock.Price.ToString();
        }

        private void frmAddOrUpdateStock_Load(object sender, EventArgs e)
        {
            _SetTheRightNames();

            if(_Operation == enScreenMode.Update && _UpdateStock != null)
            {
                _LoadStockData();
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '.' && ((Guna2TextBox)sender).Name != "tbAmount")
            {
                return;
            }

            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void MouseEnterTextBoxesEventHandler(object sender, EventArgs e)
        {
            ((Guna2TextBox)sender).PlaceholderForeColor = System.Drawing.Color.Gray;
        }

        private async Task _ShowOperationResult(clsReturnResult OperationResult)
        {
            if (_Operation == enScreenMode.Add)
            {
                lbOperationResult.Text = (OperationResult.State == clsReturnResult.enReturnResult.Success) ? "Stock was added successfully." :
                   (OperationResult.State == clsReturnResult.enReturnResult.ServerError) ? OperationResult.Error : "Stock was not added.";

                pnResultOfOperation.FillColor = (OperationResult.State == clsReturnResult.enReturnResult.Success)
                    ? System.Drawing.Color.FromArgb(192, 255, 192) : System.Drawing.Color.FromArgb(255, 192, 192);
            }
            else
            {
                lbOperationResult.Text = (OperationResult.State == clsReturnResult.enReturnResult.Success) ? "Stock was updated." :
                  (OperationResult.State == clsReturnResult.enReturnResult.ServerError) ? OperationResult.Error : "Stock was not updated.";

                pnResultOfOperation.FillColor = (OperationResult.State == clsReturnResult.enReturnResult.Success)
                    ? System.Drawing.Color.FromArgb(192, 255, 192) : System.Drawing.Color.FromArgb(255, 192, 192);
            }

            pnResultOfOperation.Visible = true;

            await Task.Delay(3000);

            pnResultOfOperation.Visible = false;
        }

        private async Task _AddNewStockOperation()
        {
            if (_Operation != enScreenMode.Add)
                return;

            clsStock NewStock = new clsStock();

            NewStock.Name = tbStockName.Text;
            NewStock.Cost = Convert.ToDouble(tbCost.Text);
            NewStock.Price = Convert.ToDouble(tbPrice.Text);
            NewStock.Amount = Convert.ToInt32(tbAmount.Text);
            NewStock.AddedBy = clsGlobal.CurrentUser.UserID;

            var AddResult = await NewStock.Save();

            if (AddResult.State == clsReturnResult.enReturnResult.Success)
            {
                OnStockAdded?.Invoke(NewStock);
            }

            await _ShowOperationResult(AddResult);
        }

        private async Task _UpdateStockOperation()
        {
            if(_Operation != enScreenMode.Update || _UpdateStock == null) return;

            _UpdateStock.Name = tbStockName.Text;
            _UpdateStock.Cost = Convert.ToDouble(tbCost.Text);
            _UpdateStock.Price = Convert.ToDouble(tbPrice.Text);
            _UpdateStock.Amount = Convert.ToInt32(tbAmount.Text);

            var Result = await _UpdateStock.Save();

            if (Result.State == clsReturnResult.enReturnResult.Success)
            {
                OnStockUpdated?.Invoke(_UpdateStock);
            }

            await _ShowOperationResult(Result);
        }

        private async void btAddOrUpdate_Click(object sender, EventArgs e)
        {
            if (!_AreTheInputsValid())
                return;

            if(_Operation == enScreenMode.Add)
            {
                await _AddNewStockOperation();
            }
            else
            {
                await _UpdateStockOperation();
            }
        }

        ~frmAddOrUpdateStock()
        {
            OnStockAdded = null;
            OnStockUpdated = null;
        }
    }
}
