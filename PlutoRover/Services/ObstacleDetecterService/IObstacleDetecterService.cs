using PlutoRover.Services.EdgeAdapterService;

namespace PlutoRover.Services.ObstacleDetecterService
{
    public interface IObstacleDetecterService
    {
        bool HasObstacle(Position position);
    }
}
