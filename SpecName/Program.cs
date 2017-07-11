using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SpecName
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xd = new XmlDocument();
            xd.Load("Books.xml");

            XmlNodeList nodelist = xd.SelectNodes("//book[title='Harry Potter']");

            foreach (XmlNode node in nodelist)
            {
                try
                {
                    string title = node.SelectSingleNode("title").InnerText;
                    string author = node.SelectSingleNode("author").InnerText;
                    string price = node.SelectSingleNode("price").InnerText;
                    Console.WriteLine("Title: " + title);
                    Console.WriteLine("Author: " + author);
                    Console.WriteLine("Price: " + price);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error in reading XML");


                }

            }

        }

    }
}