using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.FilimonchukED.Sprint5.Task3.V14.Lib
{
    public class DataService : ISprint5Task3V14
    {
        public string SaveToFileTextData(int x)
        {
            string tempDirectory = Path.GetTempPath();
            string path = Path.Combine(tempDirectory, "OutPutFileTask3.bin");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists) File.Delete(path);

            double y;
            y = 4 * Math.Pow(x, 3) / (Math.Pow(x, 3) - 1);
            y = Math.Round(y, 3);

            try
            {
                // Создаем поток для записи с кодировкой UTF-8
                using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8))
                {
                    // Записываем строку в бинарный файл
                    writer.Write(y);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка при записи в файл: {ex.Message}");
            }
            return path;
        }
    }
}
