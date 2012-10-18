using RDFRepresentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtering {
    public interface IOutput {

        /// <summary>
        /// Save triples to file.
        /// </summary>
        /// <param name="triples">Filtered triples to save.</param>
        /// <param name="filePath">Path to file for save.</param>
        public void save(List<Triple> triples, String filePath);
    }
}
