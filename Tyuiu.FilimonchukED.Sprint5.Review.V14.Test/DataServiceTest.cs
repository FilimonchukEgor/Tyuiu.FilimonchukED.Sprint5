using System.IO;
using Tyuiu.FilimonchukED.Sprint5.Review.V14.Lib;
namespace Tyuiu.FilimonchukED.Sprint5.Review.V14.Test
{
    
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = $@"C:\DataSprint5\InPutDataFileTask7V14.txt";
            string pathSaveFile = @"C:\Users\gamer\source\repos\Tyuiu.FilimonchukED.Sprint5\Tyuiu.FilimonchukED.Sprint5.Review.V14\bin\Debug\net8.0\OutPutFileTask7V14.txt";
            ds.ConvertToUpper(path, pathSaveFile);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}