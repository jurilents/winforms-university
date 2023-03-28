namespace JustLab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.difficulty = new System.Windows.Forms.TrackBar();
            this.arrayLength = new System.Windows.Forms.NumericUpDown();
            this.rangeFrom = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.rangeTo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.percentBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.resultTimeBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusState = new System.Windows.Forms.ToolStripStatusLabel();
            this.cancel = new System.Windows.Forms.Button();
            this.rangeToggle = new System.Windows.Forms.CheckBox();
            this.diff1 = new System.Windows.Forms.Label();
            this.diff2 = new System.Windows.Forms.Label();
            this.diff3 = new System.Windows.Forms.Label();
            this.diff4 = new System.Windows.Forms.Label();
            this.completedOutput = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.resultLog = new System.Windows.Forms.DataGridView();
            this.Mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ellapsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroudJobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.difficulty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrayLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeTo)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroudJobBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(10, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(463, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Parallel For";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Results log";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(10, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(463, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Parallel ForEach";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(10, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(463, 43);
            this.button3.TabIndex = 5;
            this.button3.Text = "Default For";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Array length";
            // 
            // difficulty
            // 
            this.difficulty.Location = new System.Drawing.Point(102, 235);
            this.difficulty.Maximum = 3;
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(247, 45);
            this.difficulty.TabIndex = 7;
            // 
            // arrayLength
            // 
            this.arrayLength.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.arrayLength.Location = new System.Drawing.Point(102, 177);
            this.arrayLength.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.arrayLength.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.arrayLength.Name = "arrayLength";
            this.arrayLength.Size = new System.Drawing.Size(247, 23);
            this.arrayLength.TabIndex = 8;
            this.arrayLength.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            // 
            // rangeFrom
            // 
            this.rangeFrom.DecimalPlaces = 2;
            this.rangeFrom.Location = new System.Drawing.Point(102, 206);
            this.rangeFrom.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.rangeFrom.Name = "rangeFrom";
            this.rangeFrom.Size = new System.Drawing.Size(110, 23);
            this.rangeFrom.TabIndex = 10;
            this.rangeFrom.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Break range";
            // 
            // rangeTo
            // 
            this.rangeTo.DecimalPlaces = 2;
            this.rangeTo.Location = new System.Drawing.Point(218, 206);
            this.rangeTo.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.rangeTo.Name = "rangeTo";
            this.rangeTo.Size = new System.Drawing.Size(110, 23);
            this.rangeTo.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Diffuculty";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.progressBar,
            this.percentBar,
            this.resultTimeBar,
            this.toolStripStatusLabel3,
            this.statusState});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(484, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(81, 17);
            this.toolStripStatusLabel1.Text = "Process status";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // percentBar
            // 
            this.percentBar.Name = "percentBar";
            this.percentBar.Size = new System.Drawing.Size(23, 17);
            this.percentBar.Text = "0%";
            // 
            // resultTimeBar
            // 
            this.resultTimeBar.Name = "resultTimeBar";
            this.resultTimeBar.Size = new System.Drawing.Size(34, 17);
            this.resultTimeBar.Text = "00:00";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel3.Text = "Status: ";
            // 
            // statusState
            // 
            this.statusState.Name = "statusState";
            this.statusState.Size = new System.Drawing.Size(39, 17);
            this.statusState.Text = "Ready";
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.BackColor = System.Drawing.SystemColors.Control;
            this.cancel.Location = new System.Drawing.Point(373, 507);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(99, 29);
            this.cancel.TabIndex = 15;
            this.cancel.Text = "Cancel Task";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // rangeToggle
            // 
            this.rangeToggle.AutoSize = true;
            this.rangeToggle.Location = new System.Drawing.Point(334, 209);
            this.rangeToggle.Name = "rangeToggle";
            this.rangeToggle.Size = new System.Drawing.Size(15, 14);
            this.rangeToggle.TabIndex = 16;
            this.rangeToggle.UseVisualStyleBackColor = true;
            // 
            // diff1
            // 
            this.diff1.AutoSize = true;
            this.diff1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.diff1.Location = new System.Drawing.Point(102, 267);
            this.diff1.Name = "diff1";
            this.diff1.Size = new System.Drawing.Size(31, 13);
            this.diff1.TabIndex = 20;
            this.diff1.Text = "x/10";
            this.diff1.Click += new System.EventHandler(this.diff1_Click);
            // 
            // diff2
            // 
            this.diff2.AutoSize = true;
            this.diff2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.diff2.Location = new System.Drawing.Point(175, 267);
            this.diff2.Name = "diff2";
            this.diff2.Size = new System.Drawing.Size(25, 13);
            this.diff2.TabIndex = 21;
            this.diff2.Text = "x/π";
            this.diff2.Click += new System.EventHandler(this.diff2_Click);
            // 
            // diff3
            // 
            this.diff3.AutoSize = true;
            this.diff3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.diff3.Location = new System.Drawing.Point(238, 267);
            this.diff3.Name = "diff3";
            this.diff3.Size = new System.Drawing.Size(49, 13);
            this.diff3.TabIndex = 22;
            this.diff3.Text = "e^x/x^π";
            this.diff3.Click += new System.EventHandler(this.diff3_Click);
            // 
            // diff4
            // 
            this.diff4.AutoSize = true;
            this.diff4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.diff4.Location = new System.Drawing.Point(303, 267);
            this.diff4.Name = "diff4";
            this.diff4.Size = new System.Drawing.Size(55, 13);
            this.diff4.TabIndex = 23;
            this.diff4.Text = "e^πx/x^π";
            this.diff4.Click += new System.EventHandler(this.diff4_Click);
            // 
            // completedOutput
            // 
            this.completedOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.completedOutput.AutoSize = true;
            this.completedOutput.Location = new System.Drawing.Point(438, 292);
            this.completedOutput.Name = "completedOutput";
            this.completedOutput.Size = new System.Drawing.Size(13, 15);
            this.completedOutput.TabIndex = 28;
            this.completedOutput.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Completed tasks:";
            // 
            // resultLog
            // 
            this.resultLog.AllowUserToAddRows = false;
            this.resultLog.AllowUserToOrderColumns = true;
            this.resultLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mode,
            this.Ellapsed,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Status});
            this.resultLog.Location = new System.Drawing.Point(10, 310);
            this.resultLog.Name = "resultLog";
            this.resultLog.ReadOnly = true;
            this.resultLog.Size = new System.Drawing.Size(459, 191);
            this.resultLog.TabIndex = 29;
            // 
            // Mode
            // 
            this.Mode.HeaderText = "Mode";
            this.Mode.Name = "Mode";
            this.Mode.ReadOnly = true;
            // 
            // Ellapsed
            // 
            this.Ellapsed.HeaderText = "Ellapsed Time";
            this.Ellapsed.Name = "Ellapsed";
            this.Ellapsed.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Difficulty Level";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Array Length";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // backgroudJobBindingSource
            // 
            this.backgroudJobBindingSource.DataSource = typeof(JustLab2.BackgroudJob);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.resultLog);
            this.Controls.Add(this.completedOutput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.diff4);
            this.Controls.Add(this.diff3);
            this.Controls.Add(this.diff2);
            this.Controls.Add(this.diff1);
            this.Controls.Add(this.rangeToggle);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rangeTo);
            this.Controls.Add(this.rangeFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.arrayLength);
            this.Controls.Add(this.difficulty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(600, 700);
            this.MinimumSize = new System.Drawing.Size(500, 550);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.difficulty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrayLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeTo)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroudJobBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Label label2;
        private TrackBar difficulty;
        private NumericUpDown arrayLength;
        private NumericUpDown rangeFrom;
        private Label label3;
        private NumericUpDown rangeTo;
        private Label label4;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar progressBar;
        private ToolStripStatusLabel percentBar;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel statusState;
        private ToolStripStatusLabel resultTimeBar;
        private Button cancel;
        private CheckBox rangeToggle;
        private Label diff1;
        private Label diff2;
        private Label diff3;
        private Label diff4;
        private Label completedOutput;
        private Label label7;
        private DataGridView resultLog;
        private BindingSource backgroudJobBindingSource;
        private BindingSource resultLogBindingSource;
        private DataGridViewTextBoxColumn Mode;
        private DataGridViewTextBoxColumn Ellapsed;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Status;
    }
}