using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace BigBallGame
{
    class Simulation
    {
        private List<Ball> ball;
        private Canvas board;

        public Simulation(List<Ball> ball, Canvas board)
        {
            this.ball = ball;
            this.board = board;

        }

        public void Play()
        {
            while (!finished())
            {
                Turn();
                Delay();
            }
            Console.WriteLine("Done");

        }

        private void Turn()
        {
          
        }

        private static void Delay()
        {
            Timer aTimer = new Timer(2000);
        }

        private bool finished()
        {
            bool ok = true;
            for (int i = 0; i < ball.Count; i++)
            {
                if (!ball[i].isOver)
                    ok = false;
            }
            return ok;
        }
    }
}
