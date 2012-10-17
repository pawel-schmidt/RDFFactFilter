using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Object used to store lexicalizations.
 * @author pawelschmidt
 */
namespace RDFRepresentation {
    public class LexCollection : HashSet<String> {
        private String name;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Name of lexicalizations collection, i. e. "OpisPowstawaniaObiektu"</param>
        public LexCollection(String name) {
            this.name = name;
        }

        public Boolean Contains(Entity e) {
            return base.Contains(e.Name);
        }

        public String Name {
            get { return name; }
        }

        public override string ToString() {
            return name + "{ " + String.Join(", ", this) + " }";
        }
    }
}
