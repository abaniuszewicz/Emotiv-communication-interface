namespace HeadsetController.Services.API.Requests.Headsets
{
    public class ControlDeviceRequest : Request
    {
        public override string method { get; } = "controlDevice";
        public ControlDeviceParameter @params { get; }

        public ControlDeviceRequest(int id, ControlDeviceParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}
