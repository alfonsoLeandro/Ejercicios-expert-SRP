using System;
using System.IO;

namespace Game_of_life
{
    /// <summary>
    /// Clase dedicada a leer el tablero desde una fuente externa, ya sea base de datos, archivos o cualquier otro medio.
    /// </summary>
    class FileReader
    {
        /// <summary>
        /// Transforma un archivo de lineas de 0 y 1 en una array 2D de tipo bool.
        /// Cumple con el principio SRP porque su unica responsabilidad es leer el archivo.
        /// </summary>
        /// <param name="path">El path al archivo</param>
        /// <returns>Array 2D de tipo bool</returns>
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