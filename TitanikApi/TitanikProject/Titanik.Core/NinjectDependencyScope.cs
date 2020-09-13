using Ninject;
using Ninject.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Dependencies;

namespace Titanik.Core
{
    public class NinjectDependencyScope : IDependencyScope
    {
        IResolutionRoot resolver;
        public NinjectDependencyScope(IResolutionRoot resolver) 
        {
            this.resolver = resolver;
        }

        public void Dispose()
        {
            IDisposable disposable = resolver as IDisposable;
            if (disposable != null)
            {
                disposable.Dispose();
            }

            resolver = null;
        }

        public object GetService(Type serviceType)
        {
            if(resolver == null)
            {
                throw new Exception("This scope has been disposable");
            }

            return resolver.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            if(resolver == null)
            {
                throw new Exception("This scope has been disposable");
            }

            return resolver.GetAll(serviceType);
        }
    }
}
