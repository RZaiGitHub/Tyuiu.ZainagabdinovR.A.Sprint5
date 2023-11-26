using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.ZainagabdinovR.A.Sprint5.Task4.V2.Lib;

namespace Tyuiu.ZainagabdinovR.A.Sprint5.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Asus\source\repos\Tyuiu.ZainagabdinovR.A.Sprint5\Tyuiu.ZainagabdinovR.A.Sprint5.Task4.V2\bin\Debug\InPutDataFileTask4V2.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
