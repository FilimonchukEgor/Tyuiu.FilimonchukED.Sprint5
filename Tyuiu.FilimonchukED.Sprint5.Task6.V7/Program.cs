using System.IO;
using Tyuiu.FilimonchukED.Sprint5.Task6.V7.Lib;
namespace Tyuiu.FilimonchukED.Sprint5.Task6.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path = $@"C:\DataSprint5\InPutDataFileTask6V7.txt";
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
        }
    }
}
