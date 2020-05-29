using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBallGame
{
    class Movement
    {
        public int dx { set; get; }
        public int dy { set; get; }
        public int speed { set; get; }
        public int pozx { set; get; }
        public int pozy { set; get; }

        public Movement(int pozx, int pozy, int dx, int dy, int speed)
        {
            this.pozx = pozx;
            this.pozy = pozy;
            this.dx = dx;
            this.dy = dy;
            this.speed = speed;
        }

    }
}
