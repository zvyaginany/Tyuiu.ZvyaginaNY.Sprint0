using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZvyaginaNY.Sprint0.Task2.V0.Lib;
namespace Tyuiu.ZvyaginaNY.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Надя";
            var res = DataService.GetMessage(name);


            Assert.AreEqual("Привет, Надя", res);

        }
    }
}
