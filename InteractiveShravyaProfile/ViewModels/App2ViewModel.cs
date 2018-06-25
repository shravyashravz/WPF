using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class App2ViewModel : BaseViewModel, IScreen
    {
        public string ScreenName => ScreenNames.App2Screen;

        public void OnScreenActivated()
        {
            //  throw new NotImplementedException();
        }

        public void OnScreenDeactivated()
        {
            //throw new NotImplementedException();
        }

        private string _contextName = "app2 me";

        public string ContextName
        {
            get { return _contextName; }
            set { _contextName = value; }
        }
    }
}
