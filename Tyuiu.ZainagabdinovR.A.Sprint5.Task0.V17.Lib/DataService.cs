using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZainagabdinovR.A.Sprint5.Task0.V17.Lib
{
    public class DataService : ISprint5Task0V17
    {
        public string SaveToFileTextData(int x)
        {
            string outputFile = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double z = 2.4 * Math.Pow(x, 3) + 0.4 * Math.Pow(x, 2) - 1.4 * x + 4.1;
            z = Math.Round(z, 3);
            File.WriteAllText(outputFile, Convert.ToString(z));
            return outputFile;
        }
    }
}
