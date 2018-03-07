namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.btnRand = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.rowCount = new System.Windows.Forms.NumericUpDown();
            this.columnCount = new System.Windows.Forms.NumericUpDown();
            this.bMinCount = new System.Windows.Forms.NumericUpDown();
            this.bMaxCount = new System.Windows.Forms.NumericUpDown();
            this.sMinCount = new System.Windows.Forms.NumericUpDown();
            this.sMaxCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPaint = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.genPerSec = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rowCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMinCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMaxCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMinCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMaxCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genPerSec)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRand
            // 
            this.btnRand.Enabled = false;
            this.btnRand.Location = new System.Drawing.Point(427, 40);
            this.btnRand.Name = "btnRand";
            this.btnRand.Size = new System.Drawing.Size(75, 23);
            this.btnRand.TabIndex = 0;
            this.btnRand.Text = "Fill Random";
            this.btnRand.UseVisualStyleBackColor = true;
            this.btnRand.Click += new System.EventHandler(this.btnRand_Click);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(427, 124);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(427, 95);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // rowCount
            // 
            this.rowCount.Location = new System.Drawing.Point(101, 14);
            this.rowCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.rowCount.Name = "rowCount";
            this.rowCount.Size = new System.Drawing.Size(47, 20);
            this.rowCount.TabIndex = 3;
            // 
            // columnCount
            // 
            this.columnCount.Location = new System.Drawing.Point(101, 38);
            this.columnCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.columnCount.Name = "columnCount";
            this.columnCount.Size = new System.Drawing.Size(47, 20);
            this.columnCount.TabIndex = 4;
            // 
            // bMinCount
            // 
            this.bMinCount.Location = new System.Drawing.Point(206, 12);
            this.bMinCount.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.bMinCount.Name = "bMinCount";
            this.bMinCount.Size = new System.Drawing.Size(38, 20);
            this.bMinCount.TabIndex = 5;
            this.bMinCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // bMaxCount
            // 
            this.bMaxCount.Location = new System.Drawing.Point(206, 38);
            this.bMaxCount.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.bMaxCount.Name = "bMaxCount";
            this.bMaxCount.Size = new System.Drawing.Size(38, 20);
            this.bMaxCount.TabIndex = 6;
            this.bMaxCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // sMinCount
            // 
            this.sMinCount.Location = new System.Drawing.Point(318, 12);
            this.sMinCount.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.sMinCount.Name = "sMinCount";
            this.sMinCount.Size = new System.Drawing.Size(38, 20);
            this.sMinCount.TabIndex = 7;
            this.sMinCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // sMaxCount
            // 
            this.sMaxCount.Location = new System.Drawing.Point(318, 38);
            this.sMaxCount.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.sMaxCount.Name = "sMaxCount";
            this.sMaxCount.Size = new System.Drawing.Size(38, 20);
            this.sMaxCount.TabIndex = 8;
            this.sMaxCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cells per row:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cells per column:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "BMIN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "BMAX:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "SMIN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "SMAX:";
            // 
            // btnPaint
            // 
            this.btnPaint.Location = new System.Drawing.Point(427, 10);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(75, 23);
            this.btnPaint.TabIndex = 15;
            this.btnPaint.Text = "Paint Grid";
            this.btnPaint.UseVisualStyleBackColor = true;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(427, 153);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 16;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(10, 398);
            this.trackBar.Maximum = 100;
            this.trackBar.Minimum = 1;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(292, 45);
            this.trackBar.TabIndex = 100;
            this.trackBar.Value = 100;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // genPerSec
            // 
            this.genPerSec.Location = new System.Drawing.Point(240, 372);
            this.genPerSec.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.genPerSec.Name = "genPerSec";
            this.genPerSec.Size = new System.Drawing.Size(55, 20);
            this.genPerSec.TabIndex = 101;
            this.genPerSec.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.genPerSec.ValueChanged += new System.EventHandler(this.genPerSec_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 102;
            this.label7.Text = "Generations per second:";
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(427, 183);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 103;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 438);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.genPerSec);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPaint);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sMaxCount);
            this.Controls.Add(this.sMinCount);
            this.Controls.Add(this.bMaxCount);
            this.Controls.Add(this.bMinCount);
            this.Controls.Add(this.columnCount);
            this.Controls.Add(this.rowCount);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnRand);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.rowCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMinCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMaxCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMinCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMaxCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genPerSec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRand;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.NumericUpDown rowCount;
        private System.Windows.Forms.NumericUpDown columnCount;
        private System.Windows.Forms.NumericUpDown bMinCount;
        private System.Windows.Forms.NumericUpDown bMaxCount;
        private System.Windows.Forms.NumericUpDown sMinCount;
        private System.Windows.Forms.NumericUpDown sMaxCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPaint;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.NumericUpDown genPerSec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClear;
    }
}

