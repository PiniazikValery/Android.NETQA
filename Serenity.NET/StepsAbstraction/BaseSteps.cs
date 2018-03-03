using Serenity.NET.PageObjectAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Serenity.NET.StepsAbstraction
{
    public abstract class BaseSteps
    {
        protected void WaitLoadingPage()
        {
            PageObject page=null;            
            var bindingFlags = BindingFlags.Instance |
                   BindingFlags.NonPublic |
                   BindingFlags.Public;
            foreach (var field in GetType().GetFields(bindingFlags))
            {                
                    if (field.FieldType.IsSubclassOf(typeof(PageObject)))
                    {
                        page = (PageObject)field.GetValue(this);
                    }                
            }
            page.WaitPageLoading();
        }
    }
}
