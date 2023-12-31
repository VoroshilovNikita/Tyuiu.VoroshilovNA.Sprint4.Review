﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VoroshilovNA.Sprint4.Review.V27.Lib;

namespace Tyuiu.VoroshilovNA.Sprint4.Review.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int n = 4;
            int m = 3;
            int[,] mas = new int[n, m];
            string str = "583197256891";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
