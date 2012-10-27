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
        public EntityType(String name, List<EntityType> subtypes) {
            this.name = name;
            this.subtypes = subtypes;
        }
        
        override public String ToString() {
            return name;
        }

        public String getHierarchyString() {
            return subtypesToString(this, 0);
        }

        private String subtypesToString(EntityType types, int level) {
            StringBuilder result = new StringBuilder();
            for (int i = 1; i < level; ++i) {
                result.Append("|   ");
            }
            if (level > 0) result.Append("|-");
            result.Append(types.name);
            result.Append("\n");
            foreach (EntityType et in types.subtypes) {
                result.Append(subtypesToString(et, level + 1));
            }
            return result.ToString();
        }

        public EntityType getType(String typeToFind) {
            EntityType result = search(this, typeToFind);
            return result == null? this : result;
        }

        private static EntityType search(EntityType type, String typeToFind) {
            if (type.name.Equals(typeToFind, StringComparison.OrdinalIgnoreCase)) {
                return type;
            }
            EntityType result = null;
            EntityType secondResult = null;
            foreach (EntityType et in type.subtypes) {
                if (result == null)
                    result = search(et, typeToFind);
                else if (secondResult == null)
                    secondResult = search(et, typeToFind);
                else
                    return type;
            }
            if (secondResult != null)
                return type;
            if (result != null)
                if (type.subtypes.Contains(result) && result.name.Equals(typeToFind, StringComparison.OrdinalIgnoreCase))
                    return type;
            return result;
        }
    }
}
