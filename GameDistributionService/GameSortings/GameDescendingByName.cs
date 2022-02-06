using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDistributionService.GameSortings
{
    class GameDescendingByName : IComparer<Game>
    {
        public int Compare(Game x, Game y)
        {
            return y.Name.CompareTo(x.Name);
        }
    }
}
