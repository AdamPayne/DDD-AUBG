using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Workshop:Session
    {
        private int capacity;
        private int daysDuration;
        private int seatsTaken;

        public Workshop(string id, string name,string topic,int capacity,int days,Speaker speaker):base(id, name, topic, speaker)
        {
            if(capacity < 1)
            {
                throw new Exception("Invalid capacity.");
            }
            if(days < 1)
            {
                throw new Exception("Invalid duration.");
            }
            this.capacity = capacity;
            this.daysDuration = days;
            this.seatsTaken = 0;
        }

        public int Capacity { get { return this.capacity; } }
        public int DaysDuration { get { return this.daysDuration; } set { this.daysDuration = value; } }
        public int SeatsTaken { get { return this.seatsTaken; }}

        public void IncreaseSeatsTakenNumber(int number)
        {
            if (seatsTaken+number <= capacity)
            {
                this.seatsTaken += number;
            }
            else
            {
                throw new Exception("cannot add more seats");
            }

        }


        public static bool operator ==(Workshop w1, Workshop w2)
        {
            return w1.Equals(w2);
        }

        public static bool operator !=(Workshop w1, Workshop w2)
        {
            return !w1.Equals(w2);
        }
    }
}
