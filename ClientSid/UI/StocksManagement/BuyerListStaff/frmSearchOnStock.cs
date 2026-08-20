using ClientSideBusinessLayer;
using ClientSideBusinessLayer.Businesses.Server;
using Guna.UI2.WinForms;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementSystem.SellsManagement.AddNewSale
{
    public partial class frmSearchOnStock : Form
    {

        private clsStock _Stock = null;

        public event Action<clsStock, int> OnStockFound;

        public event Action<string> OnStockExistsInList;

        public bool IsStockInBuyerList = false;

        public frmSearchOnStock()
        {
            InitializeComponent();
        }

        private bool _IsDataInvalid()
        {
            bool IsInvalid = false;

            if (string.IsNullOrEmpty(tbStockName.Text))
            {
                _SetInvalidFormat(tbStockName);
                IsInvalid = true;
            }

            if (string.IsNullOrEmpty(tbAmount.Text))
            {
                _SetInvalidFormat(tbAmount);
                IsInvalid = true;
            }

            return IsInvalid;
        }

        private void _SetInvalidFormat(Guna2TextBox Box)
        {
            (Box).PlaceholderForeColor = System.Drawing.Color.Red;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox_MouseEnter(object sender, EventArgs e)
        {
            tbStockName.PlaceholderForeColor = System.Drawing.Color.Gray;
        }


        private async Task _ShowSearchResult(clsReturnResult.enReturnResult OperationResult)
        {

            lbSearchResult.Text = (OperationResult == clsReturnResult.enReturnResult.Found) ? "Stock was found." :
               (OperationResult == clsReturnResult.enReturnResult.ServerError) ? "Server Error" : "Stock was not found";

            pnResult.FillColor = (OperationResult == clsReturnResult.enReturnResult.Found)
                ? System.Drawing.Color.FromArgb(192, 255, 192) : System.Drawing.Color.FromArgb(255, 192, 192);


            pnResult.Visible = true;

            await Task.Delay(3000);

            pnResult.Visible = false;
        }


        private async Task _SetInvalidAmountFormat()
        {
            pnResult.FillColor = System.Drawing.Color.FromArgb(255, 192, 192);

            lbSearchResult.Text = $"There is only {_Stock.Amount} of {_Stock.Name}";

            pnResult.Visible = true;

            await Task.Delay(3000);

            pnResult.Visible = false;
        }

        private async Task<bool> _IsAmountValid()
        {
            bool IsValid = true;

            if (Convert.ToInt32(tbAmount.Text) > _Stock.Amount)
            {
                IsValid = false;
                await _SetInvalidAmountFormat();
            }

            return IsValid;
        }

        private async Task _ShowStockInBuyerList()
        {

            lbSearchResult.Text = "Stock exists in buyer list";

            pnResult.FillColor = (IsStockInBuyerList)
                ? System.Drawing.Color.FromArgb(192, 255, 192) : System.Drawing.Color.FromArgb(255, 192, 192);


            pnResult.Visible = true;

            await Task.Delay(3000);

            pnResult.Visible = false;
        }


        private async void btSearch_Click(object sender, EventArgs e)
        {
            if (_IsDataInvalid())
                return;

            if (IsStockInBuyerList)
            {
                await _ShowStockInBuyerList();
                return;
            }

            if (_Stock != null && _Stock.Name == tbStockName.Text && await _IsAmountValid())
            {
                OnStockFound?.Invoke(_Stock, Convert.ToInt32(tbAmount.Text));
                return;
            }
            else
            {
                _Stock = await clsStock.GetStockByName(tbStockName.Text);
            }

            if (_Stock.State == ClientSideBusinessLayer.clsReturnResult.enReturnResult.Found && await _IsAmountValid())
            {
                OnStockFound?.Invoke(_Stock, Convert.ToInt32(tbAmount.Text));
            }

            await _ShowSearchResult(_Stock.State);
        }


        public async Task AmountIsFullFromThisStock()
        {
            pnResult.FillColor = System.Drawing.Color.FromArgb(255, 192, 192);

            lbSearchResult.Text = $"The list is full of {_Stock.Name}";

            pnResult.Visible = true;

            await Task.Delay(3000);

            pnResult.Visible = false;
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0') return;

            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        ~frmSearchOnStock()
        {
            OnStockFound = null;
            OnStockExistsInList = null;
        }

        private void tbStockName_TextChanged(object sender, EventArgs e)
        {
            //If the buyer list contains the stock into it notify it 
            if (OnStockExistsInList != null && !string.IsNullOrEmpty(tbStockName.Text))
            {
                OnStockExistsInList.Invoke(tbStockName.Text);
            }
        }
    }
}
