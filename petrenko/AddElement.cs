using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace petrenko
{
    static class AddElement
    {

        static public void AddRus(string rusword)
        {


            



            //adding to xml rus phrases

            XmlDocument xmlrus = new XmlDocument();
            xmlrus.Load("C://Users/StasPortable/source/repos/petrenko/petrenko/Rus.xml");
            XmlElement xrootrus = xmlrus.DocumentElement;
            XmlElement RusText = xmlrus.CreateElement("text");
            XmlText textrus = xmlrus.CreateTextNode($"{rusword}");
            RusText.AppendChild(textrus);
            xrootrus.AppendChild(RusText);
            xmlrus.Save("C://Users/StasPortable/source/repos/petrenko/petrenko/Rus.xml");
        }

        static public void AddEng(string engword)
        {
            //adding to xml eng phrases 
            XmlDocument xmleng = new XmlDocument();
            xmleng.Load("C://Users/StasPortable/source/repos/petrenko/petrenko/Eng.xml");

            XmlElement xrooteng = xmleng.DocumentElement;
            XmlElement EngText = xmleng.CreateElement("text");
            XmlText texteng = xmleng.CreateTextNode($"{engword}");
            EngText.AppendChild(texteng);
            xrooteng.AppendChild(EngText);
            xmleng.Save("C://Users/StasPortable/source/repos/petrenko/petrenko/Eng.xml");
        }
    }
}
