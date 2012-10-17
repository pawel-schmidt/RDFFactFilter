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
using ServiceStack.Text;

namespace TestingGUI {
    public partial class Form1 : Form {
		String 
			lexPath, lexContent,
			triplePath, tripleContent,
			patternPath, patternContent;
		
        public Form1() {
            InitializeComponent();
        }
        
       
        
        void BtnLoadClick(object sender, EventArgs e)
        {
        	OpenFileDialog openFileDialog1 = new OpenFileDialog();
			openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			
			if(openFileDialog1.ShowDialog() == DialogResult.OK){
			    lexPath = openFileDialog1.FileName;
			}
			
			if (lexPath.Length>0){
				lexContent = File.ReadAllText(lexPath);
			}
			
			//dynamic dict = Jsonify.fromFile(lexPath);
			//foreach(dynamic item in Dictionary){
			//	this.listBoxPatternTriples.Items.Add(item);
			//}
        }
        
        void BtnLoadPatternClick(object sender, EventArgs e)
        {
        	OpenFileDialog openFileDialog1 = new OpenFileDialog();
			openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			
			if(openFileDialog1.ShowDialog() == DialogResult.OK){
			    patternPath = openFileDialog1.FileName;
			}
			
			if (patternPath.Length>0){
				patternContent = File.ReadAllText(patternPath);
			}
        }
        
        void Button1Click(object sender, EventArgs e)
        {
        	OpenFileDialog openFileDialog1 = new OpenFileDialog();
			openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			
			if(openFileDialog1.ShowDialog() == DialogResult.OK){
			    triplePath = openFileDialog1.FileName;
			}
			
			if (triplePath.Length>0){
				tripleContent = File.ReadAllText(triplePath);
			}
			
			listBoxTriples.Items.Add("<FortI, zostalZbudowany, 1922>");
        }
        
    }
}
