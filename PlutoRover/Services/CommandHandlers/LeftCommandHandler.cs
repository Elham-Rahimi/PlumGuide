using PlutoRover.Common;
using PlutoRover.Models;

namespace PlutoRover.Services.CommandHandlers
{
    public class LeftCommandHandler : ICommandHandler
    {
        public void execute(RoverLocation roverLocation)
        {
            var direction = roverLocation.Direction;
            if (roverLocation.Direction == CardinalDirection.North)
                direction = CardinalDirection.West;
            if (roverLocation.Direction == CardinalDirection.South)
                direction = CardinalDirection.East;
            if (roverLocation.Direction == CardinalDirection.West)
                direction = CardinalDirection.South;
            if (roverLocation.Direction == CardinalDirection.East)
                direction = CardinalDirection.North;

            roverLocation.TurnTo(direction);
        }
    }
}
