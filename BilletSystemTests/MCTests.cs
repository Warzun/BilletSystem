using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystem.Tests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void PrisTest()
        {
            var MC = new MC();
            int pris = MC.pris();
            Assert.AreEqual(125,pris);
        }

        [TestMethod()]
        public void KøretøjTest()
        {
            var MC = new MC();
            string køretøj = MC.Køretøj();
            Assert.AreEqual("MC",køretøj);
        }
    }
}