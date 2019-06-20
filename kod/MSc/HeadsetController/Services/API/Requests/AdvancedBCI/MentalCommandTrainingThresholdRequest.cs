namespace HeadsetController.Services.API.Requests.AdvancedBCI
{
    public class MentalCommandTrainingThresholdRequest : Request
    {
        public override string method { get; } = "mentalCommandTrainingThreshold";
        public MentalCommandTrainingThresholdParameter @params { get; }

        public MentalCommandTrainingThresholdRequest(int id, MentalCommandTrainingThresholdParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}
