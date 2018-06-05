using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMultikinoRepertoire
{
    class Event
    {
        private String cinema;
        private String location;
        private String title;
        private String release;
        private String date;
        private String version;
        private String link;

        public Event(string cinema, string location, string title, string release, string date, string version, string link)
        {
            this.cinema = cinema;
            this.location = location;
            this.title = title;
            this.release = release;
            this.date = date;
            this.version = version;
            this.link = link;
        }

        public string Cinema { get => cinema; set => cinema = value; }
        public string Location { get => location; set => location = value; }
        public string Title { get => title; set => title = value; }
        public string Release { get => release; set => release = value; }
        public string Date { get => date; set => date = value; }
        public string Version { get => version; set => version = value; }
        public string Link { get => link; set => link = value; }
    }
}
