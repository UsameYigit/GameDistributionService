using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDistributionService
{
    class Game
    {
        string _name = "";
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        Publisher _publisher = new Publisher();
        public Publisher Publisher
        {
            get => _publisher;
            set => _publisher = value;
        }
        DateTime _publishDate = new DateTime();
        public DateTime PublishDate
        {
            get => _publishDate;
            set => _publishDate = value;
        }
        List<DLC> _dlcs = new List<DLC>();
        public List<DLC> DLCs
        {
            get => _dlcs;
            set => _dlcs = value;
        }
        double _price = 0;
        public double Price
        {
            get => _price;
            set => _price = value;
        }

        public Game()
        {
        }

        public Game(string Name, double Price, Publisher Publisher, DateTime PublishDate)
        {
            this.Name = Name;
            this.Publisher = Publisher;
            this.PublishDate = PublishDate;
            this.Price = Price;
        }


    }
}
