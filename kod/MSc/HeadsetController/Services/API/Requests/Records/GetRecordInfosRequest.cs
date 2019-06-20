namespace HeadsetController.Services.API.Requests.Records
{
    public class GetRecordInfosRequest : Request
    {
        public override string method { get; } = "getRecordInfos";
        public GetRecordInfosParameter @params { get; }

        public GetRecordInfosRequest(int id, GetRecordInfosParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}
