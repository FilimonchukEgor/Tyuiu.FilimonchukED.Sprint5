using System.IO;
using Tyuiu.FilimonchukED.Sprint5.Task4.V17.Lib;
namespace Tyuiu.FilimonchukED.Sprint5.Task4.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string path = $@"C:\DataSprint5\InPutDataFileTask4V17.txt";

            Console.WriteLine("Данные находится в файле: " + path);

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
        }
    }
}
