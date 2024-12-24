using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.FilimonchukED.Sprint5.Task0.V3.Lib
{
    public class DataService : ISprint5Task0V3
    {
        public string SaveToFileTextData(int x)
        {
            string tempDirectory = Path.GetTempPath();
            string path = Path.Combine(tempDirectory, "OutPutFileTask0.txt");

            double y = -0.25 * (Math.Pow(x, 3) - (3 * Math.Pow(x, 2) + 4));
            y = Math.Round(y, 3);

            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine(y);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка записи в файл" +ex.Message);
            }
            return path;
        }
    }
}
