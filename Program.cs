using System;
using System.Diagnostics;
using System.Web;

namespace ExplorerOpen
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0){
                string arg = HttpUtility.UrlDecode(args[0]);
                string caminho = arg.Remove(0,arg.IndexOf(':')+1);
                Process.Start(caminho);
            }
        }
    }
}