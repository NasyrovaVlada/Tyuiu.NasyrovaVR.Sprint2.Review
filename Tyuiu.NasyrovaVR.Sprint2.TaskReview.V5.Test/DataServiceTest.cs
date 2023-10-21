using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NasyrovaVR.Sprint2.TaskReview.V5.Lib;

namespace Tyuiu.NasyrovaVR.Sprint2.TaskReview.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0.5;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
