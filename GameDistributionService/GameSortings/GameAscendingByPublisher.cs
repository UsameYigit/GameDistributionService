using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDistributionService.GameSortings
{
    class GameAscendingByPublisher : IComparer<Game>
    {
        public int Compare(Game x, Game y)
        {
            GameDescendingByPublisher gdbp = new GameDescendingByPublisher();
            return -(gdbp.Compare(x, y));
        }
    }
}
