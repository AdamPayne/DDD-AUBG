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
            Console.WriteLine(hackConf.Name);

            DummyResourceRepository resourceRepo = new DummyResourceRepository();
            Resource nikon = resourceRepo.RetrieveResource("Nikon D90");
            Console.WriteLine(nikon.Description);

            DummyWorkshopRepository workshopRepo = new DummyWorkshopRepository();
            //hackConf.Sessions.Add(workshopRepo.RetrieveWorkshop("Intro to DDD"));


            Console.WriteLine(hackConf.Workshops[0].TimeSlots[0].StartTime + " - " + hackConf.Workshops[0].TimeSlots[0].EndTime);
            Console.WriteLine(hackConf.Workshops[0].TimeSlots[1].StartTime + " - " + hackConf.Workshops[0].TimeSlots[1].EndTime);
        }
    }
}
