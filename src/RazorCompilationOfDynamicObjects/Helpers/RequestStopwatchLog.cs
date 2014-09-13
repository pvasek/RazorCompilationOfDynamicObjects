namespace RazorCompilationOfDynamicObjects.Helpers
{
    public class RequestStopwatchLog
    {
        public RequestStopwatchLog(string path, long timeMs)
        {
            Path = path;
            TimeMs = timeMs;
        }

        public string Path { get; private set; }
        public long TimeMs { get; private set; }
    }
}