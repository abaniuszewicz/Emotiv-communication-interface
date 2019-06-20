namespace HeadsetController.Services.API.Requests.Records
{
    public class StopRecordRequest : Request
    {
        public override string method { get; } = "stopRecord";
        public StopRecordParameter @params { get; }

        public StopRecordRequest(int id, StopRecordParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}
