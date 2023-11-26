using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KaidalovIG.Sprint5.Task5.V23.Lib;
using System.IO;

namespace Tyuiu.KaidalovIG.Sprint5.Task5.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнила: Кайдалов И. Г. | СМАРТ-Б-23-1";


            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнила: Кайдалов Илья Григорьевич | СМАРТ-Б-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Создать папку вручную С:DataSprint5 и скопировать в неё файл, в котором *");
            Console.WriteLine("* есть набор вещественных значений.                                       *");
            Console.WriteLine("* Найти минимальное вещественное число в файле.                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            string path = $@"C:\DataSprint5\InPutDataFileTask5V23.txt";


            Console.WriteLine("Данные находятся в файле: " + path);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("Минимальное вещественное число в файле: " + res);
            Console.ReadKey();
        }
    }
}
