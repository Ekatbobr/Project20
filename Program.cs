using System;

namespace Project20
{
    delegate double CircleFunc(double r);

    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            В приложении объявить тип делегата, который ссылается на метод. Требования к
            сигнатуре метода следующие:
            - метод получает входным параметром переменную типа double;
            - метод возвращает значение типа double, которое является результатом вычисления.

            Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
            - длину окружности по формуле D = 2 * π * R;
            - площадь круга по формуле S = π * R²;
            - объем шара. Формула V = 4/3 * π * R³.

            Методы должны быть объявлены как статические.
            */

            try
            {
                Console.WriteLine("Введите радиус R:");
                double r = Convert.ToDouble(Console.ReadLine());

                CircleFunc length = Length;
                CircleFunc area = Area;
                CircleFunc volume = Volume;

                Console.WriteLine("Длина окружности: " + length(r));
                Console.WriteLine("Площадь круга: " + area(r));
                Console.WriteLine("Объем шара: " + volume(r));
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка! " + ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Для завершения нажмите на клавишу");
            Console.ReadKey();
        }

        static double Length(double r)
        {
            return 2 * Math.PI * r;
        }

        static double Area(double r)
        {
            return Math.PI * r * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * Math.PI * r * r * r;
        }
    }
}
