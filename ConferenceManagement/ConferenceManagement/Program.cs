using System;
using System.Collections.Generic;
using Domain;
using Repositories;

namespace ConferenceManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            DummyConferenceRepository confRepo = new DummyConferenceRepository();
            Conference hackConf = confRepo.RetrieveConference("HackConf");

            DummyResourceRepository resourceRepo = new DummyResourceRepository();
            Resource nikon = resourceRepo.RetrieveResource("Nikon D90");

            DummyVenueRepository venueRepo = new DummyVenueRepository();
            Venue ndk = venueRepo.RetrieveVenue("NDK");

            DummyHallRepository hallRepo = new DummyHallRepository();
            Hall hall1 = hallRepo.RetrieveHall(1);
            Hall hall2 = hallRepo.RetrieveHall(2);

            DummySessionRepository sessionsRepo = new DummySessionRepository();
            DummyWorkshopRepository workshopRepo = new DummyWorkshopRepository();

            TimeSlot t1 = new TimeSlot(new DateTime(2017, 12, 5, 10, 0, 0), new DateTime(2017, 12, 5, 11, 0, 0), hall1);
            TimeSlot t2 = new TimeSlot(new DateTime(2017, 12, 5, 11, 0, 0), new DateTime(2017, 12, 5, 12, 0, 0), hall1);
            TimeSlot t3 = new TimeSlot(new DateTime(2017, 12, 5, 12, 0, 0), new DateTime(2017, 12, 5, 13, 0, 0), hall2);
            TimeSlot t4 = new TimeSlot(new DateTime(2017, 12, 5, 13, 0, 0), new DateTime(2017, 12, 5, 14, 0, 0), hall2);

            hackConf.addTimeSlot(t1);
            hackConf.addTimeSlot(t2);
            hackConf.addTimeSlot(t3);
            hackConf.addTimeSlot(t4);

            hackConf.addSession(t1, sessionsRepo.RetrieveSession("Git Panic"));
            hackConf.addSession(t2, sessionsRepo.RetrieveSession("Cloud computing with Azure"));
            hackConf.addSession(t3, workshopRepo.RetrieveWorkshop("Intro to DDD"));
            hackConf.addSession(t4, workshopRepo.RetrieveWorkshop("Intro to Docker"));

            foreach(TimeSlotAssociation ta in hackConf.Sessions)
            {
                Console.WriteLine(ta.TimeSlot.StartTime + "\t" + ta.Session.Name);
            }

            hackConf.Resources.Add(nikon);
            hackConf.assignResource(nikon, hackConf.Sessions[0]);
        }
    }
}
