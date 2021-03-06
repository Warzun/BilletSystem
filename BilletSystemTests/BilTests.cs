﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystem.Tests
{
    [TestClass()]
    public class BilTests
    {
        [TestMethod()]
        public void prisTest()
        {
            var bil = new Bil();
            int pris = bil.pris();
            Assert.AreEqual(240,pris);
        }

        [TestMethod()]
        public void køretøjTest()
        {
            var bil = new Bil();
            string køretøj = bil.Køretøj();
            Assert.AreEqual("Bil", køretøj);
        }
    }
}