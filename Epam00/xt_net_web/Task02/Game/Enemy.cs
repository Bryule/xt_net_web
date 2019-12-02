using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Game
{
       class Enemy : IEnemy
        {
            public  int X { get; set; }
            public  int Y { get; set; }

            public void BearMove()
            {
                throw new NotImplementedException();
            }

            public void WolfMove()
            {
                throw new NotImplementedException();
            }
    }
}
