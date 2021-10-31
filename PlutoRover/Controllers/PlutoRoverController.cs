using Microsoft.AspNetCore.Mvc;
using PlutoRover.Common;
using PlutoRover.Models;
using PlutoRover.Services.MovementCommandHandler;

namespace PlutoRover.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PlutoRoverController : ControllerBase
    {
        private readonly IMovementCommandHandlerFactory _movementCommandHandlerFactory;

        public PlutoRoverController(IMovementCommandHandlerFactory movementCommandHandlerFactory)
        {
            _movementCommandHandlerFactory = movementCommandHandlerFactory;
        }

        [HttpGet]
        [Route("move")]
        public ActionResult<RoverLocation> Move(int x, int y, char direction, string commands)
        {
            var roverLocation = new RoverLocation(x, y, (CardinalDirection)direction);

            foreach (var command in commands.ToCharArray())
            {
                _movementCommandHandlerFactory.Execute(command, roverLocation);
            }

            return Ok(roverLocation);
        }
    }
}
