using System;

namespace CS.Itself.Delegates
{
    public class Writer
    {
        public static void WriteChapterHeader(string header)
        {
            Console.WriteLine(header + " static");
        }

        public void WriteChapterText(string text)
        {
            Console.WriteLine(text + " instance");
        }
    }
}
