using AutoMapper;
using InteractiveShravyaProfile.IOC.Navigator;
using Models.Interfaces;
using Models.Models;
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

            //Binding Models and Interfaces
            Bind<IResumeModel>().To<ResumeModel>().InSingletonScope();
            Bind<IApp1Model>().To<App1Model>().InSingletonScope();


            //Binding ViewModels to self
            Bind<MainViewModel>().ToSelf().InSingletonScope();
            Bind<ResumeViewModel>().ToSelf().InSingletonScope();
            Bind<App1ViewModel>().ToSelf().InSingletonScope();
            Bind<App2ViewModel>().ToSelf().InSingletonScope();
            Bind<HelpViewModel>().ToSelf().InSingletonScope();

            
        }
    }
}
