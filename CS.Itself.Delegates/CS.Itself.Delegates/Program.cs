using System;

namespace CS.Itself.Delegates
{
    class Program
    {
        delegate void WriteToConsole(string message);

        static void Main(string[] args)
        {
            Writer writer = new Writer();

            WriteToConsole wtc = Writer.WriteChapterHeader;
            wtc += writer.WriteChapterText;

            wtc("Chapter One");

        }
    }
}
