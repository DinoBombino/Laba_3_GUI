using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Мера объема, задаваемая в виде пары (значение, тип), допустимые типы: м^3, миллилитры, литры, баррель
-сложение
-вычитание
-умножение на число
-сравнение двух объемов
-вывод значения в любом типе*/

namespace Laba_3_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var measureItems = new string[]
        {
            "м3",
            "мл",
            "л",
            "б",
        };

            // привязываем списки значений к каждому комбобоксу
            cmBox1.DataSource = new List<string>(measureItems);
            cmBox2.DataSource = new List<string>(measureItems);
            cmBox3.DataSource = new List<string>(measureItems);

            ComparisonBox1.DataSource = new List<string>(measureItems);
            ComparisonBox2.DataSource = new List<string>(measureItems);
        }

        private MeasureOfType GetMeasureOfType(ComboBox comboBox)
        {
            MeasureOfType measureOfType;
            switch (comboBox.Text)
            {
                case "м3":
                    measureOfType = MeasureOfType.m3;
                    break;
                case "мл":
                    measureOfType = MeasureOfType.ml;
                    break;
                case "л":
                    measureOfType = MeasureOfType.l;
                    break;
                case "б":
                    measureOfType = MeasureOfType.b;
                    break;
                default:
                    measureOfType = MeasureOfType.m3;
                    break;
            }
            return measureOfType;
        }

        private void Calculate()
        {
            try
            {
                // эти строчки не трогаем
                var firstValue = double.Parse(textBox1.Text);
                var secondValue = double.Parse(textBox2.Text);
                var multiplier = 1;

                if (!string.IsNullOrEmpty(textBox3.Text))
                {
                    // Преобразуем значение из textBox3 в double
                    multiplier = (int)double.Parse(textBox3.Text);
                }

                MeasureOfType firstType = GetMeasureOfType(cmBox1);
                MeasureOfType secondType = GetMeasureOfType(cmBox2);
                MeasureOfType resultType = GetMeasureOfType(cmBox3);

                var firstLength = new Quantity(firstValue, firstType);
                var secondLength = new Quantity(secondValue, secondType);

                // заводим неинициализированную переменную под длину
                Quantity sumLength;

                // смотрим что выбрали в cmbOperation
                switch (cmbOperation.Text)
                {
                    case "+":
                        // если плюсик выбрали, то складываем
                        sumLength = firstLength + secondLength;
                        break;
                    case "-":
                        // если минус, то вычитаем
                        sumLength = firstLength - secondLength;
                        break;
                    //case "*":
                    //    sumLength = firstLength * secondLength;
                    //    break;
                    //case "/":
                    //    sumLength = firstLength / secondLength;
                    //    break;
                    default:
                        sumLength = new Quantity(0, MeasureOfType.m3);
                        break;
                }

                sumLength *= multiplier;

                txtResult.Text = sumLength.To(resultType).OutputOfTheValue();
            }
            catch (FormatException)
            {
                // если тип преобразовать не смогли
                //MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);   //Если так делать, то в свойствах текстбоксов надо поставить текст, который будет начальным
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            txtResult.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void onValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        //Сравнение
        private void CompareValues()
        {
            try
            {
                double value1 = double.Parse(textBox4.Text);
                double value2 = double.Parse(textBox6.Text);

                MeasureOfType measure1 = GetMeasureOfType(ComparisonBox1);
                MeasureOfType measure2 = GetMeasureOfType(ComparisonBox2);

                Quantity quantity1 = new Quantity(value1, measure1);
                Quantity quantity2 = new Quantity(value2, measure2);

                // Сравниваем значения
                if (quantity1 == quantity2)
                {
                    textBox5.Text = "=";
                }
                else if (quantity1 < quantity2)
                {
                    textBox5.Text = "<";
                }
                else
                {
                    textBox5.Text = ">";
                }
            }
            catch (FormatException)
            {
                // В случае некорректного ввода выводим сообщение об ошибке или предпринимаем другие действия
                //MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onCompareValues(object sender, EventArgs e)
        {
            CompareValues();
        }
    }
}
