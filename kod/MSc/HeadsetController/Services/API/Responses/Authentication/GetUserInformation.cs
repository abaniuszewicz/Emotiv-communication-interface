using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.Authentication
{
    public class GetUserInformation : IResult
    {
        public string username { get; }
        public string firstName { get; }
        public string lastName { get; }
        public object licenseAgreement { get; }

        [JsonConstructor]
        private GetUserInformation(string username, string firstName, string lastName, object licenseAgreement)
        {
            this.username = username;
            this.firstName = firstName;
            this.lastName = lastName;
            this.licenseAgreement = licenseAgreement;
        }
    }
}