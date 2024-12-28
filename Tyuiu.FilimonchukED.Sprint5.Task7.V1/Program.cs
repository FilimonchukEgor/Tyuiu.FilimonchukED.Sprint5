using Tyuiu.FilimonchukED.Sprint5.Task7.V1.Lib;
namespace Tyuiu.FilimonchukED.Sprint5.Task7.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path = $@"C:\DataSprint5\InPutDataFileTask7V1.txt";
            ds.LoadDataAndSave(path);
            Console.WriteLine(path);
        }
    }
}
