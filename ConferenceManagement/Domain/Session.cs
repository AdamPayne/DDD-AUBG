using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Session:ValueObject
    {
        private string name;
        private string topic;
        private Speaker speaker;
        private TimeSlot timeSlot;

        public Session(string name,string topic,Speaker speaker)
        {
            this.name = name;
            this.topic = topic;
            this.speaker = speaker;
                
        }

        public string Name { get { return this.name; } }
        public string Topic { get { return this.topic; } }
        public Speaker Speaker { get { return this.speaker; } }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return this.name;
            yield return this.topic;
            yield return this.speaker;
        }

        protected override int GetHashCodeCore()
        {
            throw new NotImplementedException();
        }
    }
}
