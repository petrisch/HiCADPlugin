using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PluginTemplate
{
    public class PropertyReader
    {
        
        public string GetProperty(string pr_property, string filename)
        {
            XmlDocument document = new XmlDocument();
            document.Load(filename);
            XmlNode node = document.SelectSingleNode(pr_property);
            XmlElement element = (XmlElement)node;

            return element.InnerText;
        }
    }
}
