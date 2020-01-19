using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LinkManager
{
    public class Utility
    {
        public string getFileName()
        {
            return "C:\\Root.xml";
        }
        public XmlDocument readInputFile()
        {
            XmlDocument outputXml = new XmlDocument();
            string file = getFileName();
            outputXml.Load(file);
            return outputXml;
        }
    }
}
