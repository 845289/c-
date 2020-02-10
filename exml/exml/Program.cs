using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace exml
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(@"D:\project\c#\exml\XMLFILE.xml");
            XmlNode currentnode = xml.DocumentElement.FirstChild;
            Console.WriteLine(currentnode.InnerText);
            XmlNode nextnode = currentnode.NextSibling;
            Console.WriteLine(nextnode.InnerText);
            XmlNode node3 = nextnode.NextSibling;
            Console.WriteLine(node3.InnerText);


        }
      
    }
}
