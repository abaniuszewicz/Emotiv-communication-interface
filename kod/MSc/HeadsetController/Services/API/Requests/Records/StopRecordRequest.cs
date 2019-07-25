namespace HeadsetController.Services.API.Requests.Records
{
    public class StopRecordRequest : Request
    {
        public override string method { get; } = "stopRecord";
        public StopRecordParameter @params { get; }

        public StopRecordRequest(StopRecordParameter parameter)
        {
            @params = parameter;
        }
    }
}
