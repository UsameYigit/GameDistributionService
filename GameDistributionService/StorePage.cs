using GameDistributionService.GameSortings;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDistributionService
{
    public partial class StorePage : Form
    {
        internal static List<DLC> dlcs = new List<DLC>();
        internal static List<Publisher> publishers = new List<Publisher>();
        internal static List<Game> games = new List<Game>();

        internal static List<Order> orders = new List<Order>();

        internal static List<Order> currentOrders = new List<Order>();

        Order currentOrder = new Order();

        public StorePage()
        {
            InitializeComponent();
        }

        private void StorePage_Load(object sender, EventArgs e)
        {
            LoadPage();
        }

        private void btnAddToCard_Click(object sender, EventArgs e)
        {
            AddOrderToCard();
        }
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            PlaceOrder();
        }

        private void btnDiscardOrder_Click(object sender, EventArgs e)
        {
            DiscardSelectedItem();
        }

        private void lvGameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSelectedGame();
        }

        #region Update Price Events
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                currentOrder.Quantity = Convert.ToInt32(nudQuantity.Value);
                UpdatePrice();
            }
            catch (NullReferenceException nre)
            {
                MessageBox.Show("Please select a game from the list before changing quantity");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void rbStandard_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void rbGold_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void rbPlatinium_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }
        #endregion

        #region SetDefaultStart
        void LoadPage()
        {

            SetDefaultStart();
            UploadGameList();

            if (currentOrders != null && currentOrders.Count > 0)
            {
                double totalPrice = 0;
                foreach (Order order in currentOrders)
                {
                    AddOrderToList(order);

                    totalPrice += order.TotalPrice;
                }
                lblTotalPrice.Text = "Total Price: $" + totalPrice;
                lvOrders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            SetCheckBoxes();
        }

        void SetDefaultStart()
        {
            currentOrder.Game = games[0];
            currentOrder.Edition = Editions.Standard;
            currentOrder.Quantity = 1;

            lblGameName.Text = currentOrder.Game.Name;
            lblPrice.Text = "Price: $" + currentOrder.Game.Price;
            lblTotalPrice.Text = "Total Price: $" + 0;
        }
        #endregion

        #region SetSelectedGame
        void SetSelectedGame()
        {
            foreach (Game game in games)
            {
                if (lvGameList.SelectedItems.Count > 0)
                {
                    if (lvGameList.SelectedItems[0].SubItems[0].Text == game.Name)
                    {
                        currentOrder.Game = game;

                        SetCheckBoxes();

                        UpdatePrice();

                        lblGameName.Text = currentOrder.Game.Name;

                        AllAroundMethods.ClearParameters(this);
                    }
                }
            }
        }

        void SetCheckBoxes()
        {
            flpDLCs.Controls.Clear();

            foreach (DLC dlc in currentOrder.Game.DLCs)
            {
                CheckBox cbxDlc = new CheckBox();
                cbxDlc.Name = "cbx" + (dlc.Name).Replace(" ", "");
                cbxDlc.Text = dlc.Name;
                cbxDlc.CheckedChanged += (sender, e) => CheckedChanged(this, e);

                flpDLCs.Controls.Add(cbxDlc);
            }
        }
        #endregion

        #region Order Adjustments
        void PlaceOrder()
        {
            if(currentOrders != null && currentOrders.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show(("Do you want to place the order?"), " ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    orders.AddRange(currentOrders);
                    currentOrders.Clear();


                    MessageBox.Show("Your order has been accepted.");

                    lblTotalPrice.Text = "Total Price: $" + 0;
                    lvOrders.Items.Clear();
                }
            }
            else
                MessageBox.Show("You haven't ordered anything yet.");
        }

        void DiscardSelectedItem()
        {

            if (lvOrders.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show(("Do you really want to delete the selected order?"), " ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    currentOrders.RemoveAt(lvOrders.Items.IndexOf(lvOrders.SelectedItems[0]));
                    lvOrders.SelectedItems[0].Remove();
                    SetOrderPrice();
                    MessageBox.Show("Your order deleted successfully.");
                }
            }
            else
            {
                MessageBox.Show("Please choose an order to delete.");
            }

        }

        void AddOrderToCard()
        {
            currentOrder.Quantity = Convert.ToInt32(nudQuantity.Value);

            currentOrder.OrderTime = DateTime.Now;

            AddOrderToList(currentOrder);

            lvOrders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            currentOrders.Add(new Order(currentOrder.Quantity, currentOrder.Game, currentOrder.OrderTime, currentOrder.TotalPrice, currentOrder.SelectedDLCs, currentOrder.Edition));

            SetOrderPrice();

            AllAroundMethods.ClearParameters(this);
        }
        #endregion

        #region Price Adjustments
        void SetOrderPrice()
        {
            if (currentOrders.Count > 0)
            {
                double totalPrice = 0;
                foreach (Order ord in currentOrders)
                {
                    totalPrice += ord.TotalPrice;
                }

                lblTotalPrice.Text = "Total Price: $" + totalPrice;
            }
        }

        void UpdatePrice()
        {
            SetCurrentDLCs();

            if (rbStandard.Checked)
            {
                currentOrder.Edition = Editions.Standard;
            }
            else if (rbGold.Checked)
            {
                currentOrder.Edition = Editions.Gold;
            }
            else
            {
                currentOrder.Edition = Editions.Platinium;
            }

            lblPrice.Text = "Price: $" + currentOrder.CalculateTotalPrice();
        }

        void SetCurrentDLCs()
        {
            currentOrder.SelectedDLCs = new List<DLC>();
            for (int i = 0; i < flpDLCs.Controls.Count; i++)
            {
                if (currentOrder.Game.DLCs.Count > 0)
                {
                    if ((flpDLCs.Controls[i] as CheckBox).Checked)
                    {
                        currentOrder.SelectedDLCs.Add(currentOrder.Game.DLCs[i]);
                    }
                }
            }
        }
        #endregion

        #region Listview Setters
        void AddOrderToList(Order order)
        {
            //Sets the price of the order.
            order.CalculateTotalPrice();          

            lvOrders.Items.Add(AllAroundMethods.AddItemToOrderListView(order));
        }
        void UploadGameList()
        {
            lvGameList.Items.Clear();

            foreach (Game game in games)
            {
                ListViewItem li = new ListViewItem(game.Name);
                li.SubItems.Add(game.Price.ToString());
                li.SubItems.Add(game.Publisher.PublisherName);
                li.SubItems.Add(game.PublishDate.ToString("dd/MM/yyyy"));
                lvGameList.Items.Add(li);
            }

            lvGameList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        #endregion

        #region Sorting by Columns
        bool isGameNamesAscending = true;
        bool isGamePricesAscending = true;
        bool isGamePublishersAscending = true;
        bool isGamePublishDatesAscending = true;
        private void lvGameList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (e.Column)
            {
                case 0:
                    if (isGameNamesAscending)
                    {
                        games.Sort(new GameAscendingByName());
                        SetAllTrue();
                        isGameNamesAscending = false;
                    }
                    else
                    {
                        games.Sort(new GameDescendingByName());
                        SetAllTrue();
                    }
                    break;
                case 1:
                    if (isGamePricesAscending)
                    {
                        games.Sort(new GameAscendingByPrice());
                        SetAllTrue();
                        isGamePricesAscending = false;
                    }
                    else
                    {
                        games.Sort(new GameDescendingByPrice());
                        SetAllTrue();
                    }
                    break;
                case 2:
                    if (isGamePublishersAscending)
                    {
                        games.Sort(new GameAscendingByPublisher());
                        SetAllTrue();
                        isGamePublishersAscending = false;
                    }
                    else
                    {
                        games.Sort(new GameDescendingByPublisher());
                        SetAllTrue();
                    }
                    break;
                case 3:
                    if (isGamePublishDatesAscending)
                    {
                        games.Sort(new GameAscendingByPublisDate());
                        SetAllTrue();
                        isGamePublishDatesAscending = false;
                    }
                    else
                    {
                        games.Sort(new GameDescendingByPublisDate());
                        SetAllTrue();
                    }
                    break;
                default:
                    MessageBox.Show("There is a problem.");
                    break;
            }
            UploadGameList();
        }

        void SetAllTrue()
        {
            isGameNamesAscending = true;
            isGamePricesAscending = true;
            isGamePublishersAscending = true;
            isGamePublishDatesAscending = true;
        }
        #endregion
    }
}
