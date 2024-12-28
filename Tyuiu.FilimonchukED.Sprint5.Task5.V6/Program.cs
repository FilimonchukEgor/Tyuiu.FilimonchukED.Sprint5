using System.IO;
using Tyuiu.FilimonchukED.Sprint5.Task5.V6.Lib;
namespace Tyuiu.FilimonchukED.Sprint5.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path = $@"C:\DataSprint5\InPutDataFileTask5V6.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Среднее значение всех значений = " + res);
        }
    }
}
