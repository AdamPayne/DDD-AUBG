using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Repositories
{
    interface IResourceRepository
    {
        Resource RetrieveResource(string name);
        void SaveResource();
    }
}
