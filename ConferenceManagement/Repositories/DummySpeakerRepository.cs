using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Repositories
{
    public class DummySpeakerRepository : ISpeakerRepository
    {
        private Speaker speaker1;
        private Speaker speaker2;

        public DummySpeakerRepository()
        {
            this.speaker1 = new Speaker(Guid.NewGuid().ToString(), "Mihail Mikov", "Full-stack developer");
            this.speaker2 = new Speaker(Guid.NewGuid().ToString(), "Milan Nankov", ".NET developer");
        }

        public Speaker RetrieveSpeaker(string name)
        {
            if(name == speaker1.Name)
            {
                return speaker1;
            } else if (name == speaker2.Name)
            {
                return speaker2;
            }
            return null;
        }

        public void SaveSpeaker()
        {
            
        }
    }
}
