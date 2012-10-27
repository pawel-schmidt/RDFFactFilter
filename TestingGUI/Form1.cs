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
        private List<Triple> triples = new List<Triple>();
        private List<Triple> patternTriples = new List<Triple>();
        private List<Triple> filteredTriples = new List<Triple>();
        private List<LexCollection> lex = new List<LexCollection>();
        private EntityType types = new EntityType("Obiekt");
        private const String DIALOG_FILTER = "json files (*.json)|*.json|All files (*.*)|*.*";

        public Form1() {
            InitializeComponent();
            openFileDialog.Filter = DIALOG_FILTER;
            openFileDialog.InitialDirectory = Application.StartupPath + @"..\..\";
            saveFileDialog.InitialDirectory = Application.StartupPath + @"..\..\";
        }

        private void BtnLoadTriplesClick(object sender, EventArgs e) {
            openFileDialog.FileName = "[name]_triples.json";

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                triples = input.readTriples(openFileDialog.FileName);
                listBoxTriples.Items.Clear();
                foreach (Triple t in triples) {
                    listBoxTriples.Items.Add(t.ToString());
                }
            }
        }

        private void BtnLoadPatternTriplesClick(object sender, EventArgs e) {
            openFileDialog.FileName = "[name]_pattern_triples.json";

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                patternTriples = input.readPatternTriples(openFileDialog.FileName);
                listBoxPatternTriples.Items.Clear();
                foreach (Triple t in patternTriples) {
                    listBoxPatternTriples.Items.Add(t.ToString());
                }
            }
        }

        private void BtnLoadLexClick(object sender, EventArgs e) {
            openFileDialog.FileName = "[name]_lex.json";

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                lex = input.readLexicalizations(openFileDialog.FileName);
                listBoxLex.Items.Clear();
                foreach (LexCollection l in lex) {
                    listBoxLex.Items.Add(l.ToString());
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e) {
            filteredTriples = FilteringMachine.filter(triples, patternTriples, lex, types);
            listBoxFiltered.Items.Clear();
            foreach (Triple t in filteredTriples) {
                listBoxFiltered.Items.Add(t.ToString());
            }
        }

        private void buttonLoadTypes_Click(object sender, EventArgs e) {
            openFileDialog.FileName = "[name]_type_hierarchy.json";

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                types = input.readTypeHierarchy(openFileDialog.FileName);
                listBoxTypeHierarchy.Items.Clear();
                foreach (String s in types.getHierarchyString().Split('\n')) {
                    listBoxTypeHierarchy.Items.Add(s);
                }
                //listBoxTypeHierarchy.Items.Add(types.getType("Opel"));
                //listBoxTypeHierarchy.Items.Add(types.getType("Daewoo"));
                //listBoxTypeHierarchy.Items.Add(types.getType("Nothing"));

            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            saveFileDialog.FileName = "[name]_filtered_triples.json";
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                output.save(filteredTriples, saveFileDialog.FileName);
            }
        }
    }
}
