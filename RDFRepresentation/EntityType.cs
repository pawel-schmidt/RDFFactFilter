using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RDFRepresentation {
    public class EntityType {
        private String name;

        public EntityType(String name) {
            this.name = name;
        }

        public String Name {
            get { return name; }
        }
        
        override public String ToString() {
            return name;
        }
    }
}
