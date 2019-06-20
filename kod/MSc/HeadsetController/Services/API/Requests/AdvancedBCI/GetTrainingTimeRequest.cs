namespace HeadsetController.Services.API.Requests.AdvancedBCI
{
    public class GetTrainingTimeRequest : Request
    {
        public override string method { get; } = "getTrainingTime";
        public GetTrainingTimeParameter @params { get; }

        public GetTrainingTimeRequest(int id, GetTrainingTimeParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}
