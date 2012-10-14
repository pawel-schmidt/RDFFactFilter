using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDFRepresentation {
    public class Triple {
        private String @object;
        private String subject;
        private String property;

        public Triple(String @object, String property, String subject) {
            this.@object = @object;
            this.property = property;
            this.subject = subject;
        }

        public String Object {
            get { return @object; }
            set { @object = value; }
        }

        public String Subject {
            get { return subject; }
            set { subject = value; }
        }

        public String Property {
            get { return property; }
            set { property = value; }
        }

    }
}
