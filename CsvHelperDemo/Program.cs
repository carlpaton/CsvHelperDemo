using System;

namespace CsvHelperDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new ReadFile("sample.csv").Get();

            Console.Read();
        }
    }
}
