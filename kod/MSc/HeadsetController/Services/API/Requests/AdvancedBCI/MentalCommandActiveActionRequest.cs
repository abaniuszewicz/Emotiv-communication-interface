namespace HeadsetController.Services.API.Requests.AdvancedBCI
{
    public class MentalCommandActiveActionRequest : Request
    {
        public override string method { get; } = "mentalCommandActiveAction";
        public MentalCommandActiveActionParameter @params { get; }

        public MentalCommandActiveActionRequest(int id, MentalCommandActiveActionParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}
