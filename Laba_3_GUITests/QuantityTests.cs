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

        [TestMethod()]
        public void AddNumberTest()
        {
            var quantity = new Quantity(1, MeasureOfType.m3);
            quantity = quantity + 4.25;
            Assert.AreEqual("5,25 м3", quantity.OutputOfTheValue());
        }

        [TestMethod()]
        public void SubNumberTest()
        {
            var quantity = new Quantity(3, MeasureOfType.m3);
            quantity = quantity - 1.75;
            Assert.AreEqual("1,25 м3", quantity.OutputOfTheValue());
        }

        [TestMethod()]
        public void MulByNumberTest()
        {
            var quantity = new Quantity(3, MeasureOfType.m3);
            quantity = quantity * 3;
            Assert.AreEqual("9 м3", quantity.OutputOfTheValue());
        }

        [TestMethod()]
        public void DivByNumberTest()
        {
            var quantity = new Quantity(3, MeasureOfType.m3);
            quantity = quantity / 3;
            Assert.AreEqual("1 м3", quantity.OutputOfTheValue());
        }

        [TestMethod()]
        public void MeterToAnyTest()
        {
            Quantity quantity;

            quantity = new Quantity(1000, MeasureOfType.m3);
            Assert.AreEqual("1 мл", quantity.To(MeasureOfType.ml).OutputOfTheValue());

            quantity = new Quantity(149597870700 * 2, MeasureOfType.m3);
            Assert.AreEqual("2 л", quantity.To(MeasureOfType.l).OutputOfTheValue());

            quantity = new Quantity(3 * 3.0856776 * Math.Pow(10, 16), MeasureOfType.m3);
            Assert.AreEqual("3 б", quantity.To(MeasureOfType.b).OutputOfTheValue());
        }
    }
}