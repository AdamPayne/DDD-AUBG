using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Repositories
{
    class DummyWorkshopRepository : IWorkshopRepository
    {
        private Workshop workshop1;
        private Workshop workshop2;

        public DummyWorkshopRepository()
        {
            this.workshop1 = new Workshop("Intro to DDD", "DDD", 50, 2, new Speaker("Milan Nankov"));
            this.workshop2 = new Workshop("Git Panic", "Git", 50, 2, new Speaker("Mihail Mikov"));
        }

        public Workshop RetrieveWorkshop(string name)
        {
            if(name == workshop1.Name)
            {
                return workshop1;
            }else if (name == workshop2.Name)
            {
                return workshop2;
            }
            return null;
        }

        public void SaveWorkshop()
        {
            
        }
    }
}
