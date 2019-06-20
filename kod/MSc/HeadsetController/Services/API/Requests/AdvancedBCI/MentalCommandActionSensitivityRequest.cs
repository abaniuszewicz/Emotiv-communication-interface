namespace HeadsetController.Services.API.Requests.AdvancedBCI
{
    public class MentalCommandActionSensitivityRequest : Request
    {
        public override string method { get; } = "mentalCommandActionSensitivity";
        public MentalCommandActionSensitivityParameter @params { get; }

        public MentalCommandActionSensitivityRequest(int id, MentalCommandActionSensitivityParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}
