using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZvyaginaNY.Sprint0.Task4.V0.Lib;

namespace Tyuiu.ZvyaginaNY.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
          
        }
        public void CheckedSubractionValid()
        {
            Assert.AreEqual(10, DataService.Subraction(10, 5));

        }
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(10, DataService.Multiplication(10, 5));

        }
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(10, DataService.Division(9, 3));

        }
    }
}
