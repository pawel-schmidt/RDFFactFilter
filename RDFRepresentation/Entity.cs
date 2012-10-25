using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

/**
 * Entity representation with value and type fields.
 * @author pawelschmidt
 */
namespace RDFRepresentation {
    public class Entity {
        public String value;
        public EntityType type;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">Value of entity, for example "Fort I"</param>
        /// <param name="type">Type of entity, which name is i. e. "Zamek"</param>
        public Entity(String value, EntityType type) {
            this.value= value;
            this.type = type;
        }

        public Entity() {
        	
        }
      
        override public String ToString() {
            return value;
        }
    }
}
