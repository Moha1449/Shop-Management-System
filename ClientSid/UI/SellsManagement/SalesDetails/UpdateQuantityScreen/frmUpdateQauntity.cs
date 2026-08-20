using ClientSideBusinessLayer;
using ClientSideBusinessLayer.Businesses.Server;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ShopManagementSystem.SellsManagement.SalesDetails.UpdateQauntityScreen
{
    public partial class frmUpdateQuantity: Form
    {
       private clsSaleDetail _Detail {  get; set; }

        public event Action<bool> OnUpdateAmount;

        public frmUpdateQuantity(clsSaleDetail detail)
        {
            _Detail = detail;
            InitializeComponent();
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '0')
                e.Handled = true;
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool _IsDataInvalid()
        {
           return (string.IsNullOrEmpty(tbAmount.Text));
        }

       
        private void _SetInvalidFormat()
        {
            tbAmount.PlaceholderForeColor = System.Drawing.Color.Red;
        }

        private void TextBox_MouseEnter(object sender, EventArgs e)
        {
            tbAmount.PlaceholderForeColor = System.Drawing.Color.Gray;
        }

        private async Task _ShowUpdateResult(clsReturnResult result)
        {
            lbUpdateResult.Text = (result.State == clsReturnResult.enReturnResult.Success) ? "Amount was updated." :
              (result.State == clsReturnResult.enReturnResult.NotFound) ? "Detail was not found" :
              (result.State == clsReturnResult.enReturnResult.ServerError)?result.Error:"Error";

            pnResult.FillColor = (result.State == clsReturnResult.enReturnResult.Success)
                ? System.Drawing.Color.FromArgb(192, 255, 192) : System.Drawing.Color.FromArgb(255, 192, 192);


            pnResult.Visible = true;

            await Task.Delay(3000);

            pnResult.Visible = false;
        }

        private async void btUpdate_Click(object sender, EventArgs e)
        {
            if (_Detail == null)
                return;

            if (_IsDataInvalid())
            {
                _SetInvalidFormat();
                return;
            }

            _Detail.Quantity = Convert.ToInt32(tbAmount.Text);
            var UpdateResult =await _Detail.UpdateAmount();

            if (UpdateResult.State == clsReturnResult.enReturnResult.Success)
                OnUpdateAmount?.Invoke(true);

            await _ShowUpdateResult(UpdateResult);
        }

        ~frmUpdateQuantity()
        {
            OnUpdateAmount = null;
        }
    }
}
