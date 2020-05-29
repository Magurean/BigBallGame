using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBallGame
{
    abstract class Ball
    {
        public int raza { get; set; }
        public Color color { get; set; }
        public Movement move { get; set; }
        public bool isOver { get; set; }

        public Ball(int r, Movement move, Color color)
        {
            this.raza = r;
            this.color = color;
            this.move = move;
        }

        abstract public void Miscare(Canvas canvas);

        abstract public void Conflict(Ball ball);

        public static Color ColorMix(Ball win, Ball lost)
        {
            int R = (win.color.R * win.raza + lost.color.R * lost.raza) / (win.raza + lost.raza);
            if (R > 255) R = 255;

            int G = (win.color.G * win.raza + lost.color.G * lost.raza) / (win.raza + lost.raza);
            if (G > 255) G = 255;

            int B = (win.color.B * win.raza + lost.color.B * lost.raza) / (win.raza + lost.raza);
            if (B > 255) B = 255;

            return Color.FromArgb(R, G, B);
        }
    }
}
