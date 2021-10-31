namespace PlutoRover.Infrustructures.Exceptions
{
    public interface IApplicationException
    {
        int GetCode();
        string GetMessage();
    }
}
