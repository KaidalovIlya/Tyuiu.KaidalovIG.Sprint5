using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaidalovIG.Sprint5.Task1.V24.Lib;
using System.IO;

namespace Tyuiu.KaidalovIG.Sprint5.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Илья\source\repos\Tyuiu.KaidalovIG.Sprint5\Tyuiu.KaidalovIG.Sprint5.Task1.V24\bin\Debug";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
