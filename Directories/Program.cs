using System;
using System.IO;

namespace Directories
{
    class Program
    {
        static void Main( string [ ] args )
        {
            string directoryPath = Console.ReadLine();
            Console.WriteLine(GetDirectorySize(directoryPath)); 
        }

        static double GetDirectorySize(string directoryPath)
        {
            string[] files = Directory.GetFiles(directoryPath);
            double sum = 0;

            string[] direcories = Directory.GetDirectories(directoryPath);
            for (int i = 0; i < direcories.Length; i++)
            {
               sum += GetDirectorySize(direcories [ i ]);
            }

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo info = new FileInfo(files[i]);
                Console.WriteLine($"{info.Name} --> {(info.Length/ 1024f) / 1024f:f2} MB" );
                sum += info.Length ;
            }
            return sum ;
        }
    }
}
