using InteractiveShravyaProfile.IOC.Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InteractiveShravyaProfile
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            IocKernel.Initialize(new DependencyInjection());
            base.OnStartup(e);
        }
    }
    
}
