namespace HeadsetController.Services.API.Utils
{
    public class Enums
    {
        #region Parameter

        public enum StatusUpdateEnum { active, close }
        public enum StatusCreateEnum { open, active }
        public enum StatusSetupEnum { create, load, unload, save, rename, delete }
        public enum StatusGetSetEnum { get, set }
        public enum CommandEnum { connect, disconnect, refresh }
        public enum StreamsEnum { eeg, mot, dev, pow, met, com, fac, sys }
        public enum DetectionEnum { mentalCommand, facialExpression }
        public enum RecordFormatEnum { EDF, CSV }

        #endregion

        #region Objects

        public enum StatusHeadsetEnum { discovered, connecting, connected }
        public enum StatusSessionEnum { opened, activated, closed }
        public enum ConnectedByHeadsetEnum { bluetooth, dongle, usb_cable, extender }

        #endregion
    }
}
