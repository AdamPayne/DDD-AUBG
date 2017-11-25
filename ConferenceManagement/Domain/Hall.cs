using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain
{
    public class Hall
    {
        private string id;
        private int number;
        private bool availability;

        public Hall(string id, int number, bool availability)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException("id");
            }
            this.id = id;
            this.number = number;
            this.availability = availability;
        }

        public int Number { get { return this.number; } }
        public bool Availability { get { return this.availability; } set { this.availability = value; } }

        public string Id { get => id; }
    }
}
