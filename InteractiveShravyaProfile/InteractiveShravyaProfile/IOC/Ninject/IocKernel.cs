using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveShravyaProfile.IOC.Ninject
{
     public static class IocKernel
    {
        private static StandardKernel _kernel;

        public static T Get<T>()
        {
            return _kernel.Get<T>();
        }

        public static object Get(Type type)
        {
            try
            {
                return _kernel.Get(type);
            }
            catch(ActivationException exception)
            {
                throw new Exception("Invalid Type", exception);

            }
        }

        public static void Initialize(params INinjectModule[] modules)
        {
            if (_kernel == null)
            {
                _kernel = new StandardKernel(modules);
            }
        }
    }
}
