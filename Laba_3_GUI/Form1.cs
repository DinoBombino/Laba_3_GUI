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

/*���� ������, ���������� � ���� ���� (��������, ���), ���������� ����: �^3, ����������, �����, �������
-��������
-���������
-��������� �� �����
-��������� ���� �������
-����� �������� � ����� ����*/

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
            "�3",
            "��",
            "�",
            "�",
        };

            // ����������� ������ �������� � ������� ����������
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
                case "�3":
                    measureOfType = MeasureOfType.m3;
                    break;
                case "��":
                    measureOfType = MeasureOfType.ml;
                    break;
                case "�":
                    measureOfType = MeasureOfType.l;
                    break;
                case "�":
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

                ///��� ��� ���� ����� ����� ���� �������� ������ ���� ������, � �� ��� 
                if (!string.IsNullOrEmpty(textBox1.Text))   //���������, ������ �� ����, ���� ���, �� ���� �������� �� textbox'a
                {
                    firstValue = double.Parse(textBox1.Text);
                }
                if (!string.IsNullOrEmpty(textBox2.Text))   //���������, ������ �� ����, ���� ���, �� ���� �������� �� textbox'a
                {
                    secondValue = double.Parse(textBox2.Text);
                }
                ///
                if (!string.IsNullOrEmpty(textBox3.Text))   //���������, ������ �� ����, ���� ���, �� ���� �������� �� textbox'a
                {
                    multiplier = double.Parse(textBox3.Text);
                }

                MeasureOfType firstType = GetMeasureOfType(cmBox1);
                MeasureOfType secondType = GetMeasureOfType(cmBox2);
                MeasureOfType resultType = GetMeasureOfType(cmBox3);

                var firstLength = new Quantity(firstValue, firstType);
                var secondLength = new Quantity(secondValue, secondType);

                // ������� �������������������� ���������� ��� �����
                Quantity sumLength;

                // ������� ��� ������� � cmbOperation
                switch (cmbOperation.Text)
                {
                    case "+":
                        // ���� +, �� ����������
                        sumLength = firstLength + secondLength;
                        break;
                    case "-":
                        // ���� -, �� ��������
                        sumLength = firstLength - secondLength;
                        break;
                    default:
                        //�� ��������� 0
                        sumLength = new Quantity(0, MeasureOfType.m3);
                        break;
                }

                sumLength *= multiplier;    //��� ��������� �� �����

                Properties.Settings.Default.number1 = textBox1.Text;
                Properties.Settings.Default.number2 = textBox2.Text;
                Properties.Settings.Default.Save();

                txtResult.Text = sumLength.To(resultType).OutputOfTheValue();   //��������� � ������ ����
            }
            catch (FormatException)
            {
                // ���� ��� ������������� �� ������
                //MessageBox.Show("������������ ����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);   //���� ��� ������, �� � ��������� ����������� ���� ��������� �����, ������� ����� ���������
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

        //���������
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

                // ���������� ��������
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
                // � ������ ������������� ����� ������� ��������� �� ������ ��� ������������� ������ ��������
                //MessageBox.Show("������������ ����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onCompareValues(object sender, EventArgs e)
        {
            CompareValues();
        }
    }
}
