using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

namespace SpecName
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xd = new XmlDocument();
            xd.Load("Books.xml");
            XmlNamespaceManager ns = new XmlNamespaceManager(xd.NameTable);
            ns.AddNamespace("x", "http://mynameisdharma.sh");
            XmlNodeList nodelist = xd.SelectNodes("//x:book[x:title='Harry Potter']",ns);

            foreach (XmlNode node in nodelist)
            {
                try
                {

                    Console.WriteLine(node.Attributes["category"].Value);
                    ////string title = node.SelectSingleNode("x:title").InnerText;
                    //string author = node.SelectSingleNode("/x:author").InnerText;
                    //string price = node.SelectSingleNode("//x:price").InnerText;
                    ////Console.WriteLine("Title: " + title);
                    //Console.WriteLine("Author: " + author);
                    //Console.WriteLine("Price: " + price);
                }
                catch (XPathException e)
                {
                    Console.WriteLine("Error in reading XML");


                }

            }

        }

    }
}