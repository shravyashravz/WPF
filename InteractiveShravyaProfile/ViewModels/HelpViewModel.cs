using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class HelpViewModel : BaseViewModel, IScreen
    {
        public string ScreenName => ScreenNames.HelpScreen;

        public void OnScreenActivated()
        {
          //  throw new NotImplementedException();
        }

        public void OnScreenDeactivated()
        {
            throw new NotImplementedException();
        }

        private string _contextName="Video Documentation to speed up things.";

        public string ContextName
        {
            get { return _contextName; }
            set { _contextName = value; }
        }

      
    }
}
