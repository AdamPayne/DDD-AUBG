using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Repositories
{
    class DummyVenueRepository : IVenueRepository
    {
        private Venue venue1;
        private Venue venue2;

        public DummyVenueRepository()
        {
            this.venue1 = new Venue("NDK");
            this.venue2 = new Venue("John Atanasov Hall");
        }

        public Venue RetrieveVenue(string name)
        {
            if(name == venue1.Name)
            {
                return venue1;
            } else if (name == venue2.Name)
            {
                return venue2;
            }
            return null;
        }

        public void SaveVenue()
        {
            
        }
    }
}
