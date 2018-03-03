using Framework.Drivers;
using Framework.StepsAbstraction;
using NUnit.Framework;
using System;
using System.Reflection;


namespace Framework.TestCaseAbstraction
{
    [TestFixture]
    public class TestCase
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
                    field.SetValue(this, Activator.CreateInstance((dynamic)field.FieldType));
                }
            }
        }
    }
}

