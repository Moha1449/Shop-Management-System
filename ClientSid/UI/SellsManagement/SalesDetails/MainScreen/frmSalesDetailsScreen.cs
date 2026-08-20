using ClientSideBusinessLayer;
using ClientSideBusinessLayer.Businesses.Server;
using ShopManagementSystem.Notification;
using ShopManagementSystem.SellsManagement.AddNewSale;
using ShopManagementSystem.SellsManagement.SalesDetails.UpdateQauntityScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementSystem.SellsManagement.Sales_Details
{
    public partial class frmSalesDetailsScreen : Form
    {
        private int _SaleID { get; set; }

        private double _TotalCost { get; set; }

        private List<clsSaleDetail> _Details = new List<clsSaleDetail>();

        public event Action<bool> OnBuyerListBecameEmpty;

        public frmSalesDetailsScreen(int saleID, double totalCost)
        {
            _SaleID = saleID;
            _TotalCost = totalCost;
            InitializeComponent();
        }


        private void _AddSaleDetailToGrid(clsSaleDetail Detail)
        {
            if (Detail == null)
                return;

            dgvSaleDetailsList.Rows.Add(Detail.DetailID, Detail.StockName,
                Detail.Cost, Detail.Quantity, Detail.EnteredByName);
        }

        private void _AddSaleDetailsToGrid()
        {
            foreach (clsSaleDetail detail in _Details)
            {
                _AddSaleDetailToGrid(detail);
            }
        }


        private async Task _LoadSaleDetails()
        {
            (var GetResult, var SaleDetails) = await clsSaleDetail.GetSaleDetailsBySeLeID(_SaleID);

            _Details = SaleDetails;

            if (_Details.Count == 0)
                return;

            if (GetResult == clsReturnResult.enReturnResult.Success)
            {
                _AddSaleDetailsToGrid();
            }
        }


        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmSalesDetailsScreen_Load(object sender, EventArgs e)
        {

            await _LoadSaleDetails();

            lbTotalProducts.Text = _Details.Count.ToString() + ' ' +
                lbTotalProducts.Text;

            lbTotalCost.Text += _TotalCost.ToString();
        }

        private clsSaleDetail _GetSelectedRow()
        {
            int DetailID = Convert.ToInt32(dgvSaleDetailsList.SelectedRows[0].Cells[0].Value);
            return _Details.FirstOrDefault(D => D.DetailID == DetailID);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.IsUserHasPermission(clsUser.enOperations.UpdateSells))
            {
                frmCustomMessageBox NoPermission = new frmCustomMessageBox("Not Allowed", "You do not have permission.", 7);
                NoPermission.ShowDialog();
                return;
            }

            clsSaleDetail Detail = _GetSelectedRow();

            frmUpdateQuantity UpdateAmountScreen = new frmUpdateQuantity(Detail);

            UpdateAmountScreen.OnUpdateAmount += (Result) =>
            {
                if (!Result) return;

                dgvSaleDetailsList.SelectedRows[0].Cells[3].Value = Detail.Quantity;
            };

            UpdateAmountScreen.ShowDialog();
        }


        private void _DeleteItemFromBuyerList()
        {
            if (_Details.Count == 0) return;

            int RowIndex = dgvSaleDetailsList.SelectedRows[0].Index;

            dgvSaleDetailsList.Rows.RemoveAt(RowIndex);
            _Details.RemoveAt(RowIndex);
        }


        private async void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.IsUserHasPermission(clsUser.enOperations.UpdateSells))
            {
                frmCustomMessageBox NoPermission = new frmCustomMessageBox("Not Allowed", "You do not have permission.", 7);
                NoPermission.ShowDialog();
                return;
            }

            clsSaleDetail Detail = _GetSelectedRow();

            var DeleteResult = await clsSaleDetail.DeleteSaleDetailByID(Detail.DetailID);

            string DeleteMessage = "The Detail was not deleted.";

            if (DeleteResult == clsReturnResult.enReturnResult.Success)
            {
                DeleteMessage = "The Detail was deleted.";
                _DeleteItemFromBuyerList();
            }

            frmCustomMessageBox MessageBoxDeleteResult = new frmCustomMessageBox("Delete Result"
                , DeleteMessage, 10);

            MessageBoxDeleteResult.ShowDialog();

            if (_Details.Count == 0)
                OnBuyerListBecameEmpty?.Invoke(true);
        }



        private async Task _AddItemToBuyerList(clsStock Stock, int Amount)
        {
            if (_Details.Count == 0)
                return;

            clsSaleDetail NewItem = new clsSaleDetail(_Details[0].SaleID, clsGlobal.
                CurrentUser.UserID, Stock.ID, Stock.Name, clsGlobal.CurrentUser.UserName
                , Amount, Amount * Stock.Price);


            string AddMessage = "Item is not added.";

            if (await NewItem.AddNewItemToBuyerList() == clsReturnResult.enReturnResult.Success)
            {
                AddMessage = "Item is added.";

                _Details.Add(NewItem);
                _AddSaleDetailToGrid(NewItem);
                return;
            }

            frmCustomMessageBox AddResultMessageBox = new frmCustomMessageBox("Add Result", AddMessage, 10);
            AddResultMessageBox.ShowDialog();
        }


        private bool _IsStockInBuyerList(string Name)
        {
            return _Details.Any(I => I.StockName == Name);
        }


        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.IsUserHasPermission(clsUser.enOperations.UpdateSells))
            {
                frmCustomMessageBox NoPermission = new frmCustomMessageBox("Not Allowed", "You do not have permission.", 7);
                NoPermission.ShowDialog();
                return;
            }

            frmSearchOnStock SearchScreen = new frmSearchOnStock();

            SearchScreen.OnStockFound += async (Stock, Amount) =>
            {
                if (Stock == null)
                    return;

                SearchScreen.Close();

                await _AddItemToBuyerList(Stock, Amount);
            };



            SearchScreen.OnStockExistsInList += (StockName) =>
            {
                if (string.IsNullOrEmpty(StockName))
                    return;

                SearchScreen.IsStockInBuyerList = _IsStockInBuyerList(StockName);
            };

            SearchScreen.ShowDialog();
        }

        ~frmSalesDetailsScreen()
        {
            OnBuyerListBecameEmpty = null;
        }
    }
}
