
using PlutoRover.Infrustructures.Exceptions;
using PlutoRover.Models;
using PlutoRover.Services.EdgeAdapterService;
using System.Net;

namespace PlutoRover.Services.RoverTranslateService.Exceptions
{
    public class EncounterObstacleException : ApplicationException
    {
        public EncounterObstacleException(RoverLocation roverLocation, Position position) :
            base((int)HttpStatusCode.Forbidden, 
                $"There is Obstacle At position ({position.X},{position.Y}). Rover Last Position is ({roverLocation.PositionX},{roverLocation.PositionY},{roverLocation.Direction}).")
        {
        }
    }
}
