using System;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string testdir = @"d:\Export\";


            BaseWork.Manager.GetD(testdir);


            Console.ReadLine();
            // Console.WriteLine("Hello World!");
        }
    }
}
