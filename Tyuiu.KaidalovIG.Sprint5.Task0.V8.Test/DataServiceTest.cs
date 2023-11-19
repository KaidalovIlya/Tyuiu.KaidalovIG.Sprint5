using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaidalovIG.Sprint5.Task0.V8.Lib;
using System.IO;

namespace Tyuiu.KaidalovIG.Sprint5.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = $@"C:\Users\Илья\source\repos\Tyuiu.KaidalovIG.Sprint5\Tyuiu.KaidalovIG.Sprint5.Task0.V8\bin\Debug";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
