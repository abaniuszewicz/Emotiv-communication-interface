namespace HeadsetController.Services.API.Requests.Markers
{
    public class UpdateMarkerRequest : Request
    {
        public override string method { get; } = "updateMarker";
        public UpdateMarkerParameter @params { get; }

        public UpdateMarkerRequest(UpdateMarkerParameter parameter)
        {
            @params = parameter;
        }
    }
}
