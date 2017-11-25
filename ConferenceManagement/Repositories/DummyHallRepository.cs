using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Repositories
{
    public class DummyHallRepository : IHallRepository
    {
        private Hall hall1;
        private Hall hall2;

        public DummyHallRepository()
        {
            this.hall1 = new Hall(Guid.NewGuid().ToString(), 1, true);
            this.hall2 = new Hall(Guid.NewGuid().ToString(), 2, false);
        }

        public Hall RetrieveHall(int number)
        {
            if (number == hall1.Number)
            {
                return hall1;
            } else if (number == hall2.Number)
            {
                return hall2;
            }
            return null;
        }

        public void SaveHall()
        {
            
        }
    }
}
