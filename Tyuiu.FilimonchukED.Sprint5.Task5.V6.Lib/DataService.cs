using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.FilimonchukED.Sprint5.Task5.V6.Lib
{
    public class DataService : ISprint5Task5V6
    {
        public double LoadFromDataFile(string path)
        {
            path = Path.GetTempFileName();
            // Читаем все строки из файла
            string fileContent = File.ReadAllText(path);

            // Разбиваем строку по запятым и преобразуем каждое значение в double
            double[] numbers = fileContent.Split(',')
                                          .Select(s => double.Parse(s.Trim())) // Убираем пробелы и парсим числа
                                          .ToArray();

            // Отбираем только положительные значения
            var positiveNumbers = numbers.ToArray();

            // Если есть положительные числа, считаем их среднее
            if (positiveNumbers.Any())
            {
                double average = positiveNumbers.Average();
                // Округляем результат до 3 знаков после запятой
                return Math.Round(average, 3);
            }

            // Если нет положительных чисел, возвращаем 0
            return 0;
        }
    }
}
