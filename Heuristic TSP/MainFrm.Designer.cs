namespace HeuristicTSP
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblNumberOfCities = new System.Windows.Forms.Label();
            this.txtNumberOfCities = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.txtFactorialN = new System.Windows.Forms.TextBox();
            this.lblFactorialN = new System.Windows.Forms.Label();
            this.txtNumberOfCyclicGroups = new System.Windows.Forms.TextBox();
            this.lblNumberOfCyclicGroups = new System.Windows.Forms.Label();
            this.txtNumberofStringsPerGroup = new System.Windows.Forms.TextBox();
            this.lblNumberofStringsPerGroup = new System.Windows.Forms.Label();
            this.bgConstructTable = new System.ComponentModel.BackgroundWorker();
            this.txtShortestPath = new System.Windows.Forms.TextBox();
            this.lblShortestPath = new System.Windows.Forms.Label();
            this.txtStartingCity = new System.Windows.Forms.TextBox();
            this.lblStartingCity = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnEx = new System.Windows.Forms.Button();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.btnCalculateAll = new System.Windows.Forms.Button();
            this.lblAbout = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.bgRandom = new System.ComponentModel.BackgroundWorker();
            this.btnCheckPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumberOfCities
            // 
            this.lblNumberOfCities.AutoSize = true;
            this.lblNumberOfCities.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Italic);
            this.lblNumberOfCities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNumberOfCities.Location = new System.Drawing.Point(59, 21);
            this.lblNumberOfCities.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfCities.Name = "lblNumberOfCities";
            this.lblNumberOfCities.Size = new System.Drawing.Size(172, 23);
            this.lblNumberOfCities.TabIndex = 0;
            this.lblNumberOfCities.Text = "Number Of Cities, n";
            // 
            // txtNumberOfCities
            // 
            this.txtNumberOfCities.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfCities.Location = new System.Drawing.Point(239, 18);
            this.txtNumberOfCities.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumberOfCities.Name = "txtNumberOfCities";
            this.txtNumberOfCities.Size = new System.Drawing.Size(170, 30);
            this.txtNumberOfCities.TabIndex = 1;
            this.txtNumberOfCities.TextChanged += new System.EventHandler(this.txtNumberOfCities_TextChanged);
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("BatmanForeverAlternate", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.Color.Green;
            this.btnGo.Location = new System.Drawing.Point(417, 17);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(45, 32);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.table.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.table.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.table.ColumnHeadersHeight = 20;
            this.table.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table.DefaultCellStyle = dataGridViewCellStyle2;
            this.table.Location = new System.Drawing.Point(19, 60);
            this.table.MultiSelect = false;
            this.table.Name = "table";
            this.table.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue;
            this.table.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.table.ShowCellErrors = false;
            this.table.ShowCellToolTips = false;
            this.table.ShowEditingIcon = false;
            this.table.ShowRowErrors = false;
            this.table.Size = new System.Drawing.Size(600, 264);
            this.table.TabIndex = 3;
            this.table.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellValueChanged);
            // 
            // txtFactorialN
            // 
            this.txtFactorialN.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFactorialN.Location = new System.Drawing.Point(434, 334);
            this.txtFactorialN.Margin = new System.Windows.Forms.Padding(4);
            this.txtFactorialN.Name = "txtFactorialN";
            this.txtFactorialN.ReadOnly = true;
            this.txtFactorialN.Size = new System.Drawing.Size(132, 30);
            this.txtFactorialN.TabIndex = 5;
            // 
            // lblFactorialN
            // 
            this.lblFactorialN.AutoSize = true;
            this.lblFactorialN.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Italic);
            this.lblFactorialN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblFactorialN.Location = new System.Drawing.Point(73, 337);
            this.lblFactorialN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFactorialN.Name = "lblFactorialN";
            this.lblFactorialN.Size = new System.Drawing.Size(184, 23);
            this.lblFactorialN.TabIndex = 4;
            this.lblFactorialN.Text = "Number of Strings, n!";
            // 
            // txtNumberOfCyclicGroups
            // 
            this.txtNumberOfCyclicGroups.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfCyclicGroups.Location = new System.Drawing.Point(434, 368);
            this.txtNumberOfCyclicGroups.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumberOfCyclicGroups.Name = "txtNumberOfCyclicGroups";
            this.txtNumberOfCyclicGroups.ReadOnly = true;
            this.txtNumberOfCyclicGroups.Size = new System.Drawing.Size(132, 30);
            this.txtNumberOfCyclicGroups.TabIndex = 7;
            // 
            // lblNumberOfCyclicGroups
            // 
            this.lblNumberOfCyclicGroups.AutoSize = true;
            this.lblNumberOfCyclicGroups.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Italic);
            this.lblNumberOfCyclicGroups.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNumberOfCyclicGroups.Location = new System.Drawing.Point(73, 371);
            this.lblNumberOfCyclicGroups.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfCyclicGroups.Name = "lblNumberOfCyclicGroups";
            this.lblNumberOfCyclicGroups.Size = new System.Drawing.Size(265, 23);
            this.lblNumberOfCyclicGroups.TabIndex = 6;
            this.lblNumberOfCyclicGroups.Text = "Number of Cyclic Groups, n!/2n";
            // 
            // txtNumberofStringsPerGroup
            // 
            this.txtNumberofStringsPerGroup.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberofStringsPerGroup.Location = new System.Drawing.Point(434, 402);
            this.txtNumberofStringsPerGroup.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumberofStringsPerGroup.Name = "txtNumberofStringsPerGroup";
            this.txtNumberofStringsPerGroup.ReadOnly = true;
            this.txtNumberofStringsPerGroup.Size = new System.Drawing.Size(132, 30);
            this.txtNumberofStringsPerGroup.TabIndex = 9;
            // 
            // lblNumberofStringsPerGroup
            // 
            this.lblNumberofStringsPerGroup.AutoSize = true;
            this.lblNumberofStringsPerGroup.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Italic);
            this.lblNumberofStringsPerGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNumberofStringsPerGroup.Location = new System.Drawing.Point(73, 405);
            this.lblNumberofStringsPerGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberofStringsPerGroup.Name = "lblNumberofStringsPerGroup";
            this.lblNumberofStringsPerGroup.Size = new System.Drawing.Size(217, 23);
            this.lblNumberofStringsPerGroup.TabIndex = 8;
            this.lblNumberofStringsPerGroup.Text = "Number of Strings/Group";
            // 
            // bgConstructTable
            // 
            this.bgConstructTable.WorkerSupportsCancellation = true;
            this.bgConstructTable.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgConstructTable_DoWork);
            this.bgConstructTable.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgConstructTable_RunWorkerCompleted);
            // 
            // txtShortestPath
            // 
            this.txtShortestPath.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShortestPath.Location = new System.Drawing.Point(194, 514);
            this.txtShortestPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtShortestPath.Name = "txtShortestPath";
            this.txtShortestPath.ReadOnly = true;
            this.txtShortestPath.Size = new System.Drawing.Size(132, 30);
            this.txtShortestPath.TabIndex = 13;
            // 
            // lblShortestPath
            // 
            this.lblShortestPath.AutoSize = true;
            this.lblShortestPath.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShortestPath.ForeColor = System.Drawing.Color.Green;
            this.lblShortestPath.Location = new System.Drawing.Point(72, 517);
            this.lblShortestPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShortestPath.Name = "lblShortestPath";
            this.lblShortestPath.Size = new System.Drawing.Size(120, 23);
            this.lblShortestPath.TabIndex = 12;
            this.lblShortestPath.Text = "Shortest Path";
            // 
            // txtStartingCity
            // 
            this.txtStartingCity.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartingCity.Location = new System.Drawing.Point(194, 476);
            this.txtStartingCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtStartingCity.Name = "txtStartingCity";
            this.txtStartingCity.Size = new System.Drawing.Size(132, 30);
            this.txtStartingCity.TabIndex = 15;
            // 
            // lblStartingCity
            // 
            this.lblStartingCity.AutoSize = true;
            this.lblStartingCity.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Italic);
            this.lblStartingCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblStartingCity.Location = new System.Drawing.Point(72, 479);
            this.lblStartingCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartingCity.Name = "lblStartingCity";
            this.lblStartingCity.Size = new System.Drawing.Size(114, 23);
            this.lblStartingCity.TabIndex = 14;
            this.lblStartingCity.Text = "Starting City";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Enabled = false;
            this.btnCalculate.Font = new System.Drawing.Font("BatmanForeverAlternate", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCalculate.Location = new System.Drawing.Point(434, 474);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(132, 32);
            this.btnCalculate.TabIndex = 16;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnEx
            // 
            this.btnEx.Font = new System.Drawing.Font("BatmanForeverAlternate", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnEx.Location = new System.Drawing.Point(521, 17);
            this.btnEx.Margin = new System.Windows.Forms.Padding(4);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(45, 32);
            this.btnEx.TabIndex = 17;
            this.btnEx.Text = "Ex";
            this.btnEx.UseVisualStyleBackColor = true;
            this.btnEx.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // txtDistance
            // 
            this.txtDistance.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistance.Location = new System.Drawing.Point(434, 514);
            this.txtDistance.Margin = new System.Windows.Forms.Padding(4);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.ReadOnly = true;
            this.txtDistance.Size = new System.Drawing.Size(132, 30);
            this.txtDistance.TabIndex = 19;
            this.txtDistance.TabStop = false;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistance.ForeColor = System.Drawing.Color.Green;
            this.lblDistance.Location = new System.Drawing.Point(349, 517);
            this.lblDistance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(83, 23);
            this.lblDistance.TabIndex = 18;
            this.lblDistance.Text = "Distance";
            // 
            // btnCalculateAll
            // 
            this.btnCalculateAll.Enabled = false;
            this.btnCalculateAll.Font = new System.Drawing.Font("BatmanForeverAlternate", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCalculateAll.Location = new System.Drawing.Point(233, 432);
            this.btnCalculateAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculateAll.Name = "btnCalculateAll";
            this.btnCalculateAll.Size = new System.Drawing.Size(173, 36);
            this.btnCalculateAll.TabIndex = 20;
            this.btnCalculateAll.Text = "Calculate All";
            this.btnCalculateAll.UseVisualStyleBackColor = true;
            this.btnCalculateAll.Click += new System.EventHandler(this.btnCalculateAll_Click);
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAbout.Font = new System.Drawing.Font("BatmanForeverAlternate", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblAbout.Location = new System.Drawing.Point(3, 585);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(60, 12);
            this.lblAbout.TabIndex = 21;
            this.lblAbout.Text = "About";
            this.lblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAbout.Click += new System.EventHandler(this.lblAbout_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Enabled = false;
            this.btnRandom.Font = new System.Drawing.Font("BatmanForeverAlternate", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.ForeColor = System.Drawing.Color.Black;
            this.btnRandom.Location = new System.Drawing.Point(469, 17);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(45, 32);
            this.btnRandom.TabIndex = 22;
            this.btnRandom.Text = "R";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // bgRandom
            // 
            this.bgRandom.WorkerSupportsCancellation = true;
            this.bgRandom.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgRandom_DoWork);
            this.bgRandom.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgRandom_RunWorkerCompleted);
            // 
            // btnCheckPath
            // 
            this.btnCheckPath.Enabled = false;
            this.btnCheckPath.Font = new System.Drawing.Font("BatmanForeverAlternate", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckPath.ForeColor = System.Drawing.Color.Black;
            this.btnCheckPath.Location = new System.Drawing.Point(434, 552);
            this.btnCheckPath.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckPath.Name = "btnCheckPath";
            this.btnCheckPath.Size = new System.Drawing.Size(132, 32);
            this.btnCheckPath.TabIndex = 25;
            this.btnCheckPath.Text = "Check";
            this.btnCheckPath.UseVisualStyleBackColor = true;
            this.btnCheckPath.Click += new System.EventHandler(this.btnCheckPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(194, 554);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(132, 30);
            this.txtPath.TabIndex = 24;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Italic);
            this.lblPath.ForeColor = System.Drawing.Color.Black;
            this.lblPath.Location = new System.Drawing.Point(72, 557);
            this.lblPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(48, 23);
            this.lblPath.TabIndex = 23;
            this.lblPath.Text = "Path";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 600);
            this.Controls.Add(this.btnCheckPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.btnCalculateAll);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.btnEx);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtStartingCity);
            this.Controls.Add(this.lblStartingCity);
            this.Controls.Add(this.txtShortestPath);
            this.Controls.Add(this.lblShortestPath);
            this.Controls.Add(this.txtNumberofStringsPerGroup);
            this.Controls.Add(this.lblNumberofStringsPerGroup);
            this.Controls.Add(this.txtNumberOfCyclicGroups);
            this.Controls.Add(this.lblNumberOfCyclicGroups);
            this.Controls.Add(this.txtFactorialN);
            this.Controls.Add(this.lblFactorialN);
            this.Controls.Add(this.table);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtNumberOfCities);
            this.Controls.Add(this.lblNumberOfCities);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Heuristic TSP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFrm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberOfCities;
        private System.Windows.Forms.TextBox txtNumberOfCities;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.TextBox txtFactorialN;
        private System.Windows.Forms.Label lblFactorialN;
        private System.Windows.Forms.TextBox txtNumberOfCyclicGroups;
        private System.Windows.Forms.Label lblNumberOfCyclicGroups;
        private System.Windows.Forms.TextBox txtNumberofStringsPerGroup;
        private System.Windows.Forms.Label lblNumberofStringsPerGroup;
        private System.ComponentModel.BackgroundWorker bgConstructTable;
        private System.Windows.Forms.TextBox txtShortestPath;
        private System.Windows.Forms.Label lblShortestPath;
        private System.Windows.Forms.TextBox txtStartingCity;
        private System.Windows.Forms.Label lblStartingCity;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnEx;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Button btnCalculateAll;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Button btnRandom;
        private System.ComponentModel.BackgroundWorker bgRandom;
        private System.Windows.Forms.Button btnCheckPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblPath;
    }
}

