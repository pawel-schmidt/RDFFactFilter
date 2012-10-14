using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RDFRepresentation {
    public class Entity {
        private String value;
        private EntityType type;

        public Entity(String value, EntityType type) {
            this.value = value;
            this.type = type;
        }

        public String Name {
            get { return value; }
        }

        public EntityType Type {
            get { return type; }
        }

        override public String ToString() {
            return value;
        }
    }
}
