using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.NosyrevaUA.Sprint5.TaskReview.V10.Lib
{
    public class DataService : ISprint5Task7V10
    {
        public string LoadDataAndSave(string path)
        {
            string PathToSave = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V10.txt";
            FileInfo fileInfo = new FileInfo(PathToSave);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(PathToSave);
            }
            using (StreamReader reader = new StreamReader(path))
            {
                string strInput = reader.ReadToEnd();
                string res = "";
                res = strInput.ToLower();

                File.AppendAllText(PathToSave, res);
                return PathToSave;
            }
        }
    }
}
