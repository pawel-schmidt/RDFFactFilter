using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DAO;
using RDFRepresentation;
using Filtering;

namespace TestingGUI {
    public partial class Form1 : Form {
        private IInput input = new Jsonify();
        private IOutput output = new Jsonify();
        private List<Triple> triples;
        private List<Triple> patternTriples;
        private List<Triple> filteredTriples;
        private List<LexCollection> lex;
        private const String DIALOG_FILTER = "json files (*.json)|*.json|All files (*.*)|*.*";

        public Form1() {
            InitializeComponent();
            openFileDialog.InitialDirectory = Application.StartupPath + @"..\..\";
            saveFileDialog.InitialDirectory = Application.StartupPath;
        }

        private void BtnLoadTriplesClick(object sender, EventArgs e) {
            openFileDialog.Filter = DIALOG_FILTER;

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                triples = input.readTriples(openFileDialog.FileName);
                listBoxTriples.Items.Clear();
                foreach (Triple t in triples) {
                    listBoxTriples.Items.Add(t.ToString());
                }
            }
        }

        private void BtnLoadPatternTriplesClick(object sender, EventArgs e) {
            openFileDialog.Filter = DIALOG_FILTER;

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                patternTriples = input.readPatternTriples(openFileDialog.FileName);
                listBoxPatternTriples.Items.Clear();
                foreach (Triple t in patternTriples) {
                    listBoxPatternTriples.Items.Add(t.ToString());
                }
            }
        }

        private void BtnLoadLexClick(object sender, EventArgs e) {
            openFileDialog.Filter = DIALOG_FILTER;
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                lex = input.readLexicalizations(openFileDialog.FileName);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e) {
            filteredTriples = FilteringMachine.filter(triples, patternTriples, lex);
            foreach (Triple t in filteredTriples) {
                listBoxFiltered.Items.Add(t.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                output.save(FilteringMachine.LastResult, saveFileDialog.FileName);
            }
        }
    }
}
