using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.VelizhaninIV.Sprint7.Project.V10.Lib
{
    public class DataService
    {
        public string[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }
            return arrayValues;
        }

        public bool AddRow(string path, string[] array)
        {
            bool add = false;
            string str = "";
            for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1)
                {
                    str = str + array[i] + ";";
                }
                else
                {
                    str = str + array[i];
                }
            }
            File.AppendAllText(path, str + Environment.NewLine, Encoding.UTF8);
            add = true;
            return add;
        }
    }
}

