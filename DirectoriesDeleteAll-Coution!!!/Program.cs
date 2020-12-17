using System;
using System.IO;

namespace Directories
{
    class Program
    {
        static void Main( string [ ] args )
        {
            string directoryPath = Console.ReadLine();
            GetDirectorySize(directoryPath);
        }

        static void GetDirectorySize( string directoryPath )
        {
            string[] files = Directory.GetFiles(directoryPath);
            string[] directories = Directory.GetDirectories(directoryPath);
            for (int i = 0; i < directories.Length; i++)
            {
                GetDirectorySize(directories [ i ]);
                Directory.Delete(directories [ i ]);
            }
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo info = new FileInfo(files[i]);
                File.Delete(files [ i ]);
            }
            
        }
    }
}
