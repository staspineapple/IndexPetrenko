using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace petrenko
{
    static class Result
    {
        static public void Show()
        {

            XmlDocument xmlrus = new XmlDocument();
            xmlrus.Load("C://Users/StasPortable/source/repos/petrenko/petrenko/Rus.xml");
            XmlElement xrootrus = xmlrus.DocumentElement;
            
            XmlDocument xmleng = new XmlDocument();
            xmleng.Load("C://Users/StasPortable/source/repos/petrenko/petrenko/Eng.xml");

            XmlElement xrooteng = xmleng.DocumentElement;

            int i = 1;
            int j = 1;
            foreach (XmlNode xnoderus in xrootrus)
            {
                

                foreach (XmlNode xnodeeng in xrooteng)
                {

                    if (IndexPetrenko.Calculate(xnoderus.InnerText) == IndexPetrenko.CalculateOfEng(xnodeeng.InnerText))
                    {
                        Console.WriteLine($"Index Petrenko coincided between lines {i} and {j}");
                    }
                    


                    j++;
                }
                i++;
            }
            
        }
    }
}
