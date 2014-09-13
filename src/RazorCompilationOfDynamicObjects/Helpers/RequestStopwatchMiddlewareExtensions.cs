using System.Collections.Generic;
using System.Web;

namespace RazorCompilationOfDynamicObjects.Helpers
{
    public static class RequestStopwatchMiddlewareExtensions
    {
        public static List<RequestStopwatchLog> GetRequestStopwatchLogs(this HttpRequestBase request)
        {
            return request.GetOwinContext().Get<List<RequestStopwatchLog>>(RequestStopwatchMiddleware.RequestStopwatchLogKey);
        }
    }
}