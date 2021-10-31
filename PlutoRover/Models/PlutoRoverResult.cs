using Newtonsoft.Json;

namespace PlutoRover.Models
{
    public class PlutoRoverResult
    {
        [JsonProperty("positionX")]
        public int PositionX { get; set; }

        [JsonProperty("positionY")]
        public int PositionY { get; set; }

        [JsonProperty("direction")]
        public char Direction { get; set; }

    }
}
