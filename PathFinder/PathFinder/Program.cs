using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Initialize Parameters
            Position[] positions = new Position[2];
            Direction[] directions = new Direction[2];
            String[] commands = new String[2];
            
            positions[0] = new Position(1, 2);
            positions[1] = new Position(3, 3);

            directions[0] = Direction.N;
            directions[1] = Direction.E;

            commands[0] = "LMLMLMLMM";
            commands[1] = "MMRMMRMRRM";
            #endregion

            Startup startup = new Startup(new Position(5,5), positions, directions, commands);
            startup.DoJob();

            Console.ReadLine();
        }
    }
}
