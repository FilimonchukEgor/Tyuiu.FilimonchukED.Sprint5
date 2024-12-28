using Tyuiu.FilimonchukED.Sprint5.Review.V14.Lib;
namespace Tyuiu.FilimonchukED.Sprint5.Review.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");


            string path = $@"C:\DataSprint5\InPutDataFileTask7V14.txt";
            string pathSaveFile = @"C:\Users\gamer\source\repos\Tyuiu.FilimonchukED.Sprint5\Tyuiu.FilimonchukED.Sprint5.Review.V14\bin\Debug\net8.0\OutPutFileTask7V14.txt";


            Console.WriteLine("Данные находяться в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            ds.ConvertToUpper(path, pathSaveFile);
            Console.WriteLine("Находится в файле : ");
            Console.WriteLine(pathSaveFile);
            Console.ReadKey();
        }
    }
}
