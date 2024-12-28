using System.IO;
using System.Text;
using System.Text.RegularExpressions;
namespace Tyuiu.FilimonchukED.Sprint5.Review.V14.Lib
{
    public class DataService
    {
        public void ConvertToUpper(string inputFilePath, string outputFilePath)
        {
            try
            {
                string text = File.ReadAllText(inputFilePath);

                // Преобразование всех букв в заглавные
                string upperCaseText = text.ToUpper();
                File.WriteAllText(outputFilePath, upperCaseText);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
                throw; // Проброс исключения для обработки в вызывающем коде
            }
        }
    }
}
