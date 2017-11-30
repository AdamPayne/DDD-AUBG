using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Resource
    {
        private string name;
        private string description;
        private bool availability;

        public Resource(string name, string description, bool availability)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.description = description ?? throw new ArgumentNullException(nameof(description));
            this.availability = availability;
        }

        public string Name { get => name; set => name = value; }
        public string Description { get { return this.description; } }
        public bool Availability { get { return this.availability; } set { this.availability = value; } }
    }
}
