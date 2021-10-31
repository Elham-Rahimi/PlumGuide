using PlutoRover.Models;
using PlutoRover.Services.EdgeAdapterService;

namespace PlutoRover.Services.RoverTranslateService
{
    public class RoverTranslateService : IRoverTranslateService
    {
        private readonly IEdgeAdapterService _edgeAdapterService;
        public RoverTranslateService(IEdgeAdapterService edgeAdapterService)
        {
            _edgeAdapterService = edgeAdapterService;
        }
        public void Move(RoverLocation roverLocation , Position position)
        {
            _edgeAdapterService.AdjustPosition(position);

            roverLocation.MoveTo(position.X, position.Y);
        }
    }
}
