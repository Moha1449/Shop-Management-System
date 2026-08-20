using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientSideBusinessLayer.Businesses.Server;
using ClientSideBusinessLayer;
using System.Linq;
using ShopManagementSystem.SellsManagement.Sales_Details;
using ShopManagementSystem.SellsManagement.AddNewSale;
using ShopManagementSystem.Notification;


namespace ShopManagementSystem.SellsManagement.Main_Screen
{
    public partial class usSellsManagementScreen: UserControl
    {
        private short _RowsPerPage { get; set; }

        private short _PageNumber { get; set; }


        private bool _IsDataReloaded = false;


        private List<clsSell> _Sells = new List<clsSell>();

        public usSellsManagementScreen()
        {
            _PageNumber = 1;
            _RowsPerPage = 100;
            InitializeComponent();
        }

        private async void dgvSellsList_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation != ScrollOrientation.VerticalScroll)
                return;

            if (_IsItInBottoms())
            {
                await _LoadNextSellsPageAsync();
            }
            else if (_IsItInTops())
            {
                await _LoadPerviousSellsPageAsync();
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private async void tbSearchOnSell_KeyDown(object sender, KeyEventArgs e)
        {
            if (_Sells.Count == 0)
                return;

            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(tbSearchOnSells.Text))
            {

                int SellID = Convert.ToInt32(tbSearchOnSells.Text);

                clsSell Sell =
                    _Sells.FirstOrDefault(s => s.ID == SellID);

                dgvSellsList.Rows.Clear();


                //if sell was found in the list just show it in grid
                //otherwise send request to server to get the sell
                if (Sell != null)
                    _AddSellToGrid(Sell);
                else
                {
                    Sell = await clsSell.GetSellBySellID(SellID);

                    //if the sell was found show it in grid
                    //otherwise let the grid empty
                    if (Sell.State == clsReturnResult.enReturnResult.Found)
                    {
                        _AddSellToGrid(Sell);
                        _Sells.Add(Sell);
                    }
                }

                dgvSellsList.Refresh();

                _IsDataReloaded = false;
            }
            else if (string.IsNullOrWhiteSpace(tbSearchOnSells.Text) && !_IsDataReloaded)
            {
                //reset the page number to load stocks from the begging 
                _PageNumber = 1;

                await _LoadNextSellsPageAsync();
                _IsDataReloaded = true;
            }
        }


        private bool _IsItInTops()
        {
            if (dgvSellsList.Rows.Count == 0) return false;

            return (dgvSellsList.FirstDisplayedScrollingRowIndex == 0);
        }

        private bool _IsItInBottoms()
        {
            if (dgvSellsList.Rows.Count == 0) return false;

            int FirstVisibleRowRealIndex = dgvSellsList.FirstDisplayedScrollingRowIndex;
            int LastRowVisibleRealIndex = FirstVisibleRowRealIndex + dgvSellsList.DisplayedRowCount(true) - 1;

            return LastRowVisibleRealIndex == dgvSellsList.Rows.Count - 1;
        }

        private void _AddSellToGrid(clsSell Sell)
        {
            if (Sell == null) return;

            dgvSellsList.Rows.Add(Sell.ID, Sell.TotalPrice, Sell.PayDate, Sell.DoneByName);
        }

        private void _AddSellsToGrid()
        {
            if (_Sells.Count == 0)
                return;

            foreach (var Sell in _Sells)
            {
                _AddSellToGrid(Sell);
            }
        }


        private void _ClearGrid()
        {
            dgvSellsList.Rows.Clear();
        }

        private async Task _LoadNextSellsPageAsync()
        {
            (var Result, var Sells) = await clsSell.GetSellsPaged(_PageNumber,
                _RowsPerPage);

            _Sells =Sells;

            if (Result == clsReturnResult.enReturnResult.Success)
            {
                _PageNumber++;
                _ClearGrid();
                _AddSellsToGrid();
            }
        }

        private async Task _LoadPerviousSellsPageAsync()
        {
            if (_PageNumber == 0)
                return;

            (var Result, var Sells) = await clsSell.GetSellsPaged(--_PageNumber,
                _RowsPerPage);

            _Sells =Sells ;

            if (_Sells.Count == 0)
                return;

            if (Result == clsReturnResult.enReturnResult.Success)
            {
                _ClearGrid();
                _AddSellsToGrid();
            }
            else
            {
                _PageNumber++;
            }
        }

        private void _DisenableServices()
        {
            cmSellsManagmentServices.Enabled = false;
        }

        private void _EnableServices()
        {
            cmSellsManagmentServices.Enabled = true;
        }


        private async void usSellsManagementScreen_Load(object sender, EventArgs e)
        {
            lbWelcomingMessage.Text += clsGlobal.CurrentUser.UserName;

            await _LoadNextSellsPageAsync();


            //If list is empty disable the services
            if (_Sells.Count == 0)
                _DisenableServices();
        }

        private void showSaleDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.IsUserHasPermission(clsUser.enOperations.ShowSales))
            {
                frmCustomMessageBox NoPermission = new frmCustomMessageBox("Not Allowed", "You do not have permission.", 7);
                NoPermission.ShowDialog();
                return;
            }

            int SaleID =Convert.ToInt32( dgvSellsList.SelectedRows[0].Cells[0].Value);
            double TotalCost = Convert.ToDouble(dgvSellsList.SelectedRows[0].Cells[1].Value);

            frmSalesDetailsScreen SalesDetails = new frmSalesDetailsScreen(SaleID,TotalCost);

            SalesDetails.OnBuyerListBecameEmpty += async (IsEmpty) =>
            {
                if (!IsEmpty) return;

                await _DeleteSaleFully();

                SalesDetails.Close();
            };

            SalesDetails.ShowDialog();
        }

        private void btAddNewSells_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.IsUserHasPermission(clsUser.enOperations.AddSells))
            {
                frmCustomMessageBox NoPermission = new frmCustomMessageBox("Not Allowed", "You do not have permission.", 7);
                NoPermission.ShowDialog();
                return;
            }


            frmAddNewSale AddScreen = new frmAddNewSale();

            AddScreen.OnAddNewSell += (Sell) =>
            {
                if (Sell == null) return;

                _AddSellToGrid(Sell);

                _EnableServices();
            };

            AddScreen.ShowDialog();
        }


        private async Task _DeleteSaleFully()
        {
            int SaleID = (int)dgvSellsList.SelectedRows[0].Cells[0].Value;

            string DeleteMessage = "Sale is not deleted.";

            if (await clsSell.DeleteSaleBySaleID(SaleID) == clsReturnResult.enReturnResult.Success)
            {
                DeleteMessage = "Sale is deleted.";
                dgvSellsList.Rows.RemoveAt(dgvSellsList.SelectedRows[0].Index);
            }

            frmCustomMessageBox DeleteResult = new frmCustomMessageBox("Delete Result", DeleteMessage, 7);
            DeleteResult.ShowDialog();
        }

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.IsUserHasPermission(clsUser.enOperations.DeleteSale))
            {
                frmCustomMessageBox NoPermission = new frmCustomMessageBox("Not Allowed", "You do not have permission.", 7);
                NoPermission.ShowDialog();
                return;
            }

            await _DeleteSaleFully();
        }
    }
}
