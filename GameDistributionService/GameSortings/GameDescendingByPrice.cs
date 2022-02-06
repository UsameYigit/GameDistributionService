using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDistributionService.GameSortings
{
    class GameDescendingByPrice : IComparer<Game>
    {
        public int Compare(Game x, Game y)
        {
            if (x.Price < y.Price) return 1;
            else if (x.Price > y.Price) return -1;
            else return 0;
        }
    }
}
