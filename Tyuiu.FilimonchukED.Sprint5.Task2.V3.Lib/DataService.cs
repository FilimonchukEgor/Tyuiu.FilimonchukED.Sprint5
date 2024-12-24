using tyuiu.cources.programming.interfaces.Sprint5;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.FilimonchukED.Sprint5.Task2.V3.Lib
{
    public class DataService : ISprint5Task2V3
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string tempDirectory = Path.GetTempPath();
            string path = Path.Combine(tempDirectory, "OutPutFileTask2.csv");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists) File.Delete(path);

            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 !=0) matrix[i, j] = 0;
                }
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    // Проходим по строкам данных
                    for (int i = 0; i < matrix.GetLength(0); i++)  // data.GetLength(0) - количество строк
                    {
                        string line = string.Join(";", // Используем точку с запятой как разделитель
                            matrix[i, 0], matrix[i, 1], matrix[i, 2]); // Формируем строку с разделителями
                        writer.WriteLine(line);  // Записываем строку в файл
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка записи в файл: " + ex.Message);
            }
            return path;
        }
    }
}
