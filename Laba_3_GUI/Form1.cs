using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                // ��� ������� �� �������
                var firstValue = double.Parse(textBox1.Text);
                var secondValue = double.Parse(textBox2.Text);

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
                        // ���� ������ �������, �� ����������
                        sumLength = firstLength + secondLength;
                        break;
                    case "-":
                        // ���� �����, �� ��������
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
                // ���� ��� ������������� �� ������
                //MessageBox.Show("������������ ����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);   //���� ��� ������, �� � ��������� ����������� ���� ��������� �����, ������� ����� ���������
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
