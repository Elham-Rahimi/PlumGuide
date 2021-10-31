using PlutoRover.Models;
using PlutoRover.Services.EdgeAdapterService;

namespace PlutoRover.Services.RoverTranslateService
{
    public interface IRoverTranslateService
    {
        void Move(RoverLocation roverLocation, Position position);
    }
}
