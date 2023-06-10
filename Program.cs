using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace ListTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "D:\\repozitor\\ListTest.13\\Text\\Text1.txt";
            var text = File.ReadAllText(path);

            var watchOne = Stopwatch.StartNew();

            var strings1 = new List<string>();
            if (text != null)
                strings1.Add(text);
            Console.WriteLine($"Вставка в  лист: {watchOne.Elapsed.TotalMilliseconds}  мс");

            var watchTwo = Stopwatch.StartNew();

            var strings2 = new LinkedList<string>();
            if (text != null)
                strings2.AddFirst(text);
            Console.WriteLine($"Вставка в  лист: {watchTwo.Elapsed.TotalMilliseconds}  мс");
        }
    }
}