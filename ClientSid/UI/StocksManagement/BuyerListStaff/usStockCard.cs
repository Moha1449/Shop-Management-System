using System;
using System.Windows.Forms;
using Windows.Web.UI;


namespace ShopManagementSystem.SellsManagement.AddNewSale.BuyerListStaff
{
    public partial class usStockCard : UserControl
    {
        private double _Price { get; set; }

        private string _Name { get; set; }

        private int _Amount { get; set; }

        public usStockCard(string StockName, double Price, int amount)
        {
            _Name = StockName;
            _Price = Price;
            _Amount = amount;
            InitializeComponent();

        }

        public void UpdateStates(int Amount,double Cost)
        {
            _Amount = Amount;
            lbAmount.Text = "Amount :" +' ' + _Amount.ToString();

            _Price = Cost;
            lbPrice.Text ="Price :" + ' ' + _Price.ToString();
        }

        private void usStockCard_Load(object sender, EventArgs e)
        {
            lbPrice.Text += ' ' + _Price.ToString();
            lbStockName.Text += ' ' + ((string.IsNullOrEmpty(_Name)) ? "!" : _Name);
            lbAmount.Text += ' ' + _Amount.ToString();
        }
    }
}
