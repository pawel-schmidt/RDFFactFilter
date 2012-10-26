using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

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
        
        [JsonConstructor]
        public EntityType(String name, List<EntityType>  subtypes) {
            this.name = name;
            this.subtypes = subtypes;
        }
        
        override public String ToString() {
            return name;
        }
    }
}
