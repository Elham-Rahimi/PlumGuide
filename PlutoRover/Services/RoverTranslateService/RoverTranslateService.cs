using PlutoRover.Models;
using PlutoRover.Services.EdgeAdapterService;
using PlutoRover.Services.ObstacleDetecterService;
using PlutoRover.Services.RoverTranslateService.Exceptions;
using System.Collections.Generic;

namespace PlutoRover.Services.RoverTranslateService
{
    public class RoverTranslateService : IRoverTranslateService
    {
        private readonly IEdgeAdapterService _edgeAdapterService;
        private readonly IObstacleDetecterService _obstacleDetecterService;
        public RoverTranslateService(IEdgeAdapterService edgeAdapterService, IObstacleDetecterService obstacleDetecterService)
        {
            _edgeAdapterService = edgeAdapterService;
            _obstacleDetecterService = obstacleDetecterService;
        }
        public void Move(RoverLocation roverLocation , Position position)
        {
            var wrappedPosition = _edgeAdapterService.AdjustPosition(position);

            if(_obstacleDetecterService.HasObstacle(wrappedPosition))
            {
                throw new EncounterObstacleException(roverLocation,wrappedPosition);
            }

            roverLocation.MoveTo(wrappedPosition.X, wrappedPosition.Y);
        }
    }
}
