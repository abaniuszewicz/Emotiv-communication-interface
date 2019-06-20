namespace HeadsetController.Services.API.Requests.Records
{
    public class ExportRecordRequest : Request
    {
        public override string method { get; } = "exportRecord";
        public ExportRecordParameter @params { get; }

        public ExportRecordRequest(int id, ExportRecordParameter parameter) : base(id)
        {
            this.@params = parameter;
        }
    }
}
