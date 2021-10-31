using PlutoRover.Common;
using PlutoRover.Models;
using PlutoRover.Services.EdgeAdapterService;
using PlutoRover.Services.RoverTranslateService;

namespace PlutoRover.Services.CommandHandlers
{
    public class BackwardCommandHandler : ICommandHandler
    {
        private readonly IRoverTranslateService _roverTranslateService;
        public BackwardCommandHandler(IRoverTranslateService roverTranslateService)
        {
            _roverTranslateService = roverTranslateService;
        }
        public void execute(RoverLocation roverLocation)
        {
            var position = new Position(roverLocation.PositionX,roverLocation.PositionY);

            if (roverLocation.Direction == CardinalDirection.North)
                position.Y -= 1;
            if (roverLocation.Direction == CardinalDirection.South)
                position.Y += 1;
            if (roverLocation.Direction == CardinalDirection.West)
                position.X += 1;
            if (roverLocation.Direction == CardinalDirection.East)
                position.X -= 1;

            _roverTranslateService.Move(roverLocation, position);
        }
    }


}
