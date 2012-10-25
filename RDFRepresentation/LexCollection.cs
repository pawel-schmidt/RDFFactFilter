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
	
    public class LexCollection /*: HashSet<String>*/ {
        public String name;
        public HashSet<String> items;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Name of lexicalizations collection, i. e. "OpisPowstawaniaObiektu"</param>
        public LexCollection(String name) {
            this.name = name;
            this.items = new HashSet<String>();
        }

        /**
         * Paremeterless constructor needed for serializer.
         */ 
        public LexCollection() {
        	this.items = new HashSet<String>();
        }
        
        /**
         * Just a gateway to HashSet.Add
         */ 
        public bool Add(String item) {
        	return this.items.Add(item);
        }
        
        /**
         * Just a gateway to HashSet.Contains
         */ 
        public Boolean Contains(Entity e) {
            return this.items.Contains(e.value);
        }

        public override string ToString() {
            return name + "{ " + String.Join(", ", this.items) + " }";
        }
    }
}
