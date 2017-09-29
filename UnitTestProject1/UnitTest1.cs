using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = DatabaseTestLoader.Load();

            Assert.IsTrue(result);

            //TODO:  Database is now deployed, can perform integration test here ...
        }
    }
}
