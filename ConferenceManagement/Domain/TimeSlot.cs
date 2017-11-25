using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain
{
    public class TimeSlot : ValueObject
    {
        private DateTime startTime;
        private DateTime endTime;
        private Hall hall;

        public TimeSlot(DateTime startTime, DateTime endTime, Hall hall)
        {
            if(endTime < startTime)
            {
                throw new Exception("End time should be after start time");
            }
            if (hall == null)
            {
                throw new Exception("Hall should be specified");
            }
            this.startTime = startTime;
            this.endTime = endTime;
            this.hall = hall;
        }

        public DateTime StartTime { get { return this.startTime; } }
        public DateTime EndTime { get { return this.endTime; } }

        public Hall Hall { get => hall; set => hall = value; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return this.startTime;
            yield return this.endTime;
            yield return this.hall.Id;

        }

        protected override int GetHashCodeCore()
        {
            throw new NotImplementedException();
        }
    }
}
