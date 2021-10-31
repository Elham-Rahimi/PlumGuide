using PlutoRover.Common;
using PlutoRover.Models;
using PlutoRover.Services.DirectionDetector;

namespace PlutoRover.Services.TransportCommandHandler
{
    public class TransportCommandHandler : ITransportCommandHandler
    {
        private readonly IDirectionDetector _directionDetector;

        public TransportCommandHandler(IDirectionDetector directionDetector)
        {
            _directionDetector = directionDetector;
        }
        public void Execute(RoverLocation currentLocation, string command)
        {
            var roverDirection = _directionDetector.Get(currentLocation.Direction, command);
            if (roverDirection == Direction.Up)
                MoveUp(currentLocation);

            if (roverDirection == Direction.Down)
                MoveDown(currentLocation);

            if (roverDirection == Direction.Right)
                MoveRight(currentLocation);

            if (roverDirection == Direction.Left)
                MoveLeft(currentLocation);
        }

        private static void MoveLeft(RoverLocation currentLocation)
        {
            currentLocation.PositionX -= 1;
        }

        private static void MoveRight(RoverLocation currentLocation)
        {
            currentLocation.PositionX += 1;
        }

        private static void MoveDown(RoverLocation currentLocation)
        {
            currentLocation.PositionY -= 1;
        }

        private static void MoveUp(RoverLocation currentLocation)
        {
            currentLocation.PositionY += 1;
        }
    }
}
