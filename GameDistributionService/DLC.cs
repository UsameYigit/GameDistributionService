using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDistributionService
{
    class DLC
    {
        string _name = "";
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        double _price = 0;
        public double Price
        {
            get => _price;
            set => _price = value;
        }

        public DLC()
        {
        }

        public DLC(string Name, double Price)
        {
            this.Name = Name;
            this.Price = Price;
        }
    }
}
