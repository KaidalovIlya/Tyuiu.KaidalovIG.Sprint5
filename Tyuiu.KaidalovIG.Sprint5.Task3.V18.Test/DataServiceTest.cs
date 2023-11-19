using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KaidalovIG.Sprint5.Task3.V18.Lib;

namespace Tyuiu.KaidalovIG.Sprint5.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Илья\source\repos\Tyuiu.KaidalovIG.Sprint5\Tyuiu.KaidalovIG.Sprint5.Task3.V18\bin\Debug";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
