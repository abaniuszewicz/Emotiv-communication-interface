using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace VirtualKeyboard.ViewModels
{
    public class AboutViewModel : PropertyChangedBase
    {
        public string Name => "About";
        public string Purpose => "This application serves as virtual keyboard - a keyboard that doesn't need physical keys to provide its input. Instead, to provide an interaction, it uses Emotiv Insight device, a headset that was designed for Brain-Computer Interfacing (BCI).";
        public string Author => "Application was created by Adam Baniuszewicz, student of Information and Communication Technology (ICT) at West Pomeranian University of Technology Szczecin, Faculty of Electrical Engineering.";

        public void GitHub()
        {
            Process.Start("https://github.com/abaniuszewicz");
        }

        public void Email()
        {
            Process.Start("mailto:abaniuszewicz@gmail.com");
        }
    }
}
