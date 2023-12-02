using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint5.TaskReview.V10.Lib;
using System.IO;

namespace Tyuiu.NosyrevaUA.Sprint5.TaskReview.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VaidLoadDataAndSave()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V10.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool filEx = fileinfo.Exists;
            Assert.AreEqual(filEx, true);
        }
    }
}
