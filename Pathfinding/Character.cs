using System;
using System.Collections.Generic;
using System.Text;

namespace Pathfinding
{
    class Character
    {
        public int x;
        public int y;

        public Character()
        {
            
        }

        void CheckYAxis(int yDes)
        {
            //Checks to avoid obstacles where possible in the theoretically
            //shortest route possible
            if (yDes > y) { y++; }
            else { y--; }
        }

        private void CheckXAxis(int xDes)
        {
            //Checks to avoid obstacles where possible in the theoretically
            //shortest route possible
            if (xDes > x)  { x++; }
            else {  x--;  }
        }

        //The pathfinding algorithm for the Character
        public void PathFinding(int xDes, int yDes) {
            //If at destination, do no more.
            if (x == xDes && y == yDes) {
                //Tells the simulation to stop
                Program.playing = false;
                //returns.
                return;
            }

            //Makes the path viewable
            Map.mapGrid[x, y] = 4;

            //Checks to see if the X distance or Y distance is greater.
            //The character will start on the longest path first.
            if (Math.Abs(xDes - x) > Math.Abs(yDes - y)) {
                //If the destination is on the right
                if (xDes > x){
                    //Checks to avoid obstacles where possible in the theoretically
                    //shortest route possible
                    if (Map.mapGrid[x + 1, y] == 3) {
                        CheckYAxis(yDes);
                    }
                    //If the path is un-obstructed
                    else { x++; }
                }
                //If its on the left
                else {
                    //Checks to avoid obstacles where possible in the theoretically
                    //shortest route possible
                    if (Map.mapGrid[x - 1, y] == 3) {
                        CheckYAxis(yDes);
                    }
                    //If the path is un-obstructed
                    else { x--; }
                }
            }

            //If the destination is farther on the Y axis
            else {
                //if the destination is lower
                if (yDes > y) {
                    //Checks to avoid obstacles where possible in the theoretically
                    //shortest route possible
                    if (Map.mapGrid[x, y + 1] == 3) {
                        CheckXAxis(xDes);
                    }
                    //If the path is un-obstructed
                    else { y++;  }
                }

                //if the destination is higher.
                else {
                    //Checks to avoid obstacles where possible in the theoretically
                    //shortest route possible
                    if (Map.mapGrid[x, y - 1] == 3)  {
                        CheckXAxis(xDes);
                    }
                    //If the path is un-obstructed
                    else { y--; }
                }
            }
        }
    }
}
