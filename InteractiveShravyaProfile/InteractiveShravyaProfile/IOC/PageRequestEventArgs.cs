using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveShravyaProfile.IOC
{
    public class PageRequestEventArgs : EventArgs
    {
        public string Parameter
        {
            get;
            private set;
        }

        public PageRequestEventArgs()
        {
        }
        public PageRequestEventArgs(string parameter) : this()
        {
            Parameter = parameter;
        }
    }

    public class PageChangeEventArgs : EventArgs
    {
        public string ScreenName
        { get; set; }
    }
}


