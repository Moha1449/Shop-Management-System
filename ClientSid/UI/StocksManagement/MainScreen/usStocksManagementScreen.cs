using ClientSideBusinessLayer;
using ClientSideBusinessLayer.Businesses.Server;
using ShopManagementSystem.Notification;
using ShopManagementSystem.StocksManagement.AddOrUpdateScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementSystem.StocksManagement.MainScreen
{
    public partial class usStocksManagementScreen : UserControl
    {
        private short _RowsPerPage { get; set; }

        private short _PageNumber { get; set; }

        private bool _IsDataReloaded = false;


        private List<clsStock> _Stocks = new List<clsStock>();


        public usStocksManagementScreen()
        {
            _PageNumber = 1;
            _RowsPerPage = 100;
            InitializeComponent();
        }

        private async void dgvStocksList_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation != ScrollOrientation.VerticalScroll)
                return;

            if (_IsItInBottoms())
            {
                await _LoadNextStockPageAsync();
            }
            else if (_IsItInTops())
            {
                await _LoadPerviousStockPageAsync();
            }
        }


        private bool _IsItInTops()
        {
            if (dgvStocksList.Rows.Count == 0) return false;

            return (dgvStocksList.FirstDisplayedScrollingRowIndex == 0);
        }

        private bool _IsItInBottoms()
        {
            if (dgvStocksList.Rows.Count == 0) return false;

            int FirstVisibleRowRealIndex = dgvStocksList.FirstDisplayedScrollingRowIndex;
            int LastRowVisibleRealIndex = FirstVisibleRowRealIndex + dgvStocksList.DisplayedRowCount(true) - 1;

            return LastRowVisibleRealIndex == dgvStocksList.Rows.Count - 1;
        }


        private void _AddStockToGrid(clsStock Stock)
        {
            if (Stock == null) return;

            dgvStocksList.Rows.Add(Stock.ID, Stock.Name, Stock.Amount, Stock.AddedBy);
        }

        private void _AddStocksToGrid()
        {
            if (_Stocks.Count == 0)
                return;

            foreach (var Stock in _Stocks)
            {
                _AddStockToGrid(Stock);
            }
        }

        private void _ClearGrid()
        {
            dgvStocksList.Rows.Clear();
        }

        private async Task _LoadNextStockPageAsync()
        {
            (var Result, var Stocks) = await clsStock.GetStockPaged(_PageNumber,
                _RowsPerPage);

            _Stocks = Stocks;

            if (Result == clsReturnResult.enReturnResult.Success)
            {
                _PageNumber++;
                _ClearGrid();
                _AddStocksToGrid();
            }
        }

        private async Task _LoadPerviousStockPageAsync()
        {
            if (_PageNumber == 0)
                return;

            (var Result, var Stocks) = await clsStock.GetStockPaged(--_PageNumber,
                _RowsPerPage);

            _Stocks = Stocks;

            if (_Stocks.Count == 0)
                return;

            if (Result == clsReturnResult.enReturnResult.Success)
            {
                _ClearGrid();
                _AddStocksToGrid();
            }
            else
            {
                _PageNumber++;
            }
        }

        private void _DisenableServices()
        {
            cmStocksManagmentServices.Enabled = false;
        }

        private void _EnableServices()
        {
            cmStocksManagmentServices.Enabled = true;
        }

        private async void usStocksManagementScreen_Load(object sender, System.EventArgs e)
        {
            lbWelcomingMessage.Text += clsGlobal.CurrentUser.UserName;

            await _LoadNextStockPageAsync();


            //If list is empty disable the services
            if (_Stocks.Count == 0)
                _DisenableServices();
        }


        private async void tbSearchOnStock_KeyDown(object sender, KeyEventArgs e)
        {
            if (_Stocks.Count == 0)
                return;

            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(tbSearchOnStock.Text))
            {
                clsStock stock =
                    _Stocks.FirstOrDefault(s => s.Name == tbSearchOnStock.Text);

                dgvStocksList.Rows.Clear();


                //if stock was found in the list just show it in grid
                //otherwise send request to server to get the stock
                if (stock != null)
                    _AddStockToGrid(stock);
                else
                {
                    stock = await clsStock.GetStockByName(tbSearchOnStock.Text);

                    //if the stock was found show it in grid
                    //otherwise let the grid empty
                    if (stock.State == clsReturnResult.enReturnResult.Found)
                    {
                        _AddStockToGrid(stock);
                        _Stocks.Add(stock);
                    }
                }

                dgvStocksList.Refresh();

                _IsDataReloaded = false;
            }
            else if (string.IsNullOrWhiteSpace(tbSearchOnStock.Text) && !_IsDataReloaded)
            {
                //reset the page number to load stocks from the begging 
                _PageNumber = 1;

                await _LoadNextStockPageAsync();
                _IsDataReloaded = true;
            }
        }

        private async void deleteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (!clsGlobal.CurrentUser.IsUserHasPermission(clsUser.enOperations.DeleteStocks))
            {
                frmCustomMessageBox NoPermission = new frmCustomMessageBox("Not Allowed", "You do not have permission.", 7);
                NoPermission.ShowDialog();
                return;
            }

            if (dgvStocksList.SelectedRows.Count > 0)
            {
                short StockID = Convert.ToInt16(dgvStocksList.SelectedRows[0].Cells[0].Value);

                var DeleteResult = await clsStock.DeleteStockByStockID(StockID);

                string ResultMessage = "Stock was deleted.";

                if (DeleteResult == clsReturnResult.enReturnResult.Success)
                {
                    dgvStocksList.Rows.RemoveAt(dgvStocksList.SelectedRows[0].Index);
                    _Stocks.Remove(_Stocks.FirstOrDefault(s => s.ID == StockID));

                    //If list is empty disable the services
                    if (_Stocks.Count == 0)
                        _DisenableServices();
                }
                else
                {
                    ResultMessage = "Stock was not deleted.";
                }

                frmCustomMessageBox DeleteMessageBox = new frmCustomMessageBox("Stock Delete", ResultMessage, 10);
                DeleteMessageBox.ShowDialog();
            }
        }

        private void btAddNewUser_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.IsUserHasPermission(clsUser.enOperations.AddStocks))
            {
                frmCustomMessageBox NoPermission = new frmCustomMessageBox("Not Allowed", "You do not have permission.", 7);
                NoPermission.ShowDialog();
                return;
            }

            frmAddOrUpdateStock AddScreen = new frmAddOrUpdateStock();


            AddScreen.OnStockAdded += AddNewStock_EventHandler;


            AddScreen.ShowDialog();
        }


        private void AddNewStock_EventHandler(clsStock NewStock)
        {
            if (NewStock == null)
                return;

            if (_Stocks.Count < 20)
            {
                _Stocks.Add(NewStock);
                _AddStockToGrid(NewStock);
            }

            //If list was empty and stock was added so Re-Enable the services
            _EnableServices();
        }

        private clsStock _GetSelectedStock()
        {
            if (dgvStocksList.Rows.Count == 0) return null;

            if (!(dgvStocksList.SelectedRows.Count == 1)) return null;

            short StockID = Convert.ToInt16(dgvStocksList.SelectedRows[0].Cells[0].Value);

            return _Stocks.FirstOrDefault(s => s.ID == StockID);
        }

        private void updateStockToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!clsGlobal.CurrentUser.IsUserHasPermission(clsUser.enOperations.UpdateStocks))
            {
                frmCustomMessageBox NoPermission = new frmCustomMessageBox("Not Allowed", "You do not have permission.", 7);
                NoPermission.ShowDialog();
                return;
            }

            frmAddOrUpdateStock UpdateScreen = new frmAddOrUpdateStock(_GetSelectedStock());

            UpdateScreen.OnStockUpdated += UpdateStock_EventHandler;

            UpdateScreen.ShowDialog();
        }

        private void UpdateStock_EventHandler(clsStock Stock)
        {
            if (Stock == null)
                return;

            dgvStocksList.SelectedRows[0].Cells[1].Value = Stock.Name;
            dgvStocksList.SelectedRows[0].Cells[2].Value = Stock.Amount;
        }
    }
}
