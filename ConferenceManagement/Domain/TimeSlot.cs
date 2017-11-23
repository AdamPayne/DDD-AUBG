using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain
{
    public class TimeSlot : ValueObject
    {
        private string startTime;
        private string endTime;

        public TimeSlot(string startTime,string endTime)
        {
            this.startTime = startTime;
            this.endTime = endTime;
        }

        public string StartTime { get { return this.startTime; } }
        public string EndTime { get { return this.endTime; } }


        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return this.startTime;
            yield return this.endTime;

        }

        protected override int GetHashCodeCore()
        {
            throw new NotImplementedException();
        }
    }
}
