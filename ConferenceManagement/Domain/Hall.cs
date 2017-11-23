using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain
{
    public class Hall
    {
        private int number;
        private bool availability;

        public Hall(int number,bool availability)
        {
            this.number = number;
            this.availability = availability;
        }

        public int Number { get { return this.number; } }
        public bool Availability { get { return this.availability; } set { this.availability = value; } }

    }
}
