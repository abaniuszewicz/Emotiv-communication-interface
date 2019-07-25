namespace HeadsetController.Services.API.Requests.Records
{
    public class DeleteRecordRequest : Request
    {
        public override string method { get; } = "deleteRecord";
        public DeleteRecordParameter @params { get; }

        public DeleteRecordRequest(DeleteRecordParameter parameter)
        {
            @params = parameter;
        }
    }
}
