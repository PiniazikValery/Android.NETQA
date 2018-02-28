using NUnit.Framework;
using Serenity.Drivers;
using Serenity.StepsAbstraction;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;


namespace Serenity.TestCaseAbstraction
{
    [TestFixture]
    public class BaseTestCase
    {
        [OneTimeSetUp]
        public void BeforeAllTests()
        {
            Driver.InitDriver();
            InitSteps();
        }
        [OneTimeTearDown]
        public void AfterAllTests()
        {
            Driver.Close();
        }
        private void InitSteps()
        {
            var bindingFlags = BindingFlags.Instance |
                 BindingFlags.NonPublic |
                 BindingFlags.Public;
            var stepsFields = GetType().GetFields(bindingFlags);
            foreach (var field in stepsFields)
            {
                if (field.FieldType.IsSubclassOf(typeof(BaseSteps)))
                {
                    field.SetValue(this, Activator.CreateInstance(field.FieldType));
                }
            }
        }
    }
}

