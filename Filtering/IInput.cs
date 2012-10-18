﻿using RDFRepresentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtering {
    public interface IInput {
        /// <summary>
        /// Read triples from file.
        /// </summary>
        /// <param name="filePath">Path to the file.</param>
        /// <returns>List of read triples.</returns>
        public List<Triple> readTriples(String filePath);

        /// <summary>
        /// Read pattern triples from file.
        /// </summary>
        /// <param name="filePath">Path to the file.</param>
        /// <returns>List of read pattern triples.</returns>
        public List<Triple> readPatternTriples(String filePath);

        /// <summary>
        /// Read lexicalizations from file.
        /// </summary>
        /// <param name="filePath">Path to the file.</param>
        /// <returns>List of read lexicalizations.</returns>
        public List<LexCollection> readLexicalizations(String filePath);
    }
}