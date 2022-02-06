using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDistributionService.GameSortings
{
    class GameDescendingByPublisDate : IComparer<Game>
    {
        public int Compare(Game x, Game y)
        {
            return y.PublishDate.CompareTo(x.PublishDate);
        }
    }
}
