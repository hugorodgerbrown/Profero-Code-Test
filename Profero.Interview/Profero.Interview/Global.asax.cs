using System;
using System.Web.Mvc;
using System.Web.Routing;
using Profero.Interview.Business.Core;
using Profero.Interview.IoC;

namespace Profero.Interview
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WindsorControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return ObjectFactory.GetObject<IController>(controllerType);
        }

        public override void ReleaseController(IController controller)
        {
            ObjectFactory.Release(controller);
        }
    }

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            ObjectFactory.WindsorContainer.Install(new WindsorInstaller());

            ControllerBuilder.Current.SetControllerFactory(typeof(WindsorControllerFactory));

            AreaRegistration.RegisterAllAreas();

            RegisterRoutes(RouteTable.Routes);
        }
    }
}