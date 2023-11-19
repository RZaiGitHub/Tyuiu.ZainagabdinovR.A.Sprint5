using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZainagabdinovR.A.Sprint5.Task1.V7.Lib
{
    public class DataService : ISprint5Task1V7
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string outputFile = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(outputFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(outputFile);
            }

            double[] valueArray;
            int len = (stopValue - startValue + 1);
            valueArray = new double[len];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 1.2 == 0)
                {
                    valueArray[count] = 0;
                    continue;
                }
                double y = Math.Round((Math.Sin(x)) / (x + 1.2) + Math.Sin(x) * 2 - 2 * x, 2);
                valueArray[count] = y;
                count++;
            }
            return outputFile;
        }
    }
}
