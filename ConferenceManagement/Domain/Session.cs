using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Session
    {
        private string id;
        private string name;
        private string topic;
        private Speaker speaker;
        private List<Resource> resources;

        public Session(string id, string name, string topic, Speaker speaker)
        {
            this.id = id ?? throw new ArgumentNullException(nameof(id));
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.topic = topic ?? throw new ArgumentNullException(nameof(topic));
            this.speaker = speaker ?? throw new ArgumentNullException(nameof(speaker));
            this.resources = new List<Resource>();
        }

        public override bool Equals(object obj)
        {
            // Check for null values and compare run-time types.
            if (obj == null || GetType() != obj.GetType())
                return false;

            Session s = (Session)obj;
            return s.Id==this.Id;
        }

        public static bool operator== (Session s1, Session s2)
        {
            return s1.Equals(s2);
        }

        public static bool operator !=(Session s1, Session s2)
        {
            return !s1.Equals(s2);
        }

        public string Id { get => id; }
        public string Name { get { return this.name; } }
        public string Topic { get { return this.topic; } }
        public Speaker Speaker { get { return this.speaker; } }

        public List<Resource> Resources { get => resources; set => resources = value; }

    }
}
