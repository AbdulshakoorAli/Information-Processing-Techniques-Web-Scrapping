using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace k191373_Q1
{
    internal class k191373_Q1
    {
        static void Main(string[] args)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    if (!Directory.Exists("D:\\" + args[1]))
                    {
                        Directory.CreateDirectory("D:\\"+ args[1]);
                    }
                    Uri uri = new Uri(args[0].ToString());
                    client.DownloadFile(uri, "D:\\" + args[1] +"\\Summary17Sept22.html");
                    Console.WriteLine("D:\\Assignment1\\ - will contain a file named Summary17Sept22.html");
                    _ = Console.ReadKey();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
