using PlutoRover.Common;
using System;

namespace PlutoRover.Services.DirectionDetector
{
    public class DirectionDetector : IDirectionDetector
    {
        public DirectionDetector()
        {

        }
        public Direction Get(string direction, string command)
        {
            // command validator optional direction validator

            if (command == "F")
            {
                if (direction == "N")
                    return Direction.Up;
                if (direction == "S")
                    return Direction.Down;
                if (direction == "E")
                    return Direction.Right;
                if (direction == "W")
                    return Direction.Left;
            }
            else
            {
                if (direction == "N")
                    return Direction.Down;
                if (direction == "S")
                    return Direction.Up;
                if (direction == "E")
                    return Direction.Left;
                if (direction == "W")
                    return Direction.Right;
            }

            throw new Exception();
        }

    }
}
