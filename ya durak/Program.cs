using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ya_durak
{
    internal class Program
    {
        enum Seasons
        {
            Зима,
            Весна,
            Лето,
            Осень
        }
        enum mark
        {
            Плохо = 1,
            Неудовлетоврительно,
            Удовлетворительно,
            Хорошо,
            Отлично
        }

        static void onepoint()

        {
            Console.WriteLine("Ввдеите оценку: ");
            int marks = Convert.ToInt32(Console.ReadLine());
            switch (marks)
            {
                case 1:
                    Console.WriteLine("Характеристика отметки 1:" + " " + mark.Плохо);
                    break;
                case 2:
                    Console.WriteLine("Характеристика отметки 2:" + " " + mark.Неудовлетоврительно);
                    break;
                case 3:
                    Console.WriteLine("Характеристика отметки 3:" + " " + mark.Удовлетворительно);
                    break;
                case 4:
                    Console.WriteLine("Характеристика отметки 4:" + " " + mark.Хорошо);

                    break;
                case 5:
                    Console.WriteLine("Характеристика отметки:" + " " + mark.Отлично);
                    break;
            }
        }



        static void twopoint()
        {
            Console.WriteLine("Введите время года");
            string Season = Console.ReadLine();
            switch (Season)
            {
                case "зима":
                    Console.WriteLine("23.01 - День рождение");
                    break;
                case "весна":
                    Console.WriteLine("08.03 - Международный женский день");
                    break;
                case "лето":
                    Console.WriteLine("01.06 - День защиты детей");
                    break;
                case "осень":
                    Console.WriteLine("01.09 - День знаний");
                    break;
            }
        }






        static void Main(string[] args)
        {
            onepoint();
            twopoint();
            Console.ReadKey();
        }
    }

}

