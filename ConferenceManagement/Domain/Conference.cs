using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Conference
    {
        private string id;
        private string name;
        private Venue venue;
        private DateTime date;
        private List<Resource> resources;
        private List<TimeSlotAssociation> sessions;
        private List<TimeSlot> timeslots;
        
        public Conference(string id, string name, Venue venue, DateTime date)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException("id");
            }
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Invalid name.");
            }
            if (venue == null)
            {
                throw new ArgumentNullException("venue");
            }
            if(date < DateTime.Now)
            {
                throw new Exception("date should be in the future");
            }
            this.name = name;
            this.venue = venue;
            this.date = date;
            this.resources = new List<Resource>();
            this.timeslots = new List<TimeSlot>();
            this.sessions = new List<TimeSlotAssociation>();
        } 

        public void addTimeSlot(TimeSlot timeSlot)
        {
            bool overlap = this.timeslots.Exists(t => ((t.StartTime >= timeSlot.StartTime && t.EndTime <= timeSlot.EndTime)
            || (t.EndTime > timeSlot.EndTime && t.StartTime < timeSlot.EndTime)
            || (t.StartTime > timeSlot.StartTime && t.StartTime < timeSlot.EndTime)) && t.Hall.Id== timeSlot.Hall.Id);
            if(overlap)
            {
                throw new Exception("Time slot clash");
            }
            this.timeslots.Add(timeSlot);
        }

        public bool addSession(TimeSlot timeSlot, Session session)
        {
            bool timeSlotExists = this.timeslots.Exists(t => t == timeSlot);
            bool timeSlotTaken = this.sessions.Exists(s => s.TimeSlot == timeSlot);
            bool isWorkshop = Object.ReferenceEquals(session.GetType(), typeof(Workshop));
            if (timeSlotExists && !timeSlotTaken)
            {
                if (isWorkshop)
                {
                    int timeslotsTaken = this.sessions.Count(w => w.Session == session);
                    if(timeslotsTaken < ((Workshop)session).DaysDuration)
                    {
                        sessions.Add(new TimeSlotAssociation(session, timeSlot));
                        return true;
                    } else
                    {
                        return false;
                    }
                } else
                {
                    bool sessionTaken = this.sessions.Exists(s => s.Session == session);
                    if (!sessionTaken)
                    {
                        sessions.Add(new TimeSlotAssociation(session, timeSlot));
                        return true;
                    } else
                    {
                        return false;
                    }

                }
            } else
            {
                return false;
            }
        }

        public void assignResource(Resource r, TimeSlotAssociation s)
        {
            s.Session.Resources.Add(r);
            r.Availability = false;
        }
         
        public string Id { get => id; }
        public string Name { get => name; set => name = value; }
        public Venue Venue { get => venue; set => venue = value; }
        public DateTime Date { get => date; set => date = value; }
        public List<TimeSlotAssociation> Sessions { get => sessions; set => sessions = value; }
        public List<Resource> Resources { get => resources; set => resources = value; }
        public List<TimeSlot> Timeslots { get => timeslots; set => timeslots = value; }
    }
}
