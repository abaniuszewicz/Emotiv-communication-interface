namespace HeadsetController.Services.API.Requests.Records
{
    public class GetRecordInfosRequest : Request
    {
        public override string method { get; } = "getRecordInfos";
        public GetRecordInfosParameter @params { get; }

        public GetRecordInfosRequest(GetRecordInfosParameter parameter)
        {
            @params = parameter;
        }
    }
}
