namespace HeadsetController.Services.API.Requests
{
    public abstract class Request : IRequest
    {
        private static int _id;

        public int id { get; } = _id++;
        public string jsonrpc { get; } = "2.0";
        public abstract string method { get; }
    }
}
