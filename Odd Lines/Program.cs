using System;
using System.IO;

namespace Odd_Lines
{
    class Program
    {
        static void Main( string [ ] args )
        {

            using (StreamReader inputFile = new StreamReader(@"C:\Users\vshum\source\repos\Streams, Files and Directories\Odd Lines\01. Odd Lines\Input.txt"))
            {
                using (StreamWriter newOutput = new StreamWriter(@"C:\Users\vshum\source\repos\Streams, Files and Directories\Odd Lines\01. Odd Lines\output.txt"))
                {

                    int count = 0;
                    var curLine = inputFile.ReadLine();
                    while (curLine != null)
                    {
                        if (count % 2 != 0)
                        {
                            newOutput.WriteLine(curLine);
                        }
                        count++;
                        curLine = inputFile.ReadLine( );
                    }
                }

            }



        }
    }
}
