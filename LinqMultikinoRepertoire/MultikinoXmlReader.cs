using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqMultikinoRepertoire
{
    class MultikinoXmlReader
    {
        private static String url = "https://apibeta.multikino.pl/repertoire.xml";
        private XElement element;

        public XElement Element { get => element; set => element = value; }

        public MultikinoXmlReader()
        {
            this.Element = XElement.Load(url).Element("showing");
        }

        public IEnumerable<XElement> FindBy(String s1, String query1, String s2, String query2, String orderBy)
        {
            var results = from items in Element.Elements("showing") where (string)items.Element(query1) == s1 && (string)items.Element(query2) == s2 orderby (string)items.Element(orderBy) select items;
            return results;
        }

        public IEnumerable<XElement> FindBy(String s1, String query1, String orderBy)
        {
            var results = from items in Element.Elements("showing") where (string)items.Element(query1) == s1 orderby (string)items.Element(orderBy) select items;
            return results;
        }

        public static List<Event> ConvertToEventList(IEnumerable<XElement> elements)
        {
            List<Event> events = new List<Event>();
            foreach(XElement e in elements)
            {
                events.Add( new Event( e.Element("cinema_name").Value, 
                                        e.Element("location_name").Value,
                                        e.Element("film_title").Value,
                                        e.Element("release_date").Value,
                                        e.Element("event_time").Value,
                                        e.Element("version_name").Value,
                                        e.Element("direct_link").Value) );
            }

            return events;
        }

        public static String Map(String str)
        {
            switch(str)
            {
                case "None":
                    return "";
                case "Cinema":
                    return "cinema_name";
                case "Location":
                    return "location_name";
                case "Title":
                    return "film_title";
                case "Year":
                    return "release_date";
                case "Time":
                    return "event_time";
                case "Version":
                    return "version_name";
            }

            return "";
        }
    }
}
