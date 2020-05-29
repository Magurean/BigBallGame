using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBallGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Regular balls:");
            int regular = int.Parse(Console.ReadLine());

            Console.WriteLine("Repelent balls:");
            int repellent = int.Parse(Console.ReadLine());

            Console.WriteLine("Monster balls:");
            int monster = int.Parse(Console.ReadLine());

            Console.WriteLine("Latimea canvasului:");
            int canvasWidth = int.Parse(Console.ReadLine());

            Console.WriteLine("Inaltimea canvasului:");
            int canvasHeight = int.Parse(Console.ReadLine());

            Canvas board = new Canvas(canvasHeight, canvasWidth);

            Init init = new Init(regular, monster, repellent, board);

            List<Ball> lista = init.init();

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            Simulation sim = new Simulation(lista, board);
            sim.Play();


            Console.ReadKey();
        }
    }
}
