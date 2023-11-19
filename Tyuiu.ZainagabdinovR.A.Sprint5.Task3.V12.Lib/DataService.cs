using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZainagabdinovR.A.Sprint5.Task3.V12.Lib
{
    public class DataService : ISprint5Task3V12
    {
        public string SaveToFileTextData(int x)
        {
            string outputFile = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.txt";

            double z = (Math.Pow(x, 3)) / (2 * Math.Pow((x + 5), 2));

            z = Math.Round(z, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(outputFile, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(z));
            }

            return outputFile;
        }
    }
}
