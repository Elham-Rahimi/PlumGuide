using PlutoRover.Common;
using PlutoRover.Models;

namespace PlutoRover.Services.CommandHandlers
{
    public class RightCommandHandler : ICommandHandler
    {
        public void execute(RoverLocation roverLocation)
        {
            var direction = roverLocation.Direction;
            if (roverLocation.Direction == CardinalDirection.North)
                direction = CardinalDirection.East;
            if (roverLocation.Direction == CardinalDirection.South)
                direction = CardinalDirection.West;
            if (roverLocation.Direction == CardinalDirection.West)
                direction = CardinalDirection.North;
            if (roverLocation.Direction == CardinalDirection.East)
                direction = CardinalDirection.South;

            roverLocation.TurnTo(direction);
        }
    }
}
