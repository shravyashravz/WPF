using AutoMapper;
using InteractiveShravyaProfile.IOC.Navigator;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace InteractiveShravyaProfile.IOC.Ninject
{
    public class DependencyInjection:NinjectModule
    {
        public override void Load()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });


            Bind<INavigator>().To<Navigator.Navigator>();




            Bind<MainViewModel>().ToSelf().InSingletonScope();
            Bind<ResumeViewModel>().ToSelf().InSingletonScope();
            Bind<HelpViewModel>().ToSelf().InSingletonScope();

            // Bind<IResume>().To<ResumeModel>().InSingletonScope();
        }
    }
}
