﻿using System;
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
            this.hackConf = new Conference(Guid.NewGuid().ToString(), "HackConf", new Venue(Guid.NewGuid().ToString(), "NDK"), new DateTime(2017, 12, 5));
            hackConf.Venue.AddHall(new Hall(Guid.NewGuid().ToString(), 1, true));
            hackConf.Sessions = new List<TimeSlotAssociation>();

            this.openFest = new Conference(Guid.NewGuid().ToString(), "OpenFest", new Venue(Guid.NewGuid().ToString(), "NDK"), new DateTime(2017, 12, 7));
            openFest.Venue.AddHall(new Hall(Guid.NewGuid().ToString(), 2, true));
            openFest.Sessions = new List<TimeSlotAssociation>();
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
