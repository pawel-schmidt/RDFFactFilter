using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
/**
 * RDF triple object which contains info about object, property and subject.
 * @author pawelschmidt
 */
namespace RDFRepresentation {
    public class Triple {
        public Entity @object;
        public  Entity subject;
        public  Entity property;

        /// <summary>
        /// Entities which are connected. @object entity is connected with subject by property.
        /// </summary>
        /// <param name="object"></param>
        /// <param name="property"></param>
        /// <param name="subject"></param>
        public Triple(Entity @object, Entity property, Entity subject) {
            this.@object = @object;
            this.property = property;
            this.subject = subject;
        }
        
        public Triple() {
        }

        
        public override string ToString() {
            return "<\"" + @object + "\":" + @object.type + ", \"" + property + "\", \"" + subject + "\":" + subject.type + ">";
        }
    }
}
