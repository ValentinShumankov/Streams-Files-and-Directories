using System;
using System.IO;

namespace Merge_Files
{
    class Program
    {
        static void Main( string [ ] args )
        {
            StreamReader file1 = new StreamReader(@"../../../FileOne.txt");


            StreamReader file2 = new StreamReader(@"../../../FileTwo.txt");

            StreamWriter MergeFile = new StreamWriter(@"../../../MergedFile.txt");

            var lineFile1 = string.Empty;
            var lineFile2 = string.Empty;
            while ((lineFile1 = file1.ReadLine( )) != null && (lineFile2 = file2.ReadLine( )) != null)
            {
                if (lineFile1 != null)
                {
                    MergeFile.WriteLine(lineFile1);
                }
                if (lineFile2 != null)
                {
                    MergeFile.WriteLine(lineFile2);
                }
            }

            file1.Close( );
            file2.Close( );
            MergeFile.Close( );
        }
    }
}
