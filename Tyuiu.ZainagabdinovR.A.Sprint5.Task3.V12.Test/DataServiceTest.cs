using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.ZainagabdinovR.A.Sprint5.Task3.V12.Lib;

namespace Tyuiu.ZainagabdinovR.A.Sprint5.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string outputFile = @"C:\Users\ТИУ\source\repos\Tyuiu.ZainagabdinovR.A.Sprint5\Tyuiu.ZainagabdinovR.A.Sprint5.Task3.V12\bin\Debug\OutPutFileTask3.txt";

            FileInfo fileInfo = new FileInfo(outputFile);
            bool fileExists = fileInfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
