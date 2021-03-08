using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using System.Reflection;
using SimpleInjector.Integration.Web.Mvc;
using WebApplication_test.Interfaces;
using WebApplication_test.Classes;

namespace WebApplication_test
{
	public class WebApiApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			GlobalConfiguration.Configure(WebApiConfig.Register);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);

			var container = new Container();
			container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
			//injection av klasser
			//container.Register<IBookService, SixtensBookService>();
			container.Register<IBookService, BookService>();

			container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
			container.Verify();
			DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
		}
	}
}
