using PlutoRover.Infrustructures.Exceptions;
using System.Net;

namespace PlutoRover.Services.MovementCommandHandler.Exceptions
{
    public class InvalidCommandException : ApplicationException
    {
        public InvalidCommandException() :
            base((int)HttpStatusCode.BadRequest, "Command is Invalid.")
        {
        }
    }

}
