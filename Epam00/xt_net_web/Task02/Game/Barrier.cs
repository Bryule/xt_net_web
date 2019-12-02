using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Game
{
    class Barrier : IBarrier
    {
        public  int X { get; set; }
        public  int Y { get; set; }

        public void PlaceStone()
        {
            throw new NotImplementedException();
        }

        public void PlaceTree()
        {
            throw new NotImplementedException();
        }
    }
}
