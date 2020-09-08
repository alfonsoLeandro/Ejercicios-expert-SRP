using System;
using System.IO;

namespace Game_of_life
{
    class FileReader
    {
        public static bool[,] FileToBoolArray(string path)
        {
            String[] fileLines = File.ReadAllLines(path);
            int width = fileLines[0].Length;
            int height = fileLines.Length;

            bool[,] table = new bool[height, width];


            for(int x = 0; x < height ; x++)
            {
                char[] line = fileLines[x].ToCharArray();

                for(int y = 0; y < width; y++)
                {
                    table[x,y] = line[y].Equals("1");
                }
            }


            return table;
        }
    }
}