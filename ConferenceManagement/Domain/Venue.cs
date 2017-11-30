using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Venue
    {
        private string id;
        private string name;
        private List<Hall> halls;

        public Venue(string id, string name)
        {
            this.id = id ?? throw new ArgumentNullException(nameof(id));
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.halls = new List<Hall>();
        }

        public string Name { get { return this.name; } set { this.name = value; } }

        public string Id { get => id; }

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
