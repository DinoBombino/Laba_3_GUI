using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba_3_GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Laba_3_GUI.Tests
{
    [TestClass()]
    public class QuantityTests
    {
        [TestMethod()]
        public void Adding_the_same_values() //сложение одинаковых величин
        {
            var num1 = new Quantity(3, MeasureOfType.l);
            var num2 = new Quantity(4, MeasureOfType.l);
            Quantity result = num1 + num2;
            Assert.AreEqual("7 л", result.OutputOfTheValue());
        }

        [TestMethod()]
        public void Subtraction_the_same_values() //вычитание одинаковых величин
        {
            var num1 = new Quantity(13, MeasureOfType.ml);
            var num2 = new Quantity(4, MeasureOfType.ml);
            Quantity result = num1 - num2;
            Assert.AreEqual("9 мл", result.OutputOfTheValue());
        }

        [TestMethod()]
        public void Adding_the_different_values()   //сложение разных величин
        {
            var num1 = new Quantity(3, MeasureOfType.l);
            var num2 = new Quantity(400, MeasureOfType.ml);
            Quantity result = num1 + num2;
            Assert.AreEqual("3,4 л", result.OutputOfTheValue());
        }

        [TestMethod()]
        public void Adding_the_different_values2()   //сложение разных величин, но вывод в третьей величине
        {
            var num1 = new Quantity(3, MeasureOfType.l);
            var num2 = new Quantity(400, MeasureOfType.ml);
            Quantity result = num1 + num2;
            result = result.To(MeasureOfType.m3);
            Assert.AreEqual("0,0034 м3", result.OutputOfTheValue());
        }

        [TestMethod()]
        public void Subtraction_the_different_values() //вычитание разных величин
        {
            var num1 = new Quantity(1, MeasureOfType.b);
            var num2 = new Quantity(40, MeasureOfType.l);
            Quantity result = num1 - num2;
            Assert.AreEqual("0,99965408 б", result.OutputOfTheValue());
        }

        [TestMethod()]
        public void Subtraction_the_different_values2() //вычитание разных величин, но вывод в третьей величине
        {
            var num1 = new Quantity(1, MeasureOfType.b);
            var num2 = new Quantity(40, MeasureOfType.l);
            Quantity result = num1 - num2;
            result = result.To(MeasureOfType.m3);
            Assert.AreEqual("115,59367252543942 м3", result.OutputOfTheValue());
        }

        [TestMethod()]
        public void Addition_and_multiplication() //сложение и умножение
        {
            var num1 = new Quantity(3, MeasureOfType.l);
            var num2 = new Quantity(400, MeasureOfType.ml);
            int mul = 3;
            Quantity result = num1 + num2;
            result *= mul;
            result = result.To(MeasureOfType.l);
            Assert.AreEqual("10,2 л", result.OutputOfTheValue());
        }

        [TestMethod()]
        public void Subtraction_and_multiplication()//вычитание и умножение
        {
            var num1 = new Quantity(3, MeasureOfType.l);
            var num2 = new Quantity(400, MeasureOfType.ml);
            int mul = 2;
            Quantity result = num1 - num2;
            result *= mul;
            result = result.To(MeasureOfType.l);
            Assert.AreEqual("5,2 л", result.OutputOfTheValue());
        }
    }
}
