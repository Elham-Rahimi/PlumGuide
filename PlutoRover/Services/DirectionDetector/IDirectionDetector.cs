using PlutoRover.Common;

namespace PlutoRover.Services.DirectionDetector
{
    public interface IDirectionDetector
    {
        Direction Get(string direction, string command);
    }
}