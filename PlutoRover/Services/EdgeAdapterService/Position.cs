using Newtonsoft.Json;

namespace PlutoRover.Services.EdgeAdapterService
{
    public class Position
    {
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
        [JsonProperty("x")]
        public int X { get; set; }
        [JsonProperty("y")]
        public int Y { get; set; }
    }
}
