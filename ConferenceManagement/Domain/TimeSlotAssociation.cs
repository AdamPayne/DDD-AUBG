using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class TimeSlotAssociation
    {
        Session session;
        TimeSlot timeSlot;

        public TimeSlotAssociation(Session session, TimeSlot timeSlot)
        {
            this.session = session ?? throw new ArgumentNullException(nameof(session));
            this.timeSlot = timeSlot ?? throw new ArgumentNullException(nameof(timeSlot));
        }

        public Session Session { get => session; set => session = value; }
        public TimeSlot TimeSlot { get => timeSlot; set => timeSlot = value; }
    }
}
