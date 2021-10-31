using PlutoRover.Models;

namespace PlutoRover.Services.TransportCommandHandler
{
    public interface ITransportCommandHandler
    {
        void Execute(RoverLocation currentLocation, string command);
    }
}
