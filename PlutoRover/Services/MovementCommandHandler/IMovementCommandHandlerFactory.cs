using PlutoRover.Common;
using PlutoRover.Models;

namespace PlutoRover.Services.MovementCommandHandler
{
    public interface IMovementCommandHandlerFactory
    {
        void Execute(char commad, RoverLocation roverLocation);
    }
}
