using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace InteractiveShravyaProfile.IOC.Navigator
{
    public interface INavigator
    {
        BaseViewModel GetViewModelByName(string viewModelName);
        BaseViewModel GetInitialViewModel();
    }
}
