namespace HeadsetController.Services.API.Requests.Markers
{
    public class InjectMarkerRequest : Request
    {
        public override string method { get; } = "injectMarker";
        public InjectMarkerParameter @params { get; }

        public InjectMarkerRequest(int id, InjectMarkerParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}
