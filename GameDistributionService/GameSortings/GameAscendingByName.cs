using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDistributionService.GameSortings
{
    class GameAscendingByName : IComparer<Game>
    {
        public int Compare(Game x, Game y)
        {
            GameDescendingByName gdbn = new GameDescendingByName();
            return -(gdbn.Compare(x,y));
        }
    }
}
