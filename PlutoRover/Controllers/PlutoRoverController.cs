using Microsoft.AspNetCore.Mvc;
using PlutoRover.Common;
using PlutoRover.Models;
using PlutoRover.Services.DirectionDetector;
using PlutoRover.Services.TransportCommandHandler;

namespace PlutoRover.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PlutoRoverController : ControllerBase
    {
        private readonly ITransportCommandHandler _transportCommandHandler;

        public PlutoRoverController(ITransportCommandHandler transportCommandHandler)
        {
            _transportCommandHandler = transportCommandHandler;
        }

        [HttpGet]
        [Route("move")]
        public ActionResult<RoverLocation> Move(int x, int y, string direction, string commands)
        {
            var roverLocation = new RoverLocation(x, y, direction);
            foreach (var command in commands.ToCharArray())
            {
                _transportCommandHandler.Execute(roverLocation, command.ToString());
            }

            return Ok(roverLocation);
        }
    }
}
