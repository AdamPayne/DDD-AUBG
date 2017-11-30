using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Repositories
{
    public class DummySessionRepository : ISessionRepository
    {
        private Session session1;
        private Session session2;

        public DummySessionRepository()
        {
            this.session1 = new Session(Guid.NewGuid().ToString(), "Git Panic", "VCS", 
                new Speaker(Guid.NewGuid().ToString(), "Mihail Mikov", "Full-stack developer"));
            this.session2 = new Session(Guid.NewGuid().ToString(), "Cloud computing with Azure", "Cloud Computing",
                new Speaker(Guid.NewGuid().ToString(), "Milan Nankov", ".NET Developer"));

        }

        public Session RetrieveSession(string name)
        {
            if (name == session1.Name)
            {
                return session1;
            }
            else if (name == session2.Name)
            {
                return session2;
            }
            return null;
        }

        public void SaveSession()
        {
            throw new NotImplementedException();
        }
    }
}
