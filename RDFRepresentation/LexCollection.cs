using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDFRepresentation {
    public class LexCollection : HashSet<String> {
        private String name;

        public LexCollection(String name) {
            this.name = name;
        }

        public Boolean Contains(Entity e) {
            return base.Contains(e.Name);
        }

        public String Name {
            get { return name; }
        }

        public override string ToString() {
            return name + "{ " + String.Join(", ", this) + " }";
        }
    }
}
