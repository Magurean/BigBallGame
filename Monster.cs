using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BigBallGame
{
    class Monster : Ball
    {
        public Monster(int r, Movement move, Color color) : base(r, move, color) { }

        public override void Miscare(Canvas canvas)
        {
            this.move.dx = 0;
            this.move.dy = 0;
            this.move.speed = 0;
        }

        public override void Conflict(Ball ball)
        {  
            
        }

    }
}
