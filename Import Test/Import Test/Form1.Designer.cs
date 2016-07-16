namespace Import_Test
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalampLocateHist = new System.Windows.Forms.Button();
            this.btnShowGLDTbl = new System.Windows.Forms.Button();
            this.btnGldLocateHist = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.btnSkyPatrolLocateHist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalampLocateHist
            // 
            this.btnCalampLocateHist.Location = new System.Drawing.Point(106, 34);
            this.btnCalampLocateHist.Name = "btnCalampLocateHist";
            this.btnCalampLocateHist.Size = new System.Drawing.Size(97, 44);
            this.btnCalampLocateHist.TabIndex = 0;
            this.btnCalampLocateHist.Text = "Retrieve Calamp Locate History";
            this.btnCalampLocateHist.UseVisualStyleBackColor = true;
            this.btnCalampLocateHist.Click += new System.EventHandler(this.btnCalampLocateHist_Click);
            // 
            // btnShowGLDTbl
            // 
            this.btnShowGLDTbl.Location = new System.Drawing.Point(106, 712);
            this.btnShowGLDTbl.Name = "btnShowGLDTbl";
            this.btnShowGLDTbl.Size = new System.Drawing.Size(123, 23);
            this.btnShowGLDTbl.TabIndex = 1;
            this.btnShowGLDTbl.Text = "Show Goldstar Table";
            this.btnShowGLDTbl.UseVisualStyleBackColor = true;
            this.btnShowGLDTbl.Click += new System.EventHandler(this.btnShowGLDTbl_Click);
            // 
            // btnGldLocateHist
            // 
            this.btnGldLocateHist.Location = new System.Drawing.Point(243, 34);
            this.btnGldLocateHist.Name = "btnGldLocateHist";
            this.btnGldLocateHist.Size = new System.Drawing.Size(113, 44);
            this.btnGldLocateHist.TabIndex = 2;
            this.btnGldLocateHist.Text = "Retrieve Goldstar Locate History";
            this.btnGldLocateHist.UseVisualStyleBackColor = true;
            this.btnGldLocateHist.Click += new System.EventHandler(this.btnGldLocateHist_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(106, 440);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1019, 256);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(551, 34);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(111, 44);
            this.btnClearForm.TabIndex = 5;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(106, 100);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1019, 279);
            this.dataGridView3.TabIndex = 10;
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Location = new System.Drawing.Point(106, 385);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(114, 23);
            this.btnExportCSV.TabIndex = 11;
            this.btnExportCSV.Text = "Export to CSV";
            this.btnExportCSV.UseVisualStyleBackColor = true;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // btnSkyPatrolLocateHist
            // 
            this.btnSkyPatrolLocateHist.Location = new System.Drawing.Point(396, 34);
            this.btnSkyPatrolLocateHist.Name = "btnSkyPatrolLocateHist";
            this.btnSkyPatrolLocateHist.Size = new System.Drawing.Size(111, 44);
            this.btnSkyPatrolLocateHist.TabIndex = 12;
            this.btnSkyPatrolLocateHist.Text = "Retrieve SkyPatrol Locate History";
            this.btnSkyPatrolLocateHist.UseVisualStyleBackColor = true;
            this.btnSkyPatrolLocateHist.Click += new System.EventHandler(this.btnSkyPatrolLocateHist_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 762);
            this.Controls.Add(this.btnSkyPatrolLocateHist);
            this.Controls.Add(this.btnExportCSV);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGldLocateHist);
            this.Controls.Add(this.btnShowGLDTbl);
            this.Controls.Add(this.btnCalampLocateHist);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalampLocateHist;
        private System.Windows.Forms.Button btnShowGLDTbl;
        private System.Windows.Forms.Button btnGldLocateHist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.Button btnSkyPatrolLocateHist;
    }
}

