using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * Type of entity to recognize in pattern triple.
 * @author pawelschmidt
 */
namespace RDFRepresentation {
    public class EntityType {
        private String name;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Name of entity type, i. e. "Obiekt budowlany"</param>
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
