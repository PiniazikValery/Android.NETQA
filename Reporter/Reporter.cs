using System.Diagnostics;

namespace AndroidReporter
{
    public class Reporter
    {        
        public string CurrentPage { get; set; }
        public void StepComplite()
        {
            StackTrace stackTrace = new StackTrace();           
            var methodName= stackTrace.GetFrame(1).GetMethod().Name;            
        }
    }
}
