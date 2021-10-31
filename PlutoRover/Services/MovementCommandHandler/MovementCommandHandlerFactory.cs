using PlutoRover.Common;
using PlutoRover.Models;
using PlutoRover.Services.CommandHandlers;
using PlutoRover.Services.MovementCommandHandler.Exceptions;
using PlutoRover.Services.RoverTranslateService;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlutoRover.Services.MovementCommandHandler
{
    public class MovementCommandHandlerFactory : IMovementCommandHandlerFactory
    {
        private readonly IRoverTranslateService _roverTranslateService;
        public MovementCommandHandlerFactory(IRoverTranslateService roverTranslateService)
        {
            _roverTranslateService = roverTranslateService;
        }

        public void Execute(char command, RoverLocation roverLocation)
        {
            if (!(new List<char> { 'F', 'B', 'L', 'R' }).Contains(command))
            {
                throw new InvalidCommandException();
            }

            var movementCommand = (MovementCommand)command;

            ICommandHandler commandHandler = null;
            if (movementCommand == MovementCommand.Forward)
            {
                commandHandler = new ForwardCommandHandler(_roverTranslateService);
            }

            if (movementCommand == MovementCommand.Backward)
            {
                commandHandler = new BackwardCommandHandler(_roverTranslateService);
            }

            if (movementCommand == MovementCommand.Right)
            {
                commandHandler = new RightCommandHandler();
            }

            if (movementCommand == MovementCommand.Left)
            {
                commandHandler = new LeftCommandHandler();
            }

            commandHandler.execute(roverLocation);

        }
    }
}
