using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.FilimonchukED.Sprint5.Task1.V15.Lib
{
    public class DataService : ISprint5Task1V15
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string tempDirectory = Path.GetTempPath();
            string path = Path.Combine(tempDirectory, "OutPutFileTask1.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists) File.Delete(path);

            double y;
            string strY;

            var lines = new List<string>();

            for (int x = startValue; x <= stopValue; x++)
            {
                // Пытаемся избежать деления на 0 (x-0.4)
                if (x == 0.4)
                {
                    lines.Add("0");
                    continue;
                }

                y = Math.Round(Math.Cos(x) / (x - 0.4) + Math.Sin(x) * 8 * x + 2, 2);
                strY = Convert.ToString(y);
                lines.Add(strY);
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    foreach (var line in lines)
                    {
                        writer.WriteLine(line); 
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка записи в файл" + ex.Message);
            }

            return path;
        }
    }
}
