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

        public Session(string id, string name, string topic, Speaker speaker)
        {
            this.id = id ?? throw new ArgumentNullException(nameof(id));
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.topic = topic ?? throw new ArgumentNullException(nameof(topic));
            this.speaker = speaker ?? throw new ArgumentNullException(nameof(speaker));
        }

        public string Id { get => id; }
        public string Name { get { return this.name; } }
        public string Topic { get { return this.topic; } }
        public Speaker Speaker { get { return this.speaker; } }
    }
}
