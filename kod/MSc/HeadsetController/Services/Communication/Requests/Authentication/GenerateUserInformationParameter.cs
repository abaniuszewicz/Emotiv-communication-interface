namespace HeadsetController.Services.Communication.Requests.Authentication
{
    public class GenerateUserInformationParameter
    {
        public string cortexToken { get; set; }

        public GenerateUserInformationParameter(string cortexToken)
        {
            this.cortexToken = cortexToken;
        }
    }
}