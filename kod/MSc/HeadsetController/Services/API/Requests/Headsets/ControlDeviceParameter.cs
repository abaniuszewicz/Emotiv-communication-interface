using HeadsetController.Services.API.Utils;

namespace HeadsetController.Services.API.Requests.Headsets
{
    public class ControlDeviceParameter
    {
        public string command { get; }
        public string headset { get; set; }
        private object mappings { get; set; }

        public ControlDeviceParameter(Enums.CommandEnum command)
        {
            this.command = command.ToString();
        }
    }
}