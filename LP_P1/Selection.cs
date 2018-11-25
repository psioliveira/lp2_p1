using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_P1
{
    internal class Selection
    {
        internal Renderer rend = new Renderer();
        internal List<Game> gameList;
        internal List<Game> filterList;
        public Selection(List<Game>gameList,Renderer rend )
        {
            this.gameList = gameList;
            this.rend = rend;
        }

    }
}
