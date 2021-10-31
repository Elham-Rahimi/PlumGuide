using Newtonsoft.Json;

namespace PlutoRover.Models
{
    public class RoverLocation
    {
        public RoverLocation(int x, int y, string direction)
        {
            PositionX = x;
            PositionY = y;
            Direction = direction;
        }
        [JsonProperty("positionX")]
        public int PositionX { get; set; }

        [JsonProperty("positionY")]
        public int PositionY { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }
    }
}
