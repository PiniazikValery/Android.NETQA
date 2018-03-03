using PostSharp.Aspects;
using PostSharp.Serialization;

namespace Serenity.Filters
{
    [PSerializable]
    public class Step : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
           
        }

        public override void OnExit(MethodExecutionArgs args)
        {
           
        }

        public override void OnException(MethodExecutionArgs args)
        {
            
        }
    }
}
