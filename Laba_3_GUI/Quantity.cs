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
            string typeOutput = "";
            switch (this.type_of_measure)
            {
                case MeasureOfType.m3:
                    typeOutput = "м3";
                    break;
                case MeasureOfType.ml:
                    typeOutput = "мл";
                    break;
                case MeasureOfType.l:
                    typeOutput = "л";
                    break;
                case MeasureOfType.b:
                    typeOutput = "б";
                    break;
            }
            return String.Format("{0} {1}", this.value, typeOutput);
        }

        // сложение
        public static Quantity operator +(Quantity instance, double number)
        {
            // расчитываем новое значение 3л+4=7л
            var newValue = instance.value + number;
            // создаем новый экземпляр класса, с новый значением и типом как у меры, к которой число добавляем
            var Quantity = new Quantity(newValue, instance.type_of_measure);
            // возвращаем результат
            return Quantity;
        }

        // умножение
        public static Quantity operator *(Quantity instance, double number)
        {
            return new Quantity(instance.value * number, instance.type_of_measure); ;
        }

        // вычитание
        public static Quantity operator -(Quantity instance, double number)
        {
            return new Quantity(instance.value - number, instance.type_of_measure); ;
        }

        // действия any type and any type
        // сложение двух величин
        public static Quantity operator +(Quantity instance1, Quantity instance2) 
        {
            // к текущей длине добавляем число полученное преобразованием значения второй длины в тип первой длины
            return instance1 + instance2.To(instance1.type_of_measure).value;
        }

        // вычитание двух величин
        public static Quantity operator -(Quantity instance1, Quantity instance2)
        {
            return instance1 - instance2.To(instance1.type_of_measure).value;
        }

        public Quantity To(MeasureOfType newType)
        {
            // по умолчанию новое значение совпадает со старым
            var newValue = this.value;

            if (this.type_of_measure == MeasureOfType.m3)
            {
                switch (newType)
                {
                    case MeasureOfType.m3:
                        newValue = this.value;
                        break;

                    case MeasureOfType.ml:
                        newValue = this.value * 1000000;
                        break;

                    case MeasureOfType.l:
                        newValue = this.value *1000;
                        break;

                    case MeasureOfType.b:
                        newValue = this.value * 0.008648;
                        break;
                }
            }
            else if (newType == MeasureOfType.m3)
            {
                switch (this.type_of_measure)
                {
                    case MeasureOfType.m3:
                        newValue = this.value;
                        break;

                    case MeasureOfType.ml:
                        newValue = this.value / 1000000;
                        break;

                    case MeasureOfType.l:
                        newValue = this.value / 1000;
                        break;

                    case MeasureOfType.b:
                        newValue = this.value / 0.008648;
                        break;
                }
            }
            else
            {
                newValue = this.To(MeasureOfType.m3).To(newType).value;
            }
            return new Quantity(newValue, newType);
        }

        //Сравнение
        public static bool operator ==(Quantity instance1, Quantity instance2)
        {
            return instance1.To(instance2.type_of_measure).value == instance2.value;
        }

        public static bool operator !=(Quantity instance1, Quantity instance2)
        {
            return !(instance1 == instance2);
        }

        public static bool operator <(Quantity instance1, Quantity instance2)
        {
            return instance1.To(instance2.type_of_measure).value < instance2.value;
        }

        public static bool operator >(Quantity instance1, Quantity instance2)
        {
            return instance2 < instance1;
        }
    }
}
