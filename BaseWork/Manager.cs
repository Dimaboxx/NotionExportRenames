using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;

namespace BaseWork
{
    public class Manager
    {
        public static void GetD(string Path)
        {

            foreach (var d in Directory.EnumerateDirectories(Path)  )
            {
                Console.WriteLine(d.Replace(Path,  new String( ' ' , Path.Length/4)));
                GetD(d);
            }

            foreach (var f in Directory.EnumerateFiles(Path))
            {

                Console.WriteLine(f.Replace(Path,  new String( ' ' , Path.Length/4)+"_"));
            }
            ;
        }
    }
}
