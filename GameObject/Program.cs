using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GameObject.BL;

namespace GameObject
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] triangle = new char[5, 3] { { '@', ' ', ' ' }, { '@', '@', ' ' }, { '@', '@', '@' }, { '@', '@', ' ' }, { '@', ' ', ' ' } };
            char[,] optriangle = new char[5, 3] { { ' ', ' ', '@' }, { ' ', '@', '@' }, { '@', '@', '@' }, { ' ', '@', '@' }, { ' ', ' ', '@' } };

            boundaryBL b = new boundaryBL(new pointBL(0, 0), new pointBL(0, 90), new pointBL(90, 0), new pointBL(90, 90)); 
            gameObjectBL g1 = new gameObjectBL(triangle, new pointBL(5, 5), b, "LeftToRight"); 
            gameObjectBL g2 = new gameObjectBL(optriangle, new pointBL(90, 10), b, "RightToLeft");          
            gameObjectBL g3 = new gameObjectBL(triangle, new pointBL(90, 30), b, "Patrol"); 
            gameObjectBL g4 = new gameObjectBL(triangle, new pointBL(60, 60), b, "Projectile"); 

            List<gameObjectBL> list = new List<gameObjectBL>();

            list.Add(g1);
            list.Add(g2);
            list.Add(g3);
            list.Add(g4);

            Console.CursorVisible = false;

            while (true)
            {
                Thread.Sleep(2000);
                foreach (gameObjectBL g in list)
                {
                    g.move();
                }
            }
        }
    }
}
