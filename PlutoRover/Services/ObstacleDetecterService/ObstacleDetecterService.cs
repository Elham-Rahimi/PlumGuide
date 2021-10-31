using Microsoft.Extensions.Configuration;
using PlutoRover.Services.EdgeAdapterService;
using System.Collections.Generic;

namespace PlutoRover.Services.ObstacleDetecterService
{
    public class ObstacleDetecterService: IObstacleDetecterService
    {
        private IConfiguration _configuration;
        private List<Position> obstaclePositions = new List<Position>();

        public ObstacleDetecterService(IConfiguration configuration)
        {
            _configuration = configuration;
            var valuesSection = configuration.GetSection("PlutoRover:Obstacles");
            foreach (IConfigurationSection section in valuesSection.GetChildren())
            {
                var x = section.GetValue<int>("X");
                var y = section.GetValue<int>("Y");

                obstaclePositions.Add(new Position(x, y));
            }
        }

        public bool HasObstacle(Position position)
        {
            return obstaclePositions.Exists(p => p.X == position.X && p.Y == position.Y);
        }
    }
}
