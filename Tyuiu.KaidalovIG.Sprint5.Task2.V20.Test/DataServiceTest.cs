using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KaidalovIG.Sprint5.Task2.V20.Lib;

namespace Tyuiu.KaidalovIG.Sprint5.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test2()
        {
            string path = @"C:\Users\Илья\source\repos\Tyuiu.KaidalovIG.Sprint5\Tyuiu.KaidalovIG.Sprint5.Task2.V20\bin\Debug";
            FileInfo fileinfo = new FileInfo(path);
            bool fileex = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileex);
        }
    }
}
