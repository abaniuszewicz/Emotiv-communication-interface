using System;

namespace HeadsetController.Services.Communication.Requests
{
    public class ControlBluetoothHeadsetRequest : Request
    {
        public override string Method { get; } = "controlBluetoothHeadset";

        public ControlBluetoothHeadsetRequest(int id) : base(id)
        {
            throw new NotImplementedException("This request is only for use with macOS.");
        }
    }
}