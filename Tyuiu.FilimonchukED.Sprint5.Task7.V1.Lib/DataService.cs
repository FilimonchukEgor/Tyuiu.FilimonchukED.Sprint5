using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.FilimonchukED.Sprint5.Task7.V1.Lib
{
    public class DataService : ISprint5Task7V1
    {
        public string LoadDataAndSave(string path)
        {
            path = Path.GetTempFileName();
            string str = "";
            foreach (char c in path)
            {
                if (!char.IsDigit(c))
                {
                    str += c;
                }
            }
            return str;
        } 
    }
}
