using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba_3_GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_3_GUI.Tests
{
    [TestClass()]
    public class QuantityTests
    {
        [TestMethod()]
        public void OutputOfTheValueTest()
        {
            var quantity = new Quantity(10, MeasureOfType.m3);
            Assert.AreEqual("10 м3", quantity.OutputOfTheValue());

            quantity = new Quantity(10, MeasureOfType.ml);
            Assert.AreEqual("10 мл", quantity.OutputOfTheValue());

            quantity = new Quantity(10, MeasureOfType.l);
            Assert.AreEqual("10 л", quantity.OutputOfTheValue());

            quantity = new Quantity(10, MeasureOfType.b);
            Assert.AreEqual("10 б", quantity.OutputOfTheValue());
        }
    }
}