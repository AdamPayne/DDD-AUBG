using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Venue
    {
        private string name;
        private List<Hall> halls;

        public Venue(string name)
        {
            this.name = name;
            this.halls = new List<Hall>();
        }

        public string Name { get { return this.name; } set { this.name = value; } }

        public void AddHall(Hall m)
        {
            this.halls.Add(m);
        }

        public List<Hall> AllHalls()
        {
            return this.halls;
        }
        
        public List<Hall> GetAvailableHalls()
        {
            List<Hall> availableHalls = new List<Hall>();
            availableHalls = this.halls.Where(a => a.Availability == true).ToList();
            
            return availableHalls;
        }
    }
}
