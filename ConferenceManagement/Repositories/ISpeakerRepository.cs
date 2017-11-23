using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Repositories
{
    interface ISpeakerRepository
    {
        Speaker RetrieveSpeaker(string name);
        void SaveSpeaker();
    }
}
