using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BigBallGame
{
    class Init
    {
        public List<Ball> balls { get; set; }
        public Canvas canvas { get; set; }
        public int NrRegular { get; set; }
        public int NrRepellent { get; set; }
        public int NrMonster { get; set; }

        public Random rnd = new Random();

        public Init(int NrRegular, int NrMonster, int NrRepellent, Canvas canvas)
        {
            this.balls = new List<Ball>();
            this.canvas = canvas;
            this.NrRegular = NrRegular;
            this.NrRepellent = NrRepellent;
            this.NrMonster = NrMonster;
        }

        public List<Ball> init()
        {
            initRegular();
            initRepellent();
            initMonster();
            return this.balls;
        }

        private void initRegular()
        {
            for (int i = 0; i < NrRegular; i++)
            {
                int raza = rnd.Next(1, 10);
                Movement move = new Movement(rnd.Next(canvas.width), rnd.Next(canvas.height), rnd.Next(10), rnd.Next(10), rnd.Next(10));
                Color color = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));

                Regular ball = new Regular(raza, move, color);

                balls.Add(ball);
            }
        }

        private void initRepellent()
        {
            for (int i = 0; i < NrRepellent; i++)
            {
                int raza = rnd.Next(1, 10);
                Movement move = new Movement(rnd.Next(canvas.width), rnd.Next(canvas.height), rnd.Next(10), rnd.Next(10), rnd.Next(10));
                Color color = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));

                Repellent ball = new Repellent(raza, move, color);

                balls.Add(ball);
            }
        }

        private void initMonster()
        {
            for (int i = 0; i < NrMonster; i++)
            {
                int raza = rnd.Next(1, 10);
                Movement move = new Movement(rnd.Next(canvas.width), rnd.Next(canvas.height), 0, 0, rnd.Next(5));
                Color color = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));

                Monster ball = new Monster(raza, move, color);

                balls.Add(ball);
            }
        }

    }
}
