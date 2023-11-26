using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.ZainagabdinovR.A.Sprint5.Task4.V2.Lib;

namespace Tyuiu.ZainagabdinovR.A.Sprint5.Task4.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Зайнагабдинов Р. А. | ИСТНб-23-1";
            //Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #5.4                                                            *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Зайнагабдинов Руслан Айратович | ИСТНб-23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:/DataSprint5/InPutDataFileTask4V0.txt                        *");
            Console.WriteLine("* (файл взять из архива согласно вашему варианту. Создать папку в         *");
            Console.WriteLine("* ручную С:/DataSprint5/ и скопировать в неё файл)                        *");
            Console.WriteLine("* в котором есть вещественное значение.                                   *");
            Console.WriteLine("*       cos(x) + 3x                                                       *");
            Console.WriteLine("*  y = ------------- + 4 - 2,1x                                           *");
            Console.WriteLine("*         0,25x                                                           *");
            Console.WriteLine("* Вычислить значение по формуле (Полученное значение округлить            *");
            Console.WriteLine("* до трёх знаков после запятой) и вернуть полученный результат на консоль.*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask4V2.txt";

            Console.WriteLine("Данные находится в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
