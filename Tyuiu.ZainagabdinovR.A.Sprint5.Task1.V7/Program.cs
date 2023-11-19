using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZainagabdinovR.A.Sprint5.Task1.V7.Lib;

namespace Tyuiu.ZainagabdinovR.A.Sprint5.Task1.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Зайнагабдинов Р. А. | ИСТНб-23-1";
            //Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #5.1                                                            *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Зайнагабдинов Руслан Айратович | ИСТНб-23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("*           sin(x)                                                        *");
            Console.WriteLine("* F(x)= ------------------- + sin(x) * 2 - 2 * x                          *");
            Console.WriteLine("*           x + 1,2                                                       *");
            Console.WriteLine("* (произвести табулирование) f(x) на заданном диапазоне [-5; 5]           *");
            Console.WriteLine("* с шагом 1. Произвести проверку деления на ноль.                         *");
            Console.WriteLine("* При делении на ноль вернуть значение 0                                  *");
            Console.WriteLine("* Результат сохранить в текстовый файл OutPutFileTask0.txt                *");
            Console.WriteLine("* Значение округлитиь до двух знаков после запятой и вывести на консоль   *");
            Console.WriteLine("* в таблицу.                                                              *");
            Console.WriteLine("* Значение округлитиь до двух знаков после запятой.                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.SaveToFileTextData(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|     X    |   f(x)   |");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}  |   {1, 6:f2}    |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
