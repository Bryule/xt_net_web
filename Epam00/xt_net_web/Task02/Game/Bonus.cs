using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Game
{
    class Bonus : IBonus
    {
        public  int X { get; set; }
        public  int Y { get; set; }

        public void BuffPlayer()
        {
            throw new NotImplementedException();
        }              
    }
}
