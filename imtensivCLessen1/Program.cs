using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imtensivCLessen1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Измалков Максим Задание №1 \n  Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.");
            Console.Write("Введите Имя:");
            var fName = Console.ReadLine();

            Console.Write("Введите Фамилию:");
            var lName = Console.ReadLine();

            Console.Write("Введите возраст (полных лет):");
            var age = Console.ReadLine();
            age += " лет";

            Console.Write("Введите рост (в см):");
            var height = Console.ReadLine();
           

            Console.Write("Введите вес (в кг):");
            var weighing = Console.ReadLine();
            float bodyMassIndex = Convert.ToInt32(weighing) / ((Convert.ToInt32(height) / 100) * (Convert.ToInt32(height) / 100));
            weighing += " кг";
            height += " см";
            Console.WriteLine("Измалков Максим Задание №2 \n Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах");

           Console.WriteLine($"Уважаемый {fName}, будьте добры проверьте анкету \n Имя: {fName}  Фамилия: {lName} Возраст: {age} Рост: {height} Вес: {weighing} \n Индекс Массы тела: {bodyMassIndex:F2} ");

            Console.WriteLine("Измалков Максим Задание №3");
            Console.Write("Введите координату x1 :");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату y1 :");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату x2 :");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату y2 :");
            int y2 = Convert.ToInt32(Console.ReadLine());

            var R = Distance(x1, y1, x2, y2);
            Console.WriteLine($"r={R}");

            Console.WriteLine("Измалков Максим Задание №4\n  Написать программу обмена значениями двух переменных.\n a)с использованием третьей переменной");

            Console.Write("Введите X :");
            int X = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите Y :");
            int Y = Convert.ToInt32(Console.ReadLine());

            int Z = X;
            X = Y;
            Y = Z;
            Console.WriteLine($"Значение X={X}, а Y={Y}\n б)без использования третьей переменной");

            X += Y;
            Y = X - Y;
            X = X - Y;
            Console.WriteLine($"Значение X={X}, а Y={Y}");

            Console.WriteLine("Измалков Максим Задание №5\n  Написать программу, которая выводит на экран ваше имя, фамилию и город проживания");
            Print("Максим", "Измалков", "Москва");
           
            Console.ReadKey();
        }

        static double Distance(int x1, int y1,int x2,int y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }

        static void Print(string fName, string lName, string sity )
        {
            var text = fName + " " + lName + ", проживаю в городе " + sity;
            Console.SetCursorPosition(((System.Console.BufferWidth / 2)-(text.Length/2)), 33);
            Console.WriteLine(text);
        }
    }
}
