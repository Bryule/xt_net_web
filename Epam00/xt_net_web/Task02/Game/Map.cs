using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Game
{
    class Map
    {
        private double _width;
        private double _height;
        private Enemy _enemy;
        private Bonus _bonus;
        private Barrier _barrier;
        private Player _player;

        public double Height { get; set; }
        public double Width { get; set; }

        public Map()
        {
            Height = 20;
            Width = 20;
        }     
    }    
}
