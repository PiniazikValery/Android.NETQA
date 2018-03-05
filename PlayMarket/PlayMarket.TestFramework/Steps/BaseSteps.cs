using PlayMarket.Reporter.Reporters;
using PlayMarket.TestFramework.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace PlayMarket.TestFramework.Steps
{
    public abstract class BaseSteps
    {                
        public string PageName { get; private set; }        

        public void WaitLoadingPage()
        {              
            var bindingFlags = BindingFlags.Instance |
                   BindingFlags.NonPublic |
                   BindingFlags.Public;
            var test = GetType().GetFields(bindingFlags).Where(field => field.FieldType.IsSubclassOf(typeof(PageObject))).Count();
            if (GetType().GetFields(bindingFlags).Where(field=>field.FieldType.IsSubclassOf(typeof(PageObject))).Count()>1)
            {
                throw new Exception("Steps must have only one PageObject");
            }
            foreach (var field in GetType().GetFields(bindingFlags))
            {
                if (field.FieldType.IsSubclassOf(typeof(PageObject)))
                {
                    ((PageObject)field.GetValue(this)).WaitPageLoading();
                    PageName = field.FieldType.Name;
                    break;
                }
            }            
        }
    }
}
