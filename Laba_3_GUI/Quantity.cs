using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Мера объема, задаваемая в виде пары (значение, тип), допустимые типы: м^3, миллилитры, литры, баррель
-сложение
-вычитание
-умножение на число
-сравнение двух объемов
-вывод значения в любом типе*/

namespace Laba_3_GUI
{
    public enum MeasureOfType {m3, ml, l, b};
    public class Quantity
    {
        private double value;   //значение
        private MeasureOfType type_of_measure;     //тип меры

        public Quantity(double value, MeasureOfType type_of_measure)
        {
            this.value = value;
            this.type_of_measure = type_of_measure;
        }

        public string OutputOfTheValue()
        {
            string typeOutputOfTheValue = "";
            switch (this.type_of_measure)
            {
                case MeasureOfType.m3:
                    typeOutputOfTheValue = "м3";
                    break;
                case MeasureOfType.ml:
                    typeOutputOfTheValue = "мл";
                    break;
                case MeasureOfType.l:
                    typeOutputOfTheValue = "л";
                    break;
                case MeasureOfType.b:
                    typeOutputOfTheValue = "б";
                    break;
            };
            return String.Format("{0} {1}", this.value, this.type_of_measure);
        }
    }
}
