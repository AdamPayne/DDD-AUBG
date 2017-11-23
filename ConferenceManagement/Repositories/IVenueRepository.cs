using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Repositories
{
    interface IVenueRepository
    {
        Venue RetrieveVenue(string name);
        void SaveVenue();
    }
}
