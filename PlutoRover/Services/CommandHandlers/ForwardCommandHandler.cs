using PlutoRover.Common;
using PlutoRover.Models;

namespace PlutoRover.Services.CommandHandlers
{
    public class ForwardCommandHandler : ICommandHandler
    {
        public void execute(RoverLocation roverLocation)
        {
            var positionY = roverLocation.PositionY;
            var positionX = roverLocation.PositionX;
            if (roverLocation.Direction == CardinalDirection.North)
                positionY +=1;
            if (roverLocation.Direction == CardinalDirection.South)
                positionY -= 1;
            if (roverLocation.Direction == CardinalDirection.West)
                positionX -= 1;
            if (roverLocation.Direction == CardinalDirection.East)
                positionX += 1;
            roverLocation.MoveTo(positionX, positionY);
        }
    }
}
