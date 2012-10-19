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
            this.btnLoadPatternTriples = new System.Windows.Forms.Button();
            this.btnLoadTriples = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.listBoxLex = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadLex
            // 
            this.btnLoadLex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadLex.Location = new System.Drawing.Point(509, 3);
            this.btnLoadLex.Name = "btnLoadLex";
            this.btnLoadLex.Size = new System.Drawing.Size(248, 24);
            this.btnLoadLex.TabIndex = 2;
            this.btnLoadLex.Text = "Load lex";
            this.btnLoadLex.UseVisualStyleBackColor = true;
            this.btnLoadLex.Click += new System.EventHandler(this.BtnLoadLexClick);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(12, 471);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(760, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save filtered triples";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.BackColor = System.Drawing.Color.LimeGreen;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFilter.Location = new System.Drawing.Point(12, 500);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(760, 50);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // listBoxTriples
            // 
            this.listBoxTriples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTriples.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxTriples.FormattingEnabled = true;
            this.listBoxTriples.Location = new System.Drawing.Point(3, 3);
            this.listBoxTriples.Name = "listBoxTriples";
            this.listBoxTriples.Size = new System.Drawing.Size(754, 99);
            this.listBoxTriples.TabIndex = 0;
            // 
            // listBoxPatternTriples
            // 
            this.listBoxPatternTriples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPatternTriples.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxPatternTriples.FormattingEnabled = true;
            this.listBoxPatternTriples.Location = new System.Drawing.Point(3, 108);
            this.listBoxPatternTriples.Name = "listBoxPatternTriples";
            this.listBoxPatternTriples.Size = new System.Drawing.Size(754, 99);
            this.listBoxPatternTriples.TabIndex = 1;
            // 
            // listBoxFiltered
            // 
            this.listBoxFiltered.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFiltered.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxFiltered.FormattingEnabled = true;
            this.listBoxFiltered.Location = new System.Drawing.Point(3, 318);
            this.listBoxFiltered.Name = "listBoxFiltered";
            this.listBoxFiltered.Size = new System.Drawing.Size(754, 99);
            this.listBoxFiltered.TabIndex = 3;
            // 
            // btnLoadPatternTriples
            // 
            this.btnLoadPatternTriples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadPatternTriples.Location = new System.Drawing.Point(256, 3);
            this.btnLoadPatternTriples.Name = "btnLoadPatternTriples";
            this.btnLoadPatternTriples.Size = new System.Drawing.Size(247, 24);
            this.btnLoadPatternTriples.TabIndex = 1;
            this.btnLoadPatternTriples.Text = "Load pattern triples";
            this.btnLoadPatternTriples.UseVisualStyleBackColor = true;
            this.btnLoadPatternTriples.Click += new System.EventHandler(this.BtnLoadPatternTriplesClick);
            // 
            // btnLoadTriples
            // 
            this.btnLoadTriples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadTriples.Location = new System.Drawing.Point(3, 3);
            this.btnLoadTriples.Name = "btnLoadTriples";
            this.btnLoadTriples.Size = new System.Drawing.Size(247, 24);
            this.btnLoadTriples.TabIndex = 0;
            this.btnLoadTriples.Text = "Load triples";
            this.btnLoadTriples.UseVisualStyleBackColor = true;
            this.btnLoadTriples.Click += new System.EventHandler(this.BtnLoadTriplesClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // listBoxLex
            // 
            this.listBoxLex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxLex.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxLex.FormattingEnabled = true;
            this.listBoxLex.Location = new System.Drawing.Point(3, 213);
            this.listBoxLex.Name = "listBoxLex";
            this.listBoxLex.Size = new System.Drawing.Size(754, 99);
            this.listBoxLex.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.Controls.Add(this.btnLoadTriples, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLoadPatternTriples, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLoadLex, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 30);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.listBoxTriples, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.listBoxPatternTriples, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.listBoxFiltered, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.listBoxLex, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 45);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(760, 420);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnSave);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.Text = "Tester";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Button btnLoadTriples;
        private System.Windows.Forms.Button btnLoadPatternTriples;
        private System.Windows.Forms.ListBox listBoxFiltered;
        private System.Windows.Forms.ListBox listBoxPatternTriples;
        private System.Windows.Forms.ListBox listBoxTriples;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoadLex;

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ListBox listBoxLex;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

