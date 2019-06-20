namespace HeadsetController.Services.API.Requests
{
    public interface IRequest
    {
        string jsonrpc { get; }
        string method { get; }
        int id { get; }
    }
}
