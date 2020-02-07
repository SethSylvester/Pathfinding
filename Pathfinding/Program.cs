using System;

namespace Pathfinding
{
    class Program
    {
        //Is playing bool.
        static public bool playing = true;
    
        static void Main(string[] args)
        {

            //Creates the map
            Map map = new Map();

            //generates a number of obstacles
            map.GenerateObstacles(100);

            //Creates the character
            Character p = new Character();
            p.x = 5;
            p.y = 5;

            //randomizes the destination
            Random rand = new Random();
            int destinationX = rand.Next(0, 50);
            int destinationY = rand.Next(0, 25);

            //Sets the destination
            Map.mapGrid[destinationX, destinationY] = 2;

            //Tells the player to pathfind and draws the map on each
            //button press
            while (playing)
            {
                //Draws everything
                map.DrawCharacter(p);
                map.DrawMap();

                //Tells the player to pathfind
                p.PathFinding(destinationX, destinationY);

                //readkey to allow for play by press.
                //Console.ReadKey();
            }
            //Draws the map one final time to get rid of the key that was pressed
            //appearing
            Console.Clear();
            map.DrawMap();

            //informs of the programs completion
            Console.WriteLine("The player has arrived at their destination.");
            Console.ReadKey();
        }
    }
}
