using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Repositories
{
    public class DummyResourceRepository : IResourceRepository
    {
        private Resource resource1;
        private Resource resource2;
        
        public DummyResourceRepository()
        {
            this.resource1 = new Resource("Nikon D90", "camera", false);
            this.resource2 = new Resource("Dell XPS", "laptop", true);
        }

        public Resource RetrieveResource(string name)
        {
            if(name == resource1.Name)
            {
                return resource1;
            } else if (name == resource2.Name)
            {
                return resource2;
            }
            return null;
        }

        public void SaveResource()
        {
            
        }
    }
}
