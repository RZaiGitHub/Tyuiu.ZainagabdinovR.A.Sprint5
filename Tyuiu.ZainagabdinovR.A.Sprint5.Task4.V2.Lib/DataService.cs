using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZainagabdinovR.A.Sprint5.Task4.V2.Lib
{
    public class DataService : ISprint5Task4V2
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double res = Math.Round((Math.Cos(Convert.ToDouble(strX)) + 3 * Convert.ToDouble(strX)) / (0.25 * Convert.ToDouble(strX)) + 4 - 2.1 * Convert.ToDouble(strX), 3);
            return res;
        }
    }
}
