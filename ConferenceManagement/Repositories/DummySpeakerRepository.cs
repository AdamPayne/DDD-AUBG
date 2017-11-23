using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Repositories
{
    class DummySpeakerRepository : ISpeakerRepository
    {
        private Speaker speaker1;
        private Speaker speaker2;

        public DummySpeakerRepository()
        {
            this.speaker1 = new Speaker("Mihail Mikov");
            this.speaker2 = new Speaker("Milan Nankov");
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
