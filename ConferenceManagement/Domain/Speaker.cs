using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Speaker
    {
        private string id;
        private string name;
        private string biography;

        public Speaker(string id, string name, string biography)
        {
            this.id = id ?? throw new ArgumentNullException(nameof(id));
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.biography = biography ?? throw new ArgumentNullException(nameof(biography));
        }

        public string Id { get => id; }
        public string Name { get => name; set => name = value; }
        public string Biography { get => biography; set => biography = value; }
    }
}
