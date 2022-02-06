using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDistributionService.GameSortings
{
    class GameAscendingByPublisDate : IComparer<Game>
    {
        public int Compare(Game x, Game y)
        {
            GameDescendingByPublisDate gdbd = new GameDescendingByPublisDate();
            return -(gdbd.Compare(x, y));
        }
    }
}
