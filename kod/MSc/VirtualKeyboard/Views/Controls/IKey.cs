using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace VirtualKeyboard.Views.Controls
{
    public interface IKey
    {
        string Key { get; set; }
        bool IsSelected { get; set; }
        void MoveFocus(FocusNavigationDirection direction);
    }
}
