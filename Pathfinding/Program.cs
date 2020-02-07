using System;

namespace Pathfinding
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playing = true;

            Map map = new Map();
            Character p = new Character();
            p.x = 5;
            p.y = 5;
            while(playing)
            {
                map.DrawCharacter(p);
                map.DrawMap();

                p.PathFinding(35, 20);
                Console.ReadKey();
            }
        }
    }
}
