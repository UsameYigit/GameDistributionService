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
    public partial class SeeOrders : Form
    {

        public SeeOrders()
        {
            InitializeComponent();
        }

        private void SeeOrders_Load(object sender, EventArgs e)
        {
            LoadPage();
        }

        void LoadPage()
        {
            try
            {
                double totalIncome = 0;
                int productsSold = 0;
                double dlcsSold = 0;

                foreach (Order order in StorePage.orders)
                {
                    lvAllOrders.Items.Add(AllAroundMethods.AddItemToOrderListView(order));

                    totalIncome += order.TotalPrice;
                    productsSold += order.Quantity;
                    dlcsSold += order.CalculateDLCPrice() * order.Quantity;
                }

                lvAllOrders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                lblDLCIncome.Text = dlcsSold.ToString();
                lblProductsSold.Text = productsSold.ToString();
                lblTotalIncome.Text = totalIncome.ToString();
            }
            catch (InvalidOperationException ioe)
            {
                MessageBox.Show(ioe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
