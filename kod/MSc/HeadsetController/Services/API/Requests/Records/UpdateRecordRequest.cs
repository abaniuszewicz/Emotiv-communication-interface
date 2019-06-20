namespace HeadsetController.Services.API.Requests.Records
{
    public class UpdateRecordRequest : Request
    {
        public override string method { get; } = "updateRecord";
        public UpdateRecordParameter @params { get; }

        public UpdateRecordRequest(int id, UpdateRecordParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}
