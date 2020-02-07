using System;
using System.Collections.Generic;
using System.Text;

namespace Pathfinding
{
    class Map
    {
        //The mapgrid that gets drawn
        static public int[,] mapGrid;

        public Map()
        {
            mapGrid = new int[50, 25];
        }

        //obstacles to generate
        public void GenerateObstacles(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Random rand = new Random();
                mapGrid[rand.Next(1, 50), rand.Next(1, 25)] = 3;
            }
        }

        //Draws the map
        public void DrawMap()
        {
            //Clears the map after each draw.
            Console.Clear();
            for (int y = 0; y < 25; y++)
            {
                for (int x = 0; x < 50; x++)
                {
                    //Nothing
                    if (mapGrid[x,y] == 0)
                    {
                        Console.Write(".");
                    }
                    //The player
                    else if (mapGrid[x,y] == 1)
                    {
                        Console.Write("@");
                    }
                    //The destination
                    else if (mapGrid[x,y] == 2)
                    {
                        Console.Write("U");
                    }
                    //Obstacles
                    else if (mapGrid[x,y] == 3)
                    {
                        Console.Write("O");
                    }
                    //The players path
                    else if (mapGrid[x,y] == 4)
                    {
                        Console.Write("X");
                    }
                }
                Console.WriteLine();
            }
        }

        //Draws the player
        public void DrawCharacter(Character player)
        {
            mapGrid[player.x, player.y] = 1;
        }
    }
}
