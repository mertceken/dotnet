using System;
using _20191022_1_ClassLibary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringHandlingTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            StringHandling ObjString = new StringHandling();
            String rvalue = ObjString.concat("Mert", "Çeken");
            Assert.AreEqual("MertÇeken", rvalue);

        }
    }
}
