using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Speaker:ValueObject
    {
        private string name;

        public Speaker(string name)
        {
            this.name = name;
        }

        public string Name { get { return this.name; } }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return this.name;
        }

        protected override int GetHashCodeCore()
        {
            throw new NotImplementedException();
        }
    }
}
