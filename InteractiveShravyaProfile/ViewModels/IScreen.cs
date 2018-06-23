using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public interface IScreen

    {
        string ScreenName
        { get; }

        void OnScreenActivated();
        void OnScreenDeactivated();
    }
}
