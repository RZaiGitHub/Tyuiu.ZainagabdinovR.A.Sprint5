using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.ZainagabdinovR.A.Sprint5.Task1.V7.Lib;

namespace Tyuiu.ZainagabdinovR.A.Sprint5.Task1.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string outputFile = @"C:\Users\ТИУ\source\repos\Tyuiu.ZainagabdinovR.A.Sprint5\Tyuiu.ZainagabdinovR.A.Sprint5.Task1.V7\bin\Debug\OutPutFileTask1.txt";

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = -7.83;
            valueWaitArray[1] = 16.03;
            valueWaitArray[2] = 18.87;
            valueWaitArray[3] = 4.96;
            valueWaitArray[4] = -9.99;
            valueWaitArray[5] = -2.00;
            valueWaitArray[6] = 2.16;
            valueWaitArray[7] = -7.54;
            valueWaitArray[8] = -22.76;
            valueWaitArray[9] = -20.45;
            valueWaitArray[10] = 7.77;

            double[] res;
            res = new double[len];
            CollectionAssert.AreEqual(valueWaitArray, res);
            FileInfo fileInfo = new FileInfo(outputFile);
            bool fileExists = fileInfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
