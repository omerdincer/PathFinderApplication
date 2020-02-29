using PathFinder.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder.Concrete
{
    /// <summary>
    /// Rover Class
    /// Has calculation of direction function
    /// Has printing new position function
    /// </summary>
    public class Rover : IRover
    {
        Position position;
        Direction direction;
        String commands;
        public Rover(IPosition position, Direction direction, String commands)
        {
            this.position = (Position)position;
            this.direction = direction;
            this.commands = commands;
        }

        public void Proceed()
        {
            foreach (var command in commands)
            {
                if (command == 'M')
                    Move();
                else if (command == 'L')
                    TurnLeft();
                else if (command == 'R')
                    TurnRight();
            }
        }

        private void TurnRight()
        {
            direction = (direction + 1) > Direction.W ? Direction.N : direction + 1;
        }

        private void TurnLeft()
        {
            direction = (direction - 1) < Direction.N ? Direction.W : direction - 1;
        }

        private void Move()
        {
            if (direction == Direction.W)
            {
                position.x--;
            }
            else if (direction == Direction.E)
            {
                position.x++;
            }
            else if (direction == Direction.N)
            {
                position.y++;
            }
            else if (direction == Direction.S)
            {
                position.y--;
            }
        }
        
        public void ShowNewPosition()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(position.x.ToString())
                .Append(" ")
                .Append(position.y.ToString())
                .Append(" ")
                .Append(direction.ToString());
            Console.WriteLine(builder.ToString());
        }
    }
}
