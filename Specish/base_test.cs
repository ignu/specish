using System;
using NUnit.Framework;

namespace Specish
{    
    public class base_test
    {        
        [TestFixtureSetUp]
        public void TestFixtureSetup()
        {
            establish_context();
            because();
        }

        /// <summary>
        /// Set up infrastructure.
        /// In AAA syntax, this is Arrange
        /// </summary>
        protected virtual void establish_context() {}

        /// <summary>
        /// This is why we the asserts are true.  
        /// In AAA syntax, this is the Act.
        /// </summary>
        protected virtual void because() {}

        
        /// <summary>
        /// Perform an action before each test
        /// </summary>
        [SetUp]
        public virtual void before_each()
        {
        }
        
        /// <summary>
        /// Perform an action after the last test.
        /// </summary>
        [TestFixtureTearDown]
        public virtual void after_last()
        {

        }

        /// <summary>
        /// Perform an action after the last test.
        /// </summary>
        [TearDown]
        public virtual void after_each()
        {
        }
    }
}
