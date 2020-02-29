using PathFinder.Abstract;
using PathFinder.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder
{
    public class Startup
    {
        IPosition plateauPosition;
        IPosition[] positions;
        Direction[] directions;
        String[] commands;

        /// <summary>
        /// Initialize Rover Object And Run
        /// </summary>
        /// <param name="plateauPosition"></param>
        /// <param name="positions"></param>
        /// <param name="directions"></param>
        /// <param name="commands"></param>
        public Startup(IPosition plateauPosition, IPosition[] positions, Direction[] directions, String[] commands)
        {
            this.plateauPosition = plateauPosition;
            this.positions = positions;
            this.directions = directions;
            this.commands = commands;
        }

        public void DoJob()
        {
            for(int i = 0; i < positions.Length; i ++)
            {
                Rover rover = new Rover(positions[i], directions[i], commands[i]);
                rover.Proceed();
                rover.ShowNewPosition();
            }
        }
    }
}
