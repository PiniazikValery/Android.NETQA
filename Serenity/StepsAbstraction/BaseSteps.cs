using AndroidReporter;
using Framework.PageObjectAbstraction;
using System.Dynamic;
using System.Linq.Expressions;
using System.Reflection;

namespace Framework.StepsAbstraction
{
    public abstract class BaseSteps
    {
        protected Reporter Report = new Reporter();        
    
        protected void WaitLoadingPage()
        {
            PageObject pageObject=null;
            var bindingFlags = BindingFlags.Instance |
                   BindingFlags.NonPublic |
                   BindingFlags.Public;
            foreach (var field in GetType().GetFields(bindingFlags))
            {                
                    if (field.FieldType.IsSubclassOf(typeof(PageObject)))
                    {
                        pageObject = (PageObject)field.GetValue(this);
                    }                
            }
            Report.CurrentPage = pageObject.GetType().Name;
            pageObject.WaitPageLoading();
        }       
    }
}
