using InteractiveShravyaProfile.IOC.Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace InteractiveShravyaProfile.IOC.ViewModelLocator
{
   public class ViewModelLocator
    {
        public MainViewModel MainViewModel
        {
            get
            {
                return IocKernel.Get<MainViewModel>();
            }
        }
        public ResumeViewModel ResumeViewModel
        {
            get
            {
                return IocKernel.Get<ResumeViewModel>();
            }
        }

        public App1ViewModel App1ViewModel
        {
            get
            {
                return IocKernel.Get<App1ViewModel>();
            }
        }

        public App2ViewModel App2ViewModel
        {
            get
            {
                return IocKernel.Get<App2ViewModel>();
            }
        }


        public HelpViewModel HelpViewModel
        {
            get
            {
                return IocKernel.Get<HelpViewModel>();
            }
        }

    }

}
