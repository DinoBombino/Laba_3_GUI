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
        [TestMethod()]  //Четыре типа величин
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

        [TestMethod()]  //добавление числа к значение с величиной
        public void AddNumberTest()
        {
            var quantity = new Quantity(1, MeasureOfType.m3);
            quantity = quantity + 4.25;
            Assert.AreEqual("5,25 м3", quantity.OutputOfTheValue());
        }

        [TestMethod()]  //выичтание числа из значения с величиной
        public void SubNumberTest()
        {
            var quantity = new Quantity(3, MeasureOfType.m3);
            quantity = quantity - 1.75;
            Assert.AreEqual("1,25 м3", quantity.OutputOfTheValue());
        }

        [TestMethod()]  //умножение значения с величной на число
        public void MulByNumberTest()
        {
            var quantity = new Quantity(3, MeasureOfType.m3);
            quantity = quantity * 3;
            Assert.AreEqual("9 м3", quantity.OutputOfTheValue());
        }

        [TestMethod()]  //деление значения с величиной на число
        public void DivByNumberTest()
        {
            var quantity = new Quantity(3, MeasureOfType.m3);
            quantity = quantity / 3;
            Assert.AreEqual("1 м3", quantity.OutputOfTheValue());
        }

        [TestMethod()]  //Соответствие величин(например, 1л=1000мл)
        public void MeterToAnyTest()
        {
            Quantity quantity;

            quantity = new Quantity(1, MeasureOfType.m3);
            Assert.AreEqual("1000 мл", quantity.To(MeasureOfType.ml).OutputOfTheValue());

            quantity = new Quantity(1, MeasureOfType.m3);
            Assert.AreEqual("1 л", quantity.To(MeasureOfType.l).OutputOfTheValue());

            quantity = new Quantity(1, MeasureOfType.m3);
            Assert.AreEqual("0,008648 б", quantity.To(MeasureOfType.b).OutputOfTheValue());
        }

        [TestMethod()]  //Соответствие величин обратное(напрмиер, 1000мл=1л)
        public void AnyToMeterTest()
        {
            Quantity quantity;

            quantity = new Quantity(1000, MeasureOfType.ml);
            Assert.AreEqual("1 м3", quantity.To(MeasureOfType.m3).OutputOfTheValue());

            quantity = new Quantity(1, MeasureOfType.l);
            Assert.AreEqual("1 м3", quantity.To(MeasureOfType.m3).OutputOfTheValue());

            quantity = new Quantity(1, MeasureOfType.b);
            Assert.AreEqual("115,63367252543942 м3", quantity.To(MeasureOfType.m3).OutputOfTheValue());
        }

        [TestMethod()]  //сложение и вычитание из одной величины другую
        public void AddSubKmMetersTest()
        {
            var m3 = new Quantity(0.100, MeasureOfType.m3);
            var l = new Quantity(1, MeasureOfType.l);

            Assert.AreEqual("1,1 м3", (m3 + l).OutputOfTheValue());
            Assert.AreEqual("1,1 л", (l + m3).OutputOfTheValue());

            Assert.AreEqual("0,9 л", (l - m3).OutputOfTheValue());
            Assert.AreEqual("-0,9 м3", (m3 - l).OutputOfTheValue());
        }
    }
}