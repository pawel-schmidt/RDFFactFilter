namespace TestingGUI {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
        	this.btnLoadLex = new System.Windows.Forms.Button();
        	this.btnSave = new System.Windows.Forms.Button();
        	this.btnFilter = new System.Windows.Forms.Button();
        	this.listBoxTriples = new System.Windows.Forms.ListBox();
        	this.listBoxPatternTriples = new System.Windows.Forms.ListBox();
        	this.listBoxFiltered = new System.Windows.Forms.ListBox();
        	this.btnLoadPattern = new System.Windows.Forms.Button();
        	this.button1 = new System.Windows.Forms.Button();
        	this.SuspendLayout();
        	// 
        	// btnLoadLex
        	// 
        	this.btnLoadLex.Location = new System.Drawing.Point(12, 8);
        	this.btnLoadLex.Name = "btnLoadLex";
        	this.btnLoadLex.Size = new System.Drawing.Size(56, 23);
        	this.btnLoadLex.TabIndex = 0;
        	this.btnLoadLex.Text = "Load lex";
        	this.btnLoadLex.UseVisualStyleBackColor = true;
        	this.btnLoadLex.Click += new System.EventHandler(this.BtnLoadClick);
        	// 
        	// btnSave
        	// 
        	this.btnSave.Location = new System.Drawing.Point(545, 8);
        	this.btnSave.Name = "btnSave";
        	this.btnSave.Size = new System.Drawing.Size(41, 23);
        	this.btnSave.TabIndex = 1;
        	this.btnSave.Text = "Save";
        	this.btnSave.UseVisualStyleBackColor = true;
        	// 
        	// btnFilter
        	// 
        	this.btnFilter.BackColor = System.Drawing.Color.LimeGreen;
        	this.btnFilter.FlatAppearance.BorderSize = 0;
        	this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnFilter.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.btnFilter.Location = new System.Drawing.Point(592, 8);
        	this.btnFilter.Name = "btnFilter";
        	this.btnFilter.Size = new System.Drawing.Size(55, 23);
        	this.btnFilter.TabIndex = 2;
        	this.btnFilter.Text = "Filter";
        	this.btnFilter.UseVisualStyleBackColor = false;
        	// 
        	// listBoxTriples
        	// 
        	this.listBoxTriples.FormattingEnabled = true;
        	this.listBoxTriples.Location = new System.Drawing.Point(12, 41);
        	this.listBoxTriples.Name = "listBoxTriples";
        	this.listBoxTriples.Size = new System.Drawing.Size(208, 342);
        	this.listBoxTriples.TabIndex = 3;
        	// 
        	// listBoxPatternTriples
        	// 
        	this.listBoxPatternTriples.FormattingEnabled = true;
        	this.listBoxPatternTriples.Location = new System.Drawing.Point(240, 41);
        	this.listBoxPatternTriples.Name = "listBoxPatternTriples";
        	this.listBoxPatternTriples.Size = new System.Drawing.Size(195, 342);
        	this.listBoxPatternTriples.TabIndex = 4;
        	// 
        	// listBoxFiltered
        	// 
        	this.listBoxFiltered.FormattingEnabled = true;
        	this.listBoxFiltered.Location = new System.Drawing.Point(453, 41);
        	this.listBoxFiltered.Name = "listBoxFiltered";
        	this.listBoxFiltered.Size = new System.Drawing.Size(194, 342);
        	this.listBoxFiltered.TabIndex = 5;
        	// 
        	// btnLoadPattern
        	// 
        	this.btnLoadPattern.Location = new System.Drawing.Point(74, 8);
        	this.btnLoadPattern.Name = "btnLoadPattern";
        	this.btnLoadPattern.Size = new System.Drawing.Size(76, 23);
        	this.btnLoadPattern.TabIndex = 6;
        	this.btnLoadPattern.Text = "Load pattern";
        	this.btnLoadPattern.UseVisualStyleBackColor = true;
        	this.btnLoadPattern.Click += new System.EventHandler(this.BtnLoadPatternClick);
        	// 
        	// button1
        	// 
        	this.button1.Location = new System.Drawing.Point(156, 8);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(71, 23);
        	this.button1.TabIndex = 7;
        	this.button1.Text = "Load triples";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.Button1Click);
        	// 
        	// Form1
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(655, 393);
        	this.Controls.Add(this.button1);
        	this.Controls.Add(this.btnLoadPattern);
        	this.Controls.Add(this.listBoxFiltered);
        	this.Controls.Add(this.listBoxPatternTriples);
        	this.Controls.Add(this.listBoxTriples);
        	this.Controls.Add(this.btnFilter);
        	this.Controls.Add(this.btnSave);
        	this.Controls.Add(this.btnLoadLex);
        	this.Name = "Form1";
        	this.Text = "Tester";
        	this.ResumeLayout(false);
        }
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLoadPattern;
        private System.Windows.Forms.ListBox listBoxFiltered;
        private System.Windows.Forms.ListBox listBoxPatternTriples;
        private System.Windows.Forms.ListBox listBoxTriples;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoadLex;

        #endregion
    }
}

