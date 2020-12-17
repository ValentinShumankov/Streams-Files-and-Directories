using System;
using System.IO;

namespace Line_Numbers
{
    class Program
    {
        static void Main( string [ ] args )
        {
            using (StreamReader inputFile = new StreamReader(@"..\..\..\02. Line Numbers\Input.txt"))
            {
                using (StreamWriter OutPut = new StreamWriter(@"..\..\..\02. Line Numbers\OutPut.txt"))
                {
                    var count = 1;
                    var curLine = string.Empty;
                    while ((curLine = inputFile.ReadLine()) != null)
                    {
                        OutPut.WriteLine(count + ". " + curLine);
                        count++;
                    }
                }
            }
            
        }
    }
}
