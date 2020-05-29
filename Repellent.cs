using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BigBallGame
{
    class Repellent : Ball
    {

        public Repellent(int r, Movement move, Color color) : base(r, move, color) { }

        public override void Miscare(Canvas canvas)
        {
            Console.WriteLine("Start Repellent Ball");

            this.move.pozx = (this.move.pozx + (this.move.dx * this.move.speed)) % canvas.width;
            this.move.pozy = (this.move.pozy + (this.move.dy * this.move.speed)) % canvas.height;
        }

        public override void Conflict(Ball ball)
        {
        }

        public void Conflict(Repellent ball)
        {
            Color aux;
            aux = this.color;
            this.color = ball.color;
            ball.color = aux;
        }

        public void Conflict(Monster ball)
        {
            this.raza /= 2;
        }
    }
}
