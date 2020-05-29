using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BigBallGame
{
    class Regular : Ball
    {
        public Regular(int r, Movement move, Color color) : base(r, move, color) { }

        public override void Miscare(Canvas canvas)
        {
            Console.WriteLine("Start Regular Ball");

            this.move.pozx = (this.move.pozx + (this.move.dx * this.move.speed)) % canvas.width;
            this.move.pozy = (this.move.pozy + (this.move.dy * this.move.speed)) % canvas.height;
        }

        public override void Conflict(Ball ball)
        {

        }

        public void Conflict(Regular ball)
        {
            Regular win, lost;
            if (this.raza > ball.raza)
            {win = this;lost = ball;}

            else {win = ball; lost = this;}

            lost.isOver = true;
            win.raza += lost.raza;
            win.color = Ball.ColorMix(win, lost);
            Console.WriteLine("Regular Ball is over");                 
        }

        public void Conflict(Repellent ball)
        {
            this.move.dx *= -1;
            this.move.dy *= -1;
            ball.color = Ball.ColorMix(ball, this);
        }

        public void Conflict(Monster ball)
        {
            this.isOver = true;            
            ball.color = Ball.ColorMix(ball, this);
            ball.raza += this.raza;
            Console.WriteLine("Regular Ball is over");
        }

    }
}
