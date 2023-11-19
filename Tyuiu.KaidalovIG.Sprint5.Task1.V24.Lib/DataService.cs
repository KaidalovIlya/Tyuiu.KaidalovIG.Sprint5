using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.KaidalovIG.Sprint5.Task1.V24.Lib
{
    public class DataService : ISprint5Task1V24
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            double y;
            string r;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(((3 * Math.Cos(x)) / (4 * x - 0.5)) + Math.Sin(x) - 5 * x - 2, 2);
                r = Convert.ToString(y);
                if (x != stopValue && (4 * x - 0.5) != 0)
                {
                    File.AppendAllText(path, r + Environment.NewLine);
                }
                else if (x != stopValue && (4 * x - 0.5) == 0)
                {
                    y = 0;
                    r = Convert.ToString(y);
                    File.AppendAllText(path, r + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, r);
                }
            }
            return path;
        }
    }
}
