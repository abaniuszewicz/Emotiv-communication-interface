namespace HeadsetController.Services.API.Requests.Records
{
    public class UpdateRecordRequest : Request
    {
        public override string method { get; } = "updateRecord";
        public UpdateRecordParameter @params { get; }

        public UpdateRecordRequest(UpdateRecordParameter parameter)
        {
            @params = parameter;
        }
    }
}
