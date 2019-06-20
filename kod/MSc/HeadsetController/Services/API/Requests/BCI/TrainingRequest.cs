namespace HeadsetController.Services.API.Requests.BCI
{
    public class TrainingRequest : Request
    {
        public override string method { get; } = "training";
        public TrainingParameter @params { get; }

        public TrainingRequest(int id, TrainingParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}
