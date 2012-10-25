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
        public String name;
        public List<EntityType> subtypes = new List<EntityType>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Name of entity type, i. e. "Obiekt budowlany"</param>
        public EntityType(String name) {
            this.name = name;
        }
        
        override public String ToString() {
            return name;
        }
    }
}
