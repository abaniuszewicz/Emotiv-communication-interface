namespace HeadsetController.Services.API.Requests.Records
{
    public class CreateRecordRequest : Request
    {
        public override string method { get; } = "createRecord";
        public CreateRecordParameter @params { get; }

        public CreateRecordRequest(int id, CreateRecordParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}
