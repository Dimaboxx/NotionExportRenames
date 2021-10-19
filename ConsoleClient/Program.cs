using System;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string testdir = @"d:\Export\";


            BaseWork.Manager.PrintTree(testdir);


            Console.ReadLine();
            // Console.WriteLine("Hello World!");
        }
    }
}
