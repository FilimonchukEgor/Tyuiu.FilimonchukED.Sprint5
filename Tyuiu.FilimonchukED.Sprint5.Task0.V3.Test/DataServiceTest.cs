using System.IO;
namespace Tyuiu.FilimonchukED.Sprint5.Task0.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\gamer\source\repos\Tyuiu.FilimonchukED.Sprint5\Tyuiu.FilimonchukED.Sprint5.Task0.V3\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

    }
}
