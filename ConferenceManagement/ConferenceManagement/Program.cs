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
            DummyConferenceRepository d = new DummyConferenceRepository();
            Console.Write(d.RetrieveConference("HackConf").Name);
        }
    }
}
