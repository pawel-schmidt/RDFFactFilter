using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDFRepresentation {
    public class Triple {
        private Entity @object;
        private Entity subject;
        private Entity property;

        public Triple(Entity @object, Entity property, Entity subject) {
            this.@object = @object;
            this.property = property;
            this.subject = subject;
        }

        public Entity Object {
            get { return @object; }
        }

        public Entity Subject {
            get { return subject; }
        }

        public Entity Property {
            get { return property; }
        }

        public override string ToString() {
            return "<\"" + @object + "\", \"" + property + "\", \"" + subject + "\">";
        }
    }
}
