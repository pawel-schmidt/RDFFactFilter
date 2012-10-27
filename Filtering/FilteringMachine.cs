using RDFRepresentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtering {
    public class FilteringMachine {

        /// <summary>
        /// Method used to filter facts from (phrase) triples.
        /// </summary>
        /// <param name="triples">List of (phrase) triples.</param>
        /// <param name="patternTriples">List of pattern triples.</param>
        /// <param name="lexicalizations">List of lexicalizations collections.</param>
        /// <returns>These (phrase) triples which match to collection of pattern triples.</returns>
        public static List<Triple> filter(List<Triple> triples, List<Triple> patternTriples, List<LexCollection> lexicalizations, EntityType typeHierarchy) {
            List<Triple> result = new List<Triple>();

            foreach (Triple t in triples) {

                foreach (Triple pt in patternTriples) {

                    foreach (LexCollection l in lexicalizations) {

                        // if property name of pattern triple and lexicalizations collection name are the same
                        if (pt.property.type.name.Equals(l.name, StringComparison.OrdinalIgnoreCase)) {
                            
                            foreach (String lex in l.items) {
                                // if lexicalization is equal to triple property
                                if (lex.Equals(t.property.value, StringComparison.OrdinalIgnoreCase)) {
                                    // create new triple - combination of (phrase) triple (names) and pattern triple (types)
                                    Triple toAdd = new Triple();
                                    toAdd.@object = new Entity(t.@object.value, typeHierarchy.getType(lex));
                                    toAdd.property = new Entity(t.property.value, pt.property.type);
                                    toAdd.subject = new Entity(t.subject.value, typeHierarchy.getType(lex));

                                    // add to result list and jump out from loop
                                    result.Add(toAdd);
                                    goto outer;
                                }
                            }
                        }
                    }
                }
                outer: {}
            }
            return result;
        }
    }
}
