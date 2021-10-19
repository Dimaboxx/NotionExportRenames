using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using AngleSharp.Html.Parser;


namespace BaseWork
{
    public class Manager
    {
        //public static void GetD(string Path)
        //{

        //    foreach (var d in Directory.EnumerateDirectories(Path)  )
        //    {
        //        Console.WriteLine(d.Replace(Path,  new String( ' ' , Path.Length/4)));
        //        GetD(d);
        //    }

        //    foreach (var f in Directory.EnumerateFiles(Path))
        //    {

        //        Console.WriteLine(f.Replace(Path,  new String( ' ' , Path.Length/4)+"_"));
        //    }
        //    ;
        //}


        public static void PrintTree(string Path, int level = 0)
        {
            foreach (var d in Directory.EnumerateDirectories(Path))
            {
                printLevelShift(level);
                Console.WriteLine(d.Substring(Path.Length));
                PrintTree(d,level+1);

            }
                
            foreach (var f in Directory.EnumerateFiles(Path))
            {
                printLevelShift(level);
                Console.WriteLine(f.Substring(Path.Length));
                string file = File.ReadAllText(f);
                var p = new HtmlParser();
                var doc = p.ParseDocument(file);
                var links = doc.All.Where(m => m.LocalName == "a");
                foreach (var l in links)
                {
                    printLevelShift(level+1);
                   // Console.WriteLine(l.OuterHtml);
                    string link = l.GetAttribute("href");
                      var res = HttpUtility.UrlDecode(link);

                    Console.WriteLine(res);
                }
            }
        }

        public static void printLevelShift(int level, string s = "  ")
        {
            for (int l = 0; l < level; l++)
                Console.Write(s);
        }
    }
}
