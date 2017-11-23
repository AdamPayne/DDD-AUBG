using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Repositories
{
    public class DummyConferenceRepository : IConferenceRepository
    {
        private Conference hackConf;
        private Conference openFest;

        public DummyConferenceRepository()
        {
            this.hackConf = new Conference();
            hackConf.Name = "HackConf";
            hackConf.Venue = new Venue("NDK");
            hackConf.Venue.AddHall(new Hall(1, true));

            this.openFest = new Conference();
            openFest.Name = "OpenFest";
            openFest.Venue = new Venue("NDK");
            openFest.Venue.AddHall(new Hall(2, true));
        }
        public Conference RetrieveConference(string name)
        {
            if (name == "HackConf")
            {
                return hackConf;
            } else if (name == "OpenFest")
            {
                return openFest;
            }
            return null;
        }

        public void SaveConference()
        {
            
        }
    }
}
