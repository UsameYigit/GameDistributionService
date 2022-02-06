using System.Collections.Generic;

namespace GameDistributionService
{
    class Publisher
    {
        string _publisherName = "";
        public string PublisherName 
        {
            get => _publisherName;
            set => _publisherName = value; 
        }
        List<Game> _games = new List<Game>();
        public List<Game> Games
        {
            get => _games;
            set => _games = value;
        }

        public Publisher()
        {

        }

        public Publisher(string PublisherName)
        {
            this.PublisherName = PublisherName;
        }

    } 
}