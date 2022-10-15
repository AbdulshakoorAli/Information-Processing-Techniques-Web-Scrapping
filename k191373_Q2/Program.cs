using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using HtmlAgilityPack;
using static System.Net.Mime.MediaTypeNames;

namespace k191373_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int STARTER= 18; 
            int i = 0;
            int j = STARTER;
            int scriptsIndex = 0;
            bool toggle = false;
            List<string> list = new List<string>();
            List<string> keyvalue = new List<string>();

            var path = @"D:\Assignment1\Summary17Sept22.html";
            var doc = new HtmlDocument();
            doc.Load(path);

            HtmlNodeCollection resultContent = doc.DocumentNode.SelectNodes("//td");
            HtmlNodeCollection heading = doc.DocumentNode.SelectNodes("//div[contains(@class,'table-responsive')]//h4");
            foreach (HtmlNode node in heading)
            {
                string str = node.InnerText;
                str = str.Replace("//", "").Replace("/", "");

                list.Add(str);
            }                        
            foreach (HtmlNode node in resultContent)
            {
                if (i == j)
                {
                    keyvalue.Add(node.InnerText.Trim());
                    if (!toggle)
                    {                                              
                        j = j + 5;
                        toggle = true;
                    }
                    else
                    {                        
                        j = j + 3;
                        toggle = false;
                    }
                }
                i++;
            }

            foreach (string filename in list)
            {                
                string directory = "C:\\Users\\kk\\source\\repos\\k191373_Q2\\bin\\Debug\\" + filename;
                string file = directory + "\\" + filename + ".xml";

                if (!Directory.Exists(directory))
                    System.IO.Directory.CreateDirectory(directory);

                if (!File.Exists(file))
                {
                    XmlWriter xmlWriter = XmlWriter.Create(file);
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("xml");
                    while (true)
                    {
                        if (keyvalue[scriptsIndex] == "SCRIP" || keyvalue[scriptsIndex + 1] == "CURRENT" || scriptsIndex>keyvalue.Count())
                        {
                            scriptsIndex=scriptsIndex+2;
                            break;
                        }
                        xmlWriter.WriteStartElement("Scripts");
                        xmlWriter.WriteStartElement("script");
                        xmlWriter.WriteString(keyvalue[scriptsIndex]);
                        xmlWriter.WriteEndElement();
                        ++scriptsIndex;
                        xmlWriter.WriteStartElement("Price");
                        xmlWriter.WriteString(keyvalue[scriptsIndex]);
                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteEndElement();
                        ++scriptsIndex;
                    }
                    xmlWriter.WriteEndDocument();
                    xmlWriter.Close();
                }
            }
            Console.WriteLine("Task Completed Succesfully");
            _ = Console.ReadKey();
        }
    }
}
