using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    class Program
    {
        static void Main( string [ ] args )
        {
            Dictionary<string, int> wordsList = new Dictionary<string, int>();
            using (StreamReader streamReader = new StreamReader(@"../../../words.txt")
)
            {
                var curText = streamReader.ReadToEnd().Split().ToList();
                foreach (var item in curText)
                {
                    wordsList.Add(item.ToLower(), 0);
                }
            }
            using (StreamReader textFile = new StreamReader(@"../../../text.txt"))
            {
                string curLine = textFile.ReadLine( );
                while (curLine != null)
                {
                    var splitWords = curLine.Split(new string[]{" ", "." , "?", "-" ,","},StringSplitOptions.RemoveEmptyEntries);
                    foreach (var item in splitWords)
                    {
                        if (wordsList.ContainsKey(item.ToLower()))
                        {
                            wordsList [ item.ToLower() ] += 1;
                        }
                    }
                    curLine = textFile.ReadLine( );
                }
            }
            using (StreamWriter outPutFile = new StreamWriter(@"../../../OutPut.txt"))
            {
                foreach (var item in wordsList.OrderByDescending(x => x.Value))
                {
                    outPutFile.WriteLine(item.Key + " - " + item.Value);
                }
            }
        }
    }
}
