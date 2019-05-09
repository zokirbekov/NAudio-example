namespace WaveFormRendererApp
{
    partial class HadamarForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridViewHadamar = new System.Windows.Forms.DataGridView();
            this.dataGridViewF = new System.Windows.Forms.DataGridView();
            this.dataGridViewMul = new System.Windows.Forms.DataGridView();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHadamar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHadamar
            // 
            this.dataGridViewHadamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHadamar.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewHadamar.Name = "dataGridViewHadamar";
            this.dataGridViewHadamar.Size = new System.Drawing.Size(368, 300);
            this.dataGridViewHadamar.TabIndex = 0;
            // 
            // dataGridViewF
            // 
            this.dataGridViewF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewF.Location = new System.Drawing.Point(449, 12);
            this.dataGridViewF.Name = "dataGridViewF";
            this.dataGridViewF.Size = new System.Drawing.Size(309, 300);
            this.dataGridViewF.TabIndex = 1;
            // 
            // dataGridViewMul
            // 
            this.dataGridViewMul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMul.Location = new System.Drawing.Point(822, 12);
            this.dataGridViewMul.Name = "dataGridViewMul";
            this.dataGridViewMul.Size = new System.Drawing.Size(270, 300);
            this.dataGridViewMul.TabIndex = 2;
            this.dataGridViewMul.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMul_CellContentClick);
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(1017, 361);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(75, 23);
            this.buttonCalc.TabIndex = 3;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(764, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 55);
            this.label2.TabIndex = 6;
            this.label2.Text = "=";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 559);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1079, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(13, 336);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 2;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(998, 190);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // HadamarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 594);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.dataGridViewMul);
            this.Controls.Add(this.dataGridViewF);
            this.Controls.Add(this.dataGridViewHadamar);
            this.Name = "HadamarForm";
            this.Text = "HadamarForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHadamar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHadamar;
        private System.Windows.Forms.DataGridView dataGridViewF;
        private System.Windows.Forms.DataGridView dataGridViewMul;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}