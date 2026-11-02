using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.kulibaliM.sprint1.task0.V29.lib;
namespace Tyuiu.kulibaliM.sprint1.task0.V29.test
{
    [TestClass]
    public class DataServicetest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert .AreEqual(32, res);
        }
    }
}
