using PlutoRover.Models;

namespace PlutoRover.Services.CommandHandlers
{
    public interface ICommandHandler
    {
        void execute(RoverLocation roverLocation);
    }


}
