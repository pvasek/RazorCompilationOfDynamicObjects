using RazorCompilationOfDynamicObjects.Helpers;
using Microsoft.Owin;
using Owin;
using AppFunc = System.Func<System.Collections.Generic.IDictionary<string, object>, System.Threading.Tasks.Task>; 

[assembly: OwinStartupAttribute(typeof(RazorCompilationOfDynamicObjects.Startup))]
namespace RazorCompilationOfDynamicObjects
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)        
        {

            app.Use(typeof(RequestStopwatchMiddleware));
        }
    }
}
