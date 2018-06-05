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

        public IEnumerable<XElement> FindByTitle(String title)
        {
            var results = from items in Element.Elements("showing") where (string)items.Element("film_title") == title select items;
            return results;
        }

        public IEnumerable<XElement> FindByYear(String year)
        {
            var result = from items in Element.Elements("showing")
                         where (string)items.Element("release_date") == year
                         select items;
            return result;
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
    }
}
