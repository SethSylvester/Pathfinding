using System;

namespace Pathfinding
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playing = true;

            Map map = new Map();

            map.GenerateObstacles(40);

            Character p = new Character();
            p.x = 5;
            p.y = 5;

            Random rand = new Random();
            int destinationX = rand.Next(0, 50);
            int destinationY = rand.Next(0, 25);

            while(playing)
            {
                map.DrawCharacter(p);
                map.DrawMap();

                p.PathFinding(destinationX, destinationY);
                Console.ReadKey();
            }
        }
    }
}
