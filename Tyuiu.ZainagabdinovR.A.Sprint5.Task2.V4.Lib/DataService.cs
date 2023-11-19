﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZainagabdinovR.A.Sprint5.Task2.V4.Lib
{
    public class DataService : ISprint5Task2V4
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string outputFile = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask2.txt";

            FileInfo fileInfo = new FileInfo(outputFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(outputFile);
            }

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.GetUpperBound(1) + 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] >= 0)
                    {
                        matrix[i, j] = 1;
                    }
                    if (matrix[i, j] <= 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns-1)
                    {
                        str = str + matrix[i, j] + ";";
                    }
                    else
                    {
                        str = str + matrix[i, j];
                    }
                }

                if (i != rows-1)
                {
                    File.AppendAllText(outputFile, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(outputFile, str);
                }

                str = "";
            }

            return outputFile;
        }
    }
}
