using Newtonsoft.Json;
using PlutoRover.Common;
using System;

namespace PlutoRover.Models
{
    public class RoverLocation
    {
        [JsonConstructor]
        public RoverLocation(int x, int y, CardinalDirection direction)
        {
            Direction = direction;
            PositionX = x;
            PositionY = y;
        }
        [JsonProperty("positionX")]
        public int PositionX { get; set; }

        [JsonProperty("positionY")]
        public int PositionY { get; set; }

        [JsonProperty("direction")]
        public CardinalDirection Direction { get; set; }

        public void MoveTo(int x, int y)
        {
            PositionX = x;
            PositionY = y;
        }

        public void TurnTo(CardinalDirection direction)
        {
            Direction = direction;
        }

    }
}
