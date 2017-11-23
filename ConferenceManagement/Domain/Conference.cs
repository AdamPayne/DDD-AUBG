using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Conference
    {
        private string name;
        private Venue venue;
        private DateTime date;
        private List<Session> sessions;
        private List<Workshop> workshops;
        
        public Conference(string name, Venue venue, DateTime date)
        {
            this.name = name;
            this.venue = venue;
            this.date = date;
        }

        public Conference()
        {

        }

        public string Name { get => name; set => name = value; }
        public Venue Venue { get => venue; set => venue = value; }
        public DateTime Date { get => date; set => date = value; }
        public List<Session> Sessions { get => sessions; set => sessions = value; }
        public List<Workshop> Workshops { get => workshops; set => workshops = value; }
    }
}
