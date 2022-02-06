using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDistributionService
{
    class Order
    {
        public int Quantity { get; set; }
        public Game Game { get; set; }
        public DateTime OrderTime { get; set; }
        public double TotalPrice { get; set; }
        public List<DLC> SelectedDLCs { get; set; }
        public Editions Edition { get; set; }

        public Order()
        {

        }

        public Order(int Quantity, Game Game, DateTime OrderTime, double TotalPrice, List<DLC> SelectedDLCs, Editions Edition)
        {
            this.Quantity = Quantity;
            this.Game = Game;
            this.OrderTime = OrderTime;
            this.TotalPrice = TotalPrice;
            this.SelectedDLCs = SelectedDLCs;
            this.Edition = Edition;

        }

        public double CalculateTotalPrice()
        {
            TotalPrice = (CalculateGamePrice() * Quantity) + (CalculateDLCPrice() * Quantity);
            return TotalPrice;
        }

        public double CalculateGamePrice()
        {
            return Game.Price * ((((double)Edition) / 2) + 0.5);
        }

        public double CalculateDLCPrice()
        {
            if (SelectedDLCs != null)
            {
                double totalDLCPrice = 0;
                foreach (DLC dlc in SelectedDLCs)
                {
                    totalDLCPrice += dlc.Price;
                }

                return totalDLCPrice;
            }

            return 0;
        }
    }
}
