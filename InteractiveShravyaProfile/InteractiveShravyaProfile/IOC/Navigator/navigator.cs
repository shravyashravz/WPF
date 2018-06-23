using InteractiveShravyaProfile.IOC.Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace InteractiveShravyaProfile.IOC.Navigator
{
   public class Navigator : INavigator
    {
        private List<IScreen> _screenList;
        public BaseViewModel GetInitialViewModel()
        {
            return GetViewModelByName(ScreenNames.ResumeScreen);
        }

        public BaseViewModel GetViewModelByName(string viewModelName)
        {
           if (_screenList == null)
            {
                _screenList = FindScreens().ToList();
            }
            var result = _screenList.FirstOrDefault(b => b.ScreenName == viewModelName);
            if (result == null)
            {
                throw new ArgumentException($"Failed to Navigate to '{viewModelName}'");
            }
            return (BaseViewModel)result;
        }

        private static IEnumerable<IScreen> FindScreens()
        {
            Type customType = typeof(BaseViewModel);
            var extendedType = Assembly.GetAssembly(customType).GetTypes()
                .Where(a => a.GetInterfaces()
                .Contains(typeof(IScreen)) &&
                !a.Name.Contains("Fake"));

            foreach(Type type in extendedType)
            {
                yield return (IScreen)IocKernel.Get(type);
            }
        }
    }
}
