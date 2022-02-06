using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDistributionService.GameSortings
{
    class GameAscendingByPrice : IComparer<Game>
    {
        public int Compare(Game x, Game y)
        {
            GameDescendingByPrice gdbp = new GameDescendingByPrice();
            return -(gdbp.Compare(x, y));
        }
    }
}
