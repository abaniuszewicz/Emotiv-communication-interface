namespace HeadsetController.Services.API.Requests
{
    public abstract class Request : IRequest
    {
        public int id { get; }
        public string jsonrpc { get; } = "2.0";
        public abstract string method { get; }


        protected Request(int id)
        {
            this.id = id;
        }
    }
}
