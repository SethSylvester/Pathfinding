using System;
using System.Collections.Generic;
using System.Text;

namespace Pathfinding
{
    class Map
    {
        static public int[,] mapGrid;

        public Map()
        {
            mapGrid = new int[50, 25];
            DrawMap();
        }

        public void GenerateObstacles(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Random rand = new Random();
                mapGrid[rand.Next(1, 50), rand.Next(1, 25)] = 3;
            }
        }
        public void DrawMap()
        {
            Console.Clear();
            for (int y = 0; y < 25; y++)
            {
                for (int x = 0; x < 50; x++)
                {
                    if (mapGrid[x,y] == 0)
                    {
                        Console.Write(".");
                    }
                    else if (mapGrid[x,y] == 1)
                    {
                        Console.Write("@");
                    }
                    else if (mapGrid[x,y] == 2)
                    {
                        Console.Write("U");
                    }
                    else if (mapGrid[x,y] == 3)
                    {
                        Console.Write("O");
                    }
                }
                Console.WriteLine();
            }
        }

        public void DrawCharacter(Character player)
        {
            mapGrid[player.x, player.y] = 1;
        }
    }
}
