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
                    case "*":
                        sumLength = firstLength * secondLength;
                        break;
                    case "/":
                        sumLength = firstLength / secondLength;
                        break;
                    default:
                        sumLength = new Quantity(0, MeasureOfType.m3);
                        break;
                }

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
        }

        private void onValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
