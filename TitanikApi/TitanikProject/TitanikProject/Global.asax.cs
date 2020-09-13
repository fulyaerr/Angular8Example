using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Titanik.Core;
using Titanik.Repository;
using Titanik.Repository.Interfaces;
using Titanik.Service;
using Titanik.Service.Interfaces;

namespace TitanikProject
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            GlobalConfiguration.Configuration.DependencyResolver = new NinjectDependencyResolver(CreateKernel());
        }

        private IKernel CreateKernel()
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<IUserRepository>().To<UserRepository>();
            kernel.Bind<IUser>().To<User>();


            return kernel;
        }
    }
}
