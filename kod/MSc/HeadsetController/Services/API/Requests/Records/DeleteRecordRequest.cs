namespace HeadsetController.Services.API.Requests.Records
{
    public class DeleteRecordRequest : Request
    {
        public override string method { get; } = "deleteRecord";
        public DeleteRecordParameter @params { get; }

        public DeleteRecordRequest(int id, DeleteRecordParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}
