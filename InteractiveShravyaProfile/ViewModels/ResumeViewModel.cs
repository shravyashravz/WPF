using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
  public class ResumeViewModel : BaseViewModel, IScreen
    {
        public string ScreenName => ScreenNames.ResumeScreen;

        public void OnScreenActivated()
        {
           // throw new NotImplementedException();
        }

        public void OnScreenDeactivated()
        {
            throw new NotImplementedException();
        }

        private string _contextName="shravya's resume";

        public string ContextName
        {
            get { return _contextName="shravya's resume"; }
            set { _contextName = value; }
        }

    }
}
