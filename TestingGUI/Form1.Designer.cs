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
        	this.btnLoad = new System.Windows.Forms.Button();
        	this.btnSave = new System.Windows.Forms.Button();
        	this.btnFilter = new System.Windows.Forms.Button();
        	this.listBoxTriples = new System.Windows.Forms.ListBox();
        	this.listBoxPatternTriples = new System.Windows.Forms.ListBox();
        	this.listBoxFiltered = new System.Windows.Forms.ListBox();
        	this.SuspendLayout();
        	// 
        	// btnLoad
        	// 
        	this.btnLoad.Location = new System.Drawing.Point(12, 12);
        	this.btnLoad.Name = "btnLoad";
        	this.btnLoad.Size = new System.Drawing.Size(53, 23);
        	this.btnLoad.TabIndex = 0;
        	this.btnLoad.Text = "Load";
        	this.btnLoad.UseVisualStyleBackColor = true;
        	// 
        	// btnSave
        	// 
        	this.btnSave.Location = new System.Drawing.Point(71, 12);
        	this.btnSave.Name = "btnSave";
        	this.btnSave.Size = new System.Drawing.Size(75, 23);
        	this.btnSave.TabIndex = 1;
        	this.btnSave.Text = "Save";
        	this.btnSave.UseVisualStyleBackColor = true;
        	this.btnSave.Click += new System.EventHandler(this.Button2Click);
        	// 
        	// btnFilter
        	// 
        	this.btnFilter.Location = new System.Drawing.Point(304, 12);
        	this.btnFilter.Name = "btnFilter";
        	this.btnFilter.Size = new System.Drawing.Size(75, 23);
        	this.btnFilter.TabIndex = 2;
        	this.btnFilter.Text = "Filter";
        	this.btnFilter.UseVisualStyleBackColor = true;
        	// 
        	// listBoxTriples
        	// 
        	this.listBoxTriples.FormattingEnabled = true;
        	this.listBoxTriples.Location = new System.Drawing.Point(12, 41);
        	this.listBoxTriples.Name = "listBoxTriples";
        	this.listBoxTriples.Size = new System.Drawing.Size(113, 238);
        	this.listBoxTriples.TabIndex = 3;
        	// 
        	// listBoxPatternTriples
        	// 
        	this.listBoxPatternTriples.FormattingEnabled = true;
        	this.listBoxPatternTriples.Location = new System.Drawing.Point(131, 41);
        	this.listBoxPatternTriples.Name = "listBoxPatternTriples";
        	this.listBoxPatternTriples.Size = new System.Drawing.Size(120, 238);
        	this.listBoxPatternTriples.TabIndex = 4;
        	// 
        	// listBoxFiltered
        	// 
        	this.listBoxFiltered.FormattingEnabled = true;
        	this.listBoxFiltered.Location = new System.Drawing.Point(257, 41);
        	this.listBoxFiltered.Name = "listBoxFiltered";
        	this.listBoxFiltered.Size = new System.Drawing.Size(120, 238);
        	this.listBoxFiltered.TabIndex = 5;
        	// 
        	// Form1
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(391, 302);
        	this.Controls.Add(this.listBoxFiltered);
        	this.Controls.Add(this.listBoxPatternTriples);
        	this.Controls.Add(this.listBoxTriples);
        	this.Controls.Add(this.btnFilter);
        	this.Controls.Add(this.btnSave);
        	this.Controls.Add(this.btnLoad);
        	this.Name = "Form1";
        	this.Text = "Tester";
        	this.ResumeLayout(false);
        }
        private System.Windows.Forms.ListBox listBoxFiltered;
        private System.Windows.Forms.ListBox listBoxPatternTriples;
        private System.Windows.Forms.ListBox listBoxTriples;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;

        #endregion
    }
}

