using System;
using System.Collections.Generic;
using System.IO;

namespace Slice_a_File
{
    class Program
    {
        static void Main( string [ ] args )
        {
            int count = 4;
            using (FileStream sliceMeTextFile = new FileStream(@"../../../sliceMe.txt",FileMode.Open))
            {
                long size = sliceMeTextFile.Length / count;
                for (int i = 0; i < count; i++)
                {
                    using (var peaceStream = new FileStream($@"../../../Part-{i + 1}.txt",FileMode.Create))
                    {
                        byte[] buffer = new byte[1000];
                        int countByte = 0;
                        while (countByte <= size)
                        {
                            sliceMeTextFile.Read(buffer, 0, buffer.Length);
                            peaceStream.Write(buffer, 0, buffer.Length);
                            countByte += buffer.Length;
                        }

                    }
                }

            }
          
        }
    }
}
