using ClientSideBusinessLayer.Businesses.Server;
using ShopManagementSystem.Notification;
using ShopManagementSystem.SellsManagement.AddNewSale.BuyerListStaff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ShopManagementSystem.SellsManagement.AddNewSale
{
    public partial class frmAddNewSale : Form
    {
        // The dictionary stores stock id as key and amount as value
        private Dictionary<short, int> _StocksIDsAndAmounts = new Dictionary<short, int>();

        // The dictionary stores stock id as key and the price as value
        private Dictionary<short, double> _StocksIDsAndPrices = new Dictionary<short, double>();

        public event Action<clsSell> OnAddNewSell;

        private double _TotalCost = 0d;
        public frmAddNewSale()
        {
            InitializeComponent();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool _IsThisStockAmountWentToMax(clsStock Stock, int Amount)
        {
            if (_StocksIDsAndAmounts.ContainsKey(Stock.ID))
            {
                return (_StocksIDsAndAmounts[Stock.ID] + Amount > Stock.Amount);
            }

            return false;
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            frmSearchOnStock SearchScreen = new frmSearchOnStock();

            SearchScreen.OnStockFound += async (Stock, Amount) =>
            {
                if (Stock == null) return;

                if (_IsThisStockAmountWentToMax(Stock, Amount))
                {
                    //if the amount of this stock is already full notify the user
                    //because the user still opening the search screen
                    await SearchScreen.AmountIsFullFromThisStock();
                    return;
                }

                _AddToList(Stock, Amount);
            };

            SearchScreen.ShowDialog();
        }


        private void _UpdateStates()
        {
            //the total products show only the number of different
            //products in hash table not the sum of quantities of the all products in the list (hash table)
            lbTotalProducts.Text = _StocksIDsAndAmounts.Count.ToString() + " sales shown";
            lbTotalCost.Text = "Total:$" + _TotalCost.ToString();
        }


        private void _AddStockCard(string StockName, double Price, int Amount)
        {
            var AddButton = pbAdd;
            flBuyerList.Controls.RemoveAt(flBuyerList.Controls.Count - 1);

            usStockCard StockCard = new usStockCard(StockName, Price, Amount);
            flBuyerList.Controls.Add(StockCard);

            flBuyerList.Controls.Add(AddButton);
        }

        private usStockCard _GetCardByIndex(int index)
        {
            return (usStockCard)flBuyerList.Controls[index];
        }

        private void _UpdateTheStockCard(int Index, int Amount, double Cost)
        {
            usStockCard Card = _GetCardByIndex(Index);
            Card.UpdateStates(Amount, Cost);
        }

        private void _AddToList(clsStock Stock, int Amount)
        {
            if (Stock == null) return;

            double TotalCostOfStock = Stock.Price * Amount;

            //if stocks is in the list just update the amount and the card of the stock
            //otherwise it is not in the list so add it to it 
            if (_StocksIDsAndAmounts.ContainsKey(Stock.ID))
            {
                _StocksIDsAndAmounts[Stock.ID] += Amount;
                _StocksIDsAndPrices[Stock.ID] += TotalCostOfStock;
                //the order of items in dictionary represents the real order of stock cards in flow so 
                //if we found the index of the key we will find the index of the card for updating data
                _UpdateTheStockCard(_StocksIDsAndAmounts.Keys.ToList().IndexOf(Stock.ID), _StocksIDsAndAmounts[Stock.ID], _StocksIDsAndPrices[Stock.ID]);
            }
            else
            {
                _StocksIDsAndAmounts.Add(Stock.ID, Amount);
                _StocksIDsAndPrices.Add(Stock.ID, TotalCostOfStock);

                _AddStockCard(Stock.Name, Stock.Price, Amount);
            }

            _TotalCost += TotalCostOfStock;

            _UpdateStates();
        }

        private async void btSave_Click(object sender, EventArgs e)
        {
            if (_StocksIDsAndAmounts.Count == 0)
                return;

            clsSell Sale = new clsSell(_TotalCost, clsGlobal.CurrentUser.UserID,clsGlobal.CurrentUser.UserName);

            var AddResult = await Sale.AddNewSell
                 (clsSaleDetail.TheBuyerListMaker
                 (_StocksIDsAndAmounts, _StocksIDsAndPrices));

            string AddMessage = "The Sale was not added.";

            if (AddResult.State == ClientSideBusinessLayer.clsReturnResult.enReturnResult.Success)
            {
                AddMessage = "The Sale was added.";
                OnAddNewSell?.Invoke(Sale);
            }

            frmCustomMessageBox AddedMessageBox = new frmCustomMessageBox("Add Result", AddMessage, 10);
            AddedMessageBox.ShowDialog();

            this.Close();
        }



        ~frmAddNewSale()
        {
            OnAddNewSell = null;
        }
    }
}
