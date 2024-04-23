using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            textBox1.Text = Properties.Settings.Default.number1.ToString();
            textBox2.Text = Properties.Settings.Default.number2.ToString();

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

                double firstValue = /*double.Parse(textBox1.Text)*/0;
                double secondValue = /*double.Parse(textBox2.Text)*/0;
                double multiplier = 1;

                ///это для того чтобы можно было умножить только одну строку, а не обе 
                if (!string.IsNullOrEmpty(textBox1.Text))   //Проверяем, пустое ли поле, если нет, то берём значение из textbox'a
                {
                    firstValue = double.Parse(textBox1.Text);
                }
                if (!string.IsNullOrEmpty(textBox2.Text))   //Проверяем, пустое ли поле, если нет, то берём значение из textbox'a
                {
                    secondValue = double.Parse(textBox2.Text);
                }
                ///
                if (!string.IsNullOrEmpty(textBox3.Text))   //Проверяем, пустое ли поле, если нет, то берём значение из textbox'a
                {
                    multiplier = double.Parse(textBox3.Text);
                }

                MeasureOfType firstType = GetMeasureOfType(cmBox1);
                MeasureOfType secondType = GetMeasureOfType(cmBox2);
                MeasureOfType resultType = GetMeasureOfType(cmBox3);

                var firstLength = new Quantity(firstValue, firstType);
                var secondLength = new Quantity(secondValue, secondType);

                // заводим неинициализированную переменную под объём
                Quantity sumLength;

                // смотрим что выбрали в cmbOperation
                switch (cmbOperation.Text)
                {
                    case "+":
                        // если +, то складываем
                        sumLength = firstLength + secondLength;
                        break;
                    case "-":
                        // если -, то вычитаем
                        sumLength = firstLength - secondLength;
                        break;
                    default:
                        //по умолчанию 0
                        sumLength = new Quantity(0, MeasureOfType.m3);
                        break;
                }

                sumLength *= multiplier;    //для умножения на число

                Properties.Settings.Default.number1 = textBox1.Text;
                Properties.Settings.Default.number2 = textBox2.Text;
                Properties.Settings.Default.Save();

                txtResult.Text = sumLength.To(resultType).OutputOfTheValue();   //результат с учётом меры
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
            textBox3.Clear();
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

                var quantity1 = new Quantity(value1, measure1);
                var quantity2 = new Quantity(value2, measure2);

                // Сравниваем значения
                if (quantity1 == quantity2)
                {
                    textBox5.Text = "=";
                }
                else if (quantity1 < quantity2)
                {
                    textBox5.Text = "<";
                }
                else if (quantity1 > quantity2)
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
