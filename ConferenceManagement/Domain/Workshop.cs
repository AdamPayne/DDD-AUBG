using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Workshop
    {
        private string name;
        private string topic;
        private int capacity;
        private int daysDuration;
        private int seatsTaken;
        private Speaker speaker;
        private List<TimeSlot> timeSlots;

        public Workshop(string name,string topic,int capacity,int days,Speaker speaker)
        {
            this.name = name;
            this.topic = topic;
            this.capacity = capacity;
            this.daysDuration = days;
            this.seatsTaken = 0;
            this.speaker = speaker;
            this.timeSlots = new List<TimeSlot>();
            
        }

        public string Name { get { return this.name; } }
        public string Topic { get { return this.topic; } }
        public int Capacity { get { return this.capacity; } }
        public int DaysDuration { get { return this.daysDuration; } set { this.daysDuration = value; } }
        public int SeatsTaken { get { return this.seatsTaken; }}
        public Speaker Speaker { get { return this.speaker; }}
        public List<TimeSlot> TimeSlots { get => timeSlots; set => timeSlots = value; }

        public void IncreaseSeatsTakenNumber(int number)
        {
            this.seatsTaken += number;

        }



    }
}
