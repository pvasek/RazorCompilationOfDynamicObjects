using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.Owin;

namespace RazorCompilationOfDynamicObjects.Helpers
{
    public class RequestStopwatchMiddleware : OwinMiddleware
    {
        public RequestStopwatchMiddleware(OwinMiddleware next) : base(next)
        {
        }

        private readonly List<RequestStopwatchLog> _logs = new List<RequestStopwatchLog>();
        public const string RequestStopwatchLogKey = "requestStopwatchs";

        public async override Task Invoke(IOwinContext context)
        {
            var timewatch = Stopwatch.StartNew();
            context.Set(RequestStopwatchLogKey, GetLogs());
            await Next.Invoke(context);
            timewatch.Stop();
            lock (_logs)
            {
                _logs.Add(new RequestStopwatchLog(context.Request.Path.ToString(), timewatch.ElapsedMilliseconds));
            }
        }

        private List<RequestStopwatchLog> GetLogs()
        {
            lock (_logs)
            {
                return new List<RequestStopwatchLog>(_logs);
            }
        }
    }
}